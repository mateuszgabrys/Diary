using AutoMapper;
using Diary.API.Data;
using Diary.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntryController
    {
        private readonly EntryContext _context;
        private readonly ILogger<EntryController> _logger;
        private readonly IMapper _mapper;
        public EntryController(ILogger<EntryController> logger, EntryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<Entry>> Get()
        {
            return await _context.Entries.Find(prop => true).ToListAsync();
        }
        [HttpPost("AddEntry")]
        public async Task<Entry> Post(EntryCreate createEntry)
        {
            var type = _mapper.Map<Entry>(createEntry);
            await _context.Entries.InsertOneAsync(type);
            return _mapper.Map<Entry>(type);
        }
    }
  
}
