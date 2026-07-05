# Matrix Memory Diagram

```text
Stack

matrix
   │
   ▼

Heap

      Column

      0     1     2

    +-----+-----+-----+

0   | 10 | 20 | 30 |

    +-----+-----+-----+

1   | 40 | 50 | 60 |

    +-----+-----+-----+

2   | 70 | 80 | 90 |

    +-----+-----+-----+
```

```mermaid
graph TD

A[Matrix Variable]

A --> B[(Heap Memory)]

B --> C[10]
B --> D[20]
B --> E[30]
B --> F[40]
B --> G[50]
B --> H[60]
B --> I[70]
B --> J[80]
B --> K[90]
```