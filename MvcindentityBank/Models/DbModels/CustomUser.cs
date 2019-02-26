using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace MvcindentityBank
{
    public class CustomUser :IdentityUser
    {
        public string SkinColor { get; set; }

        public DateTime LastVisit { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        //navigation property
    }
}