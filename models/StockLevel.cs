namespace DecathlonStock
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class StockLevel
    {
        [JsonProperty("isDisplayedStorePromoMention")]
        public bool IsDisplayedStorePromoMention { get; set; }

        [JsonProperty("isDisplayCrossedAppliedStorePrice")]
        public bool IsDisplayCrossedAppliedStorePrice { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("isStoreAvailable")]
        public bool IsStoreAvailable { get; set; }

        [JsonProperty("isDisplayedStoreSalesMention")]
        public bool IsDisplayedStoreSalesMention { get; set; }

        [JsonProperty("appliedStorePriceString")]
        public string AppliedStorePriceString { get; set; }

        [JsonProperty("isModelStoreDisplayCentralPrice")]
        public bool IsModelStoreDisplayCentralPrice { get; set; }

        [JsonProperty("storeSalesStartDate")]
        public string StoreSalesStartDate { get; set; }

        [JsonProperty("isDisplayedStorePrice")]
        public bool IsDisplayedStorePrice { get; set; }

        [JsonProperty("isDisplayedStoreStock")]
        public bool IsDisplayedStoreStock { get; set; }

        [JsonProperty("storePriceType")]
        public string StorePriceType { get; set; }

        [JsonProperty("storeStrikePriceString")]
        public string StoreStrikePriceString { get; set; }

        [JsonProperty("storeDiscount")]
        public string StoreDiscount { get; set; }

        [JsonProperty("variantId")]
        public string VariantId { get; set; }

        [JsonProperty("isDisplayedCentralPrice")]
        public bool IsDisplayedCentralPrice { get; set; }

        [JsonProperty("isDisplayedStoreEndOfLifeMention")]
        public bool IsDisplayedStoreEndOfLifeMention { get; set; }

        [JsonProperty("appliedStorePrice")]
        public double AppliedStorePrice { get; set; }

        [JsonProperty("isStoreDiscount")]
        public bool IsStoreDiscount { get; set; }

        [JsonProperty("isModelStoreDisplayLocalStock")]
        public bool IsModelStoreDisplayLocalStock { get; set; }

        [JsonProperty("storeStrikePrice")]
        public string StoreStrikePrice { get; set; }

        [JsonProperty("isCentral")]
        public bool IsCentral { get; set; }

        [JsonProperty("hasStoreDroppedPrice")]
        public bool HasStoreDroppedPrice { get; set; }

        [JsonProperty("storePrice")]
        public double StorePrice { get; set; }

        [JsonProperty("storePriceString")]
        public string StorePriceString { get; set; }

        [JsonProperty("storeInSales")]
        public bool StoreInSales { get; set; }

        [JsonProperty("storeSalesEndDate")]
        public string StoreSalesEndDate { get; set; }

        [JsonProperty("strikePriceStartDate")]
        public string StrikePriceStartDate { get; set; }

        [JsonProperty("isModelStoreDisplayLocalPrice")]
        public bool IsModelStoreDisplayLocalPrice { get; set; }

        [JsonProperty("storeSalesPrice")]
        public string StoreSalesPrice { get; set; }

        [JsonProperty("isSalesStorePeriod")]
        public bool IsSalesStorePeriod { get; set; }

        [JsonProperty("storeStock")]
        public object StoreStock { get; set; }

        [JsonProperty("isEresaEnable")]
        public bool IsEresaEnable { get; set; }
    }
}
