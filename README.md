# TQKho

A lightweight Windows desktop app for small warehouses. It tracks products on shelves, handles stock-in and stock-out, and shows how full each shelf is.

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET 6](https://img.shields.io/badge/.NET_6-512BD4?logo=dotnet&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?logo=sqlite&logoColor=white)

## Overview

TQKho ("Kho" is Vietnamese for *warehouse*) replaces a spreadsheet for a small stock room. Each product line is recorded with its purchase-order code, product code, name, quantity and the shelf it sits on. Staff can receive goods, release stock with a quantity check and look at any shelf to see what it holds. Everything is stored in a local SQLite file, so the app works offline without a database server. The UI is in Vietnamese.

## Features

- **Stock-in (Nhập Kho)**
  - Create, edit and delete product lines in a data grid.
  - Validated fields: PO code, product code, name, integer quantity.
  - Shelf codes must be a letter followed by digits (e.g. `K1`, `B2`), and a shelf is created automatically the first time its code is used.
- **Stock-out (Xuất Kho)**: release a quantity from a selected product. The app rejects negative numbers and quantities larger than the stock on hand.
- **Shelf view (Trực Quan)**: pick a shelf to see its products as cards, each with a progress bar showing its quantity against a capacity of 1,000 units.
- **Modern shell**: borderless main window with a custom title bar, sidebar navigation (FontAwesome icons), child forms and maximise/restore controls.
- **Zero-setup storage**: an EF Core + SQLite database (`products.db`) is created automatically on first launch.

## Tech stack

- C# / .NET 6 (`net6.0-windows`), Windows Forms
- Entity Framework Core 7 with SQLite (code-first migrations)
- FontAwesome.Sharp for icons

## Project structure

```
TQKho/
├── Program.cs                 # entry point → frmMenu
├── Form1.cs                   # frmMenu: main shell, sidebar navigation, custom title bar
├── frmNhapKho.cs              # stock-in: product grid + create/edit/delete form
├── XuatKhoConfirmForm.cs      # stock-out confirmation dialog
├── frmTrucQuan.cs             # shelf visualisation
├── frmTongQuan.cs             # overview page (placeholder)
├── CustomControls/ShelfControl.cs   # product card with fill-level progress bar
├── Models/                    # Product, Shelf
├── Contexts/DataContext.cs    # EF Core DbContext (SQLite, products.db)
├── Migrations/                # EF Core migrations
└── Exceptions/, Enums/        # shelf-code validation, form input states
```

## Getting started

### Prerequisites

- Windows
- .NET 6 SDK (or Visual Studio 2022 with the .NET desktop workload)

### Build & run

```bash
git clone https://github.com/khangzxrr/TQKho.git
cd TQKho
dotnet run --project TQKho
```

Or open `TQKho.sln` in Visual Studio and press **F5**. The SQLite database `products.db` is created next to the executable on first run.
