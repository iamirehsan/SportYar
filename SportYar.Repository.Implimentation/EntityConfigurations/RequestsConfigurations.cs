﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class RequestsConfigurations : BaseEntityConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
           
        }
    }
}
