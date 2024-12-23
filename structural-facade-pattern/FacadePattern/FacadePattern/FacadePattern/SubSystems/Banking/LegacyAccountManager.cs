using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems.Banking
{
    internal class LegacyAccountManager
    {
        public bool ValidateAccount(string accountId) => true; // Assume account validation is successful
    }
}
