using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginEg.Models
{
    public class User
    {
        [Key]
        public string EmailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }

    }

}
