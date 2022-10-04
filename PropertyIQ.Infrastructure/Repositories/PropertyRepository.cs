using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyIQ.Domain.Entities;
using PropertyIQ.Domain.Repository;

namespace PropertyIQ.Infrastructure.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public PropertyRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Property>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Properties.ToListAsync(cancellationToken);

        public async Task<Property> GetByIdAsync(int propId, CancellationToken cancellationToken = default)
        {
            var property = new Property { PropertyId = 1, Name = "Property 1" };
            return await Task.FromResult<Property>(property);

            //await _dbContext.Properties.FirstOrDefaultAsync(x => x.PropertyId == propId, cancellationToken);
        }

        public void Insert(Property property) => _dbContext.Properties.Add(property);

        public void Remove(Property property) => _dbContext.Properties.Remove(property);

        public void Update(Property property) => _dbContext.Properties.Update(property);
        
    }
}
