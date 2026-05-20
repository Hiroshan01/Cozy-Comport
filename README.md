# 🛏️ Cozy Comfort - Blanket Ordering System (SOC Architecture)

## අවලංගු කරගේ කිසිම වචනයක් නැත (කිසිදු වචනයක් නැත)

**Cozy Comfort** යනු Service-Oriented Computing (SOC) පිළිබඳ සිද්ධාන්ත ක්‍රියාවලිය සිතා ගණන් ගිරිම සඳහා නිසි හඩ සමඟ නිර්මාණ වූ blanket ordering system එකි.

## 📋 විස්තරයි

Cozy Comfort යනු blanket manufacturing වලට සම්බන්ධ කර ඇති supplier-distributor-seller networks නිසි ක්‍රියාවලිගේ දිගුවෙතින් දිගුවෙතින් සිතා ගණන් ගිරිම දෙමි.

### නිසි වැඩිවලාප්‍රතිෂ්ඨිත ක්‍රියාවලිය:
- **Manufacturer** - නිෂ්පාදකයින්ගේ කර්තව්‍ය
- **Distributor** - බෙදාහරින්නන්ගේ කර්තව්‍ය
- **Seller** - විකෙතුවලාගේ කර්තව්‍ය
- **Order Management** - ඇණවුම් ක්‍රියාවලිය
- **Inventory System** - ඉන්වෙන්ටරි පරිපාලනය

## 🏗️ Architecture

```
┌─────────────────────────────────────────────────┐
│           API Gateway (ASP.NET Core)            │
└────────────┬────────────┬────────────┬──────────┘
             │            │            │
      ┌──────▼────┐  ┌────▼─────┐  ┌─▼──────────┐
      │ Mfg Svc   │  │ Dist Svc  │  │ Seller Svc │
      └──────┬────┘  └────┬──────┘  └─┬──────────┘
             │            │          │
      ┌──────▼─────────────▼──────────▼──────┐
      │     Business Logic Layer              │
      │  (CozyComfort.Services)               │
      └──────┬─────────────────────────────┬──┘
             │                             │
      ┌──────▼──────────┐          ┌──────▼────────────┐
      │ Entity Models   │          │ Database Context  │
      │ (DTOs/Entities) │          │   (EF Core)       │
      └──────┬──────────┘          └──────┬────────────┘
             │                            │
             └────────────┬───────────────┘
                          │
                    ┌─────▼──────┐
                    │  SQL Server │
                    └────────────┘
```

## 🛠️ Technologies

- **Framework:** .NET 8 / ASP.NET Core Web API
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **Documentation:** Swagger/OpenAPI
- **Language:** C#

## 📁 Project Structure

```
CozyComfort/
├── CozyComfort.API/              # Web API Project
│   ├── Controllers/
│   ├── Program.cs
│   ├── appsettings.json
│   └── Startup Configuration
│
├── CozyComfort.Services/          # Business Logic
│   ├── Interfaces/
│   └── Implementations/
│
├── CozyComfort.Models/            # Data Models
│   ├── Entities/
│   ├── DTOs/
│   └── Enums/
│
├── CozyComfort.Data/              # Data Access
│   ├── CozyComfortDbContext.cs
│   ├── Configurations/
│   └── Migrations/
│
└── CozyComfort.sln
```

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server LocalDB
- Visual Studio Code or Visual Studio

### Installation

```bash
# Clone the repository
git clone https://github.com/Hiroshan01/Cozy-Comport.git
cd Cozy-Comport

# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Update database
dotnet ef database update --project CozyComfort.Data

# Run the API
cd CozyComfort.API
dotnet run
```

### Access Swagger UI
```
https://localhost:5001/swagger/index.html
```

## 📚 API Endpoints

### Manufacturer Service
- `GET /api/manufacturer` - සියලු නිෂ්පාදකයින් ලබා ගන්න
- `GET /api/manufacturer/{id}` - විශේෂ නිෂ්පාදකයා ලබා ගන්න
- `POST /api/manufacturer` - නව නිෂ්පාදකයා සෑදුණු
- `PUT /api/manufacturer/{id}` - නිෂ්පාදකයා යාවත්කාලීන කරන්න
- `DELETE /api/manufacturer/{id}` - නිෂ්පාදකයා ඉවත් කරන්න

### Order Service
- `GET /api/order/{id}` - ඇණවුම ලබා ගන්න
- `GET /api/order/seller/{sellerId}` - විකෙතුගේ ඇණවුම් ලබා ගන්න
- `POST /api/order` - නව ඇණවුම සෑදුණු
- `PUT /api/order/{id}/status` - තත්ත්වය යාවත්කාලීන කරන්න
- `DELETE /api/order/{id}` - ඇණවුම අවලංඝනය කරන්න

### Inventory Service
- `GET /api/inventory/check/{blanketModelId}` - ඉන්වෙන්ටරි පරීක්ෂා කරන්න
- `GET /api/inventory/low-stock` - අඩු තොගයි අයිතම
- `PUT /api/inventory/update` - ඉන්වෙන්ටරි යාවත්කාලීන කරන්න

## 📝 Database Schema

### Core Tables
- **Manufacturers** - නිෂ්පාදකයින්
- **Distributors** - බෙදාහරින්නන්
- **Sellers** - විකෙතුවලා
- **BlanketModels** - Blanket ප්‍රකාර
- **Orders** - ඇණවුම්
- **OrderItems** - ඇණවුම් අයිතම
- **InventoryItems** - ඉන්වෙන්ටරි

## 🧪 Testing

### Using Swagger UI
```
Navigate to: https://localhost:5001/swagger/index.html
```

### Using Postman
Import the collection from `/docs/Postman-Collection.json`

```bash
# Sample curl request
curl -X GET "https://localhost:5001/api/manufacturer" \
  -H "accept: application/json"
```

## 📄 Configuration

### appsettings.json
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CozyComfort;Trusted_Connection=true;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  }
}
```

## 🔒 Features

✅ Multi-tier service architecture
✅ Entity Framework Core ORM
✅ Async/Await programming
✅ Dependency Injection
✅ RESTful API design
✅ Swagger documentation
✅ Error handling & validation
✅ CORS enabled
✅ SQL Server integration

## 📊 SOA Benefits (මෙම ව්‍යවස්ථාව ක්‍රියාකරන ගෙවතින්)

| Feature | Description |
|---------|-------------|
| **Scalability** | සේවා පිරිවෙත ස්වාධීනව පරිමාණය කරන්න |
| **Maintainability** | සේවා අනුව කේතය සංවිධානය කිරීම |
| **Reusability** | සේවා අනුපිටිපල අනුකරණය |
| **Flexibility** | නව සේවා එකතු කිරීමේ සරලතා |
| **Independence** | සේවා ස්වාධීනව සඳහා කළ හැක |

## 🐛 Troubleshooting

### Database Connection Issues
```bash
# Check SQL Server LocalDB
sqllocaldb info
sqllocaldb start MSSQLLocalDB

# Update connection string in appsettings.json
```

### Port Already in Use
```bash
# Change port in appsettings.json
"Kestrel": {
  "Endpoints": {
    "Http": {
      "Url": "http://localhost:5002"
    }
  }
}
```

## 📞 Support

For issues or questions:
- GitHub Issues: https://github.com/Hiroshan01/Cozy-Comport/issues
- Email: your-email@example.com

## 📄 License

This project is licensed under the MIT License.

## ✍️ Author

**Hiroshan01** - Initial development and architecture

---

**Last Updated:** May 20, 2026
**Version:** 1.0.0
**Status:** Active Development 🚀
