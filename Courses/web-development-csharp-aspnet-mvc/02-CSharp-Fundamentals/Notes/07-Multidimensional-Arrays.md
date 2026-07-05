# Multidimensional Arrays in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Multidimensional Arrays  
> **Difficulty:** 🟡 Intermediate  
> **Prerequisites:** Arrays, Loops

---

# Overview

A **Multidimensional Array** is an array that contains more than one dimension.

The most commonly used multidimensional array is a **2-Dimensional Array**, also called a **Matrix**.

Instead of storing data in a single row, data is stored in **rows and columns**.

---

# Definition

A multidimensional array stores data in a table-like structure.

Example

```csharp
int[,] marks =
{
    {80,85,90},
    {75,88,95},
    {60,70,80}
};
```

---

# Why do we need Multidimensional Arrays?

Suppose a school stores marks of students.

Without multidimensional array:

```text
Student1 = 80 85 90
Student2 = 75 88 95
Student3 = 60 70 80
```

With multidimensional array

```text
80 85 90
75 88 95
60 70 80
```

It becomes much easier to manage data.

---

# Real World Examples

- Student Marks
- Chess Board
- Seating Arrangement
- Calendar
- Image Pixels
- Excel Sheet
- Matrix Calculations

---

# Syntax

## Declaration

```csharp
int[,] numbers;
```

---

## Declaration with Size

```csharp
int[,] numbers = new int[3,4];
```

---

## Initialization

```csharp
int[,] numbers =
{
    {1,2,3},
    {4,5,6}
};
```

---

# Structure

```text
        Column

        0    1    2

      +----+----+----+

0     |10 |20 |30 |

      +----+----+----+

1     |40 |50 |60 |

      +----+----+----+

2     |70 |80 |90 |

      +----+----+----+

         Row
```

---

# Access Elements

```csharp
Console.WriteLine(numbers[0,0]);

Console.WriteLine(numbers[2,1]);
```

Output

```
10

80
```

---

# Update Elements

```csharp
numbers[1,2]=100;
```

---

# Get Number of Rows

```csharp
numbers.GetLength(0)
```

---

# Get Number of Columns

```csharp
numbers.GetLength(1)
```

---

# Traverse Matrix

```csharp
for(int row=0;row<numbers.GetLength(0);row++)
{
    for(int col=0;col<numbers.GetLength(1);col++)
    {
        Console.Write(numbers[row,col]+" ");
    }

    Console.WriteLine();
}
```

---

# Internal Working

1. Array declared.
2. CLR allocates contiguous memory.
3. Values stored row by row.
4. Access using row and column index.

---

# Memory Representation

```text
Index

[0,0] 10

[0,1] 20

[0,2] 30

[1,0] 40

[1,1] 50

[1,2] 60
```

---

# Advantages

- Organizes tabular data
- Easy matrix calculations
- Fast random access
- Better readability

---

# Disadvantages

- Fixed size
- Same datatype only
- Difficult resizing

---

# Best Practices

✔ Use meaningful names

```csharp
studentMarks
```

✔ Use nested loops.

✔ Use GetLength() instead of hardcoding.

---

# Common Mistakes

❌

```csharp
numbers[3,0]
```

Index out of range.

---

❌

Wrong loop limits.

Always use

```csharp
GetLength()
```

---

# Interview Questions

### What is a multidimensional array?

Array having more than one dimension.

---

### Difference between Array and Multidimensional Array?

Array

```
One Dimension
```

Multidimensional Array

```
Rows + Columns
```

---

### How do you get rows?

```csharp
GetLength(0)
```

---

### How do you get columns?

```csharp
GetLength(1)
```

---

# Summary

Multidimensional arrays store data in rows and columns. They are commonly used for matrices, tables, grids, and similar structures where two-dimensional data representation is required.

---

# References

- Microsoft Learn
- C# Programming Guide