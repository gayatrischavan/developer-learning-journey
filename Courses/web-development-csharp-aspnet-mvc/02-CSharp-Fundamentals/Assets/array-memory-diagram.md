# Array Memory Diagram

```text
Stack

numbers
   │
   ▼

Heap

Index

0     1     2     3

+-----+-----+-----+-----+

| 10 | 20 | 30 | 40 |

+-----+-----+-----+-----+
```

---

## Mermaid Diagram

```mermaid
flowchart LR

A[Array Variable]

-->

B[(Heap Memory)]

B --> C[10]

B --> D[20]

B --> E[30]

B --> F[40]
```