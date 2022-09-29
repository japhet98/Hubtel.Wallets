/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  28 September 2022
* 
* @fileName - WalletDBContext.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using Hubtel.Wallets.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace Hubtel.Wallets.Api.Data
{
    public class WalletDBContext : DbContext
    {
        public WalletDBContext(DbContextOptions<WalletDBContext> options) : base(options)
        {
        }

        public DbSet<Wallet> Wallets { get; set; }
    }
}
