using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using InterpackageReboot__.Properties;

namespace InterpackageReboot__
{
    public partial class formShowInterface : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public DateTime ReturnDatetime { get; set; }

        public formShowInterface()
        {
            InitializeComponent();
        }

        private void formShowInterface_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            comboHours.SelectedIndex = 0;
            comboMinutes.SelectedIndex = 0;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(radioRemind.Checked == false && radioDateTimePicker.Checked == false && radioNow.Checked == false)
            {
                MessageBox.Show("You must select an option!", "You must select an option", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                if (radioNow.Checked == true)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else if (radioRemind.Checked == true)
                {
                    var tempDateTime = DateTime.Now;
                    var hours = int.Parse(comboHours.SelectedItem.ToString());
                    var minutes = int.Parse(comboMinutes.SelectedItem.ToString());
                    ReturnDatetime = tempDateTime.AddHours(hours).AddMinutes(minutes);
                }
                else if (radioDateTimePicker.Checked == true)
                {
                    ReturnDatetime = dtpickerDate.Value.Date.Add(dtpTime.Value.TimeOfDay);
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }

                this.Close();
            }
            
        }

        private void comboHours_Click(object sender, EventArgs e)
        {
            radioRemind.Checked = true;
            radioDateTimePicker.Checked = false;
            radioNow.Checked = false;
        }

        private void dtpickerDate_ValueChanged(object sender, EventArgs e)
        {
            radioRemind.Checked = false;
            radioDateTimePicker.Checked = true;
            radioNow.Checked = false;
        }
    }

    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        bool promptForReminder = true;
        MenuItem menuitemRebootNow;
        DateTime rebootAtTime = new DateTime();
        DateTime CheckDateTime = DateTime.Now;

        public MyCustomApplicationContext()
        {

            menuitemRebootNow = new MenuItem("Reboot Now", Xit);


            trayIcon = new NotifyIcon()
            {
                Icon = Resources.rebootIcon,
                ContextMenu = new ContextMenu(new MenuItem[]{
                    menuitemRebootNow
                }),
                Visible = true
            };
            this.trayIcon.MouseClick += new MouseEventHandler(this.trayIcon_LeftMouseClick);
            Application.ApplicationExit += new EventHandler(this.OnExit);
            RebootAt();
        }

        void trayIcon_LeftMouseClick(object sender,MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                mi.Invoke(trayIcon, null);
            }
        }

        public void RebootAt()
        {
            
            while (1==1)
            {
                if (promptForReminder)
                {
                    var threadStart = new ThreadStart(StartTheShow);
                    var thread = new Thread(threadStart);
                    thread.IsBackground = true;
                    thread.Start();
                    while (thread.IsAlive)
                    {
                        Thread.Sleep(150);
                        Application.DoEvents();
                        if (promptForReminder)
                        {
                            thread.Abort();
                        }
                    }
                }                
            }
        }

        public void StartTheShow()
        {
            promptForReminder = false;
            rebootAtTime = showInterface();
            var DTNow = DateTime.Now;
            while (DTNow < rebootAtTime)
            {
                DTNow = DateTime.Now;
                Thread.Sleep(100);
            }
            promptForReminder = true;
        }

        DateTime showInterface()
        {
            var intf = new formShowInterface();
            var diaResult= intf.ShowDialog();
            while(diaResult != DialogResult.OK)
            {
                if(diaResult == DialogResult.Yes)
                {
                    Xit(this, null);
                }
                diaResult = intf.ShowDialog();
            }
            return intf.ReturnDatetime;
        }

        void OnExit(object sender,EventArgs e)
        {
            trayIcon.Visible = false;
        }

        void Xit(object sender, EventArgs e)
        {
            MessageBox.Show("Your computer will reboot after this window is closed. Please make sure all your documents are saved!" + Environment.NewLine + Environment.NewLine +
                                    "Press OK to restart your computer", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            OnExit(this, null);
            Environment.Exit(0);
        }
    }
}