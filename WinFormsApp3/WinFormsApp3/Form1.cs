using System.Numerics;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arabalar = { "BMW", "Mercedes", "Audi" };
            listBox1.Items.AddRange(arabalar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.Text == "BMW")
                listBox2.Items.AddRange(new string[] { "M3", "M5", "X5" });
            else if (listBox1.Text == "Mercedes")
                listBox2.Items.AddRange(new string[] { "C180", "E200", "S500" });
            else if (listBox1.Text == "Audi")
                listBox2.Items.AddRange(new string[] { "A3", "A4", "A6" });
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if (listBox2.Text == "M3")
                listBox3.Items.AddRange(new string[] { "Comfort", "Sport", "Premium" });

            else if (listBox2.Text == "M5")
                listBox3.Items.AddRange(new string[] { "Comfort", "Competition", "Premium" });

            else if (listBox2.Text == "X5")
                listBox3.Items.AddRange(new string[] { "xLine", "M Sport", "Premium" });

            else if (listBox2.Text == "C180")
                listBox3.Items.AddRange(new string[] { "Style", "AMG", "Exclusive" });

            else if (listBox2.Text == "E200")
                listBox3.Items.AddRange(new string[] { "Avantgarde", "AMG", "Exclusive" });

            else if (listBox2.Text == "S500")
                listBox3.Items.AddRange(new string[] { "Luxury", "AMG", "Maybach" });

            else if (listBox2.Text == "A3")
                listBox3.Items.AddRange(new string[] { "Advanced", "S Line", "Black Edition" });

            else if (listBox2.Text == "A4")
                listBox3.Items.AddRange(new string[] { "Advanced", "S Line", "Black Edition" });

            else if (listBox2.Text == "A6")
                listBox3.Items.AddRange(new string[] { "Advanced", "S Line", "Black Edition" });
        }
    }
}
