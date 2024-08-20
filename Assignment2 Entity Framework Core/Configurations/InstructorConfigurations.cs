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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Id).UseIdentityColumn(1, 1);
            I.Property(I => I.Name).IsRequired(true).HasMaxLength(20);
            I.Property(I => I.Salary).IsRequired(true).HasColumnType("money");
            I.Property(I => I.Bonus).HasColumnType("money");
            I.Property(I => I.Address).HasMaxLength(50);
            I.Property(I => I.HourRate).IsRequired(true);
        }
    }
}
