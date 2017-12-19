using System.ComponentModel.DataAnnotations;

namespace Girlboss
{
    public class Customer
    {
        public int id { get; set; }

        [Required, StringLength(49)]
        //[EmailAddress]
        public string firstName  { get; set; }

        public string lastName { get; set;  }

        [Required ,EmailAddress]
        public string email { get; set;  }
       
    }
}