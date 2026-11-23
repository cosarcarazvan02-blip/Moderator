namespace ModeratorApp;
public record ModerationResult (
string Text ,
Verdict Verdict ,
IReadOnlyList <string > Found , 
string CensoredText ) ;
