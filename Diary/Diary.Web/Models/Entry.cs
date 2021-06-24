using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Web.Models
{
    public class Entry
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
