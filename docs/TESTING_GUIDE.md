# 🌐 Cozy Comfort API - Testing Guide

## Postman Collection (API Testing)

### Setup Postman Collection

```json
{
  "info": {
    "name": "Cozy Comfort API",
    "description": "Complete API collection for Cozy Comfort Blanket Ordering System",
    "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
  },
  "item": [
    {
      "name": "Manufacturer Endpoints",
      "item": [
        {
          "name": "Create Manufacturer",
          "request": {
            "method": "POST",
            "header": [
              {
                "key": "Content-Type",
                "value": "application/json"
              }
            ],
            "body": {
              "mode": "raw",
              "raw": "{\n  \"name\": \"Cozy Comfort Ltd\",\n  \"email\": \"info@cozycomfort.com\",\n  \"phone\": \"+94112345678\",\n  \"address\": \"123 Colombo, Sri Lanka\",\n  \"productionCapacity\": 1000\n}"
            },
            "url": {
              "raw": "https://localhost:7001/api/manufacturer",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "manufacturer"]
            }
          }
        },
        {
          "name": "Get All Manufacturers",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/manufacturer",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "manufacturer"]
            }
          }
        },
        {
          "name": "Get Manufacturer by ID",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/manufacturer/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "manufacturer", "1"]
            }
          }
        },
        {
          "name": "Update Manufacturer",
          "request": {
            "method": "PUT",
            "header": [
              {
                "key": "Content-Type",
                "value": "application/json"
              }
            ],
            "body": {
              "mode": "raw",
              "raw": "{\n  \"name\": \"Cozy Comfort Ltd Updated\",\n  \"email\": \"updated@cozycomfort.com\",\n  \"phone\": \"+94112345679\",\n  \"address\": \"456 Colombo, Sri Lanka\",\n  \"productionCapacity\": 2000\n}"
            },
            "url": {
              "raw": "https://localhost:7001/api/manufacturer/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "manufacturer", "1"]
            }
          }
        },
        {
          "name": "Delete Manufacturer",
          "request": {
            "method": "DELETE",
            "url": {
              "raw": "https://localhost:7001/api/manufacturer/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "manufacturer", "1"]
            }
          }
        }
      ]
    },
    {
      "name": "Order Endpoints",
      "item": [
        {
          "name": "Create Order",
          "request": {
            "method": "POST",
            "header": [
              {
                "key": "Content-Type",
                "value": "application/json"
              }
            ],
            "body": {
              "mode": "raw",
              "raw": "{\n  \"sellerId\": 1,\n  \"orderItems\": [\n    {\n      \"blanketModelId\": 1,\n      \"quantity\": 50,\n      \"unitPrice\": 25.50\n    }\n  ]\n}"
            },
            "url": {
              "raw": "https://localhost:7001/api/order",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "order"]
            }
          }
        },
        {
          "name": "Get Order by ID",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/order/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "order", "1"]
            }
          }
        },
        {
          "name": "Get Orders by Seller",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/order/seller/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "order", "seller", "1"]
            }
          }
        },
        {
          "name": "Update Order Status",
          "request": {
            "method": "PUT",
            "header": [
              {
                "key": "Content-Type",
                "value": "application/json"
              }
            ],
            "body": {
              "mode": "raw",
              "raw": "\"Approved\""
            },
            "url": {
              "raw": "https://localhost:7001/api/order/1/status",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "order", "1", "status"]
            }
          }
        },
        {
          "name": "Cancel Order",
          "request": {
            "method": "DELETE",
            "url": {
              "raw": "https://localhost:7001/api/order/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "order", "1"]
            }
          }
        }
      ]
    },
    {
      "name": "Inventory Endpoints",
      "item": [
        {
          "name": "Check Inventory",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/inventory/check/1",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "inventory", "check", "1"]
            }
          }
        },
        {
          "name": "Get Low Stock Items",
          "request": {
            "method": "GET",
            "url": {
              "raw": "https://localhost:7001/api/inventory/low-stock",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "inventory", "low-stock"]
            }
          }
        },
        {
          "name": "Update Inventory",
          "request": {
            "method": "PUT",
            "url": {
              "raw": "https://localhost:7001/api/inventory/update?blanketModelId=1&quantity=100&operation=add",
              "protocol": "https",
              "host": ["localhost"],
              "port": ["7001"],
              "path": ["api", "inventory", "update"],
              "query": [
                {
                  "key": "blanketModelId",
                  "value": "1"
                },
                {
                  "key": "quantity",
                  "value": "100"
                },
                {
                  "key": "operation",
                  "value": "add"
                }
              ]
            }
          }
        }
      ]
    }
  ]
}
```

---

## 🧪 Manual Testing (Swagger UI)

### 1️⃣ Manufacturer Testing

