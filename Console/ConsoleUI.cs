using Model;
using Service;

namespace Console;

public class ConsoleUi(IBookService bookService, IAuthorService authorService)
{
    private bool _running;
    
    public void Run()
    {
        _running = true;
        ShowMainMenu();
        System.Console.WriteLine();
        while (_running)
        {
            System.Console.Write(">>> ");
            var input = System.Console.ReadLine()?.Trim();
            try
            {
                switch (input)
                {
                    case "add book":
                        AddBook();
                        break;
                    case "add author":
                        AddAuthor();
                        break;
                    case "show authors":
                        ShowAuthors();
                        break;
                    case "exit":
                        Stop();
                        break;
                    default:
                        System.Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
    
    private static void ShowMainMenu()
    {
        System.Console.WriteLine("Menu Commands:");
        System.Console.WriteLine("- add book");
        System.Console.WriteLine("- add author");
        System.Console.WriteLine("- show authors");
        System.Console.WriteLine("- exit");
    }

    private void Stop()
    {
        _running = false;
    }
    
    private void AddBook()
    {
        System.Console.WriteLine();
        System.Console.Write("Enter name: ");
        var name = System.Console.ReadLine()!.Trim();
        
        System.Console.Write("Enter quantity: ");
        var quantity = int.Parse(System.Console.ReadLine()!);
        
        var authors = SelectAuthor();
        
        bookService.AddBooks(name, quantity, authors);
        System.Console.WriteLine();
    }

    private IEnumerable<Author> SelectAuthor()
    {
        var authors = authorService.FindAllAuthors().ToList();
        System.Console.WriteLine("Select author: ");
        PrintAuthor(authors);
        System.Console.Write("Enter author ids: ");
        var ids = System.Console.ReadLine()!
            .Split(',')
            .Select(int.Parse)
            .ToList();
        var selectedAuthors = ids
            .Select(id =>
            {
                if (id < 0 || id > authors.Count)
                    throw new ArgumentException("Invalid author id.");
                return authors[id - 1];    
            })
            .ToList();
        return selectedAuthors;       
    }
    
    private void AddAuthor()
    {
        System.Console.WriteLine();
        System.Console.Write("Enter name: ");
        var name = System.Console.ReadLine()!.Trim();
        authorService.AddAuthor(name);
        System.Console.WriteLine();
    }
    
    private void ShowAuthors()
    {
        System.Console.WriteLine();
        var authors = authorService.FindAllAuthors().ToList();
        if (authors.Count == 0)
            System.Console.WriteLine("No authors to be shown.");
        else PrintAuthor(authors);       
        System.Console.WriteLine();       
    }

    private void PrintAuthor(List<Author> authors)
    {
        for (var i = 0; i < authors.Count; i++)
        {
            var author = authors[i];
            System.Console.WriteLine($"{i + 1}. {author.Name}");       
        }
    }
}