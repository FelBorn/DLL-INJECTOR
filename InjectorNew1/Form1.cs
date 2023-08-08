using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace InjectorNew1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Process[] pc = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            comboBox1.Items.Clear();
            foreach (Process p in pc)
            {
                comboBox1.Items.Add(p.ProcessName);
            }
        }
        private static string? DLLPATH { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.InitialDirectory = @"C:\";
                OFD.Title = "Locate the DLL";
                OFD.DefaultExt = "dll";
                OFD.Filter = "DLL Files (*.dll)|*.dll";
                OFD.CheckFileExists = true;
                OFD.CheckPathExists = true;
                OFD.ShowDialog();

                textBox1.Text = OFD.FileName;
                DLLPATH = OFD.FileName;
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DLLPATH = textBox1.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process[] pc = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            comboBox1.Items.Clear();
            foreach (Process p in pc)
            {
                comboBox1.Items.Add(p.ProcessName);
            }
        }
        static readonly IntPtr INTPTR_ZERO = (IntPtr)0;
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress,
            IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        public static int INJECT(string processname, string DLLPATH)
        {
            if (!File.Exists(DLLPATH))
            {
                return (1);
            }
            uint _processid = 0;
            Process[] _processes = Process.GetProcesses();
            for (int i = 0; i < _processes.Length; i++)
            {
                if (_processes[i].ProcessName == processname)
                {
                    _processid = (uint)_processes[i].Id;
                }
            }
            if (_processid == 0)
            {
                return (2);
            }
            if (!ResetInject(_processid, DLLPATH))
            {
                return 3;
            }
            return 4;  //INJECT WORKED!
        }
        public static bool ResetInject(uint Process, string DLLPATH)
        {
            IntPtr handleprocess = OpenProcess((0x2 | 0x8 | 0x10 | 0x20 | 0x400), 1, Process);

            if (handleprocess == INTPTR_ZERO)
            {
                return false;
            }
            IntPtr IpAddress = VirtualAllocEx(handleprocess, (IntPtr)null, (IntPtr)DLLPATH.Length, (0x1000 | 0x2000), 0x40);
            if (IpAddress == INTPTR_ZERO)
            {
                return false;
            }
            byte[] _bytes = Encoding.ASCII.GetBytes(DLLPATH);
            if (WriteProcessMemory(handleprocess, IpAddress, _bytes, (uint)_bytes.Length, 0) == 0)
            {
                return false;
            }
            CloseHandle(handleprocess);
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Result = INJECT(comboBox1.Text, DLLPATH);
            if (Result == 1)
            {
                MessageBox.Show("File Does Not Exist!");
            }
            else if (Result == 2)
            {
                MessageBox.Show("Process Does Not Exist!");
            }
            else if (Result == 3)
            {
                MessageBox.Show("Injection Failed.");
            }
            else if (Result == 4)
            {
                MessageBox.Show("Injected!");
            }
        }
        public Point mouselocation { get; set; }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void move_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousepos = Control.MousePosition;
                mousepos.Offset(mouselocation.X, mouselocation.Y);
                Location = mousepos;
            }
        }
    }
}