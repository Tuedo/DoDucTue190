
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoDucTue190.Models
{
public class HocPhan
{
    [Key]
    public string TenHocPhan { get; set; }
    public int MaHocPhan { get; set; }
    public double TenGiangVien { get; set; }
    public string StudentName { get; set; }
    [ForeignKey("StudentName")]


    
}
}