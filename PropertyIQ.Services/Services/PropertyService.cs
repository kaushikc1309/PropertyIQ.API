using PropertyIQ.Domain.Entities;
using PropertyIQ.Domain.Repository;
using PropertyIQ.ServiceAbstractions.Services;

namespace PropertyIQ.Services.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IRepositoryManager _repositoryManager;

        public PropertyService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        
        public async Task<Property> GetById(int propertyId)
        {
            return await _repositoryManager.PropertyRepository.GetByIdAsync(propertyId);
        }
    }
}
