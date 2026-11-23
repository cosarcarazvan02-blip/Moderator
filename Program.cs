using ModeratorApp;

class Program
{
    public static void Main(string[] args)
    {
        Moderator m = new Moderator();

        Console.Write("Introduceti mesajul:");
        string? mesaj = Console.ReadLine();

        ModerationResult m2 = m.Moderate(mesaj);
        Console.WriteLine("Verdictul este:" + m2.Verdict);
        Console.WriteLine("Textul cenzurat:" + m2.CensoredText);
    }
}

