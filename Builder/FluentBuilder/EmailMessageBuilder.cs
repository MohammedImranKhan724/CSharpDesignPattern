namespace Builder.FluentBuilder
{
    public class EmailMessageBuilder
    {
        private readonly EmailMessage _emailMessage = new();

        public EmailMessageBuilder To(string to)
        {
            _emailMessage.To = to;
            return this;
        }

        public EmailMessageBuilder From(string from)
        {
            _emailMessage.From = from;
            return this;
        }

        public EmailMessageBuilder Subject(string subject)
        {
            _emailMessage.Subject = subject;
            return this;
        }

        public EmailMessageBuilder Body(string body)
        {
            _emailMessage.Body = body;
            return this;
        }

        public EmailMessageBuilder AsHtml()
        {
            _emailMessage.IsHtml = true;
            return this;
        }

        public EmailMessage Build()
        {
            if (string.IsNullOrEmpty(_emailMessage.To))
            {
                throw new InvalidOperationException("Recipient (To) is required.");
            }

            return _emailMessage;
        }

    }
}
