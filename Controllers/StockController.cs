using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace DecathlonStock.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase {

        [HttpGet ("{urlSuffix}/{variant}")]
        public ActionResult<StockResponse> Get (string urlSuffix, string variant) {
            var url = $"https://www.decathlon.co.uk/{urlSuffix}";
            var web = new HtmlWeb ();
            var doc = web.Load (url);

            var content = doc.DocumentNode.SelectSingleNode ("//div[contains(@class, 'product-size')]").ChildNodes;
            var variantNames = new Dictionary<string, string> ();
            var stockLevels = new Dictionary<string, bool> ();
            foreach (HtmlNode node in content) {
                if (node.Name == "input") {
                    if (node.Attributes.Any (x => x.Value.Contains ("_desc"))) {
                        var nameAttribute = node.Attributes.FirstOrDefault (x => x.Value.Contains ("_desc"));
                        var valueAttribute = node.Attributes.FirstOrDefault (x => x.Name.Contains ("value"));
                        variantNames.Add (nameAttribute.Value.Substring (0, nameAttribute.Value.IndexOf ("_")), valueAttribute.Value);
                    }

                    if (node.Attributes.Any (x => x.Value.Contains ("_availability"))) {
                        var availability = node.Attributes.FirstOrDefault (x => x.Name.Contains ("value"));
                        var nameAttribute = node.Attributes.FirstOrDefault (x => x.Value.Contains ("_availability"));
                        var variantName = variantNames[nameAttribute.Value.Substring (0, nameAttribute.Value.IndexOf ("_"))];
                        var instock = availability.Value == "A" ? true : false;
                        stockLevels.Add (variantName, instock);
                    }
                }
            }
            return new StockResponse() {
                Variant = variant,
                InStock = stockLevels[variant]
            };
        }
    }
}