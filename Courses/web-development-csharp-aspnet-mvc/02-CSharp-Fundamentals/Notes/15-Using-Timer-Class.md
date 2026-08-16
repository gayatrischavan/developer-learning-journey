# Using the Timer Class in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** `Timer` (Windows Forms)  
> **Difficulty:** 🟡 Beginner

---

# 1. What is a Timer?

A **Timer** is a component that repeatedly runs a piece of code after a set amount of time keeps passing, without the program needing to constantly check the clock itself.

In this lecture, `Timer` refers to `System.Windows.Forms.Timer` — the Timer component used inside Windows Forms applications.

```csharp
Timer timer = new Timer();
```

---

# 2. Why do we use a Timer?

A Timer is useful whenever something needs to happen repeatedly, at a regular pace, without manual triggering — for example:

- ✅ Updating a counter or clock display
- ✅ Refreshing data on a form periodically
- ✅ Creating simple countdowns
- ✅ Triggering repeated actions in small games or animations

---

# 3. Timer in Windows Forms

`Timer` is a Windows Forms component, so it is normally used inside a `Form` alongside other controls such as `Label` and `Button`. It runs on the same thread as the form and relies on the form's message loop to fire its events — this is why a working, ticking Timer example needs an actual running Windows Forms application (see `Form1.cs`), not a plain console program.

---

# 4. Creating a Timer

```csharp
Timer timer = new Timer();
```

## Explanation

- `Timer` is the class.
- `timer` is the object used to configure and control it (setting `Interval`, calling `Start()`/`Stop()`, connecting `Tick`).
- Creating a Timer does not start it — it must be explicitly started with `Start()`.

---

# 5. Timer `Interval`

`Interval` controls how much time passes between each `Tick` event.

```csharp
timer.Interval = 1000;
```

---

# 6. Understanding Milliseconds

`Interval` is measured in **milliseconds**, not seconds.

```text
500 ms  = 0.5 second
1000 ms = 1 second
2000 ms = 2 seconds
```

So `timer.Interval = 1000;` means the Timer will tick approximately once every second.

`Timer` intervals are **not perfectly precise like a real-time clock** — actual timing can vary slightly depending on system load and how busy the application's message loop is. For beginner purposes, it should be treated as "approximately" the configured interval, not an exact guarantee.

---

# 7. `Start()`

`Start()` begins the Timer. Once started, it will fire the `Tick` event repeatedly, once per `Interval`, until it is stopped.

```csharp
timer.Start();
```

---

# 8. `Stop()`

`Stop()` halts the Timer. No further `Tick` events will fire until `Start()` is called again.

```csharp
timer.Stop();
```

## `Start()` vs `Stop()`

| `Start()` | `Stop()` |
| --- | --- |
| Begins ticking at the configured `Interval` | Halts ticking immediately |
| `Tick` event begins firing repeatedly | `Tick` event stops firing |
| Used when the repeating action should begin | Used when the repeating action should pause/end |

Calling `Start()` on an already-running Timer, or `Stop()` on an already-stopped Timer, does not cause an error — it simply has no additional effect.

---

# 9. `Tick` Event

The `Tick` event occurs repeatedly, according to the Timer's configured `Interval`, for as long as the Timer is running.

```csharp
private void timer_Tick(object sender, EventArgs e)
{
    // code executed on each tick
}
```

---

# 10. Connecting Timer to the Tick Event

Before `Tick` can do anything, the Timer must be connected to a handler method.

```csharp
Timer timer = new Timer();
timer.Interval = 1000;
timer.Tick += timer_Tick;
```

`timer.Tick += timer_Tick;` tells the Timer: "every time you tick, run this method."

---

# 11. What happens every Tick?

```text
Timer Created
     ↓
Interval Set
     ↓
Tick Event Connected
     ↓
Start()
     ↓
Wait for Interval
     ↓
Tick Event Fires
     ↓
Execute Code
     ↓
Wait Again
     ↓
Next Tick
```

This repeats continuously until `Stop()` is called (or the form closes).

---

# 12. Creating a Counter with Timer

A very common beginner pattern: increase a counter by 1 on every tick.

```text
Timer
 ↓
Tick
 ↓
counter++
 ↓
Label.Text
 ↓
Repeat
```

```csharp
private int counter = 0;

private void timer_Tick(object sender, EventArgs e)
{
    counter++;
    label1.Text = counter.ToString();
}
```

The `counter` variable is declared **outside** the `Tick` handler (as a class-level field), so its value is preserved between ticks. Only the increment (`counter++`) happens inside `Tick`.

---

# 13. Updating a Label using Timer

Since `Timer` is a Windows Forms component, it is commonly paired with a `Label` to show live-updating text on screen.

```csharp
label1.Text = counter.ToString();
```

Every time `Tick` fires, the label's text is refreshed with the current counter value, so the user sees the number increase on the form in real time.

---

# 14. Starting and Stopping Timer

In a typical form, two buttons control the Timer:

```csharp
private void button1_Click(object sender, EventArgs e) // Start button
{
    timer.Start();
}

private void button2_Click(object sender, EventArgs e) // Stop button
{
    timer.Stop();
}
```

