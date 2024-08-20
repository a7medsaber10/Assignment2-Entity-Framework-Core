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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(s => s.Id);
            S.Property(s => s.Id).UseIdentityColumn();
            S.Property(s => s.FName).IsRequired(true).HasColumnType("varchar").HasMaxLength(50);
            S.Property(s => s.LName).IsRequired(true).HasColumnType("varchar").HasMaxLength(50);
            S.Property(s => s.Address).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
