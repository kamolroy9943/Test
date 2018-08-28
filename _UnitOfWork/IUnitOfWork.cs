using System;
using DatingApp.Api.Repositories;

namespace DatingApp.Api._UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IPersonRepository Persons{get;}
         int SaveAll();
    }
}