# GitHub Agent Handover — CityLibrarywinF

This file is a handover brief for a GitHub agent to create and configure the repository for the CityLibrarywinF project.

---

## Task Summary

Create a new GitHub repository for a C# Windows Forms library management desktop application, push all project files, and configure the repo correctly.

---

## Repository Details

| Field | Value |
|---|---|
| **Repo name** | `CityLibrarywinF` |
| **Description** | A C# Windows Forms desktop app for managing a city library — books, members, and issue/return transactions. |
| **Visibility** | Public |
| **Owner** | britneymnchauke (confirm with user if different) |
| **Default branch** | `main` |

---

## Files to Push

Push everything inside the `CityLibrarywinF/` folder on the Desktop. The structure should look like this in the repo:

```
CityLibrarywinF/
├── readme.md                          ← project README (already written)
├── todo.md                            ← full fix & feature checklist (already written)
├── GITHUB_HANDOVER.md                 ← this file (can be removed after setup)
└── CityLibrarywinF/
    ├── CityLibrarywinF.sln
    ├── CityLibrarywinF/
    │   ├── Program.cs
    │   ├── Form1.cs
    │   ├── Form1.Designer.cs
    │   ├── books.cs
    │   ├── Members.cs
    │   ├── Transaction.cs
    │   ├── Manage Books.cs
    │   ├── Manage Books.Designer.cs
    │   ├── MembersForm.cs
    │   ├── MembersForm.Designer.cs
    │   ├── IssuesReturnForm.cs
    │   ├── IssuesReturnForm.Designer.cs
    │   └── CityLibrarywinF.csproj
```

**Do NOT push** the following (add to `.gitignore`):
- `bin/` and `obj/` folders
- `.vs/` folder
- `*.user` files
- `*.json` files inside `obj/`

---

## .gitignore to Create

Create a `.gitignore` at the repo root with this content:

```
# Visual Studio
.vs/
bin/
obj/
*.user
*.suo
*.userosscache
*.sln.docstates

# Build results
[Dd]ebug/
[Rr]elease/
x64/
x86/

# NuGet
*.nupkg
project.lock.json
project.fragment.lock.json
artifacts/

# Data files (generated at runtime)
books.json
members.json
transactions.json
```

---

## Repo Setup Steps for the Agent

1. **Create the repo** with the name and description above. Set visibility to Public.
2. **Create the `.gitignore`** file at the root using the content above.
3. **Push all project files** from `C:\Users\user\OneDrive\Desktop\CityLibrarywinF\` excluding the paths listed above.
4. **Set the default branch** to `main`.
5. **Create the following labels** on the repo for issue tracking:

| Label | Color | Purpose |
|---|---|---|
| `bug` | `#d73a4a` | Compile errors and runtime bugs |
| `enhancement` | `#a2eeef` | New features to implement |
| `good first issue` | `#7057ff` | Easy fixes like typos |
| `help wanted` | `#008672` | Items needing attention |

6. **Create the following issues** from `todo.md` to track progress:

**Bug issues (label: `bug`):**
- IssuesReturnForm.cs — Missing constructor declaration
- MembersForm.cs — Broken object initializer syntax
- Manage Books.cs — Wrong event handler signature (3 parameters)
- books.cs — `Add()` throws NotImplementedException
- IssuesReturnForm.cs — `Manage_Books.book` static list doesn't exist
- IssuesReturnForm.cs — `Members.members` static list doesn't exist
- IssuesReturnForm.cs — `Transaction.Add()` not defined
- IssuesReturnForm.cs — `IsAvailabe` property missing from books class

**Typo issues (label: `good first issue`):**
- Fix typo: "Authour" → "Author" across all files
- Fix typo: "IsAvailabe" → "IsAvailable" in IssuesReturnForm.cs

**Enhancement issues (label: `enhancement`):**
- Create `DataStore.cs` — shared static data lists
- Implement Add Book functionality in Manage Books form
- Implement Add Member functionality in MembersForm
- Implement Return Book logic in IssuesReturnForm
- Wire up Returns button in Form1
- Add data persistence using JSON (save/load on app open/close)
- Add input validation across all forms

---

## Context for the Agent

- This project was built in **Visual Studio 2022** using **.NET Windows Forms**.
- There are currently **compile errors** — the project does not build yet. See `todo.md` for the full list.
- `readme.md` contains corrected code snippets for every broken file and a recommended fix order.
- The developer (Britney) will be working through the fixes herself using the `todo.md` checklist.
- The repo is for personal/portfolio use.

---

## After Setup

Once the repo is created and files are pushed, confirm:
- [ ] Repo is visible at `https://github.com/britneymnchauke/CityLibrarywinF`
- [ ] `readme.md` renders correctly on the repo homepage
- [ ] `.gitignore` is present and `bin/`, `obj/`, `.vs/` are excluded
- [ ] Issues are created and labelled
- [ ] Default branch is `main`
