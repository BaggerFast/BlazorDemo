using System.ComponentModel.DataAnnotations;

namespace DataCore.Models;

public class CalcModel
{
    [Required]
    public float FirstValue { get; set; }
    [Required]
    public float SecondValue { get; set; }
    [Required]
    public string Sign { get; set; } = "+";
    public string Calculate() =>
    Sign switch
    {
        "/" => (FirstValue / SecondValue).ToString(),
        "*" => (FirstValue * SecondValue).ToString(),
        "+" => (FirstValue + SecondValue).ToString(),
        "-" => (FirstValue - SecondValue).ToString(),
        _ => "0"
    };
}