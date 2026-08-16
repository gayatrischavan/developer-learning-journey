# Using the Random Class in C#

> **Module:** 02 - C# Fundamentals  
> **Topic:** `Random`  
> **Difficulty:** 🟡 Beginner

---

# 1. What is the `Random` Class?

`Random` is a built-in C# class (from the `System` namespace) used to generate **pseudo-random** numbers — numbers that appear random but are actually produced by a deterministic algorithm based on an internal starting value (a *seed*).

For everyday beginner programs (dice rolls, random selections, sample data, simple games), this is exactly what "random" means in practice.

```csharp
Random random = new Random();
```

---

# 2. Why do we use `Random`?

`Random` is useful whenever a program needs unpredictable-looking values, for example:

- ✅ Simulating dice rolls or coin tosses
- ✅ Picking a random item from a list
- ✅ Generating sample/test data
- ✅ Adding variety to simple games
- ✅ Generating basic random strings for learning exercises

---

# 3. Creating a `Random` Object

Before generating any random values, a `Random` object must be created.

```csharp
Random random = new Random();
```

## Explanation

- `Random` is the class (blueprint).
- `random` is the object/variable used to call its methods.
- Once created, the same `random` object can be reused to generate many different values — there is no need to create a new `Random` object every time a value is needed.

```csharp
int a = random.Next();
int b = random.Next();
```

`a` and `b` will normally be different values, because each call to `Next()` advances the internal sequence.

---

# 4. `Next()` Method

`Next()` returns a **non-negative** pseudo-random integer.

```csharp
Random random = new Random();

int number = random.Next();
Console.WriteLine(number);
```

The exact value printed changes every time the program runs — it is not a fixed number, and it should never be hardcoded or assumed in advance.

---

# 5. `Next(min, max)` Method

`Next(min, max)` returns a pseudo-random integer within a specific range.

```csharp
int number = random.Next(1, 10);
```

---

# 6. Understanding the `min` and `max` Parameters

```text
min = inclusive
max = exclusive
```

- `min` **can** be returned.
- `max` **cannot** be returned.

---

# 7. Important: Maximum Value Is Exclusive

```csharp
random.Next(1, 10);
```

This can produce any integer from `1` to `9` — it will **never** produce `10`.

```text
random.Next(1, 10)  → possible: 1, 2, 3, 4, 5, 6, 7, 8, 9
random.Next(1, 10)  → NOT possible: 10
```

More examples:

```csharp
random.Next(0, 2);   // possible: 0, 1        (never 2)
random.Next(1, 7);   // possible: 1, 2, 3, 4, 5, 6   (never 7 — useful for a dice roll)
random.Next(5, 6);   // always produces 5     (never 6)
```

This is one of the most important rules to remember when using `Next(min, max)`.

---

# 8. `NextDouble()` Method

`NextDouble()` returns a pseudo-random floating-point number of type `double`.

```csharp
double value = random.NextDouble();
Console.WriteLine(value);
```

---

# 9. Understanding the Range of `NextDouble()`

```text
0.0 <= value < 1.0
```

- The value **can** be `0.0`.
- The value **cannot** be `1.0`.

To scale this into a different range, multiply the result:

```csharp
double value = random.NextDouble() * 100;
```

This produces a value greater than or equal to `0.0` and less than `100.0` — the same inclusive/exclusive rule still applies, just scaled up.

---

# 10. `NextBytes()` Method

A **byte** is a small unit of data that can hold a whole number from `0` to `255`. `NextBytes()` fills an existing array of bytes with pseudo-random values.

```csharp
byte[] bytes = new byte[5];
random.NextBytes(bytes);
```

---

# 11. Generating Random Bytes

```csharp
byte[] bytes = new byte[5];
random.NextBytes(bytes);

foreach (byte b in bytes)
{
    Console.WriteLine(b);
}
```

## Explanation

- `bytes` is created first as an empty array of 5 slots — `NextBytes()` does not create the array itself.
- `NextBytes(bytes)` **modifies the array that is passed in**, filling every slot with a random value from `0` to `255`.
- The exact numbers printed will differ every time the program runs.

---

# 12. Generating Random Characters

A random character can be picked by generating a random **index** into a string of possible characters.

```csharp
string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

int index = random.Next(0, characters.Length);
char character = characters[index];

Console.WriteLine(character);
```

`Next(0, characters.Length)` is used deliberately — `characters.Length` is exclusive, so the generated index always stays within valid bounds for the string (`0` to `characters.Length - 1`).

---

# 13. Generating a Random String

Repeating the same idea in a loop builds up a random string, one character at a time.

```csharp
string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string result = "";

for (int i = 0; i < 5; i++)
{
    int index = random.Next(0, characters.Length);
    result += characters[index];
}

Console.WriteLine(result); // Example: "QPZLK"
```

---

# 14. Generating a Simple Random Password

> ⚠️ **Learning example only.** This technique is for practicing `Random` and string building — it is **not** suitable for real authentication, security tokens, or production password generation. Security-sensitive password/token generation should use a proper cryptographic API (such as `System.Security.Cryptography`), not ordinary `System.Random`. Cryptography itself is outside the scope of this lecture.

