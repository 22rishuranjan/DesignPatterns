using FacadePattern.SubSystems.Banking;

namespace FacadePattern.Facade
{
    internal class BankingFacade
    {
        private readonly LegacyAccountManager _accountManager;
        private readonly LegacyTransactionProcessor _transactionProcessor;
        private readonly LegacyNotificationSystem _notificationSystem;

        public BankingFacade()
        {
            _accountManager = new LegacyAccountManager();
            _transactionProcessor = new LegacyTransactionProcessor();
            _notificationSystem = new LegacyNotificationSystem();
        }

        public void TransferFunds(string fromAccount, string toAccount, double amount)
        {
            if (_accountManager.ValidateAccount(fromAccount) && _accountManager.ValidateAccount(toAccount))
            {
                _transactionProcessor.ProcessTransaction(fromAccount, toAccount, amount);
                _notificationSystem.SendNotification(fromAccount, toAccount, amount);
            }
        }
    }
}
