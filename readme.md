
            Start editing…# XmlUrlLauncher
This is a simple C# console Windows-only application that reads a URL from an XML file (config.xml) and opens it in the default browser. If no default browser is set, it falls back to Microsoft Edge.
## Requirements

.NET 8 runtime: Ensure it’s installed on your machine. Download it from [here](https://dotnet.microsoft.com/download/dotnet/8.0" target="_blank" rel="noopener noreferrer) if needed.
A config.xml file in the same directory as the executable.

## Setup

Clone the repository:
bashCollapseWrapCopygit clone https://github.com/frytzy/XmlUrlLauncher.git

Navigate to the project directory:
bashCollapseWrapCopycd XmlUrlLauncher

Build the project using the .NET CLI:
bashCollapseWrapCopydotnet build

(Optional) Publish the project for a specific runtime (e.g., Windows 64-bit):
bashCollapseWrapCopydotnet publish -c Release -r win-x64 --self-contained false


## Usage

Create a config.xml file in the same directory as the executable with this format:
xmlCollapseWrapCopy&lt;config&gt;
    &lt;url&gt;https://example.com&lt;/url&gt;
&lt;/config&gt;

"Copy this as raw XML without the encoded characters."

Run the application:

If you built it, go to the build output directory and run:
bashCollapseWrapCopydotnet XmlUrlLauncher.dll

If you published it, run the executable directly:
bashCollapseWrapCopy./XmlUrlLauncher.exe




## Notes

The application checks the Windows registry for a default browser.
If no default browser is found, it uses Microsoft Edge as a fallback.
Ensure config.xml is correctly formatted and placed in the executable’s directory.
This project is compatible with Windows 11.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE" target="_blank" rel="noopener noreferrer) file for details.
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