using System.Collections.Generic;
using DatingApp.Api.Data.Models;

namespace DatingApp.Api.Repositories
{
    public interface IPersonRepository: IRepository<Person>
    {
         IEnumerable<Person> getAllPerson();
    }
}