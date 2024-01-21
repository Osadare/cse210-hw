using System;
using System.Collections.Generic;
using System.IO;
public class Journal{

public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)//class instance.
    {
      _entries.Add(entry);
    }
    public List<Entry> GetEntries()
    {
        return new List<Entry>(_entries);
      
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file){
       string[] lines = System.IO.File.ReadAllLines(file); 
       foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
        
    }


}