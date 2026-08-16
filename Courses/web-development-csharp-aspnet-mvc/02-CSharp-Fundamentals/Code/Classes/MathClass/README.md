# Using Math Class - Code Examples

This folder contains practical examples related to **Using the Math Class in C#**, matching [Notes/16-Using-Math-Class.md](../../../Notes/16-Using-Math-Class.md).

## Topic

**Using Math Class**

## Learning Objectives

After completing these examples, you will be able to:

- Use `Math.PI` and `Math.E` as predefined constants
- Use `Math.Abs()`, `Math.Min()`, and `Math.Max()`
- Use `Math.Pow()` and `Math.Sqrt()`, and know both return `double`
- Use `Math.Round()`, `Math.Ceiling()`, and `Math.Floor()`, and understand how they differ
- Understand why `Math` is never instantiated with `new`

## Files

| File                  | Description                                                          |
| ---------------------- | ----------------------------------------------------------------------- |
| Program.cs             | Entry point; runs every demo plus a consolidated Math example         |
| MathBasicMethods.cs     | `Math.PI`, `Math.E`, `Math.Abs()`, `Math.Min()`, `Math.Max()`        |
| MathPower.cs             | `Math.Pow()` - base/exponent, returns `double`                       |
| MathSqrt.cs               | `Math.Sqrt()` - returns `double`                                     |
| MathRound.cs               | `Math.Round()` (including midpoint/banker's rounding), `Math.Ceiling()`, `Math.Floor()` |
| PracticeExercises.cs        | Practice questions only (no solutions)                             |

---

## Suggested Learning Order

```text
MathBasicMethods
      ↓
MathPower
      ↓
MathSqrt
      ↓
MathRound
      ↓
Program
      ↓
PracticeExercises
```

---

## Important Concepts

- `Math.PI`
- `Math.E`
- `Abs()`
- `Min()`
- `Max()`
- `Pow()`
- `Sqrt()`
- `Round()`
- `Ceiling()`
- `Floor()`

`Math` is a static class — all members are called as `Math.MethodName(...)`, never on a `new Math()` object. `Math.Pow()` and `Math.Sqrt()` both return `double`. Default `Math.Round(value)` uses midpoint rounding to even (`Math.Round(10.5)` is `10`, not `11`). `Ceiling()` always rounds toward positive infinity and `Floor()` always rounds toward negative infinity — this matters especially for negative numbers.

---

## How to Run the Examples

1. Open this folder as (or add it to) a C# Console Application project.
2. Set `Program.cs` as the startup file.
3. Run the project (`F5` in Visual Studio, or `dotnet run`).
4. Read the console output alongside each file to see which concept produced which line.

---

## References

- Microsoft Learn - Math Class
- C# Programming Guide
- Udemy Course Notes (Lecture 46: Using Math Class)
