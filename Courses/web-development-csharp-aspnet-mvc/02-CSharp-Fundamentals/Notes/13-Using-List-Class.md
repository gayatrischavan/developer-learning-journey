# Using the List Class in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** `List<T>`  
> **Difficulty:** 🟡 Beginner

---

# 1. What is a Collection?

A **collection** is an object that can hold multiple values together, instead of storing each value in its own separate variable.

Instead of writing:

```csharp
string name1 = "Rahul";
string name2 = "Sneha";
string name3 = "Amit";
```

a collection lets us store all of them together as one group, which is much easier to manage when the number of items is large or unknown in advance.

C# provides several built-in collection types. This lecture focuses on one of the most commonly used: `List<T>`.

---

# 2. What is `List<T>`?

`List<T>` is a built-in C# class (from the `System.Collections.Generic` namespace) that stores a **resizable, ordered collection of items** of a single type `T`.

`T` is a placeholder for the type of data the list will hold — for example `List<int>` holds integers, `List<string>` holds strings, and `List<Employee>` holds `Employee` objects.

```csharp
using System.Collections.Generic;

List<int> numbers = new List<int>();
```

---

# 3. Why use a List?

Arrays are useful, but they have a major limitation: their size is fixed once created.

A `List<T>`:

- ✅ Grows and shrinks automatically as items are added or removed
- ✅ Provides built-in methods like `Add()`, `Remove()`, `Clear()`
- ✅ Removes the need to manually track how many items are in use
- ✅ Works with any data type, including custom classes like `Employee`

---

# 4. List vs Array

```text
Array
  ↓
Fixed size

List<T>
  ↓
Dynamic collection
```

| Array | List\<T\> |
| --- | --- |
| Fixed size, set at creation | Resizable — grows/shrinks automatically |
| `int[] numbers = new int[3];` | `List<int> numbers = new List<int>();` |
| No built-in `Add`/`Remove` methods | Has `Add()`, `Remove()`, `RemoveAt()`, `Clear()`, etc. |
| Size must be known in advance | Size can change while the program runs |
| Slightly more memory-efficient for a known, fixed size | More flexible for data that changes over time |

Both store elements of a single type and support index-based access (`numbers[0]`).

---

# 5. Creating a List

```csharp
List<int> numbers = new List<int>();
```

## Syntax Breakdown

```text
List<int> numbers = new List<int>();
 │    │      │        │      │
 │    │      │        │      └── Type argument (must match the declared type)
 │    │      │        └───────── Creates a new, empty List object
 │    │      └────────────────── Reference variable
 │    └───────────────────────── Type argument (type of items the list holds)
 └────────────────────────────── List class
```

A newly created list is empty — it contains zero items until you add some.

---

# 6. Adding Items with `Add()`

The `Add()` method appends a new item to the end of the list.

```csharp
List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
```

After this code runs, `numbers` contains `[10, 20, 30]`, in that order.

---

# 7. Accessing List Items

List items are accessed using an index, just like an array, starting at `0`.

```csharp
Console.WriteLine(numbers[0]); // 10
Console.WriteLine(numbers[1]); // 20
Console.WriteLine(numbers[2]); // 30
```

Accessing an index that does not exist (for example `numbers[5]` on a 3-item list) throws an `ArgumentOutOfRangeException` at runtime.

---

# 8. Updating List Items

An existing item can be replaced using its index.

```csharp
numbers[1] = 99;

Console.WriteLine(numbers[1]); // 99
```

This overwrites the value at that index — it does not add a new item, so `Count` stays the same.

---

# 9. Removing Items with `Remove()`

`Remove()` removes the **first occurrence** of a specific value from the list.

```csharp
numbers.Remove(20);
```

If `numbers` was `[10, 20, 30]`, it becomes `[10, 30]` after this call.

If the value does not exist in the list, `Remove()` does nothing and does not throw an error.

---

# 10. Removing by Index with `RemoveAt()`

`RemoveAt()` removes the item at a specific index, regardless of its value.

```csharp
numbers.RemoveAt(0);
```

If `numbers` was `[10, 30]`, it becomes `[30]` after this call.

Passing an invalid index (out of range) throws an `ArgumentOutOfRangeException`.

---

# 11. Removing All Items with `Clear()`

`Clear()` removes every item from the list, leaving it empty.

