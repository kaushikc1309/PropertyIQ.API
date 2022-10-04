using PropertyIQ.Domain.Entities;

namespace PropertyIQ.ServiceAbstractions.Services
{
    public interface IPropertyService
    {
        Task<Property> GetById(int propertyId);
    }
}
