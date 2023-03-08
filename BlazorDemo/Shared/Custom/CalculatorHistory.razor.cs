using BlazorDemo.Services;
using DataCore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Shared.Custom;

public partial class CalculatorHistory : ComponentBase
{
    [Inject] private CalcDataService CalcService { get; set; }

    private IReadOnlyList<CalcModel> CalcData => CalcService.GetData();

    public void Update()
    {
        StateHasChanged();
    }
}