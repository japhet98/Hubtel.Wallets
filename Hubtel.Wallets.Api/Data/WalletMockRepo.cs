/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  29 September 2022
* 
* @fileName - WalletMockRepo.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using Hubtel.Wallets.Api.Interfaces;
using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public Task <IEnumerable<Wallet>> GetAllWallets()
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
            return Task.FromResult(_wallets);
        }

        public Task<Wallet> GetWalletById(int _walletId)
        {
            Wallet _task = new Wallet
            {
                ID = 2,
                AccountNumber = "9203423049203",
                Name = "MY Accoun one",
                Owner = "0242424242",
                WalletType = "Bank Account"
            };
            return Task.FromResult(_task);
        }

        public bool IsWalletDuplicate(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }

        public bool IsWalleWithinMaxLimit(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChanges()
        {
            return Task.FromResult(true);
        }
    }
}
