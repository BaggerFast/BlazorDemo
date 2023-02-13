using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public class Calculator {

    [Required]
    [Range(int.MinValue, int.MaxValue, ErrorMessage = "Error")]
    public float FirstValue { get; set; }

    [Required]
    [Range(int.MinValue, int.MaxValue, ErrorMessage = "Error")]
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

public partial class Calc: LayoutComponentBase
{
    public Calculator CalcExpression = new();

    public string? Result { get; set; } = "";

    public void SetAnswer()
    {
        Result = CalcExpression.Calculate();
    } 
}
