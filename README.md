# C# Programming - Arrays & Methods Lab

This repository showcases practical implementations of common programming logic in C#. It focuses on array processing techniques and the use of modern C# function features.

## 🛠 Features

### 1. Array Operations
- **Sum Calculation:** Efficiently calculating the total of array elements.
- **Duplicate Detection:** Logic to count the total number of duplicate elements within an integer array using nested iteration and state tracking.

### 2. Advanced Methods
- **Multiple Returns via `out`:** Implementation of a function `sumAndSub` that processes four parameters and returns both summation and subtraction results simultaneously using `out` keywords.

### 3. Input Handling
- Uses `int.TryParse` to ensure the application doesn't crash on invalid user input.
- Clear console management using `Console.Clear()`.

## 💻 Code Example: Multi-Value Return
```csharp
static void sumAndSub(int num1, int num2, int num3, int num4, out int sum, out int sub) {
    sum = num1 + num2 + num3 + num4;
    sub = num1 - num2 - num3 - num4;
}
