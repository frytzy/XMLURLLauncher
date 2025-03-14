using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using Microsoft.Win32;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Get the directory of the executable
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = Path.Combine(exePath, "config.xml");

            // Check if the XML file exists
            if (!File.Exists(xmlPath))
            {
                Console.WriteLine("Config file not found.");
                return;
            }

            // Load and parse the XML file
            XDocument doc = XDocument.Load(xmlPath);
            string url = doc.Element("config")?.Element("url")?.Value;

            // Verify that a URL was found
            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("URL not found in config file.");
                return;
            }

            // Launch the URL with the default browser or Edge
            if (IsDefaultBrowserSet())
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else
            {
                LaunchWithEdge(url);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static bool IsDefaultBrowserSet()
    {
        // Check the registry for the default browser setting
        string userChoiceKey = @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";
        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(userChoiceKey))
        {
            if (key != null)
            {
                object progId = key.GetValue("ProgId");
                return progId != null && !string.IsNullOrEmpty(progId.ToString());
            }
            return false;
        }
    }

    static void LaunchWithEdge(string url)
    {
        try
        {
            // Launch the URL with Microsoft Edge
            Process.Start("msedge", url);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to launch Edge: " + ex.Message);
        }
    }
}