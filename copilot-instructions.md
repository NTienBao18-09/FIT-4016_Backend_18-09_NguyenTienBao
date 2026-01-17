# AI Coding Guidelines for HaMinhVuong-KT

## Architecture Overview
This is an ASP.NET Core order management system with a hybrid MVC/API architecture:
- **MVC Layer**: Razor views in `Views/Home/` for order CRUD operations (currently incomplete - controller actions missing)
- **API Layer**: RESTful endpoints in `Controllers/OrdersController.cs` for programmatic order access
- **Data Layer**: Entity Framework Core with SQL Server, models in `Models/`, context in `Data/ApplicationDbContext.cs`

## Key Models & Relationships
- `Order` ↔ `Product` (many-to-one): Orders reference products by `ProductId`
- Order numbers follow format: `ORD-YYYYMMDD-XXXX` (e.g., `ORD-20260117-0001`)
- Database tables use snake_case columns, lowercase table names (configured via `[Table]` attributes)

## Development Workflow
- **Build**: `dotnet build`
- **Run**: `dotnet run` (launches on http://localhost:5275)
- **Database**: Local SQL Server instance (`DESKTOP-AHVKPFM\SQLEXPRESS`), connection in `appsettings.json`
- **Seeding**: Call `DbSeeder.Seed(context)` in `Program.cs` for sample data (15 products, 30 orders)

## Coding Patterns
- **API Endpoints**: Use `[HttpGet]`, `[HttpPost]`, etc. with route `api/orders`
- **EF Queries**: Always `Include(o => o.Product)` when querying orders
- **Validation**: Strict model validation (regex for order numbers, range for quantities)
- **Pagination**: Implement with `Skip((page-1)*pageSize).Take(pageSize)` in API
- **Search**: Case-insensitive `Contains` on `OrderNumber` and `CustomerName`

## Namespace Conventions
- Models/Data: `OrderManagement.Models`, `OrderManagement.Data`
- Controllers: `HaMinhVuong_KT.Controllers` (inconsistent - prefer `OrderManagement.Controllers`)

## Common Pitfalls
- MVC setup incomplete in `Program.cs` - add `AddControllersWithViews()`, `UseStaticFiles()`, routing middleware
- HomeController missing CRUD actions for views in `Views/Home/`
- Ensure SQL Server is running locally before startup

## Example: Creating Order via API
```csharp
[HttpPost]
public async Task<IActionResult> Create(Order order)
{
    if (!ModelState.IsValid) return BadRequest();
    _context.Orders.Add(order);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
}
```</content>
<parameter name="filePath">d:\Backend\HaMinhVuong-KT\.github\copilot-instructions.md