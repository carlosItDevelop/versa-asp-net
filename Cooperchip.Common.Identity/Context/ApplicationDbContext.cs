using Cooperchip.Common.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace Cooperchip.Common.Identity.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public ApplicationDbContext()
            : base("SiteEmpresa", throwIfV1Schema: false)
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /*---/  Gerenciamento de Claims ---*/
        public DbSet<Client> Client { get; set; }
        public DbSet<Claims> Claims { get; set; }
        /*---/  Gerenciamento de Claims ---*/

    }

}