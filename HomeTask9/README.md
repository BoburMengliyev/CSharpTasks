# 🧩 Softclub Employee Management Console App

Bu loyiha **konsol ilovasi** bo‘lib, xodimlar (`Employee`) va bo‘limlar (`Department`)ni saqlash, qo‘shish va hisoblash imkonini beradi. Loyiha **uch qatlamli arxitekturaga** asoslangan: `MainApp`, `Infrastructure`, va `Domain`.

## 📦 Loyiha Tuzilmasi

> `MainApp` **arxitektura**

![images](./Pictures/Screenshot_1.png)

> `Domain` **arxitektura**

> `Department.cs` > ![images](./Pictures/Screenshot_2.png)

> `Employee.cs` > ![images](./Pictures/Screenshot_3.png)

> `Infrastructure` **arxitektura**

> `DepartmentService.cs` > ![images](./Pictures/Screenshot_4.png)

> `EmployeeService.cs` > ![images](./Pictures/Screenshot_5.png)

> `Program.cs` => **natija**
> ![images](./Pictures/Screenshot_6.png)

---

## 🧠 Funksiyalar

### 👤 EmployeeService

- `List<Employee> GetEmployees()`
- `void AddEmployee(Employee employee)`
- `int CountEmployees()`

### 🏢 DepartmentService

- `List<Department> GetDepartments()`
- `void AddDepartment(Department department)`
- `int CountDepartments()`

---

## 🛠 Ishga tushurish

1. Visual Studio yoki Rider orqali `Softclub.sln` faylini oching.
2. **MainApp** loyihasini asosiy loyihaga (`Set as Startup Project`) belgilang.
3. Ilovani `Run` tugmasi bilan ishga tushiring.

---

## 🔧 Texnologiyalar

- C# (.NET 9.0)
- Console App
- 3-layer architecture (Domain, Infrastructure, UI)

---

## 🧑‍💻 Muallif

- **Mengliyev Bobur**
- Email: boburbekmengliyev2025@gmail.com
- Telegram: [@theboburmengliyev](https://t.me/theboburmengliyev)

---

## 📄 Litsenziya

Ushbu loyiha ta’limiy maqsadlarda yaratilgan va erkin foydalanish uchun mo‘ljallangan.
