# Using Timer Class - Code Examples

This folder contains practical examples related to **Using the Timer Class in C#**, matching [Notes/15-Using-Timer-Class.md](../../../Notes/15-Using-Timer-Class.md).

## Topic

**Using Timer Class**

## Learning Objectives

After completing these examples, you will be able to:

- Create a `Timer` and set its `Interval` (in milliseconds)
- Connect a Timer's `Tick` event to a handler method
- Start and stop a Timer with `Start()` / `Stop()`
- Build a counter that increases once per tick
- Update a `Label` on a Windows Form from inside a `Tick` handler
- Understand why Timer examples require a running Windows Forms application

## Files

| File                  | Description                                                                 |
| ---------------------- | ------------------------------------------------------------------------------ |
| Program.cs             | Application entry point (`Main`); starts the Windows Forms app via `Application.Run(new Form1())` |
| Form1.cs                | The live, working example: Timer + counter + Start/Stop buttons + Label     |
| TimerBasics.cs           | Reference: creating a Timer and setting `Interval`                          |
| TimerStartStop.cs        | Reference: `Start()` and `Stop()`                                           |
| TimerTick.cs              | Reference: connecting and understanding the `Tick` event                    |
| TimerCounter.cs           | Reference: the counter pattern (`counter++` inside `Tick`)                  |
| Output.md                 | Expected conceptual output/behavior                                          |

---

## Suggested Learning Order

```text
TimerBasics
    ↓
TimerStartStop
    ↓
TimerTick
    ↓
TimerCounter
    ↓
Form1
    ↓
Output
```

---

## Important Concepts

- Timer
- Interval (milliseconds)
- Start
- Stop
- Tick
- Event
- Counter
- Label update

`Interval` is measured in **milliseconds** (`1000` ≈ 1 second) and is approximate, not perfectly precise real-time timing.

---

## Windows Forms Dependency

`Timer` (`System.Windows.Forms.Timer`) is a **Windows Forms component**. These examples depend on being part of a Windows Forms project/context:

- `Program.cs` is the single application entry point (`Main`), matching the pattern used in `Code/WindowsFormsMethods/`. It starts the form via `Application.Run(new Form1())`.
- `Form1.cs` is the only file with the live, actually-ticking example — it requires a `Label` and two `Button` controls (Start/Stop) to exist on the form (added via the Windows Forms designer in Visual Studio, matching the convention already used in `Code/WindowsFormsMethods/Form1.cs`).
- `TimerBasics.cs`, `TimerStartStop.cs`, `TimerTick.cs`, and `TimerCounter.cs` are **reference/syntax examples only** — they compile and run safely, but their `Tick` events will not actually fire when called outside `Form1.cs`, because there is no Windows Forms message loop running in that context. They are not called from `Program.cs`, to avoid mixing Console and Windows Forms architectures.

---

## How to Run

1. Add this folder's files to a Windows Forms Application project (as `Code/WindowsFormsMethods/` already does).
2. Design `Form1` with a `Label` (`label1`) and two buttons (`button1` = Start, `button2` = Stop).
3. Set `Program.cs` as the startup file.
4. Run the project. Click **Start** to begin the counter, **Stop** to pause it.

---

## References

- Microsoft Learn - Windows Forms Timer Component
- C# Programming Guide
- Udemy Course Notes (Lecture 45: Using Timer Class)
