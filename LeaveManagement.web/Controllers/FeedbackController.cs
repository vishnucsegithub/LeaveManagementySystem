using LeaveManagement.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Newtonsoft.Json;
using System.Text;

namespace LeaveManagement.web.Controllers
{
    public class FeedbackController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7013/api");
        private readonly HttpClient _httpClient;
        public FeedbackController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<FeedbackViewModel> feedbackList = new List<FeedbackViewModel>();
            HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress+ "/Feedback/GetFeedback").Result;

            if (response.IsSuccessStatusCode) { 
                string data = response.Content.ReadAsStringAsync().Result;
                feedbackList = JsonConvert.DeserializeObject<List<FeedbackViewModel>>(data);
                
            }
            return View(feedbackList);
        }
        [HttpGet]
        public IActionResult Create() { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(FeedbackViewModel model) {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _httpClient.PostAsync(_httpClient.BaseAddress + "/Feedback/AddFeedback", content).Result ;
                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Feedback Added";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();

        
        }
            [HttpGet]

            public IActionResult Edit(int Id) {
                try
                {
                    FeedbackViewModel feedback = new FeedbackViewModel();
                    HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/Feedback/SearchFeedback" + Id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string data = response.Content.ReadAsStringAsync().Result;
                        feedback = JsonConvert.DeserializeObject<FeedbackViewModel>(data);
                    }
                    return View(feedback);
                }
                catch (Exception ex)
                {
                    TempData["errorMessage"] = ex.Message;
                    return View();
                }
            }
            [HttpPost]

            public IActionResult Edit(FeedbackViewModel model)
            {
                try
                {
                    string data = JsonConvert.SerializeObject(model);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _httpClient.PutAsync(_httpClient.BaseAddress + "/Feedback/UpdateFeedback", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        TempData["successMessage"] = "Feedback Updated";
                        return RedirectToAction("Index");
                    }
                    return View();
                }
                catch (Exception ex)
                {
                    TempData["errorMessage"] = ex.Message;
                    return View();
                }
            }
            [HttpDelete]
            public IActionResult Delete(int Id)
            {
                try
                {
                    FeedbackViewModel feedback = new FeedbackViewModel();
                    HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/Feedback/SearchFeedback" + Id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string data = response.Content.ReadAsStringAsync().Result;
                        feedback = JsonConvert.DeserializeObject<FeedbackViewModel>(data);
                    }
                    return View(feedback);
                }
                catch (Exception ex)
                {
                    TempData["errorMessage"] = ex.Message;
                    return View();
                }
            }
            [HttpPost,ActionName("Delete")] 
            public IActionResult DeleteConfirmed(int Id)
            {
                try
                {
                    HttpResponseMessage response = _httpClient.DeleteAsync(_httpClient.BaseAddress + "/Feedback/DeleteFeedback" + Id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        TempData["successMessage"] = "Feedback Deleted";
                        return RedirectToAction("Index");
                    }
                    return View();
                }
                catch (Exception ex)
                {
                    TempData["errorMessage"] = ex.Message;
                    return View();
                }
        }
    }
}
