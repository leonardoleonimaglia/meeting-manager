using MeetingManager.Domain.Interfaces;
using MeetingManager.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using MeetingManager.Domain.Entities;
using Newtonsoft.Json.Linq;

namespace MeetingManager.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IUsersRepository _userRepository;

        public UsersController(IUnitOfWorkFactory unitOfWorkFactory,
            IUsersRepository userRepository)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            try
            {
                using (_unitOfWorkFactory.StartUnitOfWork())
                {
                    var allUsers = await _userRepository.GetAsync();
                    return JsonConvert.SerializeObject(allUsers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            try
            {
                using(_unitOfWorkFactory.StartUnitOfWork())
                {
                    var user = await _userRepository.GetByIdAsync(id);
                    return JsonConvert.SerializeObject(user);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public void Post([FromBody] Users user)
        {
            try
            {
                using (var uow = _unitOfWorkFactory.StartUnitOfWorkWithTransaction())
                {
                    _userRepository.Add(user);

                    uow.Save();
                    uow.Commit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public void Put([FromBody] Users user)
        {
            try
            {
                using (var uow = _unitOfWorkFactory.StartUnitOfWorkWithTransaction())
                {
                    _userRepository.Update(user);

                    uow.Save();
                    uow.Commit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
