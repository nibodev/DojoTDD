namespace DojoTDD.Domain.Dojo_2.Entities
{
    public class Transaction
    {
        public Transaction(Account source, Account destiny, double value)
        {
            Source = source;
            Destiny = destiny;
            Value = value;
        }
        public Account Source { get; private set; }
        public Account Destiny { get; private set; }
        public double Value { get; private set; }
    }
}
