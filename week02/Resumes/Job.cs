public class Job{
    public string _company ;
    public string _jobTitle;
    public int _starterYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"JobTitle: {_jobTitle} {_company} {_starterYear - _endYear}");
    }
}