Clicking **Start** begins the counter increasing once per interval; clicking **Stop** freezes it at its current value. Clicking **Start** again resumes counting from where it left off (the counter is not reset, because `counter` is not reinitialized inside `Tick` or the button handlers).

---

# 15. Complete Timer Example

```csharp
public partial class Form1 : Form
{
    private Timer timer;
    private int counter = 0;

    public Form1()
    {
        InitializeComponent();

        timer = new Timer();
        timer.Interval = 1000;       // ~1 second
        timer.Tick += timer_Tick;    // connect the Tick event
    }

    private void button1_Click(object sender, EventArgs e) // Start
    {
        timer.Start();
    }

    private void button2_Click(object sender, EventArgs e) // Stop
    {
        timer.Stop();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        counter++;
        label1.Text = counter.ToString();
    }
}
```

This ties together creating the Timer, setting `Interval`, connecting `Tick`, and controlling it with `Start()`/`Stop()`, while updating a `Label` on every tick.

---

# 16. Timer Lifecycle

```text
Create Timer
     ↓
Set Interval
     ↓
Connect Tick Event
     ↓
Start Timer
     ↓
Timer Running
     ↓
Tick
     ↓
Execute Code
     ↓
Repeat
     ↓
Stop Timer
```

A Timer can be started and stopped multiple times during a form's lifetime — it is not a one-time-use object.

---

# 17. Common Beginner Mistakes

❌ Forgetting to set `Interval`

```csharp
Timer timer = new Timer();
timer.Start(); // ticks using the default Interval, which may not be what was intended
```

✔ Correct

```csharp
Timer timer = new Timer();
timer.Interval = 1000;
timer.Start();
```

---

❌ Forgetting to call `Start()`

```csharp
Timer timer = new Timer();
timer.Interval = 1000;
timer.Tick += timer_Tick; // configured, but never actually starts ticking
```

---

❌ Forgetting to connect the `Tick` event

```csharp
timer.Interval = 1000;
timer.Start(); // runs, but nothing happens because no handler is connected
```

---

❌ Putting the counter initialization inside `Tick`

```csharp
private void timer_Tick(object sender, EventArgs e)
{
    int counter = 0; // WRONG: resets to 0 on every single tick
    counter++;
    label1.Text = counter.ToString(); // will always show "1"
}
```

✔ Correct: declare `counter` outside `Tick`, as shown in section 12.

---

❌ Calling `Start()` repeatedly and unnecessarily

```csharp
timer.Start();
timer.Start(); // has no additional effect - the timer is already running
```

---

❌ Forgetting to call `Stop()`

Leaving a Timer running when it is no longer needed keeps triggering `Tick` unnecessarily.

---

❌ Confusing milliseconds with seconds

```csharp
timer.Interval = 1; // WRONG assumption: this is NOT 1 second, it is 1 millisecond
```

✔ Correct

```csharp
timer.Interval = 1000; // 1000 milliseconds = 1 second
```

---

❌ Expecting perfect real-time precision

```text
WRONG assumption: Interval = 1000 guarantees a tick at EXACTLY every 1.000 second, with no variation.
```

✔ Correct understanding: `Interval` is approximate — actual timing can vary slightly depending on system load.

---

# 18. Key Takeaways

- `Timer` (`System.Windows.Forms.Timer`) repeatedly runs code at a set interval, without manual triggering.
- `Interval` is measured in milliseconds, not seconds (`1000` ≈ 1 second).
- `Start()` begins ticking; `Stop()` halts it; both can be called multiple times over the Timer's lifetime.
- `Tick` is the event that fires once per interval while the Timer is running, and it must be explicitly connected with `+=`.
- A counter used inside `Tick` must be declared outside the handler so its value survives between ticks.
- `Timer` intervals are approximate, not perfectly precise.
- Timer examples depend on a running Windows Forms application — they will not tick in a plain console program with no message loop.

---

# Quick Revision

- Create: `Timer timer = new Timer();`
- Set interval (ms): `timer.Interval = 1000;` → ~1 second
- Connect Tick: `timer.Tick += timer_Tick;`
- Start: `timer.Start();`
- Stop: `timer.Stop();`
- Tick handler: `private void timer_Tick(object sender, EventArgs e) { ... }`
- Counter pattern: declare `counter` outside `Tick`, do `counter++;` and `label1.Text = counter.ToString();` inside `Tick`.
- `Interval` is approximate, never guaranteed to the millisecond.

---

# Practice Questions

## Easy

1. What does the `Interval` property control, and in what unit is it measured?
2. How do you create a `Timer` object?
3. What is the difference between `Start()` and `Stop()`?
4. What is the `Tick` event, and when does it fire?
5. Write the code to connect a Timer's `Tick` event to a method named `timer_Tick`.

## Medium

6. Why must a counter variable be declared outside the `Tick` event handler instead of inside it?
7. What would happen if `timer.Interval` was never set before calling `Start()`?
8. What would happen if `Start()` was called but the `Tick` event was never connected?
9. Describe, step by step, what happens from the moment a Timer is created to the moment its first `Tick` fires.
10. Why does a Timer example need to run inside an actual Windows Forms application instead of a plain console program?
