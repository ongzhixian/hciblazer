using System;

namespace HciBlazer.Data
{
    public interface IAppUserRole
    {
        string RoleName { get; set; }

    }
    public class AppUserRole : IAppUserRole
    {
        public string RoleName { get; set; }
    }
}
