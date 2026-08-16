# Using the Math Class in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** `Math`  
> **Difficulty:** 🟡 Beginner

---

# 1. What is the `Math` Class?

`Math` is a class provided by .NET that contains commonly used mathematical constants and methods — absolute value, minimum/maximum, powers, square roots, and rounding, among others.

```csharp
Math.Abs(-10);
Math.Max(10, 20);
Math.Min(10, 20);
Math.Pow(2, 3);
Math.Sqrt(25);
```

---

# 2. Why do we use `Math`?

`Math` saves us from writing our own logic for common mathematical operations, for example:

- ✅ Getting a value's absolute (non-negative) size
- ✅ Comparing two values to find the smaller/larger one
- ✅ Raising a number to a power
- ✅ Finding a square root
- ✅ Rounding numbers up, down, or to the nearest whole number

---

# 3. `System.Math`

`Math` lives in the `System` namespace as `System.Math`. Every member of `Math` used in this lecture is **static**, meaning they belong to the class itself, not to an object.

```text
Math.MethodName(...)
```

Because of this, `Math` is called directly through the class name — it is **never** instantiated with `new`.

```csharp
Math math = new Math(); // WRONG - this does not compile
```

`Math` has no instance members and no public constructor, so there is nothing to construct. Every usage of `Math` in this lecture looks like `Math.Abs(...)`, `Math.Pow(...)`, etc. — never `math.Abs(...)` on an object.

---

# 4. Important Math Constants

Besides methods, `Math` also provides a small number of commonly used constants.

| Constant | Approximate Value | Meaning |
| --- | --- | --- |
| `Math.PI` | `3.14159...` | Ratio of a circle's circumference to its diameter |
| `Math.E` | `2.71828...` | The base of natural logarithms |

---

# 5. `Math.PI`

```csharp
Console.WriteLine(Math.PI); // 3.14159265358979...
```

`Math.PI` is useful whenever a calculation involves circles (area, circumference) or other formulas that rely on this constant. Beginners do not need deep mathematical theory to use it — just know it is a fixed, predefined `double` value.

---

# 6. `Math.E`

```csharp
Console.WriteLine(Math.E); // 2.71828182845905...
```

`Math.E` is Euler's number, used in some growth/exponential-style calculations. For this lecture, it is enough to know it exists as a predefined constant, the same way `Math.PI` does.

---

# 7. Absolute Value with `Math.Abs()`

`Math.Abs()` returns the non-negative (absolute) version of a number — how far it is from zero, ignoring its sign.

```csharp
Console.WriteLine(Math.Abs(-10)); // 10
Console.WriteLine(Math.Abs(10));  // 10
Console.WriteLine(Math.Abs(-3.5)); // 3.5
```

A positive number stays the same; a negative number loses its minus sign.

---

# 8. Minimum with `Math.Min()`

`Math.Min()` returns the **smaller** of two values.

```csharp
int result = Math.Min(10, 20);
Console.WriteLine(result); // 10
```

---

# 9. Maximum with `Math.Max()`

`Math.Max()` returns the **larger** of two values.

```csharp
int result = Math.Max(10, 20);
Console.WriteLine(result); // 20
```

A simple practical use: finding the higher of two exam scores.

```csharp
int score1 = 78;
int score2 = 92;

int highest = Math.Max(score1, score2);
Console.WriteLine(highest); // 92
```

---

# 10. Power with `Math.Pow()`

`Math.Pow(base, exponent)` raises `base` to the power of `exponent`.

```csharp
double result = Math.Pow(2, 3); // 2³ = 8
Console.WriteLine(result); // 8
```

```text
first argument  → base
second argument → exponent
```

`Math.Pow()` **always returns a `double`**, even when both arguments are whole numbers — it does not return `int`.

---

# 11. Square Root with `Math.Sqrt()`

`Math.Sqrt()` returns the square root of a number.

```csharp
double result = Math.Sqrt(25); // √25 = 5
Console.WriteLine(result); // 5
```

Just like `Math.Pow()`, `Math.Sqrt()` **returns a `double`**, not an `int`.

---

# 12. Rounding with `Math.Round()`

