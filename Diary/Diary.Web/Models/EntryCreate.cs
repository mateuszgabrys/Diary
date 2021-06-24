using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Web.Models
{
    public class EntryCreate
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
