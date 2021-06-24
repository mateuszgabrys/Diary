using Diary.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Diary.Web.Services
{
    public class EntryService
    {
        HttpClient _httpClient;
        public EntryService()
        {
            _httpClient = new HttpClient();
        }

        //public async Task<IEnumerable<Entry>> GetMyEntries()
        //{
        //    string url = "http://localhost:5006/api/Entry";

        //    var response = await _httpClient.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var children = await response.Content.ReadAsStringAsync();
        //        var childrenConverted = JsonConvert.DeserializeObject<IEnumerable<Entry>>(children);
        //        return childrenConverted;
        //    }
        //    return null;
        //}

        //public async Task<HttpResponseMessage> CreateEntry(EntryCreate entryCreate)
        //{
        //    var responseMessage = await _httpClient.PostAsJsonAsync($"http://diaryapi:8300/api/Entry/AddEntry",
        //        new EntryCreate
        //        {
        //            Title = entryCreate.Title,
        //            Description = entryCreate.Description,
        //            Tags = entryCreate.Tags,
        //            DateOfCreation = DateTime.Now

                   
        //        });
        //    return responseMessage;
        //}
    }
}
