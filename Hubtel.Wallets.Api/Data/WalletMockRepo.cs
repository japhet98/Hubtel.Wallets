using Hubtel.Wallets.Api.Interfaces;
using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;

namespace Hubtel.Wallets.Api.Data
{
    public class WalletMockRepo : IWalletRepo
    {
        public void CreateWallet(Wallet _wallet)
        {
            
        }

        public void DeleteWallet(Wallet _wallet)
        {
            
        }

        public IEnumerable<Wallet> GetAllWallets()
        {
            IEnumerable<Wallet> _wallets = new List<Wallet>
            {
                new Wallet
                {
                    ID = 1,
                    AccountNumber = "9203423049203",
                    Name = "MY Accoun one",
                    Owner = "0242424242",
                    WalletType = "Bank Account"
                }
                ,
                new Wallet    {
                    ID = 2,
                    AccountNumber = "9203423049203",
                    Name = "MY Accoun one",
                    Owner = "0242424242",
                    WalletType = "Bank Account"
                }
            };
            return _wallets;
        }

        public Wallet GetWalletById(int _walletId)
        {
            return new Wallet
            {
                ID = 2,
                AccountNumber = "9203423049203",
                Name = "MY Accoun one",
                Owner = "0242424242",
                WalletType = "Bank Account"
            };
        }

        public bool SaveChanges()
        {
            return true;
        }
    }
}