```csharp
string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
string password = "";

for (int i = 0; i < 8; i++)
{
    int index = random.Next(0, characters.Length);
    password += characters[index];
}

Console.WriteLine(password); // Example: "aZ3kLpQ9"
```

This combines uppercase letters, lowercase letters, and digits using the same index-based technique from the previous section.

---

# 15. Complete Random Class Example

```csharp
Random random = new Random();

// Generate an integer
int number = random.Next();
Console.WriteLine($"Random Number       : {number}");

// Generate an integer in a range (max is exclusive)
int diceRoll = random.Next(1, 7);
Console.WriteLine($"Dice Roll (1-6)      : {diceRoll}");

// Generate a double (0.0 <= value < 1.0)
double value = random.NextDouble();
Console.WriteLine($"Random Double        : {value}");

// Generate random bytes
byte[] bytes = new byte[5];
random.NextBytes(bytes);
Console.Write("Random Bytes         : ");
foreach (byte b in bytes)
{
    Console.Write($"{b} ");
}
Console.WriteLine();

// Generate a random string
string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string randomString = "";
for (int i = 0; i < 5; i++)
{
    int index = random.Next(0, characters.Length);
    randomString += characters[index];
}
Console.WriteLine($"Random String        : {randomString}");
```

This single example ties together `Next()`, `Next(min, max)`, `NextDouble()`, `NextBytes()`, and index-based random string generation using one shared `Random` object.

---

# 16. Common Beginner Mistakes

❌ Forgetting to create the `Random` object

```csharp
Random random;
int number = random.Next(); // error: object was never created with "new"
```

✔ Correct

```csharp
Random random = new Random();
int number = random.Next();
```

---

❌ Confusing `Next()` with `Next(min, max)`

```csharp
random.Next();       // any non-negative integer
random.Next(1, 10);  // integer restricted to a specific range
```

These are two different overloads with very different behavior — always check which one is being used.

---

❌ Assuming the maximum value is inclusive

```csharp
random.Next(1, 10); // WRONG assumption: this can return 10
```

✔ Correct understanding

```text
random.Next(1, 10) can return 1 through 9 only. It never returns 10.
```

---

❌ Assuming random output is predictable or fixed

```csharp
int number = random.Next(1, 10);
Console.WriteLine(number); // WRONG: do not assume this always prints the same value
```

The output changes on every run — never hardcode an expected result.

---

❌ Treating `NextDouble()` as including `1.0`

```csharp
double value = random.NextDouble(); // WRONG assumption: this can be exactly 1.0
```

✔ Correct understanding

```text
0.0 <= value < 1.0   (1.0 is never returned)
```

---

❌ Forgetting that `NextBytes()` modifies the provided array

```csharp
byte[] bytes = new byte[5];
byte[] result = random.NextBytes(bytes); // wrong: NextBytes() returns void
```

✔ Correct

```csharp
byte[] bytes = new byte[5];
random.NextBytes(bytes); // "bytes" itself is filled in place
```

---

❌ Creating unnecessarily complicated random-string code

Beginners often overcomplicate character selection. The simple, readable approach is enough:

```csharp
int index = random.Next(0, characters.Length);
char character = characters[index];
```

---

# 17. Key Takeaways

- `Random` generates pseudo-random values using an internal algorithm, not true randomness.
- Create one `Random` object with `new Random()` and reuse it for multiple calls.
- `Next()` returns any non-negative integer.
- `Next(min, max)` returns an integer where `min` is inclusive and `max` is exclusive.
- `NextDouble()` returns a value where `0.0` is inclusive and `1.0` is exclusive.
- `NextBytes(array)` fills an existing byte array in place; it does not return a new array.
- Random characters/strings can be built by using `Next(min, max)` to pick indexes from a string of allowed characters.
- The random password example in this lecture is for learning purposes only, not for real security use.

---

# Quick Revision

- Create: `Random random = new Random();`
- Any non-negative integer: `random.Next();`
- Integer in a range: `random.Next(min, max);` → `min` inclusive, `max` exclusive.
- Double between 0 and 1: `random.NextDouble();` → `0.0` inclusive, `1.0` exclusive.
- Scale a double: `random.NextDouble() * 100;`
- Fill a byte array: `random.NextBytes(bytes);`
- Random character: `characters[random.Next(0, characters.Length)];`
- Random string: loop the character-selection technique and append to a string.
- Random "password" example: educational only — not cryptographically secure.

---

# Practice Questions

## Easy

1. How do you create a `Random` object in C#?
2. What kind of value does `random.Next()` return?
3. What is the difference between `min` and `max` when calling `random.Next(min, max)`?
4. What is the possible range of values returned by `random.NextDouble()`?
5. What does `random.NextBytes(bytes)` do to the `bytes` array?

## Medium

6. Write code to simulate a single dice roll (a random number from 1 to 6).
7. Write code to generate one random uppercase letter using `Next()` and a character string.
8. Write code to generate a random string of 6 characters.
9. Write a simple learning-only random password generator that uses uppercase letters, lowercase letters, and numbers.
10. Write one small program that uses `Next()`, `Next(min, max)`, and `NextDouble()` together, using the same `Random` object for all three calls.
