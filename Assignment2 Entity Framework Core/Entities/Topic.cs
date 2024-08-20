using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Entities
{
    #region Mapping By Convention
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigational property
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
    #endregion

    #region Mapping By Data Annotation
    //[Table("Topics", Schema = "dbo")]
    //public class Topic
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [StringLength(10)]
    //    public string Name { get; set; }
    //}
    #endregion
}
