using FuelAccountingShell.Infrastructure.Messages;
using FuelAccountingShell.Models.Token;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace FuelAccountingShell.Infrastructure
{
    public class CommonClient
    {
        public static List<T> GetData<T>(string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JSonWebToken.Token);
                var data = client.GetAsync(path).Result;
                data.EnsureSuccessStatusCode();
                var result = data.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<T>>(result);
                return response;
            }
            catch
            {
                MaterialMessageBox.Show($"Ошибка соединения с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                CloseForms.Close();
                return new List<T>();
            }
        }

        public static DialogResult CreateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JSonWebToken.Token);
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = client.PostAsync(path, content).Result;
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MaterialMessageBox.Show("Запись успешно создана.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, false);
                    return dialogResult;
                }
                return dialogResult;
            }
            catch
            {
                MaterialMessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                CloseForms.Close();
                return DialogResult.Cancel;
            }
        }

        public static DialogResult UpdateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JSonWebToken.Token);
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = client.PutAsync(path, content).Result;
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MaterialMessageBox.Show("Запись успешно обновлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dialogResult;
                }
                return dialogResult;
            }
            catch
            {
                MaterialMessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                CloseForms.Close();
                return DialogResult.Cancel;
            }
        }

        public static DialogResult DeleteData(Guid id, string path)
        {
            try
            {
                var dialog = MaterialMessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, false);
                if (dialog == DialogResult.Yes)
                {
                    var client = new GenerateHttpClient().GetHttpClient;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JSonWebToken.Token);
                    var data = client.DeleteAsync(path + id).Result;
                    var dialogResult = ResponseMessages.MessageFiltr(data);
                    if (dialogResult == DialogResult.OK)
                    {
                        MaterialMessageBox.Show("Запись успешно удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, false);
                        return dialogResult;
                    }
                    return dialogResult;
                }
                return DialogResult.No;
            }
            catch
            {
                MaterialMessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                CloseForms.Close();
                return DialogResult.Cancel;
            }
        }

        public static bool SignIn(string login, string password)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient;
                var data = client.PostAsync($"Token/signIn?login={login}&password={password}", null).Result;
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    var result = data.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<TokenResponse>(result);
                    JSonWebToken.UserTypes = response.UserType;
                    JSonWebToken.Token = response.Token;
                    MaterialMessageBox.Show("Успешный вход в приложение.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, false);
                    return true;
                }
                return false;
            }
            catch
            {
                MaterialMessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                return false;
            }
        }

        public static byte[] GetDocument(Guid id)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JSonWebToken.Token);
                var dataBytes = client.GetByteArrayAsync($"FuelAccountingItem/document={id}").Result;
                return dataBytes;
            }
            catch
            {
                MaterialMessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                CloseForms.Close();
                return null;
            }
        }
    }
}
