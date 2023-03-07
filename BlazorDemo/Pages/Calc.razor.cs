using BlazorDemo.Services;
using DataCore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public partial class Calc: LayoutComponentBase
{
    [Inject] private CalcDataService? CalcService { get; set; }
    private CalcModel CalcExpression { get; set; } = new();

    protected override void OnInitialized()
    {
        CalcExpression = new();
        base.OnInitialized();
    }

    private void HandleValidSubmit()
    {
        CalcService?.AddData(CalcExpression);
    }
    
}