using DataCore.Models;

namespace BlazorDemo.Services;

public class CalcDataService
{
    private readonly List<CalcModel> _data = new ();
    
    public void AddData(CalcModel data)
    {
        _data.Add(data);
    }

    public IReadOnlyList<CalcModel> GetData()
    {
        return _data.AsReadOnly();
    }
}