# CI/CD Project 

[![CI Pipeline](https://github.com/Omeedkhalidi/cicd-project/actions/workflows/ci.yml/badge.svg)](https://github.com/Omeedkhalidi/cicd-project/actions/workflows/ci.yml)

##  Beskrivning
Detta projekt är ett .NET API byggt med ASP.NET Core.

API:t stödjer CRUD (Create, Read, Update, Delete) för Tasks.

---

## Funktioner

- GET /tasks → hämta alla tasks  
- GET /tasks/{id} → hämta en task  
- POST /tasks → skapa en task  
- PUT /tasks/{id} → uppdatera en task  
- DELETE /tasks/{id} → ta bort en task  

---

##  Tester

Kör tester:

```bash
dotnet test
```

---

## CI

Projektet använder GitHub Actions för att:
- bygga projektet
- köra tester automatiskt

---

## 🌐 Swagger

http://localhost:5027/swagger

---

## 👨‍💻 Författare
Omeed Khalidi
