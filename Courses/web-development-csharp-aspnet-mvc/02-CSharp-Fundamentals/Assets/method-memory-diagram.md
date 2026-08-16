# Method Memory Diagram

When a method is called, memory is allocated on the **Call Stack**.

```text
Before Calling Method

+----------------------+
| Main()               |
+----------------------+
```

Calling

```csharp
Add(10,20);
```

Memory

```text
+----------------------+
| Add()                |
| a = 10               |
| b = 20               |
+----------------------+
| Main()               |
+----------------------+
```

After Return

```text
+----------------------+
| Main()               |
+----------------------+
```

---

## Explanation

Each method gets

- Local Variables
- Parameters
- Temporary Memory

When the method finishes,

its stack frame is removed automatically.