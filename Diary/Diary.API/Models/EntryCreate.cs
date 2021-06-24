using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.API.Models
{
    public class EntryCreate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
