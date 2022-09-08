using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial07.Server.Models;
using Tutorial07.Shared;

namespace Tutorial07.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)

        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AssignTicket>().HasKey(assign => new { assign.TicketID, assign.ProjectID });
        }


        public DbSet<Tutorial07.Shared.Project> Project { get; set; }

        public DbSet<Tutorial07.Shared.Company> Company { get; set; }

        public DbSet<Tutorial07.Shared.Ticket> Ticket { get; set; }

        public DbSet<Tutorial07.Shared.AssignTicket> AssignTicket { get; set; }

        public DbSet<Tutorial07.Shared.AssignCompany> AssignCompany { get; set; }

    }
}