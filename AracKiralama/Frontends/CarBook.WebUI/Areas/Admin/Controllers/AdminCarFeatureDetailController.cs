using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();

            // API çağrısı
            var responseMessage = await client.GetAsync($"https://localhost:7060/api/CarFeatures?id={id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);

                // Başarılı bir yanıt alınırsa View'a veri gönder
                return View(values);
            }

            // API çağrısı başarısız ise bir hata View'ı gösterilebilir
            ModelState.AddModelError(string.Empty, "API ile bağlantı kurulamadı.");
            return View();
        }

        [HttpPost]
        [Route("Index/{id}")]
        public async Task<IActionResult> Index(int id, List<ResultCarFeatureByCarIdDto> resultCarFeatureByCarIdDto)
        {
            var client = _httpClientFactory.CreateClient();

            foreach (var item in resultCarFeatureByCarIdDto)
            {
                string apiUrl = item.Available
                    ? $"https://localhost:7060/api/CarFeatures/CarFeatureChangeAvailableToTrue?id={item.CarFeatureID}"
                    : $"https://localhost:7060/api/CarFeatures/CarFeatureChangeAvailableToFalse?id={item.CarFeatureID}";

                var response = await client.PostAsync(apiUrl, null); // POST metodu kullanılıyor
                if (!response.IsSuccessStatusCode)
                {
                    ModelState.AddModelError(string.Empty, $"ID {item.CarFeatureID} için işlem başarısız.");
                }
            }

            if (!ModelState.IsValid)
            {
                // Eğer herhangi bir hata oluşmuşsa, aynı sayfaya döner
                return View(resultCarFeatureByCarIdDto);
            }

            return RedirectToAction("Index", "AdminCar");
        }

        [HttpGet]
        [Route("CreateFeatureByCarId")]
        public async Task<IActionResult> CreateFeatureByCarId()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Features");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);

                // Verileri View'a gönder
                return View(values);
            }

            // API başarısız ise boş View döndür
            ModelState.AddModelError(string.Empty, "API ile bağlantı kurulamadı.");
            return View();
        }
    }
}
