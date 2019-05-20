using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HciBlazer.Data
{
    public interface IUserCredential
    {
        int Id { get; set; }

        string Username { get; set; }

        string Password { get; set; }

    }

    [Table("UserCredential")]
    public class UserCredential : IUserCredential
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}