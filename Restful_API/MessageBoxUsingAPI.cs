using System;
using System.Runtime.InteropServices;

class MessageBoxUsingAPI
{
    //import MessageBox function from user32.dll
    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)] 
    static extern int MessageBox(IntPtr hWhd, String text, String caption, int type);

    static void Main(string[] args)
    {
        MessageBox(IntPtr.Zero, "Hello,World!", "My message Box", 0);
        Console.ReadLine();
    }

  
}
