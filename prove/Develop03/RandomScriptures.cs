using System;

public class RandomScriptures
{
    private Dictionary<string, string> _scriptures;

    public RandomScriptures()
    {
        _scriptures = new Dictionary<string, string>();

        _scriptures.Add("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptures.Add("2 Nephi 2:1-2", "Nevertheless, Jacob, my first-born in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.");
        _scriptures.Add("Psalm 105:1-2", "O give thanks unto the LORD; call upon his name: Make known his deeds among the people. Sing unto him, sing psalms unto him: Talk ye of all his wondrous works.");
         
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        KeyValuePair<string, string> randomScripture = _scriptures.ElementAt(index);

        string[] referenceParts = randomScripture.Key.Split(' ');
        string book = referenceParts[0];
        string[] chapterVerseParts = referenceParts[1].Split(':');
        int chapter = int.Parse(chapterVerseParts[0]);
        string verseText = chapterVerseParts[1];

        int startVerse;
        int endVerse;
        if (verseText.Contains("-"))
        {
            string[] verseRangeParts = verseText.Split('-');
            startVerse = int.Parse(verseRangeParts[0]);
            endVerse = int.Parse(verseRangeParts[1]);
        }
        else
        {
            startVerse = int.Parse(verseText);
            endVerse = startVerse;
        }

        return new Scripture(book, chapter, startVerse, endVerse, randomScripture.Value);
    }
}