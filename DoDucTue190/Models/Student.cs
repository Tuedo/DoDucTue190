using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoDucTue190.Models
{
public class Student
{
    [Key]
    public string StudentName { get; set; }
    public int StudentId { get; set; }
    public double StudentAge { get; set; }


    
}
}