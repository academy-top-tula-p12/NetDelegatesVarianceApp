using NetDelegatesVarianceApp;




// Contravariance
EmailMessageReceiver emailReceiver = EmailMessanger;
emailReceiver(new EmailMessage("Hello world"));

emailReceiver = Messanger;
emailReceiver(new EmailMessage("Hello People"));


// For Contravariance
void EmailMessanger(EmailMessage message)
{
    message.Print();
}

void Messanger(Message message)
{
    message.Print();
}




void CovarianceExample()
{
    // Covariance
    MessageBuilder builder = MessageFactory;

    var mess1 = builder("Hello world");
    Console.WriteLine(mess1.GetType());
    mess1.Print();

    builder = EmailMessageFactory;
    var mess2 = builder("Hello people");
    Console.WriteLine(mess2.GetType());
    mess2.Print();

    // For Covariance
    EmailMessage EmailMessageFactory(string text)
    {
        return new EmailMessage(text);
    }

    Message MessageFactory(string text)
    {
        return new Message(text);
    }
}


// For Contravariance
delegate void EmailMessageReceiver(EmailMessage message);

// For Covariance
delegate Message MessageBuilder(string text);