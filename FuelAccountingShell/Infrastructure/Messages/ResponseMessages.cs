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
                case HttpStatusCode.Conflict: GetMessageValidatorAsync(response); return DialogResult.No;
                case HttpStatusCode.NotFound: GetMessageExceptionAsync(response); return DialogResult.No;
                case HttpStatusCode.NotAcceptable: GetMessageExceptionAsync(response); return DialogResult.No;
                default: return DialogResult.OK;
            }
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
            MessageBox.Show($"{message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void GetMessageExceptionAsync(HttpResponseMessage data)
        {
            var result = await data.Content.ReadAsStringAsync();
            var error = JsonConvert.DeserializeObject<MessageErrors>(result);
            MessageBox.Show($"{error.Message}", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
