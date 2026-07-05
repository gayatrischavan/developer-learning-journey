# Data Types Diagram

## Classification

```text
Data Types
│
├── Value Types
│   ├── byte
│   ├── short
│   ├── int
│   ├── long
│   ├── float
│   ├── double
│   ├── decimal
│   ├── char
│   └── bool
│
└── Reference Types
    ├── string
    ├── object
    ├── array
    ├── class
    └── interface
```

## Mermaid Diagram

```mermaid
graph TD

A[Data Types]

A --> B[Value Types]
A --> C[Reference Types]

B --> D[int]
B --> E[double]
B --> F[char]
B --> G[bool]

C --> H[string]
C --> I[array]
C --> J[class]
```
