using AutoMapper;
using Diary.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Diary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClient, IMapper mapper)
        {
            _logger = logger;
            _httpClient = httpClient.CreateClient("LearningDiaryApi");
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("/api/Entry");
            var content = await response.Content.ReadAsStringAsync();
            var entrieslist = JsonConvert.DeserializeObject<IEnumerable<Entry>>(content);
            return View(entrieslist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> AddEntry()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> AddEntry(EntryCreate entryCreate)
        //{
        //    var responseMessage = await _httpClient.PostAsJsonAsync($"/Entry/AddEntry",
        //        new EntryCreate
        //        {
        //            Title = entryCreate.Title,
        //            Description = entryCreate.Description,
        //            Tags = entryCreate.Tags,
        //            DateOfCreation = DateTime.Now
        //        });
        //    var type = _mapper.Map<Entry>(responseMessage);
        //    return View(type);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
