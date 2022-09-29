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

namespace Hubtel.Wallets.Api.Interfaces
{
    public interface IWalletRepo
    {
        void CreateWallet(Wallet _wallet);
        void DeleteWallet(Wallet _wallet);

        Wallet GetWalletById(int _walletId);

        IEnumerable<Wallet> GetAllWallets();

    }
}
