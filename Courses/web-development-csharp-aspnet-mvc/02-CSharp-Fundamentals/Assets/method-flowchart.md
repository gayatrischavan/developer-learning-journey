# Method Execution Flow

## Flowchart

```mermaid
flowchart TD

A[Program Starts] --> B[Main Method]

B --> C[Method Call]

C --> D[Control Transfers to Method]

D --> E[Method Executes Statements]

E --> F{Return Type?}

F -- Yes --> G[Return Value]

F -- No --> H[Finish Execution]

G --> I[Back to Caller]

H --> I

I --> J[Continue Remaining Code]

J --> K[Program Ends]
```

---

## Example

```csharp
static void Main()
{
    int result = Add(10, 20);

    Console.WriteLine(result);
}

static int Add(int a, int b)
{
    return a + b;
}
```

Execution Flow

```
Main()

↓

Add(10,20)

↓

30 Returned

↓

Console.WriteLine()

↓

Program Ends
```