# 🧮 Windows Form Calculator - C# GUI Masterpiece

![Calculator Demo](calculator-demo.gif) *<!-- Replace with your actual GIF -->*

[![C# Version](https://img.shields.io/badge/C%23-.NET%204.7-blue.svg)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Yes!-brightgreen.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> **Your desktop calculation companion** - A feature-rich calculator built with C# and Windows Forms that combines elegant design with powerful functionality!

## ✨ Features

### � Basic Operations
| Button | Function | 
|--------|----------|
| ➕ | Addition |
| ➖ | Subtraction |
| ✖️ | Multiplication |
| ➗ | Division |
| 🟰 | Equals |

### 🔢 Advanced Functions
- **√** Square root
- **x²** Exponentiation
- **%** Percentage calculations
- **±** Toggle positive/negative
- **C/CE** Clear operations

### 🎨 GUI Highlights
- **Sleek numeric keypad** (0-9)
- **Memory functions** (M+, M-, MR, MC)
- **Backspace** for easy corrections
- **Responsive display** showing full operation
- **Windows-native feel** with modern touches

## 🖥️ Screenshot
![Calculator Interface](screenshot.png) *<!-- Add your screenshot -->*

## 🛠️ Installation

```bash
# Clone repository
git clone https://github.com/your-username/Windows-Form-Calculator.git

# Open in Visual Studio
start CalculatorSolution.sln
```

🧠 Behind the Scenes
🏗️ OOP Architecture
```csharp
public class CalculatorEngine
{
    public double Calculate(double firstNum, double secondNum, string op)
    {
        switch(op)
        {
            case "+": return firstNum + secondNum;
            case "-": return firstNum - secondNum;
            // ... other operations
        }
    }
}
```

🎨 GUI Design Principles
```csharp
// Creating a modern button
var btn = new Button() {
    Text = "7",
    Font = new Font("Segoe UI", 12),
    BackColor = Color.FromArgb(240, 240, 240),
    FlatStyle = FlatStyle.Flat
};
```
