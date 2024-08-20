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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(C => C.Id);
            C.Property(C => C.Id).UseIdentityColumn(10, 10);
            C.Property(C => C.Duration).IsRequired(true);
            C.Property(C => C.Name).IsRequired(true).HasColumnType("varchar").HasMaxLength(50);
            C.Property(C => C.Description).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
