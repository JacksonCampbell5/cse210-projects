using System.IO;
public class Journal
{
    List<Entry> _journal = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _journal.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }   
    }
    public void SaveToFile(String file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _journal)
        {
            outputfile.WriteLine($"{entry._date},{entry._prompt},{entry._message}");
        }
        }
    }
    public void LoadFromFile(String file)
    {
       string[] lines = System.IO.File.ReadAllLines(file);
       foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split(",");
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._message = parts[2];
            _journal.Add(newEntry);
        }
    }
}