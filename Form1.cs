using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        int j = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            bool isnum = int.TryParse(textBox1.Text, out int n);
            if (isnum)
            {
                Console.WriteLine("Setting registry values");
                var proc = Process.Start("reg.exe", "add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v TaskbarAcrylicOpacity /t REG_DWORD /d " + n + " /f");
                proc.WaitForExit();
                var proc1 = Process.Start("reg.exe", "add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v EnableTransparency /t REG_DWORD /d 1 /f");
                proc1.WaitForExit();
                var proc2 = Process.Start("reg.exe", "add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v SystemUsesLightTheme /t REG_DWORD /d 0 /f");
                proc2.WaitForExit();
                var proc3 = Process.Start("reg.exe", "reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v ColorPrevalence /t REG_DWORD /d 0 /f");
                proc3.WaitForExit();
                foreach (var process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }
                Console.WriteLine("Completed");
            }
            else
            {
                Environment.Exit(-1);
            }    


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            Console.WriteLine("trackbar_scroll (onscroll event)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            Console.WriteLine("If you see this log console is working! (AllocatedConsole)");
            var handle = GetConsoleWindow();
            Console.WriteLine("got some handle ahh consolewindow idk");
            ShowWindow(handle, SW_HIDE);
            Console.WriteLine("i hide console window !!!!");
            UseImmersiveDarkMode(this.Handle, true);
            Console.WriteLine("I use immersivedark mode something");
            textBox1.Text = trackBar1.Value.ToString();
            Console.WriteLine("i SET TEXTBOX TEXT TO TRACKBAR VALUE");
            textBox1.SendToBack();
            Console.WriteLine("I sent textbox to back idk why");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked show console button");
            var handle = GetConsoleWindow();
            Console.WriteLine("got some handle ahh consolewindow idk");
            if (j == 0)
            {

                ShowWindow(handle, SW_SHOW);
                Console.WriteLine("I show console!");
                j = 1;
            }
            else
            {
                ShowWindow(handle, SW_HIDE);
                Console.WriteLine("I hide console!");
                j = 0;
            }

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
                Console.WriteLine("textBox1_LostFocus");
                bool isnum = int.TryParse(textBox1.Text, out int n);
                if (isnum)
                {
                    if (n > 255 || n < 0)
                    {
                        if (n > 255)
                        {
                            n = 255;
                            trackBar1.Value = n;
                            textBox1.Text = trackBar1.Value.ToString();
                        }
                        else
                        {
                            n = 0;
                            trackBar1.Value = n;
                            textBox1.Text = trackBar1.Value.ToString();
                        }

                    }
                    else
                    {
                        trackBar1.Value = n;
                    }

                }
                else
                {
                    textBox1.Text = trackBar1.Value.ToString();
                }
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("textBox1_MouseLeave");
            this.ActiveControl = null;
        }


        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }
    }
}
