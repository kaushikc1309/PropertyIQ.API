using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PropertyIQ.Domain.Entities;

namespace PropertyIQ.Domain.Repository
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Property>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Property> GetByIdAsync(int propId, CancellationToken cancellationToken = default);
        void Insert(Property property);
        void Remove(Property property);
        void Update(Property property);
    }
}
