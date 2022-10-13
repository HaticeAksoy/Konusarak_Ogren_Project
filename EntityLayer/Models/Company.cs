using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Company
    {


        [Key]
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyRole { get; set; }

    }
}
