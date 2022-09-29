/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  29 September 2022
* 
* @fileName - WalletProfile.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using AutoMapper;
using Hubtel.Wallets.Api.Dtos;
using Hubtel.Wallets.Api.Models;

namespace Hubtel.Wallets.Api.Profiles
{
    public class WalletProfile : Profile
    {
       public WalletProfile()
        {
            CreateMap<Wallet, WalletReadDto>();
            CreateMap<WalletCreateDto, Wallet>();
        }
    }
}
