using BlazorDemo.Shared.Custom;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public partial class CalcSection : LayoutComponentBase
{
    private CalculatorHistory CalcHistoryComponent;

    private void HandleCalcSubmitChanged()
    {
        CalcHistoryComponent.Update();
    }
}