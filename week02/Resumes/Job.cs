using System;

public class Job
{
    private string _company { get; set; };
    private string _jobTitle { get; set; };
    private int _startYear { get; set; };
    private int _endYear { get; set; };

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}