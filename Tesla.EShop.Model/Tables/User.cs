using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tesla.EShop.Model.Tables
{
    [Table("User")]
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }

        //0女 1男
        public bool? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public  DateTime? CreationTime { get; set; }
    }
}