**Create Manufacturer:**
```
POST /api/manufacturer

Body:
{
  "name": "Cozy Comfort Ltd",
  "email": "info@cozycomfort.com",
  "phone": "+94112345678",
  "address": "123 Main Street, Colombo",
  "productionCapacity": 1000
}

Expected: 201 Created
```

**Get All:**
```
GET /api/manufacturer

Expected: 200 OK with list of manufacturers
```

**Get by ID:**
```
GET /api/manufacturer/1

Expected: 200 OK with manufacturer details
```

**Update:**
```
PUT /api/manufacturer/1

Body:
{
  "name": "Updated Name",
  "email": "updated@email.com",
  "phone": "+94112345679",
  "address": "456 New Street",
  "productionCapacity": 2000
}

Expected: 204 No Content
```

**Delete:**
```
DELETE /api/manufacturer/1

Expected: 204 No Content
```

---

### 2️⃣ Order Testing

**Create Order:**
```
POST /api/order

Body:
{
  "sellerId": 1,
  "orderItems": [
    {
      "blanketModelId": 1,
      "quantity": 50,
      "unitPrice": 25.50
    }
  ]
}

Expected: 201 Created
Response:
{
  "id": 1,
  "sellerId": 1,
  "orderDate": "2026-05-20T09:30:00Z",
  "status": "Pending",
  "totalAmount": 1275.00,
  "orderItems": [...]
}
```

**Get Order:**
```
GET /api/order/1

Expected: 200 OK with order details
```

**Get Orders by Seller:**
```
GET /api/order/seller/1

Expected: 200 OK with list of orders
```

**Update Status:**
```
PUT /api/order/1/status

Body: "Approved"

Expected: 204 No Content
```

**Cancel Order:**
```
DELETE /api/order/1

Expected: 204 No Content
```

---

### 3️⃣ Inventory Testing

**Check Inventory:**
```
GET /api/inventory/check/1

Expected: 200 OK
Response:
{
  "id": 1,
  "blanketModelId": 1,
  "quantityInStock": 500,
  "reorderLevel": 100
}
```

**Get Low Stock Items:**
```
GET /api/inventory/low-stock

Expected: 200 OK with items below reorder level
```

**Update Inventory:**
```
PUT /api/inventory/update?blanketModelId=1&quantity=100&operation=add

Expected: 204 No Content
```

---

## 🧬 Load Testing (Performance Testing)

### Using Apache JMeter

```
Test Plan:
1. Thread Group: 100 users
2. Ramp-up period: 10 seconds
3. Loop count: 10

Endpoints to test:
- GET /api/manufacturer (Read heavy)
- POST /api/order (Write heavy)
- GET /api/inventory/low-stock (Filter queries)
```

---

## 🛡️ Security Testing

### CORS Testing
```bash
curl -X OPTIONS "https://localhost:7001/api/manufacturer" \
  -H "Origin: http://localhost:3000" \
  -H "Access-Control-Request-Method: POST"
```

### Invalid Input Testing
```bash
# Test with empty body
curl -X POST "https://localhost:7001/api/manufacturer" \
  -H "Content-Type: application/json" \
  -d '{}'

# Test with invalid data type
curl -X POST "https://localhost:7001/api/manufacturer" \
  -H "Content-Type: application/json" \
  -d '{"name": 123, "productionCapacity": "invalid"}'
```

---

## 📊 Test Results Template

```
API Testing Report - Cozy Comfort System
Date: 2026-05-20
Tester: Hiroshan01

| Endpoint | Method | Status | Response Time | Notes |
|----------|--------|--------|---------------|----- |
| /api/manufacturer | GET | 200 | 45ms | OK |
| /api/manufacturer | POST | 201 | 120ms | OK |
| /api/manufacturer/{id} | GET | 200 | 30ms | OK |
| /api/manufacturer/{id} | PUT | 204 | 100ms | OK |
| /api/manufacturer/{id} | DELETE | 204 | 80ms | OK |
| /api/order | POST | 201 | 150ms | OK |
| /api/order/{id} | GET | 200 | 40ms | OK |
| /api/inventory/check/{id} | GET | 200 | 35ms | OK |

Summary:
✅ Total Tests: 8
✅ Passed: 8
❌ Failed: 0
✅ Success Rate: 100%
⏱️ Average Response Time: 75ms

Performance:
✅ All endpoints respond within acceptable time
✅ Database queries are optimized
✅ CORS properly configured
✅ Error handling working correctly
```

---

**Testing Guidelines:**
- Always test in development first
- Use both Swagger UI and Postman
- Test with various data inputs
- Monitor API response times
- Check error handling
- Verify CORS headers

**Version:** 1.0.0
**Last Updated:** May 20, 2026
