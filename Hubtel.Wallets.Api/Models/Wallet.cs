using System;
using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models
{
    public class Wallet
    {
        [Key]
        
        public int ID { get; set; }
        [Required(ErrorMessage ="Wallet name cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Wallet Type cannot be empty")]
        public string WalletType { get; set; }
        [Required(ErrorMessage = "Account Number cannot be empty")]
        public string AccountNumber { get; set; }
        [Phone, Required(ErrorMessage = "Account user's phone number cannot be empty")]
        public string Owner { get; set; }
   
        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
