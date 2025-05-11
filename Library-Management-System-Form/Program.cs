using Microsoft.EntityFrameworkCore;
using Persistency;
using Persistency.repository;
using Service;

namespace Library_Management_System_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            var dbContext = new LmsDbContextFactory().CreateDbContext([]);
            
            using (var context = new LmsDbContextFactory().CreateDbContext([]))
            {
                context.Database.Migrate();
            }
            
            var bookRepository = new BookRepository(dbContext);
            var authorRepository = new AuthorRepository(dbContext);
            var bookService = new BookService(bookRepository);
            var authorService = new AuthorService(authorRepository);
            
            Application.Run(new LibraryManagementSystemForm(bookService, authorService));
        }
    }
}