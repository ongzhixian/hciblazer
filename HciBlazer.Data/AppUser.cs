using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HciBlazer.Data
{
    public interface IAppUser
    {
        UserCredential UserCredential { get; set; }

        IEnumerable<AppUserRole> UserRoles { get; set; }
    }

    public class AppUser : IAppUser
    {
        [Key]
        public int Id { get; set; }

        public UserCredential UserCredential { get; set; }

        public IEnumerable<AppUserRole> UserRoles { get; set; }

    }
}
