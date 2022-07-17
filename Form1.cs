namespace Text_Spammer_V2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label1.Text = "SPEED:" + " " + trackBar1.Value + " " + "ms";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;        
            richTextBox1.ForeColor = Color.Black;       
            timer1.Start();           
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            richTextBox1.Enabled = true;
            richTextBox1.ForeColor = Color.Yellow;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            label1.Text = "SPEED:" + " " + "500" + " " + "ms";
            trackBar1.Value = 500;            

        }
    }
}