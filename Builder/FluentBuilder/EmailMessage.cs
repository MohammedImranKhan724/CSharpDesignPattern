namespace Builder.FluentBuilder
{
    public class EmailMessage
    {
        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string From { get; set; }

        public bool IsHtml { get; set; }

        public override string ToString()
        {
            return $"From: {From}\nTo: {To}\nSubject: {Subject}\nIsHtml: {IsHtml}\nBody: {Body}";
        }
    }
}
