namespace Model;

public sealed class Book : Entity<Guid>
{
    private readonly HashSet<Author> _authors = [];
    
    public string Title { get; private set; } = string.Empty;
    public IReadOnlyCollection<Author> Authors => _authors;
    public int Quantity { get; private set; }
    public int LoanedQuantity { get; private set; }
    public Statistics Statistics { get; private set; } = null!;
    
    public Book() {}
    public Book(Guid id, string title, int quantity)
    {
        Id = id;
        SetTitle(title);
        SetQuantity(quantity);
        LoanedQuantity = 0;
        Statistics = new Statistics();
    }
    
    public void SetTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.", nameof(title));
        Title = title;
    }
    
    public void AddAuthor(Author author)
    {
        if (_authors.Add(author))
            author.AddBook(this);
    }
    
    public void RemoveAuthor(Author author)
    {
        if (_authors.Remove(author))
            author.RemoveBook(this);
    }
    
    public void SetQuantity(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative.");
        if (quantity < LoanedQuantity)
            throw new InvalidOperationException("Quantity cannot be less than the number of books loaned.");
        Quantity = quantity;
    }
    
    public void IncrementQuantity()
    {
        Quantity++;
    }
    
    public void DecrementQuantity()
    {
        if (Quantity == 0)
            throw new InvalidOperationException("Quantity cannot become negative.");
        Quantity--;
    }

    public void IncreaseQuantity(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
        Quantity += amount;
    }

    public void DecreaseQuantity(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
        if (amount > Quantity)
            throw new InvalidOperationException("Amount cannot exceed the current quantity.");
        Quantity -= amount;
    }

    public void LoanBook()
    {
        if(Quantity == LoanedQuantity)
            throw new InvalidOperationException("There are no more books left to loan.");

        LoanedQuantity++;
        Statistics.Loaned();
    }

    public void LoanBooks(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
        if (LoanedQuantity > Quantity - amount)
            throw new InvalidOperationException("Amount cannot exceed the number of available books.");
        LoanedQuantity += amount;
        Statistics.LoanedAmount(amount);
    }
    
    public void ReturnBook()
    {
        if (LoanedQuantity == 0)
            throw new InvalidOperationException("There are no books left to return.");

        LoanedQuantity--;
    }
    
    public void ReturnBooks(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
        if (LoanedQuantity < amount)
            throw new InvalidOperationException("Amount cannot exceed the number of books loaned.");
        LoanedQuantity -= amount;
    }
}