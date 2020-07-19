using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ngTest.Models
{
    public class Driver
    {

        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(9)]
        public string Phone { get; set; }
        [Required]
        public DateTime StartOfWork { get; set; }
        [Required]
        public DateTime LastEyesTest { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}