`Math.Round()` rounds a floating-point number to the nearest whole number.

```csharp
Console.WriteLine(Math.Round(10.4)); // 10
Console.WriteLine(Math.Round(10.6)); // 11
```

## Midpoint Values (`.5`)

Midpoint values need special care. By default, `Math.Round(value)` in .NET uses **"banker's rounding"** (also called *rounding to even* / `MidpointRounding.ToEven`) — a midpoint value rounds to whichever neighboring whole number is **even**.

```csharp
Console.WriteLine(Math.Round(10.5)); // 10 (rounds down to the nearest even number)
Console.WriteLine(Math.Round(11.5)); // 12 (rounds up to the nearest even number)
```

This is a deliberate design choice to reduce statistical bias when rounding many values — it is **not** a bug, and `Math.Round(10.5)` should **not** be assumed to always become `11`.

`Math.Round()` also has overloads that accept an explicit `MidpointRounding` mode (such as `MidpointRounding.AwayFromZero`) when a different midpoint behavior is needed — this lecture only covers the default behavior, not those overloads in depth.

---

# 13. Ceiling with `Math.Ceiling()`

`Math.Ceiling()` rounds a value **up**, toward positive infinity.

```csharp
Console.WriteLine(Math.Ceiling(10.2)); // 11
```

This holds true for negative numbers too — "toward positive infinity" means toward the larger (less negative) direction:

```csharp
Console.WriteLine(Math.Ceiling(-10.2)); // -10 (not -11)
```

---

# 14. Floor with `Math.Floor()`

`Math.Floor()` rounds a value **down**, toward negative infinity.

```csharp
Console.WriteLine(Math.Floor(10.8)); // 10
```

Again, this matters for negative numbers — "toward negative infinity" means toward the smaller (more negative) direction:

```csharp
Console.WriteLine(Math.Floor(-10.8)); // -11 (not -10)
```

## `Round` vs `Ceiling` vs `Floor`

| Method | Behavior | `10.2` → | `10.8` → | `-10.2` → | `-10.8` → |
| --- | --- | --- | --- | --- | --- |
| `Math.Round()` | Nearest whole number (midpoint rounds to even) | `10` | `11` | `-10` | `-11` |
| `Math.Ceiling()` | Always toward positive infinity (upward) | `11` | `11` | `-10` | `-10` |
| `Math.Floor()` | Always toward negative infinity (downward) | `10` | `10` | `-11` | `-11` |

`Ceiling()` and `Floor()` should **not** be thought of as "just add 1" or "just remove the decimal" — that description breaks down for negative numbers, as shown above.

---

# 15. Complete Math Example

```csharp
Console.WriteLine($"Math.PI              : {Math.PI}");
Console.WriteLine($"Math.E               : {Math.E}");

Console.WriteLine($"Math.Abs(-10)        : {Math.Abs(-10)}");
Console.WriteLine($"Math.Min(10, 20)     : {Math.Min(10, 20)}");
Console.WriteLine($"Math.Max(10, 20)     : {Math.Max(10, 20)}");

Console.WriteLine($"Math.Pow(2, 3)       : {Math.Pow(2, 3)}");
Console.WriteLine($"Math.Sqrt(25)        : {Math.Sqrt(25)}");

Console.WriteLine($"Math.Round(10.5)     : {Math.Round(10.5)}");
Console.WriteLine($"Math.Ceiling(10.2)   : {Math.Ceiling(10.2)}");
Console.WriteLine($"Math.Floor(10.8)     : {Math.Floor(10.8)}");
```

This single example ties together the constants and every method covered in this lecture.

---

# 16. Choosing the Correct Math Method

```text
Need absolute value?     → Abs()
Need the smaller value?  → Min()
Need the larger value?   → Max()
Need an exponent?        → Pow()
Need a square root?      → Sqrt()
Need nearest rounding?   → Round()
Need upward rounding?    → Ceiling()
Need downward rounding?  → Floor()
```

---

# 17. Common Beginner Mistakes

❌ Trying to create a `Math` object

```csharp
Math math = new Math(); // WRONG: Math has no instance members or public constructor
```

