using DataCore.Models;

namespace BlazorDemo.Services;

public class CalcDataService
{
    private readonly List<CalcModel> _data;

    public CalcDataService()
    {
        _data = new List<CalcModel>();
    }

    public void AddData(CalcModel newCalc)
    {
        if (_data.Any(newCalc.Equals))
        {
            return;
        }

        _data.Add(newCalc);
    }

    public IReadOnlyList<CalcModel> GetData()
    {
        return _data.AsReadOnly();
    }
}