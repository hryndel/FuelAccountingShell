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
                case HttpStatusCode.OK: return DialogResult.OK;
                case HttpStatusCode.Conflict: GetMessageValidatorAsync(response); break;
                case HttpStatusCode.NotFound: GetMessageExceptionAsync(response); break;
                case HttpStatusCode.NotAcceptable: GetMessageExceptionAsync(response); break;
                default: break;
            }
            return DialogResult.No;
        }

        public static async void GetMessageValidatorAsync(HttpResponseMessage data)
        {
            var result = await data.Content.ReadAsStringAsync();
            var errors = JsonConvert.DeserializeObject<Errors>(result);
            var message = string.Empty;
            foreach ( var er in errors.MessageErrors)
            {
                message += $"{er.Message}\n";
            }
            MaterialMessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
        }

        public static async void GetMessageExceptionAsync(HttpResponseMessage data)
        {
            var result = await data.Content.ReadAsStringAsync();
            var error = JsonConvert.DeserializeObject<MessageErrors>(result);
            MaterialMessageBox.Show($"{error.Message}", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
        }
    }
}
