using PropertyIQ.Domain.Entities;
using PropertyIQ.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyIQ.Infrastructure.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IPropertyRepository>? _lazyRepositoryRepository;
        
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyRepositoryRepository = new Lazy<IPropertyRepository>(() => new PropertyRepository(dbContext));
           
        }

        public IPropertyRepository PropertyRepository => _lazyRepositoryRepository.Value;
        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
