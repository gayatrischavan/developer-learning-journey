# Output

## Timer Counter Example (Form1.cs)

`Interval = 1000` ms ≈ 1 second between ticks. This is approximate, not an exact real-time guarantee.

Initial:

```
0
```

After first Tick (~1 second after Start):

```
1
```

After second Tick (~2 seconds after Start):

```
2
```

After third Tick (~3 seconds after Start):

```
3
```

... and so on, once per interval, for as long as the Timer keeps running.

---

## Start / Stop Behavior

```
Click Start -> Counter begins increasing, once per tick
Click Stop  -> Counter stops increasing (keeps its last value)
Click Start again -> Counter resumes increasing from where it left off (not reset)
```

---

## Reference Files (TimerBasics.cs, TimerStartStop.cs, TimerTick.cs, TimerCounter.cs)

These files print to the console (visible only if run in a console-attached context) to illustrate the syntax in isolation:

```
Timer created.
Interval set to 1000 ms (~1 second).

Timer started - it will tick every Interval while running.
Timer stopped - ticking has been halted.

Tick event connected to timer_Tick().

Counter demo configured.
See Form1.cs for the live, ticking version with a Label.
```

Note: calling `Demo()` in these reference files does not actually produce ticking output, because no Windows Forms message loop is running in that context. The live, ticking behavior only happens inside `Form1.cs` while the application is running (`Program.cs` → `Application.Run(new Form1())`).
