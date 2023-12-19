using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NetDelegatesVarianceApp
{
    class Message
    {
        public string? Text { get; set; }
        public Message(string? text) => Text = text;

        public virtual void Print()
            => Console.WriteLine($"Message: {Text}");
    }

    class EmailMessage : Message
    {
        public EmailMessage(string? text) : base(text) { }

        public override void Print()
            => Console.WriteLine($"Email Message: {Text}");
    }

    class SmsMessage : Message
    {
        public SmsMessage(string? text) : base(text) { }

        public override void Print()
            => Console.WriteLine($"Sms Message: {Text}");
    }
}
