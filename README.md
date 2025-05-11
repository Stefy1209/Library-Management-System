# Library Management System

This is a C# application designed to streamline the management of books in a library, including features for tracking loans, returns, and book metadata.

## New Functionality

Each book displayed in the app includes statistics such as the number of times it has been loaned.

## ⚙️ Setup Instructions

1. **Clone the repository**
2. **Build the application**
   - **Using JetBrains Rider**: Click the **Build** button.
   - **Using Visual Studio**: Open the terminal and run: ***dotnet build***

---

## 🧭 Using the Application

Upon launching the app:
- On the **left**, you'll see a table listing books, available copies, and loaned copies.
- On the **right**, you'll find buttons to manage the library.

### Available Actions

1. **Search Book**
2. **Loan Book**
3. **Return Book**
4. **Add Book**
5. **Remove Book**
6. **Modify Book**
7. **Statistics**

---

### 🔍 Search Book

A new window will appear prompting you to enter a title and optionally select authors.  
If no criteria are provided, it searches through the entire collection.

---

### 📤 Loan Book

Select a book from the table and click **Loan Book**.  
This registers one copy as loaned.

---

### 📥 Return Book

Select a book and click **Return Book** to mark a copy as returned.

---

### ➕ Add Book

Opens a new window prompting:
- Title
- Number of copies
- One or more authors (required)

You can add a new author using the **Add Author** button.  
If the input is valid, the book will be added to the table.

---

### 🗑️ Remove Book

Select a book and click **Remove Book** to delete it from the system.

---

### ✏️ Modify Book

Click a book and then **Modify Book**.  
A window will open allowing you to update the title, number of copies, and associated authors.

---

### 📊 Statistics

Click a book and then **Statistics** to view:
- Title
- Number of times loaned
- List of authors

---

