using System.ComponentModel.DataAnnotations;
using DataCore.Enums;

namespace DataCore.Models;

public class CalcModel
{
    [Required]
    public float FirstNum { get; set; }
    
    [Required]
    public float SecondNum { get; set; }
    
    [Required]
    public SignEnum Sign { get; set; } = SignEnum.Addition;
    public string Calculate() =>
    Sign switch
    {
        SignEnum.Addition => $"{FirstNum + SecondNum}",
        SignEnum.Subtraction => $"{FirstNum - SecondNum}",
        SignEnum.Multiplication => $"{FirstNum * SecondNum}",
        SignEnum.Division => $"{FirstNum / SecondNum}",
        _ => "0"
    };
}