# Variable Life Cycle

## Flow

```mermaid
flowchart TD

A[Declare Variable]
B[Allocate Memory]
C[Initialize Variable]
D[Use Variable]
E[Modify Value]
F[Program Ends]
G[Memory Released]

A --> B
B --> C
C --> D
D --> E
E --> D
D --> F
F --> G
```

---

## Steps

1. Declare the variable.
2. Memory is allocated.
3. Initial value is assigned.
4. Variable is used in the program.
5. Value may change.
6. Program terminates.
7. Memory is released.
