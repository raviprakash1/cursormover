using Timer = System.Windows.Forms.Timer;

namespace CursorMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Do some stuff
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            label4.Text = Convert.ToChar(169) + "Jammer Tools";
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            
            // timer.Interval = 4 minutes
            int time = Convert.ToInt16(textBox1.Text);
            int x = Convert.ToInt16(textBox2.Text);
            int y = Convert.ToInt16(textBox3.Text);
            timer.Interval = (int)(TimeSpan.TicksPerSecond * time / TimeSpan.TicksPerMillisecond);
            timer.Tick += (sender, args) => { Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y); };
            timer.Start();
            button1.Text = "Running...";
            Hide();
            notifyIcon1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            timer.Stop();
            button1.Text = "Start Moving";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            Show();
            
        }


        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    //if the form is minimized  
        //    //hide it from the task bar  
        //    //and show the system tray icon (represented by the NotifyIcon control)  
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //        Hide();
        //        notifyIcon1.Visible = true;
        //    }
        //}

        
    }
}