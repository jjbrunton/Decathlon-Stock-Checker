using Newtonsoft.Json;

namespace Decathlon.Stock.Checker.Models
{
    public partial class Stock
    {
        [JsonProperty("defaultPriceDropInfoTO")]
        public object DefaultPriceDropInfoTo { get; set; }

        [JsonProperty("defaultStickerInfoTO")]
        public object DefaultStickerInfoTo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("leadTime")]
        public object LeadTime { get; set; }

        [JsonProperty("modelUrl")]
        public string ModelUrl { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("skus")]
        public Skus[] Skus { get; set; }

        [JsonProperty("uniqueSize")]
        public bool UniqueSize { get; set; }
    }
}