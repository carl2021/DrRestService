using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordsLib.Model;

namespace DrRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RecordsController : ControllerBase
    {
        private static List<Records> recordsList = new List<Records>()
        {
            new Records(1, "Wack", "Carl", 11),
            new Records(2, "REEEEEE", "Jonas", 120)
        };


        // GET: api/Records
        [HttpGet]
        public IEnumerable<Records> Get()
        {
            return recordsList;
        }

        // GET: api/Records/5
        [HttpGet("{id}", Name = "Get")]
        public Records Get(int id)
        {
            return recordsList.Find(i => i.Id == id);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] Records value)
        {
            recordsList.Add(value);
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Records value)
        {
            Records record = Get(id);
            if (record != null)
            {
                record.Id = value.Id;
                record.Title = value.Title;
                record.Artist = value.Artist;
                record.SongDuration = value.SongDuration;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Records record = Get(id);
            recordsList.Remove(record);
        }
    }
}
