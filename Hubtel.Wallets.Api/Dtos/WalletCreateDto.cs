using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Dtos
{
    public class WalletCreateDto
    {
        [Required(ErrorMessage = "Wallet name cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wallet Type cannot be empty")]
        public string WalletType { get; set; }

        [Required(ErrorMessage = "Account Number cannot be empty")]
        public string AccountNumber { get; set; }

        [Phone, Required(ErrorMessage = "Account user's phone number cannot be empty")]
        public string Owner { get; set; }

    }
}
