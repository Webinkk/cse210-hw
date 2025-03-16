public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

   public Entry(string date, string promptText, string entryText)
   {
    _date = DateTime.Parse(date);
    _promptText = promptText;
    _entryText = entryText;
   }

    public void Display()
    {
        string DateFormatting = _date.ToString("MM/dd/yyyy");

        Console.WriteLine($"Date: {DateFormatting}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-------------------------------");
    }
}