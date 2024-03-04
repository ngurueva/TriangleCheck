namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sideA.Text = Properties.Settings.Default.a.ToString();
            sideB.Text = Properties.Settings.Default.b.ToString();
            sideC.Text = Properties.Settings.Default.c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            
            try { 
                a = double.Parse(this.sideA.Text);
                b = double.Parse(this.sideB.Text);
                c = double.Parse(this.sideC.Text);
            }
            catch(FormatException)
            {
                return; 
            }


            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save();


            MessageBox.Show(Logic.Compare(a, b, c));
        }
    }
    public class Logic
    {
        public static string Compare(double a, double b, double c)
        {
            string m = "";
            if ((a > b + c) || (b > a + c) || (c > a + b))
                m = "Треугольник не существует";
            else
            {
                if (a > b && a > b)
                {
                    if (a * a == b * b + c * c)
                        m = "Треугольник прямоугольный";
                    else
                        m = "Треугольник не прямоугольный";
                }

                else if (b > a && b > c)
                {
                    if (b * b == a * a + c * c)
                        m = "Треугольник прямоугольный";
                    else
                        m = "Треугольник не прямоугольный";
                }

                else if (c > a && c > b)
                {
                    if (c * c == b * b + a * a)
                        m = "Треугольник прямоугольный";
                    else
                        m = "Треугольник не прямоугольный";
                }
            }
            return m;
        }
    }
}
