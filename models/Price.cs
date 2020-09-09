using System;
using Newtonsoft.Json;

namespace Decathlon.Stock.Checker.Models
{
    public partial class Price
    {
        [JsonProperty("activePrice")]
        public double ActivePrice { get; set; }

        [JsonProperty("discountAmount")]
        public object DiscountAmount { get; set; }

        [JsonProperty("discountPercentage")]
        public long DiscountPercentage { get; set; }

        [JsonProperty("displayDiscountPercentage")]
        public bool DisplayDiscountPercentage { get; set; }

        [JsonProperty("ecoFeePrice")]
        public object EcoFeePrice { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listPrice")]
        public double ListPrice { get; set; }

        [JsonProperty("onSale")]
        public bool OnSale { get; set; }

        [JsonProperty("recommendedStandardPrice")]
        public object RecommendedStandardPrice { get; set; }

        [JsonProperty("salePrice")]
        public object SalePrice { get; set; }

        [JsonProperty("salesType")]
        public object SalesType { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("uniformPrice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UniformPrice { get; set; }
    }
}