namespace ModeratorApp;
public class Moderator
{
public ModerationResult Moderate ( string text )
    {
        return new ModerationResult("text",
        Verdict.Permis,
        new List <string>(),
        text);
    }
}