using Newtonsoft.Json;
using System.Collections.Generic;

namespace FuelAccountingShell.Infrastructure.Messages
{
    public class Errors
    {
        [JsonProperty("errors")]
        public List<MessageErrors> MessageErrors { get; set; }
    }
}
