using CarBook.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var locationID = TempData["locationID"];

            if (locationID != null && int.TryParse(locationID.ToString(), out id))
            {
                ViewBag.locationID = locationID;

                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync($"https://localhost:7060/api/RentACars?locationID={id}&available=true");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                    return View(values);
                }
                else
                {
                    ModelState.AddModelError("", "Araç listesi alınırken bir hata oluştu. Lütfen daha sonra tekrar deneyin.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Geçerli bir locationID bulunamadı. Lütfen doğru bir konum seçin.");
            }

            return View();
        }
    }
}