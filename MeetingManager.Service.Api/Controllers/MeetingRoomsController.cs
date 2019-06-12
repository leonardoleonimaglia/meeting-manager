using System;
using MeetingManager.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeetingManager.Domain.Interfaces;

namespace MeetingManager.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingRoomsController : ControllerBase
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMeetingRoomsRepository _meetingRoomsRepository;

        public MeetingRoomsController(IUnitOfWorkFactory unitOfWorkFactory,
            IMeetingRoomsRepository meetingRoomsRepository)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _meetingRoomsRepository = meetingRoomsRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            try
            {
                using (_unitOfWorkFactory.StartUnitOfWork())
                {
                    //var meetingRooms = await _meetingRoomsRepository.GetByIdAsync(id);
                    //return JsonConvert.SerializeObject(meetingRooms);

                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}