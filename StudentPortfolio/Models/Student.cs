using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortfolio.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Rank { get; set; }

    }

  
}