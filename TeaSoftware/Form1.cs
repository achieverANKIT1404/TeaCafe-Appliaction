namespace TeaSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        int quantityTea = 1;

        int tea;
        private void button1_Click(object sender, EventArgs e)
        {
            String name = button1.Text;

            setN.Text = name;

            tea = quantityTea * 10;

            String price1 = tea.ToString();

            textBox1.Text = "10 " + "x " + quantityTea + " = " + tea+" Rs/-";

            quantityTea++;
        }

        int quantityElaichi = 1;

        int elaichi;
        private void button2_Click(object sender, EventArgs e)
        {
            String name1 = button2.Text;

            setN1.Text = name1;

            elaichi = quantityElaichi * 15;

            String price2 = elaichi.ToString();

            textBox2.Text = "15 " + "x " + quantityElaichi + " = " + elaichi + " Rs/-";

            quantityElaichi++;
        }

        int quantityChoclate = 1;

        int choclate;
        private void button3_Click(object sender, EventArgs e)
        {
            String name2 = button3.Text;

            setN2.Text = name2;

            choclate = quantityChoclate * 20;

            String price3 = choclate.ToString();

            textBox3.Text = "20 " + "x " + quantityChoclate + " = " + choclate + " Rs/-";

            quantityChoclate++;
        }

        int quantityMasala = 1;

        int masala;
        private void button4_Click_1(object sender, EventArgs e)
        {
            String name3 = button4.Text;

            setN3.Text = name3;

            masala = quantityMasala * 18;

            String price4 = masala.ToString();

            textBox4.Text = "18 " + "x " + quantityMasala + " = " + masala + " Rs/-";

            quantityMasala++;
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        int total;
        private void button5_Click(object sender, EventArgs e)
        {

            total = tea + elaichi + choclate + masala;

            String total1 = total.ToString();

            textBox5.Text = total1 + " Rs/-";
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = " ";
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            textBox2.Text = " ";
        }

        private void clear3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            textBox3.Text = " ";
        }

        private void clear4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();

            textBox4.Text = " ";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        Bitmap bitmap;
        private void printer_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;

            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}