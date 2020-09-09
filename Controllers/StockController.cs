using System.Net;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decathlon.Stock.Checker.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DecathlonStock.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {

        [HttpGet("{skuSize?}")]
        public ActionResult<StockResponse> Get([FromQuery] string urlSuffix, string? skuSize)
        {
            var url = $"https://www.decathlon.co.uk/{urlSuffix}";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var content = doc.GetElementbyId("pdm_productdetailsmaincartridge");

            var json = content.Attributes.FirstOrDefault(x => x.Name == "data-pdmjsmodels");

            if (json == null)
            {
                return this.NotFound();
            }

            var stock = JsonConvert.DeserializeObject<List<Stock>>(WebUtility.HtmlDecode(json.Value)).FirstOrDefault();

            if (stock == null)
            {
                return this.NotFound(new ErrorResponse()
                {
                    Error = "No stock data was found"
                });
            }

            if (!string.IsNullOrEmpty(skuSize))
            {
                var foundSku = stock.Skus?.FirstOrDefault(x => x.Size == skuSize);
                if (foundSku == null)
                {
                    return this.BadRequest(new ErrorResponse()
                    {
                        Error = "Size variant not found"
                    });
                }

                return new StockResponse()
                {
                    Variant = foundSku.Size,
                    InStock = foundSku.Available
                };
            }

            var skusInStock = stock.Skus.Where(x => x.Available);

            return new StockResponse()
            {
                Variant = string.Join(",", skusInStock.Select(x => x.Size)),
                InStock = true
            };
        }
    }
}