using DatingApp.Api._UnitOfWork;
using DatingApp.Api.Data.Models;
using DatingApp.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonRepository _personRepo;

        public PersonsController(IUnitOfWork unitOfWork, IPersonRepository personRepo)
        {
            this._personRepo = personRepo;
            this._unitOfWork = unitOfWork;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personRepo.getAllPerson());
        }

        [HttpPost]
        public IActionResult AddPerson([FromBody] Person person)
        {
            _personRepo.Add(person);
            int result = _unitOfWork.SaveAll();

            return NoContent();
        }
    }
}
