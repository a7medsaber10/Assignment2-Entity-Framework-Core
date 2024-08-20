using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Entities
{
    #region Mapping By Convention
    public class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigtional property
        [ForeignKey("TopicId")]
        public Topic? topic { get; set; }
    }
    #endregion

    #region Mapping By Data Annotation
    //[Table("Courses", Schema = "dbo")]
    //public class Course
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [Range(3, 10)]
    //    public int Duration { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [MaxLength(10)]
    //    public string Name { get; set; }

    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    public string? Description { get; set; }

    //    public int TopId { get; set; }
    //}
    #endregion

    #region Mapping By Fluent APIs
    //public class Course
    //{
    //    public int Id { get; set; }
    //    public int Duration { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int TopId { get; set; }
    //}
    #endregion
}
