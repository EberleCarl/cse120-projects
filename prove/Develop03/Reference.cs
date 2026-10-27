public class Reference
{
    public string Book { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    // Constructor for single verse
    public Reference(string book, int verse)
    {
        Book = book;
        StartVerse = verse;
        EndVerse = verse;
    }

    // Constructor for verse range
    public Reference(string book, int startVerse, int endVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public string GetReferenceText()
    {
        if (StartVerse == EndVerse)
            return $"{Book} {StartVerse}";
        else
            return $"{Book} {StartVerse}-{EndVerse}";
    }
}
