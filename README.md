# 🎓 Student Management System (OgrenciUyg)

This project is a **C# Console Application** designed to simulate a basic student information system. It demonstrates the fundamentals of **Object-Oriented Programming (OOP)** by separating the data model (`Ogrenci.cs`) from the main execution logic (`Program.cs`).

## 📂 Project Structure

The solution consists of two main classes working together within the `OgrenciUyg` namespace:

| File Name | Responsibility |
| :--- | :--- |
| **`Ogrenci.cs`** | **The Class/Model.** Defines the student object properties (ID, Name, Grades) and methods (Calculate Average, Show Info). |
| **`Program.cs`** | **The Main Logic.** Handles user interaction, menus, and creates instances of the `Ogrenci` class. |

## 🚀 Features & Concepts Demonstrated

* **OOP Principles:** Uses a separate class to define the "Student" entity.
* **Constructors:** Uses a parameterized constructor to initialize student data immediately upon object creation.
* **Encapsulation:** Fields (like `isim`, `vize1`) are `private`, while methods to access them are `public`.
* **Algorithmic Logic:** Calculates weighted grade averages.
* **Control Flow:** Implements `while` loops for continuous operation and `switch-case` for menu selection.

## 🧮 How It Works

### 1. The Student Class (`Ogrenci.cs`)
This class holds the data. The grade average calculation follows this specific university formula:
* **Midterm 1 (Vize 1):** 20%
* **Midterm 2 (Vize 2):** 20%
* **Final:** 60%

```csharp
// Logic used in Ogrenci.cs
double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
```

### 2. The Main Program (Program.cs)
The program starts by creating a sample student object using the constructor:

```c#
Ogrenci ogrenci1 = new Ogrenci(3, "Fikret", "Sınmaz", 75, 80, 90, "Necmettin Erbakan");
```
Then, it presents a menu to the user to interact with this student object.

## 💻 Usage Example
When you run the application, you will see a menu loop like this:
```plaintext
Yapmak istediğiniz işlemi seçiniz
1 - Öğrenci bilgileri göster
2 - Öğrencinin ortalamasını göster
3 - Öğrencinin okulunu göster
4 - Çıkış

> 1
Öğrencinin Numarası : 3
Öğrencinin ismi : Fikret
Öğrencinin soyismi : Sınmaz
...

> 2
Öğrencinin ortalaması : 85
```

## 🛠️ How to Run

1. Open the project in Visual Studio or VS Code.

2. Ensure both Program.cs and Ogrenci.cs are in the same project folder.

3. Run the application (F5 or dotnet run).

## ⚠️ Requirements

- .NET SDK (Core or Framework)

- A C# IDE (Visual Studio, Rider, etc.)
