using System.ComponentModel.DataAnnotations;
using DataCore.Enums;

namespace DataCore.Models;

public class CalcModel
{
    [Required] public float FirstNum { get; set; }

    [Required] public float SecondNum { get; set; }

    [Required] public SignEnum Sign { get; set; } = SignEnum.Addition;

    public float Answer =>
        Sign switch
        {
            SignEnum.Addition => FirstNum + SecondNum,
            SignEnum.Subtraction => FirstNum - SecondNum,
            SignEnum.Multiplication => FirstNum * SecondNum,
            SignEnum.Division => FirstNum / SecondNum,
            _ => 0
        };

    public string SignToString =>
        Sign switch
        {
            SignEnum.Addition => "+",
            SignEnum.Subtraction => "-",
            SignEnum.Multiplication => "*",
            SignEnum.Division => "/",
            _ => "+"
        };

    public bool Equals(CalcModel calc)
    {
        if (ReferenceEquals(this, calc))
        {
            return true;
        }

        return
            Equals(FirstNum, calc.FirstNum) &&
            Equals(SecondNum, calc.SecondNum) &&
            Equals(Sign, calc.Sign);
    }

    public CalcModel Clone()
    {
        return new()
        {
            FirstNum = FirstNum,
            SecondNum = SecondNum,
            Sign = Sign
        };
    }
}