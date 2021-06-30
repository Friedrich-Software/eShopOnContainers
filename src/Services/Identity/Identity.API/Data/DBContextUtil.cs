using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.eShopOnContainers.Services.Identity.API.Data;
using Microsoft.eShopOnContainers.Services.Identity.API.Models;

namespace Microsoft.eShopOnContainers.Services.Identity.API.Data
{


    public static class ApplicationDbContextExtension
    {

        private static bool _created = false;


        public static void DropCreateDatabaseAlways(this ApplicationDbContext dbContext)
        {
            if (!_created)
            {
                _created = true;
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
        }
    }
}