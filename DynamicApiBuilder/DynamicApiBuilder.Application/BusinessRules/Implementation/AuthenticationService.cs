using DynamicApiBuilder.Application.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicApiBuilder.Application.BusinessRules.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<Ulid> GetHashToken()
        {
            Ulid ulid = Ulid.NewUlid();
            await Task.Run(() => SaveUniqueHashToken(ulid));
            return ulid;
        }

        private async Task SaveUniqueHashToken(Ulid ulid)
        {

        }
    }
}
