namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        [StringLength(50)]
        public string FacultyID { get; set; }

        [StringLength(50)]
        public string MajorID { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }
    }
}
