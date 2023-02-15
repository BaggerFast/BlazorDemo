using DataCore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public partial class Calc: LayoutComponentBase
{
    private CalcModel CalcExpression { get; set; } = new();

    protected override void OnInitialized()
    {
        CalcExpression = new();
        base.OnInitialized();
    }
}