✔ Correct

```csharp
Math.Abs(-10); // called directly on the class
```

---

❌ Confusing `Math.Min()` with `Math.Max()`

```csharp
Math.Min(10, 20); // returns 10, the SMALLER value
Math.Max(10, 20); // returns 20, the LARGER value
```

---

❌ Confusing `Math.Pow()`'s argument order

```csharp
Math.Pow(2, 3); // base = 2, exponent = 3 -> 2³ = 8
Math.Pow(3, 2); // base = 3, exponent = 2 -> 3² = 9 (a DIFFERENT result)
```

---

❌ Assuming `Math.Pow()` returns `int`

```csharp
int result = Math.Pow(2, 3); // WRONG: does not compile - Math.Pow() returns double
```

✔ Correct

```csharp
double result = Math.Pow(2, 3);
```

---

❌ Assuming `Math.Sqrt()` returns `int`

```csharp
int result = Math.Sqrt(25); // WRONG: does not compile - Math.Sqrt() returns double
```

✔ Correct

```csharp
double result = Math.Sqrt(25);
```

---

❌ Confusing `Round()`, `Ceiling()`, and `Floor()`

```csharp
Math.Round(10.2);   // 10 (nearest)
Math.Ceiling(10.2); // 11 (always up)
Math.Floor(10.2);   // 10 (always down)
```

---

❌ Assuming `Math.Round(10.5)` always becomes `11`

```csharp
Math.Round(10.5); // WRONG assumption: this is 10, not 11 (rounds to the nearest EVEN number by default)
```

---

❌ Forgetting that `Ceiling()` rounds toward positive infinity

```csharp
Math.Ceiling(-10.2); // WRONG assumption: this is -10, not -11
```

---

❌ Forgetting that `Floor()` rounds toward negative infinity

```csharp
Math.Floor(-10.8); // WRONG assumption: this is -11, not -10
```

---

# 18. Key Takeaways

- `Math` is a static class — its members are always called as `Math.MethodName(...)`, never on a `new Math()` object.
- `Math.PI` and `Math.E` are predefined constants.
- `Math.Abs()` returns a value's non-negative size.
- `Math.Min()`/`Math.Max()` return the smaller/larger of two values.
- `Math.Pow(base, exponent)` and `Math.Sqrt(value)` both return `double`, never `int`.
- `Math.Round()` rounds to the nearest whole number; by default, midpoint values (`.5`) round to the nearest **even** number (banker's rounding), not always upward.
- `Math.Ceiling()` always rounds toward positive infinity; `Math.Floor()` always rounds toward negative infinity — both behave differently from `Round()` and from each other, especially with negative numbers.

---

# Quick Revision

- No object needed: `Math.Abs(-10);` — never `new Math()`.
- Constants: `Math.PI`, `Math.E`
- Absolute value: `Math.Abs(x)`
- Smaller/larger: `Math.Min(a, b)` / `Math.Max(a, b)`
- Power: `Math.Pow(base, exponent)` → `double`
- Square root: `Math.Sqrt(x)` → `double`
- Nearest whole number: `Math.Round(x)` → midpoint rounds to even by default
- Always up: `Math.Ceiling(x)` (toward positive infinity)
- Always down: `Math.Floor(x)` (toward negative infinity)

---

# Practice Questions

## Easy

1. What does `Math.Abs(-15)` return?
2. What does `Math.Min(7, 3)` return, and what does `Math.Max(7, 3)` return?
3. What is the result of `Math.Pow(2, 3)`, and what data type does it return?
4. What is the result of `Math.Sqrt(49)`, and what data type does it return?
5. Why can't you write `Math math = new Math();`?

## Medium

6. What does `Math.Round(10.5)` return by default, and why?
7. What is the difference between `Math.Ceiling(10.2)` and `Math.Floor(10.2)`?
8. What does `Math.Ceiling(-10.2)` return? Explain why it is not `-11`.
9. Write a small program that uses `Math.Abs()`, `Math.Max()`, and `Math.Round()` together.
10. Write a small real-world calculation (for example, finding the area of a circle using `Math.PI`) using at least two `Math` members from this lecture.
