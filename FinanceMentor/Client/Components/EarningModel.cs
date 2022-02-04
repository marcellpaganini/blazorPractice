namespace Client.Components
{
    public class EarningModel
    {
            public DateTime Date { get; set; }
            public string Subject { get; set; }            
            public EarningCategory Category { get; set; }            
            public Decimal Amount { get; set; }
    }
}