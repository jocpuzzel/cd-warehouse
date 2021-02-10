namespace Tdd
{
    public class CD
    {
        public CD(IPaymentProvider paymentProvider, int stockAmount, string title, string artist)
        {
            StockAmount = stockAmount;
            Title = title;
            Artist = artist;
        }

        public int StockAmount { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public void Buy()
        {
            if (StockAmount > 0)
            {
                StockAmount--;
            }    
        }
    }
}