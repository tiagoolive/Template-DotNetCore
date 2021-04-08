using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("f2f2b361-325a-409d-bf8d-9c375181018e"), Name = "User Default", Email = "userdefault@template.com", DateCreated = new DateTime(2021,2,2), IsDeleted = false, DateUpdated = null}
                );

            return builder;
        }
    }
}
