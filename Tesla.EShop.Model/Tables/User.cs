using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Tesla.EShop.Model.Tables
{
    [Table("User")]
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }        
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public  DateTime? CreationTime { get; set; }
    }
}
