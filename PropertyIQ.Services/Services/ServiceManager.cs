using PropertyIQ.Domain.Repository;
using PropertyIQ.Infrastructure.Repository;
using PropertyIQ.ServiceAbstractions;
using PropertyIQ.ServiceAbstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyIQ.Services.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPropertyService> _lazyPropertyService;


        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyPropertyService = new Lazy<IPropertyService>(() => new PropertyService(repositoryManager));

        }

        public IPropertyService PropertyService => _lazyPropertyService.Value;


    }
}
