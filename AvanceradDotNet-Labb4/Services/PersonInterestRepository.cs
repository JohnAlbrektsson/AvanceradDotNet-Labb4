using AvanceradDotNet_Labb4.Models;
using Microsoft.EntityFrameworkCore;

namespace AvanceradDotNet_Labb4.Services
{
    public class PersonInterestRepository : IPersonInterestRepo<PersonInterest>
    {
        private AppDbContext _appDbContext;
        public PersonInterestRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<PersonInterest> Add(PersonInterest newEntity)
        {
            if(newEntity == null)
            {
                return null;
            }
            await _appDbContext.PersonInterests.AddAsync(newEntity);
            await _appDbContext.SaveChangesAsync();
            return newEntity;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonInterest> Get(int id)
        {
            return await _appDbContext.PersonInterests.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<PersonInterest>> GetAll()
        {
            return await _appDbContext.PersonInterests.ToListAsync();
        }

        public Task Update(PersonInterest entity)
        {
            throw new NotImplementedException();
        }
    }
}
