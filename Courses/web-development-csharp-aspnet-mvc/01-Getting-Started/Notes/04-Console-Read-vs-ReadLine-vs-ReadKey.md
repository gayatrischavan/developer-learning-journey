# Console.Read() vs Console.ReadLine() vs Console.ReadKey()

## Overview

These methods read input from the keyboard.

---

## Why do we need them?

Programs need user input.

Examples:

- Name
- Age
- Choice
- Password

---

## Syntax

```csharp
Console.Read();

Console.ReadLine();

Console.ReadKey();
```

---

# Console.Read()

Reads one character.

Returns ASCII code.

```csharp
int value = Console.Read();
```

Example

Input

```
A
```

Output

```
65
```

---

# Console.ReadLine()

Reads the entire line.

Returns string.

```csharp
string name = Console.ReadLine();
```

Input

```
Gayatri
```

Output

```
Gayatri
```

---

# Console.ReadKey()

Reads one key press.

Waits until user presses a key.

```csharp
Console.ReadKey();
```

Mostly used to prevent the console window from closing immediately.

---

## Comparison

| Method     | Returns        |
| ---------- | -------------- |
| Read()     | ASCII Code     |
| ReadLine() | String         |
| ReadKey()  | ConsoleKeyInfo |

---

## Flow

```
Keyboard

↓

Console.Read()

↓

Program
```

---

## Best Practices

Use

ReadLine()

for almost all user inputs.

Use

ReadKey()

to pause the console.

Use

Read()

only when working with characters.

---

## Common Mistakes

Using Read() when expecting a full string.

Forgetting ReadKey() at the end of beginner programs.

---

## Interview Questions

Difference between Read and ReadLine?

What does ReadKey return?

Which method is used to pause the console?

---

## Summary

Read → one character

ReadLine → entire line

ReadKey → one key press
