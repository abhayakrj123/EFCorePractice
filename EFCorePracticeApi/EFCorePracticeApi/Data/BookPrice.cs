namespace EFCorePracticeApi.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CurrencyId { get; set; }

        public int Amount { get; set; }

        public Book Book { get; set; }

        public Currencies Currency { get; set; }
    }
}
