using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicApiBuilder.Application.BusinessRules.Interface
{
    public interface IAuthenticationService
    {
        Task<Ulid> GetHashToken();
    }
}
