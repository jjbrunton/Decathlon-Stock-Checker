using Newtonsoft.Json;

namespace Decathlon.Stock.Checker.Models
{
    public partial class Skus
    {
        [JsonProperty("aboveThreshold")]
        public bool AboveThreshold { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("availableQuantity")]
        public long AvailableQuantity { get; set; }

        [JsonProperty("backInStockQualified")]
        public bool BackInStockQualified { get; set; }

        [JsonProperty("belowThreshold")]
        public bool BelowThreshold { get; set; }

        [JsonProperty("customizable")]
        public bool Customizable { get; set; }

        [JsonProperty("customizationUrl")]
        public object CustomizationUrl { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("hasTrylive")]
        public bool HasTrylive { get; set; }

        [JsonProperty("hideStockLevel")]
        public bool HideStockLevel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("leadTime")]
        public object LeadTime { get; set; }

        [JsonProperty("lifeCycle")]
        public long LifeCycle { get; set; }

        [JsonProperty("modelReferenceCode")]
        public string ModelReferenceCode { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("priceDropInfoTO")]
        public object PriceDropInfoTo { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("shippingDelay")]
        public object ShippingDelay { get; set; }

        [JsonProperty("shippingMethodOption")]
        public object ShippingMethodOption { get; set; }

        [JsonProperty("shippingPrice")]
        public object ShippingPrice { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("skuPartnerName")]
        public string SkuPartnerName { get; set; }

        [JsonProperty("skuStockLevel")]
        public object SkuStockLevel { get; set; }

        [JsonProperty("stickerInfoTO")]
        public object StickerInfoTo { get; set; }

        [JsonProperty("storePrice")]
        public object StorePrice { get; set; }

        [JsonProperty("taxCode")]
        public long TaxCode { get; set; }

        [JsonProperty("unitOfMeasure")]
        public object UnitOfMeasure { get; set; }

        [JsonProperty("unitPrice")]
        public object UnitPrice { get; set; }

        [JsonProperty("unitValue")]
        public object UnitValue { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }
    }
}