```csharp
numbers.Clear();

Console.WriteLine(numbers.Count); // 0
```

The list itself still exists after `Clear()` — it is simply empty, not `null`.

---

# 12. Checking Number of Items with `Count`

`Count` returns how many items are **currently stored** in the list.

```csharp
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);

Console.WriteLine(numbers.Count); // 2
```

`Count` updates automatically every time an item is added or removed.

---

# 13. Understanding `Capacity`

`Capacity` represents how many items the list's **internal storage** can currently hold before it needs to allocate more memory.

```csharp
List<int> numbers = new List<int>();
Console.WriteLine(numbers.Capacity); // 0 (implementation detail, may vary)

numbers.Add(10);
Console.WriteLine(numbers.Capacity); // internally grows, e.g. 4
```

When more items are added than the current `Capacity` allows, `List<T>` automatically allocates a larger internal array behind the scenes — this happens transparently, and beginners do not need to manage it manually.

---

# 14. `Count` vs `Capacity`

| `Count` | `Capacity` |
| --- | --- |
| Number of items actually in the list right now | Size of the internal storage currently allocated |
| Always accurate and predictable | An internal detail; exact values can vary by .NET version |
| Increases/decreases as items are added/removed | Only grows automatically when needed; does not shrink on its own |
| Example: 3 items added → `Count` is `3` | Internal array might already hold room for 4 or more → `Capacity` can be `≥ Count` |

`Capacity` is **not** the maximum number of items a list can ever contain — it is only the size of the currently allocated internal storage. When the list needs more room than the current `Capacity`, .NET automatically grows it. In practice, `Capacity` is almost always greater than or equal to `Count`, never less.

---

# 15. Creating a List of Strings

```csharp
List<string> names = new List<string>();

names.Add("Rahul");
names.Add("Sneha");
names.Add("Amit");

Console.WriteLine(names[0]); // Rahul
```

---

# 16. Creating a List of Integers

```csharp
List<int> ages = new List<int>();

ages.Add(25);
ages.Add(30);
ages.Add(28);

Console.WriteLine(ages.Count); // 3
```

---

# 17. Creating a List of Objects

A list can also store objects created from a custom class, not just built-in types like `int` or `string`.

```csharp
List<Employee> employees = new List<Employee>();
```

This creates a list that can only hold `Employee` objects — attempting to add anything else (like a `string`) will not compile.

---

# 18. `List<Employee>`

This lecture reuses the existing `Employee` class from `Code/Classes/ClassAndObject/Employee.cs` — no new `Employee` class is created here.

```csharp
public int EmployeeID { get; set; }
public string Name { get; set; }
public int Age { get; set; }
public double Salary { get; set; }

public double FindSalary()
{
    double bonus = Salary * 0.10;
    return Salary + bonus;
}
```

Creating and adding `Employee` objects to a list:

```csharp
List<Employee> employees = new List<Employee>();

Employee emp1 = new Employee();
emp1.EmployeeID = 101;
emp1.Name = "Rahul";
emp1.Age = 28;
emp1.Salary = 40000;

employees.Add(emp1);
```

---

# 19. Looping through a List

A `foreach` loop is the most common way to process every item in a list.

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

The same pattern works for any list type, including `List<Employee>`:

```csharp
foreach (Employee emp in employees)
{
    Console.WriteLine($"{emp.Name} - {emp.Salary}");
}
```

A `for` loop with an index also works, and is useful when the index itself is needed:

```csharp
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

# 20. Commonly Used List Methods

| Method / Member | Purpose |
| --- | --- |
| `Add(item)` | Adds an item to the end of the list |
| `Insert(index, item)` | Inserts an item at a specific index, shifting later items forward |
| `Remove(item)` | Removes the first matching item |
| `RemoveAt(index)` | Removes the item at a specific index |
| `Clear()` | Removes all items |
| `Contains(item)` | Returns `true` if the item exists in the list |
| `IndexOf(item)` | Returns the index of the first matching item, or `-1` if not found |
| `Count` | Number of items currently in the list |
| `Capacity` | Size of the internal storage currently allocated |

```csharp
numbers.Insert(1, 15);                // inserts 15 at index 1

