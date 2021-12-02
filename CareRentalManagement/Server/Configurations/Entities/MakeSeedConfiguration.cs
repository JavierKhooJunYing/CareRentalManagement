using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace CareRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    Id = 2,
                    Name = "Toyata",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );  
        }
    }
}
