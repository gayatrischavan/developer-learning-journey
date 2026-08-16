# Class and Object in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Class and Object  
> **Difficulty:** 🟡 Beginner

---

# 1. What is a Class?

A **class** is a user-defined blueprint (or template) that describes what data and behavior something should have.

A class itself does not hold real values. It only defines the structure — what an object created from it *will* contain.

```csharp
class Employee
{
    // fields, properties, methods go here
}
```

Think of a class as a **design**, not a physical thing.

---

# 2. Why do we use a Class?

Without classes, related data (like an employee's ID, name, age, salary) would be stored in separate, unrelated variables scattered around the program.

A class lets us:

- ✅ Group related data and behavior together
- ✅ Reuse the same structure to create many similar objects
- ✅ Keep code organized and easy to maintain
- ✅ Model real-world entities (Employee, Car, BankAccount, etc.)

---

# 3. Class as a Blueprint

A common analogy: a class is like a **house blueprint**, and an object is the **actual house** built from it.

```text
Blueprint (Class)          Actual Houses (Objects)
─────────────────          ────────────────────────
   House Plan        →     House at Street A
                     →     House at Street B
                     →     House at Street C
```

One blueprint can be used to build many houses. Similarly, one class can be used to create many objects, each with its own data.

---

# 4. Basic Class Syntax

```csharp
access_modifier class ClassName
{
    // Fields
    // Properties
    // Methods
}
```

Example

```csharp
public class Employee
{
}
```

This is currently an empty class — a blueprint with no details yet. We will add fields, properties, and methods to it in the next sections.

---

# 5. What is an Object?

An **object** is a real, usable instance of a class. It is created in memory and holds actual values.

If `Employee` is the blueprint, then a specific employee (with a real ID, name, age, and salary) is an object of that class.

```text
Class   → Employee (blueprint, no data)
Object  → emp1 (real employee with actual values)
```

A class can be used to create many objects, and each object keeps its own separate data.

---

# 6. Creating an Object using `new`

The `new` keyword allocates memory for an object and creates an instance of the class.

```csharp
Employee emp1 = new Employee();
```

## Syntax Breakdown

```text
Employee emp1 = new Employee();
   │       │      │       │
   │       │      │       └── Constructor call (creates the object)
   │       │      └────────── new keyword (allocates memory)
   │       └───────────────── Reference variable (stores the object)
   └───────────────────────── Class name (type)
```

You can create multiple, independent objects from the same class:

```csharp
Employee emp1 = new Employee();
Employee emp2 = new Employee();
```

`emp1` and `emp2` are two separate objects — changing one does not affect the other.

---

# 7. Class Members

Everything defined inside a class is called a **class member**. The main members covered in this lecture are:

- **Fields** – variables that store data
- **Properties** – controlled access to data
- **Methods** – actions or behavior

```csharp
public class Employee
{
    // Field
    private int age;

    // Property
    public string Name { get; set; }

    // Method
    public double FindSalary()
    {
        return 50000;
    }
}
```

---

# 8. Fields

A **field** is a variable declared directly inside a class. It represents the raw data storage of an object.

```csharp
public class Employee
{
    public int EmployeeID;
    public string Name;
    public int Age;
    public double Salary;
}
```

Fields are usually kept `private` in well-designed code, and accessed through properties instead (explained in the next sections). For beginner examples, `public` fields are shown first to keep things simple.

---

# 9. Properties

A **property** is a class member that controls how a field's value is read or changed from outside the class.

Properties look like fields when you use them, but internally they can run logic through `get` and `set`.

```csharp
public class Employee
{
    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}
```

Properties are the recommended way to expose data in C#, because they let you add validation later without changing how other code uses the class.

---

# 10. Get and Set Accessors

- `get` — returns (reads) the value of a property.
- `set` — assigns (writes) a value to a property. The incoming value is available through the special keyword `value`.

```csharp
public class Employee
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
```

## Using it

```csharp
Employee emp1 = new Employee();
emp1.Age = 25;          // calls the "set" accessor, value = 25
Console.WriteLine(emp1.Age); // calls the "get" accessor
```

## Auto-Implemented Properties

When a property does not need extra logic, C# allows a shorter form where the compiler creates the hidden backing field automatically:

```csharp
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

This is the most common style for simple properties in beginner and real-world code alike.

---

# 11. Methods inside a Class

A method inside a class defines an **action** that an object can perform. Methods can use the object's own fields/properties.

```csharp
public class Employee
{
    public double Salary { get; set; }

    public double FindSalary()
    {
        return Salary;
    }
}
```

A method can also contain calculation logic, not just return a stored value:

```csharp
public class Employee
{
    public double Salary { get; set; }

    public double FindSalary()
    {
        double bonus = Salary * 0.10;
        return Salary + bonus;
    }
}
```

---

# 12. Creating and Using an Employee Class

Bringing fields, properties, and methods together into one complete example:

```csharp
public class Employee
{
    // Properties
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    // Method
    public double FindSalary()
    {
        double bonus = Salary * 0.10;
        return Salary + bonus;
    }
}
```

Creating an object of this class:

```csharp
Employee emp1 = new Employee();
```

At this point, `emp1` exists in memory but its properties still hold their default values (`0` for numbers, `null` for strings) until we assign them.

---

# 13. Accessing Employee Properties

Object members are accessed using the **dot (`.`) operator**.

```csharp
Employee emp1 = new Employee();

emp1.EmployeeID = 101;
emp1.Name = "Rahul";
emp1.Age = 28;
emp1.Salary = 40000;

Console.WriteLine(emp1.Name);   // Rahul
Console.WriteLine(emp1.Age);    // 28
Console.WriteLine(emp1.Salary); // 40000
```

Each object stores its own copy of these values:

```csharp
Employee emp2 = new Employee();
emp2.Name = "Sneha";

Console.WriteLine(emp1.Name); // Rahul  (unaffected)
Console.WriteLine(emp2.Name); // Sneha
```

---

# 14. Calling an Employee Method

Methods are also accessed using the dot operator, followed by parentheses `()`.

```csharp
double salary = emp1.FindSalary();
Console.WriteLine(salary); // 44000
```

## Syntax Breakdown

```text
emp1.FindSalary();
 │      │
 │      └── Method being called
 └───────── Object on which the method runs
```

The method uses `emp1`'s own `Salary` value, so calling `FindSalary()` on different objects can return different results.

---

# 15. Class vs Object

| Class | Object |
| --- | --- |
| A blueprint / design | A real instance created from the blueprint |
| Does not occupy memory for data | Occupies memory when created |
| Declared once | Multiple objects can be created |
| Defines fields, properties, methods | Holds actual values for those members |
| Created using `class` keyword | Created using `new` keyword |

```csharp
class Employee { }          // Class

Employee emp1 = new Employee(); // Object
```

---

# 16. Field vs Property

This is one of the most important distinctions for beginners.

| Field | Property |
| --- | --- |
| A plain variable inside a class | A member that controls access to data |
| Direct storage of data | May use a backing field internally |
| No validation possible | Can validate/process data using `get`/`set` |
| Usually kept `private` in good practice | Usually kept `public` to expose data safely |
| Example: `private int age;` | Example: `public int Age { get; set; }` |

```csharp
public class Employee
{
    private int age;              // Field (raw storage)

    public int Age                // Property (controlled access)
    {
        get { return age; }
        set { age = value; }
    }
}
```

In short: **fields store data, properties control how that data is accessed or changed.**

---

# 17. Important Terminology

| Term | Meaning |
| --- | --- |
| Class | Blueprint that defines fields, properties, and methods |
| Object | Instance of a class created using `new` |
| Field | Variable declared inside a class |
| Property | Controlled access point to a field's value |
| `get` | Accessor that reads a property's value |
| `set` | Accessor that assigns a property's value |
| `value` | Implicit keyword holding the value passed to `set` |
| Instance | Another word for an object of a class |
| Member | Any field, property, or method defined in a class |
| Dot operator (`.`) | Used to access members of an object |

---

# 18. Common Beginner Mistakes

❌ Forgetting `new` when creating an object

```csharp
Employee emp1;       // only declares a reference, no object exists yet
emp1.Name = "Rahul";  // error: object not created
```

✔ Correct

```csharp
Employee emp1 = new Employee();
emp1.Name = "Rahul";
```

---

❌ Confusing a class with an object

```csharp
Employee.Name = "Rahul"; // wrong: Name belongs to an object, not the class itself
```

✔ Correct

```csharp
Employee emp1 = new Employee();
emp1.Name = "Rahul";
```

---

❌ Trying to use `value` outside a `set` accessor

```csharp
public int Age
{
    get { return value; } // wrong: "value" only exists inside "set"
}
```

---

❌ Expecting one object's data to affect another

```csharp
Employee emp1 = new Employee();
Employee emp2 = new Employee();

emp1.Name = "Rahul";
Console.WriteLine(emp2.Name); // null, NOT "Rahul" — each object is independent
```

---

# 19. Key Takeaways

- A class is a blueprint; it does not hold real data by itself.
- An object is a real instance of a class, created using `new`.
- Fields store raw data; properties control access to that data through `get` and `set`.
- Methods define the actions an object can perform, often using its own field/property values.
- Every object created from a class has its own independent copy of the data.
- Members of an object (fields, properties, methods) are accessed using the dot (`.`) operator.

---

# Quick Revision

- Class = blueprint, Object = real instance built from that blueprint.
- Use `new` to create an object: `Employee emp1 = new Employee();`.
- Fields = plain variables; Properties = controlled access using `get`/`set`.
- `get` reads a value, `set` writes a value using the keyword `value`.
- Auto-property shortcut: `public int Age { get; set; }`.
- Methods define behavior and can use the object's own data (e.g. `FindSalary()`).
- Access any member with the dot operator: `emp1.Name`, `emp1.FindSalary()`.
- Each object has its own independent copy of the class's data.

---

# Practice Questions

1. What is a class in C#? How is it different from an object?
2. Why do we use the `new` keyword when creating an object?
3. What is the difference between a field and a property?
4. What do the `get` and `set` accessors do?
5. What does the keyword `value` refer to inside a `set` accessor?
6. Create a class `Employee` with `EmployeeID`, `Name`, `Age`, and `Salary`. Add a method `FindSalary()` that returns `Salary` plus a 10% bonus.
7. If you create two `Employee` objects and set different `Name` values on each, will changing one object's `Name` affect the other? Explain why.
8. What happens if you try to access a property on an object that was never created with `new`?
9. Rewrite a property with a manual backing field as an auto-implemented property.
10. Explain, in your own words, why properties are generally preferred over public fields.
