# Using List Class - Code Examples

This folder contains practical examples related to **Using the List Class in C#**, matching [Notes/13-Using-List-Class.md](../../../Notes/13-Using-List-Class.md).

## Learning Objectives

After completing these examples, you will be able to:

- Create a `List<T>` of any type
- Add, access, update, and remove items in a list
- Understand the difference between `Remove()` and `RemoveAt()`
- Understand `Count` vs `Capacity`
- Loop through a list using `foreach`
- Store custom objects (`Employee`) in a `List<Employee>`

## Files

| File                  | Description                                                        |
| ---------------------- | -------------------------------------------------------------------- |
| Program.cs             | Entry point; runs every demo plus a full `List<string>`/`List<Employee>` example |
| ListOfIntegers.cs       | `List<int>`: create, add, access, update, remove, clear, count      |
| ListOfStrings.cs        | `List<string>`: create, add, read, update, remove, loop, count      |
| ListOfObjects.cs        | `List<Employee>`: create, add objects, access properties, loop      |
| ListMethods.cs          | Commonly used methods: `Add`, `Insert`, `Contains`, `IndexOf`, `Remove`, `RemoveAt`, `Clear` |
| CountAndCapacity.cs     | Dedicated `Count` vs `Capacity` demonstration                       |
| PracticeExercises.cs    | Practice questions only (no solutions)                              |

---

## Suggested Learning Order

```text
ListOfIntegers
    ↓
ListOfStrings
    ↓
ListOfObjects
    ↓
ListMethods
    ↓
CountAndCapacity
    ↓
Program
    ↓
PracticeExercises
```

---

## Important Concepts

- `List<T>` — a generic, resizable collection of a single type
- Generic List — the `<T>` type parameter (`List<int>`, `List<string>`, `List<Employee>`)
- `Add()` — appends an item to the end
- `Remove()` — removes the first matching **value**
- `RemoveAt()` — removes the item at a specific **index**
- `Clear()` — removes all items
- `Count` — number of items currently in the list
- `Capacity` — size of the internal storage currently allocated (not a fixed maximum)
- Index — the zero-based position used to access/update an item
- List of objects — a list can hold custom class instances, not just built-in types

---

## Existing Employee Dependency

`ListOfObjects.cs` (and the `List<Employee>` section of `Program.cs`) reuse the **existing** `Employee` class from:

```text
Code/Classes/ClassAndObject/Employee.cs
```

via `using ClassAndObjectDemo;`. No duplicate `Employee` class is defined anywhere in this folder. For these files to compile, `Employee.cs` from `Code/Classes/ClassAndObject/` must be included in the same project/compilation.

---

## How to Run the Examples

1. Include this folder's files together with `Employee.cs` from `Code/Classes/ClassAndObject/` in a C# Console Application project.
2. Set `Program.cs` as the startup file.
3. Run the project (`F5` in Visual Studio, or `dotnet run`).
4. Read the console output alongside each file to see which concept produced which line.

---

## References

- Microsoft Learn - List\<T\> Class
- C# Programming Guide
- Udemy Course Notes (Lecture 43: Using List Class)
