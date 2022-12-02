namespace HarryPotter;

public class Letter
{
    public string Message { get; set; }
    public string LetterSender { get; set; }
    public string LetterReciever { get; set; }

    public Letter(string message, string letterSender, string letterReciever)
    {
        Message = message;
        LetterSender = letterSender;
        LetterReciever = letterReciever;
    }
}