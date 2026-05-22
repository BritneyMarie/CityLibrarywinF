# CityLibrarywinF — To-Do List

A full checklist of everything that needs to be fixed and implemented to make this project fully functional.

---

## 🐛 Bug Fixes (Compile Errors — must fix first)

- [ ] **IssuesReturnForm.cs — Missing constructor declaration**
  The file has `{ InitializeComponent(); }` with no method name. Add:
  ```csharp
  public IssuesReturnForm() { InitializeComponent(); }
  ```

- [ ] **MembersForm.cs — Broken object initializer**
  Lines 23–26 use semicolons inside an object initializer block (invalid syntax). Fix to:
  ```csharp
  var member = new Members
  {
      MemberID = txt_MemberID.Text,
      MemberName = txt_MemberName.Text
  };
  ```

- [ ] **Manage Books.cs — Wrong event handler signature**
  `btnAddBooks_Click(object sender, EventArgs e, books books)` has a third parameter WinForms cannot pass. Remove the third parameter:
  ```csharp
  private void btnAddBooks_Click(object sender, EventArgs e)
  ```

- [ ] **books.cs — `Add()` throws NotImplementedException**
  The instance `Add()` method on `books` is a placeholder. Remove it and implement a static shared list instead (see Architecture section in README).

- [ ] **IssuesReturnForm.cs — `Manage_Books.book` doesn't exist**
  `Manage_Books` has no static book list. Create a shared `DataStore.cs` with a static `List<books>` and reference it here.

- [ ] **IssuesReturnForm.cs — `Members.members` doesn't exist**
  `Members` class has no static list. Add one to `DataStore.cs` and reference it.

- [ ] **IssuesReturnForm.cs — `Transaction.Add()` not defined**
  The `Transaction` class has no `Add()` method or static list. Add both to `DataStore.cs`.

- [ ] **IssuesReturnForm.cs — `book.IsAvailabe` doesn't exist**
  The `books` class is missing the `IsAvailable` property (also note the typo: `IsAvailabe`). Add:
  ```csharp
  public bool IsAvailable { get; set; } = true;
  ```

---

## ✏️ Typo Fixes

- [ ] **"Authour" → "Author"** in `books.cs`, `Manage Books.cs`, and any Designer files that reference it.
- [ ] **"IsAvailabe" → "IsAvailable"** in `IssuesReturnForm.cs` once the property is added.

---

## 🚧 Missing Implementations (Features not yet built)

- [ ] **Create `DataStore.cs`** — A central static class to hold shared in-memory lists:
  ```csharp
  public static class DataStore
  {
      public static List<books> Books = new List<books>();
      public static List<Members> Members = new List<Members>();
      public static List<Transaction> Transactions = new List<Transaction>();
  }
  ```

- [ ] **Manage Books — wire up the Add button**
  After fixing the event handler signature, populate the book from form inputs and add to `DataStore.Books`. Refresh `lstShowBooks` after adding.

- [ ] **Manage Books — add Delete/Edit book**
  Currently there is no way to remove or update a book once added.

- [ ] **MembersForm — wire up the Add Member button**
  `btn_AddMember_Click` is empty. Move the member-creation logic there (not in `textBox1_TextChanged`).

- [ ] **MembersForm — add `Members.Add()` or use DataStore**
  `Members.Add(Members)` is called but not defined. Route this through `DataStore.Members.Add(member)`.

- [ ] **IssuesReturnForm — complete the Issue Book logic**
  After fixing references, confirm the full flow: select book → select member → record transaction → mark book unavailable → refresh dropdowns.

- [ ] **IssuesReturnForm — implement Return Book**
  Add a "Return Book" button handler that sets `book.IsAvailable = true`, sets `Transaction.ReturnDate = DateTime.Now`, and refreshes the UI.

- [ ] **Form1 — wire up the Returns button**
  `btn_Returns_Click` is empty. Open `IssuesReturnForm` (or a dedicated Return form) here.

- [ ] **Data persistence — save and load data**
  All data is lost when the app closes. Implement JSON or CSV file save/load for `DataStore.Books`, `DataStore.Members`, and `DataStore.Transactions`. Load on app start, save on every change (or on close).

---

## 💡 Nice-to-Have Improvements (After core is working)

- [ ] Add search/filter to the book and member lists.
- [ ] Show overdue books (issues with no return date after X days).
- [ ] Add input validation (empty fields, duplicate ISBNs, duplicate member IDs).
- [ ] Rename `books` class to `Book` (C# convention: PascalCase for class names).
- [ ] Add a splash screen or login screen.
- [ ] Replace in-memory storage with a local SQLite database for proper persistence.
