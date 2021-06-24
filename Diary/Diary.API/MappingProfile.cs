using AutoMapper;
using Diary.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entry, EntryCreate>();
            CreateMap<EntryCreate, Entry>();
        }
    }
}
