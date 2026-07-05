# Common Console Methods in C#

## Overview

The `Console` class provides methods to interact with the user through the command-line interface. It allows us to display output, read input, change console appearance, play sounds, and control the console window.

The `Console` class belongs to the `System` namespace.

```csharp
using System;
```

---

# Definition

The `Console` class is a built-in class in the .NET Framework that provides methods and properties for performing standard input and output operations.

---

# Why do we need the Console Class?

The Console class helps us to:

- Display output to the screen.
- Accept user input.
- Pause the application.
- Change text and background colors.
- Clear the screen.
- Play sounds.
- Set the console window title.
- Control cursor position.

---

# Common Console Methods

| Method                      | Purpose                                         |
| --------------------------- | ----------------------------------------------- |
| Console.Write()             | Prints text without moving to the next line     |
| Console.WriteLine()         | Prints text and moves to the next line          |
| Console.Read()              | Reads one character and returns its ASCII value |
| Console.ReadLine()          | Reads an entire line of text                    |
| Console.ReadKey()           | Reads a key pressed by the user                 |
| Console.Clear()             | Clears the console window                       |
| Console.Beep()              | Plays a beep sound                              |
| Console.ResetColor()        | Restores default console colors                 |
| Console.SetCursorPosition() | Moves the cursor to a specified position        |

---

# Console.Write()

## Purpose

Displays output without moving the cursor to the next line.

### Syntax

```csharp
Console.Write("Text");
```

### Example

```csharp
Console.Write("Hello ");
Console.Write("Gayatri");
```

### Output

```
Hello Gayatri
```

---

# Console.WriteLine()

## Purpose

Displays output and moves the cursor to the next line.

### Syntax

```csharp
Console.WriteLine("Text");
```

### Example

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

### Output

```
Hello
World
```

---

# Console.Read()

## Purpose

Reads a single character from the keyboard and returns its ASCII value.

### Syntax

```csharp
int value = Console.Read();
```

### Example

```csharp
Console.Write("Enter a character: ");

int ascii = Console.Read();

Console.WriteLine();
Console.WriteLine(ascii);
```

### Input

```
A
```

### Output

```
65
```

---

# Console.ReadLine()

## Purpose

Reads an entire line of text.

### Syntax

```csharp
string name = Console.ReadLine();
```

### Example

```csharp
Console.Write("Enter Name: ");

string name = Console.ReadLine();

Console.WriteLine("Welcome " + name);
```

### Output

```
Enter Name: Gayatri

Welcome Gayatri
```

---

# Console.ReadKey()

## Purpose

Reads a single key press and pauses the application until a key is pressed.

### Syntax

```csharp
Console.ReadKey();
```

### Example

```csharp
Console.WriteLine("Press any key...");
Console.ReadKey();
```

---

# Console.Clear()

## Purpose

Clears everything from the console window.

### Example

```csharp
Console.WriteLine("Hello");
Console.Clear();
```

---

# Console.Beep()

## Purpose

Plays the default system beep sound.

### Example

```csharp
Console.Beep();
```

---

# Console.Title

## Purpose

Changes the title of the console window.

### Example

```csharp
Console.Title = "C# Learning Repository";
```

---

# Console.ForegroundColor

## Purpose

Changes the text color.

### Example

```csharp
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Success!");

Console.ResetColor();
```

---

# Console.BackgroundColor

## Purpose

Changes the background color.

### Example

```csharp
Console.BackgroundColor = ConsoleColor.Blue;

Console.Clear();

Console.ResetColor();
```

---

# Console.ResetColor()

## Purpose

Restores the default foreground and background colors.

### Example

```csharp
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Error");

Console.ResetColor();
```

---

# Console.SetCursorPosition()

## Purpose

Moves the cursor to a specified location.

### Syntax

```csharp
Console.SetCursorPosition(left, top);
```

### Example

```csharp
Console.SetCursorPosition(10,5);

Console.Write("Hello");
```

---

# Console.WindowWidth

Gets or sets the width of the console window.

```csharp
Console.WindowWidth = 100;
```

---

# Console.WindowHeight

Gets or sets the height of the console window.

```csharp
Console.WindowHeight = 40;
```

---

# Flow Diagram

```text
User Input
     │
     ▼
Console.Read()
Console.ReadLine()
Console.ReadKey()
     │
     ▼
Program Processing
     │
     ▼
Console.Write()
Console.WriteLine()
     │
     ▼
Display Output
```

---

# Real World Example

Imagine an ATM Machine.

```
ATM asks:

Enter PIN

↓

You enter PIN

↓

ATM processes

↓

ATM displays balance
```

Similarly,

```
Console.WriteLine()

↓

Console.ReadLine()

↓

Program Logic

↓

Console.WriteLine()
```

---

# Advantages

- Simple to use.
- Ideal for beginners.
- Useful for debugging.
- Supports input and output.
- Provides console customization.

---

# Disadvantages

- Limited graphical interface.
- Suitable only for text-based applications.
- Not ideal for modern desktop applications.

---

# Best Practices

- Use `WriteLine()` for better readability.
- Use `ReadLine()` when expecting full user input.
- Call `ResetColor()` after changing colors.
- Avoid unnecessary `Console.Clear()`.
- Give meaningful prompts before reading input.

---

# Common Mistakes

❌ Using `Read()` when a full string is required.

✔ Use `ReadLine()`.

---

❌ Forgetting `Console.ReadKey()` before closing the program.

✔ Use `ReadKey()` to pause the console when needed.

---

❌ Forgetting to reset colors.

✔ Always call `Console.ResetColor()`.

---

# Interview Questions

## 1. What is the difference between Write() and WriteLine()?

`Write()` prints on the same line.

`WriteLine()` prints and moves to the next line.

---

## 2. What is the return type of ReadLine()?

`string`

---

## 3. What is the return type of Read()?

`int` (ASCII value)

---

## 4. Which method pauses the console until a key is pressed?

`Console.ReadKey()`

---

## 5. Which method clears the console?

`Console.Clear()`

---

## Summary

The `Console` class is the primary way to interact with users in console applications. It provides methods for displaying output, accepting input, changing colors, clearing the screen, and controlling the console window. Mastering these methods is the first step toward building interactive C# applications.

---

# References

- Microsoft Learn – Console Class
- .NET API Documentation
- C# Language Specification
