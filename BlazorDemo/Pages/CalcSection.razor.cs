using BlazorDemo.Services;
using DataCore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages;

public partial class CalcSection: LayoutComponentBase
{
    [Inject] private CalcDataService? CalcService { get; set; }

}