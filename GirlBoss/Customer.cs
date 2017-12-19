using System.ComponentModel.DataAnnotations;

namespace Girlboss
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(49)]
        //[EmailAddress]
        public string firstName  { get; set; }

        public string lastName { get; set;  }

        [Required ,EmailAddress]
        public string Email { get; set;  }
       
    }
}