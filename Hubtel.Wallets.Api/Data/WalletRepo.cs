﻿/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  29 September 2022
* 
* @fileName - WalletRepo.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using Hubtel.Wallets.Api.Interfaces;
using Hubtel.Wallets.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Hubtel.Wallets.Api.Data
{
    public class WalletRepo : IWalletRepo
    {
        private readonly WalletDBContext _dbContext;

        public WalletRepo(WalletDBContext context)
        {
            _dbContext = context; 
        }
        public void CreateWallet(Wallet _wallet)
        {
            if (_wallet == null) throw new ArgumentNullException(nameof(_wallet));
         

            _dbContext.Add(_wallet);
        }

        public void DeleteWallet(Wallet _wallet)
        {
            if (_wallet == null) throw new ArgumentNullException(nameof(_wallet));
            _dbContext.Remove(_wallet);
        }

        public IEnumerable<Wallet> GetAllWallets()
        {
            IEnumerable<Wallet> _wallets = from wallet in _dbContext.Wallets
                                           select wallet;
            return _wallets;
        }

        public Wallet GetWalletById(int _walletId)
        {
            Wallet _wallet = _dbContext.Wallets.FirstOrDefault(wallet => wallet.ID == _walletId);
            return _wallet;
        }

        public bool IsWalletDuplicate(Wallet wallet)
        {
           bool isDuplicated = (_dbContext.Wallets.Count(_w => _w.Owner == wallet.Owner && _w.Name == wallet.Name && _w.WalletType == wallet.WalletType && _w.AccountNumber == wallet.AccountNumber)>0);
            return isDuplicated;
        }

        public bool IsWalleWithinMaxLimit(Wallet _wallet)
        {
            bool _IsWithinLimit = (_dbContext.Wallets.Count(wallet => wallet.Owner == _wallet.Owner) < 5);
            return _IsWithinLimit;
        }

        public bool SaveChanges()
        {
          return (_dbContext.SaveChanges()>=0);
        }
    }
}
