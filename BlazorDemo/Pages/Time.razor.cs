using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public partial class Time : LayoutComponentBase
{
    private DateTime _Date => DateTime.Now;

    protected override Task OnInitializedAsync()
    {
        Timer timer = new(_ => { InvokeAsync(StateHasChanged); }, null, 1000, 1000);
        return base.OnInitializedAsync();
    }
}