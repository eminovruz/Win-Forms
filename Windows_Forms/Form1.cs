namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        private string? color = "red";

        public Form1()
        {
            InitializeComponent();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString();
        }

        private void btn_clickme_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                btn_clickme.BackColor = Color.Blue;
            }
            else if(e.Button == MouseButtons.Right)
            {
                btn_clickme.BackColor = Color.Red;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Cordinates.Text = e.X.ToString();
            Cordinates.Text += " : ";
            Cordinates.Text += e.Y.ToString();
        }

        private void Clock_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Clock_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (color == "red")
            {
                Buton.BackColor = Color.Blue;
                color = "blue";
            }
            else
            {
                Buton.BackColor = Color.Red;
                color = "red";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Label l = new Label
            {
                Text = "Dynamic added label",
                Location = new Point(200, 200),
                Size = new Size(50, 70),
                BackColor = Color.Green
            };




            Controls.Add(l);
        }
    }
}