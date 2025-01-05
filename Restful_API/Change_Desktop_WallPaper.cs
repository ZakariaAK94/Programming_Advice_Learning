using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ChangeDesktopWellPaper
{
    internal class Program
    {
        // Import the SystemParametersInfo function from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool SystemParametersInfo(uint uAction, uint uParam, string lpvParam, uint fWinIni);

        // Constants for the function
        public static readonly uint SPI_SETDESKWALLPAPER = 0x14;
        public static readonly uint SPIF_UPDATEINIFILE = 0x01;
        public static readonly uint SPIF_SENDCHANGE = 0x02;

        static void Main(string[] args)
        {
            // The path to the wallpaper image
            string wallpaperPath = @"C:\pics\ocean_horizon_sunset.jpg"; // Replace with your wallpaper path
           // SystemParametersInfo(0x0014, 0, wallpaperPath, 0x02); // SPI_SETDESKWALLPAPER, 0x14 = 20 in decimal is a number
           // that indicate to change desktop picture
            SystemParametersInfo(SPI_SETDESKWALLPAPER, SPIF_UPDATEINIFILE, wallpaperPath, SPIF_SENDCHANGE);
            Console.WriteLine("Desktop wallpaper change successfully");
            Console.ReadLine();
        }
    }
}
