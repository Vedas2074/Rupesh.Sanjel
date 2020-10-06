using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names =new List<string>() { "Ram", " Shyam"};
        names.Add("Rupesh");
        names.Add("Sobit");
        names.Add("Samip");
        names.Add("Biman");

        names.Sort();
    }
    public void LearnAboutDictionary()
    {
        // Holds key-value pairs
        Dictionary <string,string> countryCapitals =new Dictionary<string, string>
        {
            ["USA"] ="WDC",
            ["Russia"] ="Mosco"
        };
        countryCapitals.Add("Nepal","Kathmandu ");
        countryCapitals.Add("Bhutan","Thimpu");
        countryCapitals.Add("India","Delhi");
        countryCapitals.Add("China","Beiging");

    }
}
