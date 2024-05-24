using Newtonsoft.Json;

namespace FuelAccountingShell.Infrastructure.Messages
{
    public class MessageErrors
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
