using CarBook.Dto.CarDtos;
using CarBook.Dto.CarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v2 = "Aracınızı Seçiniz";
            var client= _httpClientFactory.CreateClient();
            var reponseMessage = await client.GetAsync("https://localhost:7027/api/CarPricings");
            if(reponseMessage.IsSuccessStatusCode)
            {
                var jsonData=await reponseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDto>>(jsonData);   
                return View(values);
            }
            return View();
        }
    }
}
