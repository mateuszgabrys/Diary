using AutoMapper;
using Diary.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Web
{
    public class MappingProfileWeb : Profile
    {
        public MappingProfileWeb()
        {
            CreateMap<Entry, EntryCreate>();
            CreateMap<EntryCreate, Entry>();
        }
    }
}
