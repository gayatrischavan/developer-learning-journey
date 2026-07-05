# Console.Write() vs Console.WriteLine()

## Overview

Both methods are used to display output.

The main difference is how they handle the cursor position.

---

## Why do we need them?

Programs need to display messages to users.

Example:

```
Enter Name:
```

or

```
Welcome Gayatri
```

---

## Syntax

```csharp
Console.Write();

Console.WriteLine();
```

---

## Write()

Prints text on the same line.

```csharp
Console.Write("Hello ");
Console.Write("World");
```

Output

```
Hello World
```

Cursor remains after "World".

---

## WriteLine()

Prints text and moves the cursor to the next line.

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

Output

```
Hello
World
```

---

## Difference

| Write            | WriteLine         |
| ---------------- | ----------------- |
| Same line        | New line          |
| Cursor remains   | Cursor moves      |
| Used for prompts | Used for messages |

---

## Real World Example

```
Enter Name:
```

Use

```csharp
Console.Write("Enter Name: ");
```

After user types

```
Gayatri
```

---

## Best Practices

Use

```csharp
Write()
```

for input prompts.

Use

```csharp
WriteLine()
```

for displaying information.

---

## Common Mistakes

Using WriteLine before ReadLine

```csharp
Console.WriteLine("Enter Name:");
```

This moves cursor to next line.

Better

```csharp
Console.Write("Enter Name: ");
```

---

## Interview Questions

Why use Write instead of WriteLine while taking input?

What happens to the cursor after WriteLine()?

---

## Summary

Write keeps the cursor on the same line.

WriteLine moves it to the next line.
