using System;

// У цьому коді клас EmailSender виконує дві задачі: надсилає email та логує результат.
// Щоб дотримуватися принципу єдиного обов'язку, логування винесено в окремий клас.

class Email
{
    public string Theme { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}

class Logger
{
    public void Log(string message) => Console.WriteLine(message);
}

class EmailSender
{
    private readonly Logger _logger;

    public EmailSender(Logger logger) => _logger = logger;

    public void Send(Email email)
    {
        // Надсилання повідомлення...
        _logger.Log($"Email від '{email.From}' до '{email.To}' відправлено.");
    }
}

class Program
{
    static void Main()
    {
        var emails = new[]
        {
            new Email { From = "Me", To = "Vasya", Theme = "Who are you?" },
            new Email { From = "Vasya", To = "Me", Theme = "Vacuum cleaners!" },
            new Email { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" },
            new Email { From = "Vasya", To = "Me", Theme = "Washing machines!" },
            new Email { From = "Me", To = "Vasya", Theme = "Yes" },
            new Email { From = "Vasya", To = "Petya", Theme = "+2" }
        };

        var logger = new Logger();
        var emailSender = new EmailSender(logger);

        foreach (var email in emails)
        {
            emailSender.Send(email);
        }

        Console.ReadKey();
    }
}
