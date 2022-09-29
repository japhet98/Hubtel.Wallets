/**
* @author Japhet Kuntu Blankson
* 
* @createdOn  29 September 2022
* 
* @fileName - WalletReadDto.cs
* 
* @Copyright (c) 2022 HUBTEL
*/

using System;

namespace Hubtel.Wallets.Api.Dtos
{
    public class WalletReadDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string WalletType { get; set; }
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
