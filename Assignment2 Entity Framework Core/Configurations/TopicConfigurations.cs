using Assignment2_Entity_Framework_Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Configurations
{
    internal class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasKey(T => T.Id);
            T.Property(T => T.Id).UseIdentityColumn();
            T.Property(T => T.Name).IsRequired(true).HasMaxLength(20);
        }
    }
}