bool hasValue = numbers.Contains(30); // true or false
int position = numbers.IndexOf(30);   // index, or -1
```

---

# 21. Complete Employee List Example

```csharp
List<Employee> employees = new List<Employee>();

Employee emp1 = new Employee();
emp1.EmployeeID = 101;
emp1.Name = "Rahul";
emp1.Age = 28;
emp1.Salary = 40000;

Employee emp2 = new Employee();
emp2.EmployeeID = 102;
emp2.Name = "Sneha";
emp2.Age = 25;
emp2.Salary = 45000;

Employee emp3 = new Employee();
emp3.EmployeeID = 103;
emp3.Name = "Amit";
emp3.Age = 30;
emp3.Salary = 50000;

// Adding employees
employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);

// Reading a single employee
Console.WriteLine(employees[0].Name); // Rahul

// Looping through employees
foreach (Employee emp in employees)
{
    Console.WriteLine($"{emp.EmployeeID} - {emp.Name} - {emp.FindSalary()}");
}

// Removing an employee
employees.Remove(emp2);

// Checking Count
Console.WriteLine(employees.Count); // 2
```

This single example ties together creating a list, adding objects, reading values, looping, accessing properties, calling a method, removing an item, and checking `Count`.

---

# 22. Common Beginner Mistakes

❌ Forgetting to initialize the list before adding items

```csharp
List<int> numbers;
numbers.Add(10); // error: list was never created with "new"
```

✔ Correct

```csharp
List<int> numbers = new List<int>();
numbers.Add(10);
```

---

❌ Assuming `Remove()` removes by index

```csharp
numbers.Remove(0); // removes the VALUE 0, not the item at index 0
```

✔ Correct (to remove by position)

```csharp
numbers.RemoveAt(0);
```

---

❌ Confusing `Count` with `Capacity`

```csharp
Console.WriteLine(numbers.Capacity); // NOT the number of items currently stored
```

✔ Correct (to check how many items exist)

```csharp
Console.WriteLine(numbers.Count);
```

---

❌ Accessing an index that does not exist

```csharp
List<int> numbers = new List<int>(); // empty
Console.WriteLine(numbers[0]);       // throws ArgumentOutOfRangeException
```

✔ Correct: check `Count` first, or use `Contains()`/`IndexOf()` before accessing by index.

---

# 23. Key Takeaways

- `List<T>` is a resizable, ordered collection that holds items of a single type.
- Unlike an array, a `List<T>` grows and shrinks automatically as items are added or removed.
- `Add()` appends, `Remove()` removes by value, `RemoveAt()` removes by index, `Clear()` empties the list.
- `Count` is the number of items currently in the list; `Capacity` is the internal storage size currently allocated — `Capacity` is not a hard maximum.
- `List<T>` works with built-in types (`List<int>`, `List<string>`) and with custom classes (`List<Employee>`).
- The existing `Employee` class (with `EmployeeID`, `Name`, `Age`, `Salary`, `FindSalary()`) is reused as-is for `List<Employee>` examples.
- `foreach` is the most common way to loop through a list's items.

---

# Quick Revision

- Create: `List<int> numbers = new List<int>();`
- Add: `numbers.Add(10);`
- Remove by value: `numbers.Remove(10);`
- Remove by index: `numbers.RemoveAt(0);`
- Remove all: `numbers.Clear();`
- Size right now: `numbers.Count`
- Allocated internal storage: `numbers.Capacity` (grows automatically, not a fixed maximum)
- Loop: `foreach (var item in numbers) { ... }`
- Lists can hold objects too: `List<Employee> employees = new List<Employee>();`

---

# Practice Questions

## Easy

1. What is the difference between an array and a `List<T>`?
2. How do you create an empty `List<string>`?
3. Write the code to add three integers to a `List<int>`.
4. What does `Count` return on a list?
5. Which method removes a specific value from a list, and which method removes an item by its index?

## Medium

6. What is the difference between `Count` and `Capacity`? Is `Capacity` ever smaller than `Count`?
7. Create a `List<Employee>`, add two `Employee` objects to it, and print each employee's `Name` using a `foreach` loop.
8. What happens if you call `Remove()` with a value that does not exist in the list?
9. What happens if you try to access an index that is greater than or equal to the list's `Count`?
10. Given a `List<Employee>`, write the steps to find and remove the employee whose `EmployeeID` is `102`.
