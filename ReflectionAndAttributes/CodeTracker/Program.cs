using System;

[Author("Peshooo")]
public class StartUp
{
    [Author("Gosho")]
    static void Main(string[] args)
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}
