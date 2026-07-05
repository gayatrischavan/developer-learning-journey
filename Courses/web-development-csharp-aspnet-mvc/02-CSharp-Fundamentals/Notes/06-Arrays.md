# Arrays in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Arrays  
> **Difficulty:** 🟢 Beginner  
> **Prerequisites:** Variables, Data Types, Loops

---

# Overview

An array is a collection of elements of the **same data type** stored in contiguous memory locations. Instead of creating multiple variables for related data, an array allows you to manage them using a single variable and an index.

---

# Definition

An **array** is a fixed-size collection of elements of the same type.

Example:

```csharp
int[] marks = { 80, 75, 90, 85 };
```

---

# Why do we need Arrays?

Without arrays:

```csharp
int mark1 = 80;
int mark2 = 75;
int mark3 = 90;
int mark4 = 85;
```

With arrays:

```csharp
int[] marks = {80,75,90,85};
```

Advantages:

- Less code
- Easy iteration
- Better memory management
- Simplifies data processing

---

# Real World Examples

- Student Marks
- Employee Salaries
- Product Prices
- Monthly Sales
- Daily Temperatures

---

# Syntax

## Declaration

```csharp
int[] numbers;
```

---

## Initialization

```csharp
int[] numbers = {10,20,30,40};
```

---

## Declaration + Size

```csharp
int[] numbers = new int[5];
```

---

## Declaration + Values

```csharp
int[] numbers = new int[] {10,20,30};
```

---

# Array Structure

```text
Index

0     1     2     3

↓

+-----+-----+-----+-----+

| 10 | 20 | 30 | 40 |

+-----+-----+-----+-----+
```

---

# Accessing Elements

```csharp
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[2]);
```

Output

```
10

30
```

---

# Updating Elements

```csharp
numbers[1] = 50;
```

Array becomes

```
10 50 30 40
```

---

# Array Length

```csharp
Console.WriteLine(numbers.Length);
```

Output

```
4
```

---

# Loop Through Array

## for Loop

```csharp
for(int i=0;i<numbers.Length;i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

## foreach Loop

```csharp
foreach(int item in numbers)
{
    Console.WriteLine(item);
}
```

---

# Common Array Methods

| Method | Purpose |
|---------|---------|
| Sort() | Sort array |
| Reverse() | Reverse array |
| Clear() | Remove values |
| Copy() | Copy array |
| IndexOf() | Search |
| BinarySearch() | Binary search |

---

# Internal Working

1. Declare array.
2. CLR allocates contiguous memory.
3. Elements stored sequentially.
4. Access using index.
5. Index starts at 0.

---

# Memory Representation

```text
Stack

numbers

↓

Heap

+----+----+----+----+

10 20 30 40

+----+----+----+----+
```

---

# Advantages

✔ Fast access

✔ Easy iteration

✔ Less code

✔ Better organization

✔ Efficient memory usage

---

# Disadvantages

❌ Fixed size

❌ Same data type only

❌ Insertion in middle is expensive

---

# Best Practices

✔ Use meaningful names

```csharp
studentMarks
```

✔ Use foreach for reading

✔ Check Length before accessing

✔ Avoid hard-coded indexes

---

# Common Mistakes

❌

```csharp
numbers[5]
```

when size is 5.

IndexOutOfRangeException.

---

❌

```csharp
numbers[-1]
```

Invalid index.

---

# Interview Questions

### What is an array?

A collection of same datatype elements stored contiguously.

---

### Why does indexing start at 0?

Because memory offset starts from zero.

---

### Difference between Array and List?

Array → Fixed size

List → Dynamic size

---

### What property returns array size?

```
Length
```

---

### Can arrays store different data types?

No.

---

# Quick Revision

```
Array

↓

Collection

↓

Same Data Type

↓

Fixed Size

↓

Index Starts at 0

↓

Length Property
```

---

# Summary

Arrays allow storing multiple values of the same type using one variable. They provide fast indexed access, are easy to iterate using loops, and are widely used in almost every C# application.

---

# References

- Microsoft Learn – Arrays
- C# Programming Guide