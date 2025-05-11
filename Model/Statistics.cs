namespace Model;

public class Statistics : Entity<Guid>
{
    public int NrTimesLoaned { get; private set; }
    public Guid BookId { get; private set; }
    public Book Book { get; private set; }

    public void Loaned()
    {
        NrTimesLoaned++;
    }
    
    public void LoanedAmount(int amount)
    {
        NrTimesLoaned += amount;
    }
}