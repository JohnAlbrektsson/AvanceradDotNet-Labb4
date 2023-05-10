using AvanceradDotNet_Labb4.Models;
using Microsoft.EntityFrameworkCore;

namespace AvanceradDotNet_Labb4.Services
{
    public class PersonRepository : IPersonRepository<Person>
    {
        private AppDbContext _appDbContext;
        public PersonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<Person> Add(Person newObject)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _appDbContext.Persons.ToListAsync();
        }

        public async Task<IEnumerable<Interest>> GetInterests(int id)
        {
            var result = from pi in _appDbContext.PersonInterests
                         join i in _appDbContext.Interests on pi.InterestID equals i.InterestId
                         join p in _appDbContext.Persons on pi.PersonID equals p.PersonId
                         where pi.PersonID == id
                         select i;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<Link>> GetLinks(int id)
        {
            var result = from pi in _appDbContext.PersonInterests
                         join l in _appDbContext.Links on pi.LinkID equals l.LinkId
                         join p in _appDbContext.Persons on pi.PersonID equals p.PersonId
                         where pi.PersonID == id
                         select l;
            return await result.ToListAsync();
        }

        public Task<Person> Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
