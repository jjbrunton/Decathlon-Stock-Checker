using Newtonsoft.Json;

namespace Decathlon.Stock.Checker.Models
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public string Error {get;set;}
    }
}