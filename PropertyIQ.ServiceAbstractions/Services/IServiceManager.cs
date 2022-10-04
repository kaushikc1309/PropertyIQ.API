using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyIQ.ServiceAbstractions.Services
{
    public interface IServiceManager
    {
        IPropertyService PropertyService { get; }
    }
}
