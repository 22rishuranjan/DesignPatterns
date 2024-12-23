using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems.Banking
{
    internal class LegacyTransactionProcessor
    {
        public void ProcessTransaction(string from, string to, double amount) =>
            Console.WriteLine($"Notification sent: {amount} transferred from {from} to {to}");
    }
}
