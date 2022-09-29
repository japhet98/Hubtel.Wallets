/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  28 September 2022
* 
* @fileName - IWalletRepo.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Interfaces
{
    public interface IWalletRepo
    {
       Task<bool> SaveChanges();
        void CreateWallet(Wallet _wallet);
        void DeleteWallet(Wallet _wallet);

       Task<Wallet> GetWalletById(int _walletId);
     bool IsWalleWithinMaxLimit(Wallet wallet);
   bool IsWalletDuplicate(Wallet wallet);

        Task<IEnumerable<Wallet>> GetAllWallets();

    }
}
