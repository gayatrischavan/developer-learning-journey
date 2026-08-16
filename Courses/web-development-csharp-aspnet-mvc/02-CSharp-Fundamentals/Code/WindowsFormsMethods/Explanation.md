# Line by Line Explanation

## Example 1

```csharp
HideRadioButtons();
```

Purpose

Hide the GroupBox that contains radio buttons.

---

Inside Method

```csharp
groupBox1.Visible = false;
```

The control becomes invisible.

---

## Example 2

```csharp
ClearAllText();
```

Purpose

Clear all text boxes.

Inside

```csharp
textBox1.Clear();

textBox2.Clear();
```

---

## Example 3

```csharp
FillTextBox(textBox1.Text);
```

Flow

```
Textbox1

↓

Method Parameter

↓

Textbox2
```

Method

```csharp
public void FillTextBox(string text)
{
    textBox2.Text = text;
}
```

---

## Example 4

```csharp
SetNumber(23);
```

Method

```csharp
public void SetNumber(int age)
{
    label1.Text =
        "You are "
        + age
        + " years old.";
}
```

Result

```
You are 23 years old.
```

---

# Key Concepts

- Method Call
- Parameters
- UI Update
- Reusable Code