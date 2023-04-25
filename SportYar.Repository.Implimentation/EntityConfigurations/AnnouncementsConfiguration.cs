using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class AnnouncementsConfiguration : BaseEntityConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsExpired).HasDefaultValue(false);
            builder.HasMany(x=>x.Requests).WithOne(x=>x.Announcement).HasForeignKey(x=>x.AnnouncementId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
