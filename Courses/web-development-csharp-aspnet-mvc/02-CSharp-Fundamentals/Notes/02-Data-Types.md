# Data Types in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Data Types  
> **Difficulty:** 🟢 Beginner  
> **Prerequisites:** Variables

---

# Overview

A **Data Type** specifies the type of data a variable can store. It tells the C# compiler how much memory should be allocated and what operations can be performed on the stored value.

Every variable in C# must have a data type.

---

# Definition

A **Data Type** is a classification that specifies:

- What type of value a variable can store.
- How much memory is required.
- What operations are allowed on that value.

Example:

```csharp
int age = 23;
```

Here:

- `int` → Data Type
- `age` → Variable
- `23` → Value

---

# Why do we need Data Types?

Data types help the compiler:

- Allocate the correct amount of memory.
- Prevent invalid data assignments.
- Improve performance.
- Detect errors during compilation.
- Ensure type safety.

Without data types, the compiler would not know how to store or process values.

---

# Classification of Data Types

C# data types are broadly divided into:

```
Data Types
│
├── Value Types
│   ├── Integer
│   ├── Floating Point
│   ├── Character
│   ├── Boolean
│   └── Struct
│
└── Reference Types
    ├── String
    ├── Array
    ├── Class
    ├── Interface
    └── Object
```

---

# Value Types

Value types store the actual value directly in memory.

Examples:

- int
- double
- float
- decimal
- char
- bool

Example:

```csharp
int age = 23;
```

---

# Reference Types

Reference types store the address (reference) of an object in memory.

Examples:

- string
- object
- array
- class

Example:

```csharp
string name = "Gayatri";
```

---

# Common Data Types

| Data Type | Size     | Example   |
| --------- | -------- | --------- |
| byte      | 1 byte   | 255       |
| short     | 2 bytes  | 32000     |
| int       | 4 bytes  | 100       |
| long      | 8 bytes  | 999999999 |
| float     | 4 bytes  | 10.5f     |
| double    | 8 bytes  | 10.56789  |
| decimal   | 16 bytes | 100.99m   |
| char      | 2 bytes  | 'A'       |
| bool      | 1 byte   | true      |
| string    | Variable | "Hello"   |

---

# Integer Data Types

Used for storing whole numbers.

```csharp
byte age = 25;
short marks = 500;
int salary = 45000;
long population = 1450000000;
```

---

# Floating Point Data Types

Used for storing decimal numbers.

```csharp
float pi = 3.14f;

double percentage = 98.75;

decimal amount = 1500.99m;
```

---

# Character Data Type

Stores a single Unicode character.

```csharp
char grade = 'A';
```

---

# Boolean Data Type

Stores only two values.

```csharp
bool isLoggedIn = true;

bool isAdmin = false;
```

---

# String Data Type

Stores a sequence of characters.

```csharp
string name = "Gayatri";
```

---

# Object Data Type

Can store any type of value.

```csharp
object value = 100;

value = "Hello";

value = true;
```

---

# Memory Representation

```text
RAM

+-------------------------+
| age        | 23         |
| salary     | 45000.50   |
| grade      | A          |
| isActive   | True       |
| name       | Gayatri    |
+-------------------------+
```

---

# Syntax

```csharp
dataType variableName = value;
```

Example

```csharp
int age = 23;

string name = "Gayatri";

bool isWorking = true;
```

---

# Flow Diagram

```text
Choose Data Type

↓

Declare Variable

↓

Allocate Memory

↓

Store Value

↓

Use Variable
```

---

# Code Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int age = 23;
        double salary = 50000.50;
        char grade = 'A';
        bool isEmployee = true;
        string name = "Gayatri";

        Console.WriteLine($"Name      : {name}");
        Console.WriteLine($"Age       : {age}");
        Console.WriteLine($"Salary    : {salary}");
        Console.WriteLine($"Grade     : {grade}");
        Console.WriteLine($"Employee  : {isEmployee}");
    }
}
```

---

# Output

```
Name      : Gayatri
Age       : 23
Salary    : 50000.5
Grade     : A
Employee  : True
```

---

# Real World Example

### Banking System

```csharp
string accountHolder = "Rahul";

decimal balance = 25000.50m;

bool isActive = true;
```

---

### Hospital Management System

```csharp
string patientName = "Amit";

int age = 45;

char bloodGroup = 'B';

bool admitted = true;
```

---

# Advantages

- Type safety
- Better memory management
- Faster execution
- Compile-time error checking
- Improved readability

---

# Disadvantages

- Choosing the wrong data type may waste memory.
- Incorrect conversions can cause data loss.

---

# Best Practices

✔ Use `int` for whole numbers.

✔ Use `double` for scientific calculations.

✔ Use `decimal` for financial calculations.

✔ Use meaningful variable names.

✔ Use `bool` for true/false conditions.

---

# Common Mistakes

❌ Using `int` for decimal values.

```csharp
int price = 99.99;
```

Correct:

```csharp
double price = 99.99;
```

---

❌ Forgetting suffixes.

```csharp
float pi = 3.14;
```

Correct:

```csharp
float pi = 3.14f;
```

---

❌ Using `double` for money.

Correct:

```csharp
decimal amount = 1500.75m;
```

---

# Interview Questions

### 1. What is a Data Type?

A data type specifies the type of value a variable can store.

---

### 2. What are Value Types?

Types that directly store their values in memory.

Examples:

- int
- bool
- double

---

### 3. What are Reference Types?

Types that store references to objects.

Examples:

- string
- array
- class

---

### 4. Difference between float, double and decimal?

| float                   | double               | decimal                |
| ----------------------- | -------------------- | ---------------------- |
| 4 Bytes                 | 8 Bytes              | 16 Bytes               |
| Less Precision          | More Precision       | Highest Precision      |
| Scientific Calculations | General Calculations | Financial Calculations |

---

### 5. Why is decimal used for money?

Because it provides higher precision and avoids floating-point rounding errors.

---

# Quick Revision

### Definition

A Data Type defines what type of value a variable can store.

### Categories

- Value Types
- Reference Types

### Syntax

```csharp
int age = 23;
```

### Remember

- int → Whole numbers
- double → Decimal numbers
- decimal → Money
- char → Single character
- bool → True/False
- string → Text

---

# Practice Exercises

## Exercise 1

Create variables for:

- Name
- Age
- Salary
- Grade
- IsEmployee

Display all values.

---

## Exercise 2

Create variables for a student.

Calculate total marks and average.

---

## Exercise 3

Create variables for an online shopping application.

Store:

- Product Name
- Price
- Quantity
- Total Amount

---

# Summary

Data Types are one of the most fundamental concepts in C#. They determine how data is stored, how much memory is allocated, and what operations can be performed. Choosing the correct data type improves application performance, memory usage, and code readability.

---

# References

- Microsoft Learn – Built-in Types
- C# Programming Guide
- ECMA C# Language Specification
- .NET Documentation
