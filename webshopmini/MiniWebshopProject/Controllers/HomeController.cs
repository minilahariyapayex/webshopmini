using Microsoft.AspNetCore.Mvc;
using MiniWebshopProject.Models;
using System.Diagnostics;
using MiniWebshopProject.Helper;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using MiniWebshopProject.Model;

namespace MiniWebshopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> CreatePaymentOrder()
        {
            try
            {
                PaymentOrderResponseModel responseObj = new PaymentOrderResponseModel();
                PaymentOrderRequestModel reqObj = PrepareReqModel.GetPaymentOrderRequestModel();
                string token = "6a9d9aefbeb0e081bf9cdb957bf3ca5f28f25a9e8b87234884e5096669552bca";
                using (var client = new HttpClient())
                {
                    var url = "https://api.stage.payex.com/psp/paymentorders";
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    var myContent = JsonConvert.SerializeObject(reqObj);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var result = await client.PostAsync(url, byteContent);
                    if (result != null)
                    {
                        var res = await result.Content.ReadAsStringAsync();
                        responseObj = JsonConvert.DeserializeObject<PaymentOrderResponseModel>(res);
                        return Redirect(responseObj.operations[2].href);
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}
