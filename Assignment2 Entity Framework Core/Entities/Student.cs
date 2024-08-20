using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Entities
{
    #region Mapping By Convention
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        // Navigational property
        [ForeignKey("DeptId")]
        public Department? department { get; set; }
    }
    #endregion

    #region Mapping By Data Annotation
    //[Table("Students", Schema = "dbo")]
    //public class Student
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [StringLength(10, MinimumLength = 3)]
    //    public string FName { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [StringLength(10, MinimumLength = 3)]
    //    public string LName { get; set; }

    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    public string? Address { get; set; }

    //    [Range(20, 30)]
    //    public int? Age { get; set; }

    //    public int DeptId { get; set; }
    //} 
    #endregion

    #region Mapping By Fluent APIs
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string Address { get; set; }
    //    public int Age { get; set; }
    //}
    #endregion
}
