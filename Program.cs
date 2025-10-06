using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Get the directory where the executable is located
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = Path.Combine(exeDir, "config.xml");
            
            // Check if config file exists
            if (!File.Exists(xmlPath))
            {
                Console.WriteLine("Error: config.xml not found at " + xmlPath);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
            
            // Read URL from XML
            XDocument config = XDocument.Load(xmlPath);
            XElement urlElement = config.Root.Element("URL");
            string url = urlElement != null ? urlElement.Value : null;
            
            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("Error: URL not found in config.xml");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
            
            // Try to open with default browser
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                // Fallback to Edge
                Process.Start("msedge", url);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

