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
    internal class DepartmentsConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(d => d.Id).UseIdentityColumn(10, 10);
            D.Property(d => d.Name).IsRequired(true).HasMaxLength(20);
            D.Property(d => d.HiringDate).IsRequired(true);
        }
    }
}
