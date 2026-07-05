# Variables in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Variables  
> **Difficulty:** 🟢 Beginner  
> **Prerequisites:** Console Applications, Console Class

---

# Overview

Variables are one of the fundamental building blocks of every programming language. They allow us to store data in memory, retrieve it later, modify it, and use it throughout a program.

Almost every C# application—whether a Console App, Windows Forms application, ASP.NET MVC application, or Web API—uses variables.

---

# Definition

A **variable** is a named memory location used to store data that can change during program execution.

In simple words:

> A variable is like a **container** that stores information.

Example:

```csharp
int age = 23;
```

Here:

- `int` → Data Type
- `age` → Variable Name
- `23` → Value

---

# Why do we need Variables?

Imagine writing a Student Management System.

Without variables:

```text
Student Name = Gayatri

Student Age = 23

Student City = Pune
```

There would be no way to store this information in memory.

Variables help us:

- Store data
- Update data
- Perform calculations
- Display information
- Pass values to methods

Without variables, programming would not be practical.

---

# Real-Life Analogy

Think of a variable as a labeled storage box.

```
+--------------------+
| Name               |
|--------------------|
| Gayatri            |
+--------------------+
```

The label is the **variable name**, and the content inside the box is the **value**.

---

# How Variables Work

When you create a variable:

```csharp
int age = 23;
```

C# performs these steps:

1. Reserves memory.
2. Stores the value.
3. Associates the memory with the variable name.
4. Allows the program to access the value using the variable name.

---

# Memory Representation

```text
RAM

+--------------------+
| Variable | Value   |
|----------|---------|
| age      | 23      |
| salary   | 50000   |
| name     | Gayatri |
+--------------------+
```

---

# Syntax

```csharp
dataType variableName = value;
```

Example:

```csharp
int age = 23;
string name = "Gayatri";
double salary = 50000.75;
bool isActive = true;
```

---

# Variable Declaration

Declaring a variable means creating it.

```csharp
int age;
```

No value has been assigned yet.

---

# Variable Initialization

Assigning a value for the first time is called initialization.

```csharp
age = 23;
```

---

# Declaration and Initialization Together

```csharp
int age = 23;
```

This is the most common approach.

---

# Multiple Variable Declaration

```csharp
int x = 10;
int y = 20;
int z = 30;
```

Or

```csharp
int x = 10, y = 20, z = 30;
```

---

# Changing Variable Values

Variables can change during program execution.

```csharp
int age = 23;

age = 24;
```

Final value:

```
24
```

---

# Variable Naming Rules

A variable name:

- Must begin with a letter or `_`
- Cannot begin with a number
- Cannot contain spaces
- Cannot use C# keywords
- Is case-sensitive

✔ Valid

```csharp
studentName
_age
salary2025
```

❌ Invalid

```csharp
1name
student name
class
```

---

# Flow Diagram

```text
Declare Variable

↓

Allocate Memory

↓

Assign Value

↓

Use Variable

↓

Modify Value (Optional)

↓

Program Ends
```

---

# Code Example

```csharp
using System;

class Program
{
    static void Main()
    {
        string name = "Gayatri";
        int age = 23;
        double salary = 50000.50;
        bool isWorking = true;

        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Salary : " + salary);
        Console.WriteLine("Working : " + isWorking);
    }
}
```

---

# Output

```
Name : Gayatri
Age : 23
Salary : 50000.5
Working : True
```

---

# Real World Example

### Hospital Management System

```csharp
string patientName = "Rahul";
int patientAge = 30;
string bloodGroup = "B+";
```

---

### Banking Application

```csharp
string accountNumber = "123456";
double balance = 25000.75;
```

---

### E-commerce Website

```csharp
string productName = "Laptop";
double price = 65000;
int quantity = 2;
```

---

# Internal Working

```text
Program Starts

↓

Variable Declared

↓

Memory Allocated

↓

Value Stored

↓

Program Uses Value

↓

Memory Released after Program Ends
```

---

# Advantages

- Stores data efficiently
- Makes programs dynamic
- Improves readability
- Enables calculations
- Reusable throughout the program

---

# Disadvantages

- Incorrect naming reduces readability
- Uninitialized variables may cause errors
- Using wrong data types can lead to bugs

---

# Best Practices

✔ Use meaningful names

```csharp
studentName
```

instead of

```csharp
s
```

✔ Initialize variables whenever possible.

✔ Choose the correct data type.

✔ Follow camelCase naming convention.

---

# Common Mistakes

❌ Using reserved keywords

```csharp
int class = 10;
```

---

❌ Using spaces

```csharp
int student age;
```

---

❌ Beginning with a number

```csharp
int 123salary;
```

---

❌ Choosing the wrong data type

```csharp
int price = 99.99;
```

Use:

```csharp
double price = 99.99;
```

---

# Interview Questions

### 1. What is a variable?

A variable is a named memory location used to store data.

---

### 2. What is variable declaration?

Creating a variable without assigning a value.

---

### 3. What is variable initialization?

Assigning the first value to a variable.

---

### 4. Can a variable value change?

Yes. Variables can be updated during program execution.

---

### 5. Where are variables stored?

Variables are stored in memory (RAM) while the program is running.

---

### 6. What are the rules for naming variables?

- Start with a letter or `_`
- No spaces
- No keywords
- Case-sensitive

---

# Quick Revision

### Definition

A variable is a named memory location that stores data.

### Syntax

```csharp
dataType variableName = value;
```

### Example

```csharp
int age = 23;
```

### Interview One-Liner

> Variables store data that can change during program execution.

---

# Practice Exercises

## Exercise 1

Create variables to store:

- Your Name
- Your Age
- Your City

Display them on the console.

---

## Exercise 2

Create variables for:

- Product Name
- Product Price
- Product Quantity

Calculate the total price.

---

## Exercise 3

Create variables for:

- Student Name
- Marks in 5 Subjects

Calculate the average marks.

---

# Summary

Variables are the foundation of programming. They allow us to store, update, and retrieve data efficiently. Choosing meaningful names and the correct data types makes code easier to understand and maintain.

---

# References

- Microsoft Learn – Variables in C#
- C# Programming Guide
- ECMA C# Language Specification
