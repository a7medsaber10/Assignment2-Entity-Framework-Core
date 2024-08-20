using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Entities
{
    #region Mapping By Convention
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigational property
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public DateTime HiringDate { get; set; }

        // Navigational property
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
    #endregion

    #region Mapping By Data Annotation
    //[Table("Departments", Schema = "dbo")]
    //public class Department
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [StringLength(20)]
    //    public string Name { get; set; }

    //    [Required]
    //    public int InsId { get; set; }

    //    [Required]
    //    public DateTime HiringDate { get; set; }
    //}
    #endregion

    #region Mapping by Fluent APIs
    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int InsId { get; set; }
    //    public DateTime HiringDate { get; set; }
    //}
    #endregion
}
