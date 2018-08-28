using DatingApp.Api.Data;
using DatingApp.Api.Repositories;

namespace DatingApp.Api._UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPersonRepository Persons { get; private set; }

        private readonly TestContext _context;



        public UnitOfWork(TestContext context)
        {
            _context = context;
            Persons = new PersonRepository(_context);
        }
        public int SaveAll()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}