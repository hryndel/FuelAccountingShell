using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace FuelAccountingShell.Infrastructure.Messages
{
    public static class ResponseMessages
    {
        public static DialogResult MessageFiltr(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK: 
                    return DialogResult.OK;
                case HttpStatusCode.Conflict: 
                    GetMessageValidatorAsync(response); 
                    break;
                case HttpStatusCode.NotFound: 
                    GetMessageExceptionAsync(response); 
                    break;
                case HttpStatusCode.NotAcceptable: 
                    GetMessageExceptionAsync(response); 
                    break;
                case HttpStatusCode.Unauthorized: 
                    MaterialMessageBox.Show("Отказано в доступе", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                    break;
                default: break;
            }
            return DialogResult.No;
        }

        public static void GetMessageValidatorAsync(HttpResponseMessage data)
        {
            var result = data.Content.ReadAsStringAsync().Result;
            var errors = JsonConvert.DeserializeObject<Errors>(result);
            var message = string.Empty;
            foreach ( var er in errors.MessageErrors)
            {
                message += $"{er.Message}\n";
            }
            MaterialMessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
        }

        public static void GetMessageExceptionAsync(HttpResponseMessage data)
        {
            var result = data.Content.ReadAsStringAsync().Result;
            var error = JsonConvert.DeserializeObject<MessageErrors>(result);
            MaterialMessageBox.Show($"{error.Message}", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
        }
    }
}
