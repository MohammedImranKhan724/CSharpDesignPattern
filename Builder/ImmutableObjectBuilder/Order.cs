namespace Builder.ImmutableObjectBuilder
{
    public class Order
    {
        public string OrderId { get; }

        public decimal Amount { get; }

        public bool IsPaid { get; }

        public string Notes { get; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}\nAmount: {Amount}\nIsPaid: {IsPaid}\nNotes: {Notes}";
        }

        private Order(string orderId, decimal amount, bool isPaid, string notes)
        {
            OrderId = orderId;
            Amount = amount;
            IsPaid = isPaid;
            Notes = notes;
        }

        public class Builder
        {
            // Required
            internal string OrderId { get; }
            internal decimal Amount { get; }

            internal bool IsPaid { get; private set; }
            internal string Notes { get; private set; }

            public Builder(string orderId, decimal amount)
            {
                OrderId = orderId;
                Amount = amount;
            }

            public Builder MarkAsPaid()
            {
                IsPaid = true;
                return this;
            }

            public Builder AddNotes(string notes)
            {
                Notes = notes;
                return this;
            }

            public Order Build()
            {
                if (Amount <= 0)
                {
                    throw new InvalidOperationException("Amount must be greater than zero.");
                }

                return new Order(OrderId, Amount, IsPaid, Notes);
            }
        }
    }
}
