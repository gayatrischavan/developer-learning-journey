# Methods in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** Methods  
> **Difficulty:** 🟡 Beginner to Intermediate

---

# What is a Method?

A **method** is a reusable block of code that performs a specific task.

Instead of writing the same code multiple times, you can place it inside a method and call it whenever needed.

A method improves:

- ✅ Code Reusability
- ✅ Readability
- ✅ Maintainability
- ✅ Organization
- ✅ Performance (by reducing duplicate code)

---

# Real World Example

Imagine making tea.

Instead of explaining every step repeatedly, you simply say:

```
MakeTea()
```

The method already contains all the steps.

Likewise in programming,

instead of writing

```csharp
textBox1.Clear();
textBox2.Clear();
```

everywhere,

we write

```csharp
ClearAllText();
```

and call it whenever required.

---

# Definition

A **method** is a collection of statements that performs a specific task and optionally returns a result to the caller.

---

# Method Syntax

```csharp
access_modifier return_type MethodName(parameter_list)
{
    // Method Body

    return value;
}
```

Example

```csharp
public int Add(int x, int y)
{
    return x + y;
}
```

---

# Parts of a Method

```text
public int Add(int x,int y)
│      │      │      │
│      │      │      └── Parameters
│      │      └───────── Method Name
│      └──────────────── Return Type
└─────────────────────── Access Modifier
```

---

# Method Execution Flow

```text
Main()

↓

Method Call

↓

Control goes to Method

↓

Method Executes

↓

Return Value (Optional)

↓

Back to Caller
```

---

# Advantages of Methods

✔ Code Reusability

✔ Better Readability

✔ Easy Maintenance

✔ Less Code Duplication

✔ Easy Debugging

✔ Better Program Structure

✔ Faster Development

---

# Access Modifiers

Access modifiers control where a method can be accessed.

| Modifier           | Description                                            |
| ------------------ | ------------------------------------------------------ |
| public             | Accessible from anywhere                               |
| private            | Accessible only inside the same class                  |
| protected          | Accessible inside the class and derived classes        |
| internal           | Accessible within the same assembly                    |
| protected internal | Combination of protected and internal                  |
| private protected  | Accessible within the same assembly by derived classes |

Example

```csharp
public void Show()
{
}

private void Hide()
{
}
```

---

# Types of Methods

There are four common types of methods.

## 1. Without Parameters & Without Return Type

Receives nothing.

Returns nothing.

```csharp
public void ClearAllText()
{
    textBox1.Clear();
    textBox2.Clear();
}
```

Call

```csharp
ClearAllText();
```

---

## 2. With Parameters & Without Return Type

Receives input.

Returns nothing.

```csharp
public void FillTextBox(string text)
{
    textBox2.Text = text;
}
```

Call

```csharp
FillTextBox(textBox1.Text);
```

---

## 3. Without Parameters & With Return Type

No input.

Returns a value.

```csharp
public string GetName()
{
    return "Gayatri";
}
```

Call

```csharp
string name = GetName();
```

---

## 4. With Parameters & With Return Type

Receives input.

Returns output.

```csharp
public int Add(int a,int b)
{
    return a+b;
}
```

Call

```csharp
int result = Add(25,100);
```

---

# Static Methods

A static method belongs to the class instead of an object.

It can be called without creating an object.

Example

```csharp
public static int FindMinimum(int x,int y)
{
    if(x<y)
        return x;

    return y;
}
```

Call

```csharp
int min = Numbers.FindMinimum(3,5);
```

---

# Parameter Passing

There are three common ways.

## Value Parameter

Passes a copy of the value.

Changes do not affect the original variable.

```csharp
public void Increment(int number)
{
    number++;
}
```

---

## Output Parameter (out)

Used to return multiple values.

The variable does not need to be initialized before passing.

Example

```csharp
public void GetData(out int age)
{
    age = 23;
}
```

---

## Reference Parameter (ref)

Passes the actual memory reference.

Changes affect the original variable.

Example

```csharp
public void Increment(ref int number)
{
    number++;
}
```

---

# Method Overloading

Method Overloading means creating multiple methods with the same name but different parameter lists.

Example

```csharp
Print()

Print(string text)

Print(string text,bool upperCase)
```

Benefits

- Better Readability
- Flexible Code
- Cleaner APIs

---

# Methods Used in the Course

From the Windows Forms examples:

```csharp
HideRadioButtons()

ClearAllText()

FillTextBox(string text)

SetNumber(int age)

GetName()

FindMinimum()

Add()
```

---

# Best Practices

✔ Use meaningful method names.

✔ One method should perform one task.

✔ Keep methods short.

✔ Avoid duplicate code.

✔ Use PascalCase for method names.

✔ Use parameters instead of global variables.

✔ Return values when required.

---

# Common Mistakes

❌ Long methods

❌ Duplicate code

❌ Meaningless names

```csharp
A()

B()

XYZ()
```

✔ Better

```csharp
CalculateSalary()

PrintInvoice()

ValidateUser()
```

---

# Interview Questions

### What is a method?

A reusable block of code that performs a specific task.

---

### Why do we use methods?

- Reusability
- Readability
- Maintainability

---

### What are parameters?

Input values passed to a method.

---

### Difference between Parameter and Argument?

Parameter

```csharp
void Add(int x,int y)
```

Argument

```csharp
Add(10,20);
```

---

### Difference between ref and out?

| ref                   | out                    |
| --------------------- | ---------------------- |
| Must be initialized   | No need to initialize  |
| Used for input/output | Used mainly for output |

---

### What is Method Overloading?

Multiple methods having the same name but different parameter lists.

---

### Difference between Static and Instance Method?

| Static                  | Instance            |
| ----------------------- | ------------------- |
| Belongs to Class        | Belongs to Object   |
| Called using Class Name | Called using Object |
| No object required      | Object required     |

---

# Summary

A method is a reusable block of code that performs a specific task.

Methods help create clean, maintainable, and reusable applications.

Every method consists of:

- Access Modifier
- Return Type
- Method Name
- Parameters
- Method Body

Methods can:

- Receive Parameters
- Return Values
- Be Static
- Be Overloaded
- Use Value, Reference, or Output Parameters

Mastering methods is one of the most important skills in C# because almost every application is built using methods.

---

# References

- Microsoft Learn
- C# Programming Guide
- Udemy Course Notes
