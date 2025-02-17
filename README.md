# BinaryStringAnalysis

This project is a simple C# console application that evaluates binary strings based on specific criteria.

## 📝 Task Description

The application checks whether a given binary string is **"good"** based on the following conditions:

1. The number of `0`s and `1`s in the string must be equal.
2. For every prefix of the string, the number of `1`s must be **greater than or equal** to the number of `0`s.

## 🚀 How to Run the Project

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/okanbisgin/BinaryStringAnalysis.git
cd BinaryStringAnalysis
```

### 2️⃣ Run the Application
```bash
dotnet run
```
This will prompt you to enter a binary string and check if it is **"good"** or **"not good"**.

---

## 📌 Example Usage
**Input:**  
```
Enter a binary string:
110011
```
**Output:**  
```
The binary string is not good.
```

---

## 💻 Code Implementation

The main function in `Program.cs`:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a binary string:");
        string binaryString = Console.ReadLine();

        if (IsGoodBinaryString(binaryString))
        {
            Console.WriteLine("The binary string is good.");
        }
        else
        {
            Console.WriteLine("The binary string is not good.");
        }
    }

    static bool IsGoodBinaryString(string binaryString)
    {
        int count0 = 0;
        int count1 = 0;

        // Check if the number of 0's and 1's are equal
        foreach (char c in binaryString)
        {
            if (c == '0') count0++;
            else if (c == '1') count1++;
        }

        if (count0 != count1) return false;

        // Check if for every prefix, the number of 1's is >= the number of 0's
        count0 = 0;
        count1 = 0;
        foreach (char c in binaryString)
        {
            if (c == '0') count0++;
            else if (c == '1') count1++;

            if (count1 < count0) return false;
        }

        return true;
    }
}
```

---

## 🔥 Features
✅ Checks if a binary string meets the required conditions.  
✅ Simple console-based input/output for user interaction.  
✅ Efficient algorithm to validate binary strings.  

---

## 📜 License
This project is open-source and available under the MIT License.

---
