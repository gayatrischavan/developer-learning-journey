# Method Life Cycle

```mermaid
flowchart LR

A[Method Declared]
-->B[Method Called]

B-->C[Parameters Passed]

C-->D[Method Executes]

D-->E{Return Value?}

E--Yes-->F[Return Result]

E--No-->G[Return Control]

F-->H[Caller Continues]

G-->H
```

---

## Method Life Cycle

```
Declare Method

↓

Compile Program

↓

Call Method

↓

Pass Parameters

↓

Execute Statements

↓

Return Value (Optional)

↓

Back to Caller
```

---

## Important

A method **does not execute** until it is called.