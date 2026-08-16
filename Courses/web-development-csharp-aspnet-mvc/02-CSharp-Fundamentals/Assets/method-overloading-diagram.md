# Method Overloading

## Concept

```mermaid
graph TD

A[Print]

A --> B[Print()]

A --> C[Print(string)]

A --> D[Print(string,bool)]

A --> E[Print(int)]
```

---

## Rules

Method Name

✔ Same

Parameters

✔ Different

Return Type

❌ Return type alone cannot overload a method.

---

## Example

```csharp
void Print()

void Print(string text)

void Print(int number)

void Print(string text,bool upperCase)
```

---

Compiler chooses the correct method based on

- Number of Parameters
- Parameter Types
- Parameter Order