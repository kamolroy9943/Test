using System.Collections.Generic;
using System.Linq;
using DatingApp.Api.Data;
using DatingApp.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext _context) : base(_context)
        {
        }

        private TestContext dbContext {get{return Context as TestContext;}}
        public IEnumerable<Person> getAllPerson()
        {
            return dbContext.Persons.ToList();
        }
    }
}