using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeterReadings.API.Models
{
    public class Account
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }

      
    }
}
