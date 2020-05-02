using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domian
{
    public class Customer
    {
        public int id { get; set; }
        [MaxLength(70)]
        [Required]
        public string Username { get; set; }


        public string PassWord { get; set; }

        [MaxLength(50)]
        [Required]
        public string Firstname { get; set; }

        [MaxLength(50)]
        [Required]
        public string Lastname { get; set; }
        [MaxLength(11)]
        [Required]
        public string Mobile { get; set; }

        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
