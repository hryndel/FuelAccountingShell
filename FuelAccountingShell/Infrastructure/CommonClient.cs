using FuelAccountingShell.Infrastructure.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelAccountingShell.Infrastructure
{
    public class CommonClient
    {
        public static async Task<List<T>> GetData<T>(string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient();
                var data = await client.GetAsync(path);
                data.EnsureSuccessStatusCode();
                var result = await data.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<T>>(result);
                return response;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }

        public static async Task<DialogResult> CreateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = await client.PostAsync(path, content);
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись успешно создана.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dialogResult;
                }
                return dialogResult;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }
        }

        public static async Task<DialogResult> UpdateData<T>(T modelRequest, string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient();
                var json = JsonConvert.SerializeObject(modelRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var data = await client.PutAsync(path, content);
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись успешно обновлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dialogResult;
                }
                return dialogResult;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }
        }

        public static async Task<DialogResult> DeleteData(Guid id, string path)
        {
            try
            {
                var client = new GenerateHttpClient().GetHttpClient();
                var data = await client.DeleteAsync(path + id);
                var dialogResult = ResponseMessages.MessageFiltr(data);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Запись успешно удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dialogResult;
                }
                return dialogResult;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }
        }
    }
}
