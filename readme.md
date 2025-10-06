# XmlUrlLauncher

A simple C# Windows application that reads a URL from an XML configuration file and opens it in the default browser. If no default browser is set, it falls back to Microsoft Edge.

## Requirements

- **Windows 10/11** (Edge is included by default)
- **.NET Framework 4.8** (already installed on Windows 10/11)
- A `config.xml` file in the same directory as the executable

## Setup

### Clone the Repository

```bash
git clone https://github.com/frytzy/XmlUrlLauncher.git
cd XmlUrlLauncher
```

### Build Options

#### Option 1: Using Built-in CSC Compiler (No SDK Required)

Windows includes a C# compiler. Compile directly without installing anything:

```powershell
# Navigate to project directory
cd C:\URLLauncher

# Find and use the built-in compiler
$csc = Get-ChildItem "C:\Windows\Microsoft.NET\Framework*\v4*\csc.exe" -Recurse -ErrorAction SilentlyContinue | Select-Object -Last 1 -ExpandProperty FullName
& $csc /target:winexe /out:URLLauncher.exe URLLauncher.cs
```

#### Option 2: Using .NET SDK (If Installed)

If you have the .NET SDK installed:

```bash
dotnet build -c Release
```

Or publish as a standalone executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

## Configuration

Create a `config.xml` file in the same directory as `URLLauncher.exe`:

```xml
<Configuration>
    <URL>https://www.example.com/</URL>
</Configuration>
```

**Important:** 
- The `<URL>` tag must be capitalized
- Both `config.xml` and `URLLauncher.exe` must be in the same folder

## Usage

1. Place `config.xml` and `URLLauncher.exe` in the same directory
2. Run `URLLauncher.exe`
3. The URL will open in your default browser (or Edge if no default is set)

## How It Works

1. Reads the URL from `config.xml` in the executable's directory
2. Attempts to open the URL using the system's default browser
3. If the default browser fails, automatically falls back to Microsoft Edge
4. Displays error messages if configuration issues are detected

## Notes

- This is a Windows-only application
- No console window appears when running (compiled as WinExe)
- Edge is guaranteed to be available on Windows 10/11 as a fallback
- The application uses .NET Framework 4.8 for maximum compatibility

## License

This project is licensed under the MIT License.

```
MIT License

Copyright (c) 2025 frytzy

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
