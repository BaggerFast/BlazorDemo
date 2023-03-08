using BlazorDemo.Services;
using DataCore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Shared.Custom;

public partial class Calculator : ComponentBase
{
    public Calculator()
    {
        CalcExpression = new CalcModel();
    }

    [Inject] private CalcDataService CalcService { get; set; }

    [Parameter] public EventCallback HandleCalcSubmitChanged { get; set; }

    private CalcModel CalcExpression { get; set; }

    private void HandleValidSubmit()
    {
        CalcService.AddData(CalcExpression);
        CalcExpression = CalcExpression.Clone();
        HandleCalcSubmitChanged.InvokeAsync();
    }
}