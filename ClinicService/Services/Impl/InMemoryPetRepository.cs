using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class InMemoryPetRepository : IPetRepository
    {

        public int Create(Pet item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Pet item)
        {
            throw new NotImplementedException();
        }
    }
}
