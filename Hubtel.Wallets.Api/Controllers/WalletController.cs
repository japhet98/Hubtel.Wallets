using AutoMapper;
using Hubtel.Wallets.Api.Data;
using Hubtel.Wallets.Api.Dtos;
using Hubtel.Wallets.Api.Interfaces;
using Hubtel.Wallets.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hubtel.Wallets.Api.Controllers
{
    [Route("api/wallets")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletRepo _walletRepo;
        private readonly IMapper _mapper; 
        public WalletController(IWalletRepo repository,IMapper mapper)
        {
            _walletRepo = repository;
            _mapper = mapper;
        }

        [HttpGet]   
        public ActionResult<IEnumerable<Wallet>> GetAllWallets()
        {
            IEnumerable<Wallet> _wallets = _walletRepo.GetAllWallets();
            return Ok(_mapper.Map<IEnumerable<WalletReadDto>>(_wallets));
        }
    }
}
