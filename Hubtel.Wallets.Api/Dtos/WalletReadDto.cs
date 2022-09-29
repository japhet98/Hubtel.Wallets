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
