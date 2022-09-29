/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  29 September 2022
* 
* @fileName - WlletController.cs
* 
* @Copyright (c) 2022 HUBTEL
*/


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

        [HttpGet("{id}", Name = "GetWalletById")]
        public ActionResult<Wallet> GetWalletById( int id)
        {
            Wallet _wallet = _walletRepo.GetWalletById(id);
            if (_wallet == null) return NotFound("Wallet not found");
            return Ok(_mapper.Map<WalletReadDto>(_wallet));
        }
        [HttpPost]
        public ActionResult<WalletReadDto> CreateWallet([FromBody] WalletCreateDto wallet)
        {
          
            Wallet _walletModel = _mapper.Map<Wallet>(wallet);
            //check for wallets duplicates;

            if (_walletModel.WalletType.ToLower() != "card" && _walletModel.WalletType.ToLower() != "momo") return BadRequest("Wallet Type should either be [Card] or [Momo]");

            if (_walletModel.WalletType.ToLower() == "card") _walletModel.AccountNumber = _walletModel.AccountNumber.Substring(0, 6);

            //Check if Wallet is within maximum wallet limit
            if (!_walletRepo.IsWalleWithinMaxLimit(_walletModel)) return BadRequest("An account cannot have more than 5 wallets");

            if (_walletRepo.IsWalletDuplicate(_walletModel)) return BadRequest("Similar wallet already exist for this user") ;


            _walletRepo.CreateWallet(_walletModel);
            _walletRepo.SaveChanges();

            WalletReadDto _walletReadDto = _mapper.Map<WalletReadDto>(_walletModel);
            return CreatedAtRoute(nameof(GetWalletById), new { id = _walletReadDto.ID },_walletReadDto);
          
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteWallet(int id)
        {
            Wallet _wallet = _walletRepo.GetWalletById(id);
            if (_wallet == null) return NotFound("Wallet not found");
            _walletRepo.DeleteWallet(_wallet);
            _walletRepo.SaveChanges();
            return NoContent();
        }
    }
}
