# Class and Object - Code Examples

This folder contains practical examples related to **Classes and Objects in C#**, matching [Notes/12-Class-and-Object.md](../../../Notes/12-Class-and-Object.md).

## Files

| File                  | Description                                              |
| ---------------------- | --------------------------------------------------------- |
| Program.cs             | Entry point; runs every demo and a full Employee example |
| Employee.cs             | The `Employee` class (blueprint) used throughout this folder |
| Fields.cs               | What a field is: declaration, initialization, access, update |
| Properties.cs           | Property declaration, auto-implemented properties, field vs property |
| GetSet.cs               | How `get` and `set` accessors work                        |
| Methods.cs              | Methods inside a class: parameters, return values, calling |
| PracticeExercises.cs    | Practice questions only (no solutions)                    |

---

## How the Examples are Related

- `Employee.cs` defines the class used as the running example across the folder — it appears again in `Methods.cs` and in the final example in `Program.cs`.
- `Fields.cs`, `Properties.cs`, and `GetSet.cs` each introduce a small, self-contained class (`EmployeeFieldExample`, `EmployeeWithProperty`, `EmployeeAge`) so every concept can be seen in isolation before it's combined in `Employee.cs`.
- `Methods.cs` shows a plain method with parameters/return value, then calls `Employee.FindSalary()` to connect it back to the main class.
- `Program.cs` ties everything together: it runs each `Demo()` in order, then builds one complete `Employee` object end-to-end (Class → Object → Properties → Assign → Read → Method).

---

## How to Run the Examples

1. Open the `ClassAndObject` folder as (or add it to) a C# Console Application project in Visual Studio / `dotnet`.
2. Set `Program.cs` as the startup file.
3. Run the project (`F5` in Visual Studio, or `dotnet run` from the folder).
4. Read the console output alongside each file to see which concept produced which line.

---

## Concepts Learned

- Declaring a class as a blueprint (`Employee`)
- Creating an object using `new`
- Fields vs Properties
- Auto-implemented properties
- `get` and `set` accessors and the `value` keyword
- Declaring and calling methods with parameters and return values
- Accessing object members with the dot (`.`) operator
- Each object holding its own independent copy of data

---

## Suggested Learning Order

1. `Employee.cs` — see the finished class first, as a preview
2. `Fields.cs`
3. `Properties.cs`
4. `GetSet.cs`
5. `Methods.cs`
6. `PracticeExercises.cs`
7. `Program.cs` — see all concepts run together

---

## References

- Microsoft Learn - Classes and Objects
- C# Programming Guide
- Udemy Course Notes (Lecture 42: Class and Object)
