namespace Project_Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operand = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "|")
                result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "|";

        }

        private void opeartor_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operand = button.Text;

            resultValue = double.Parse(result.Text);
            isOperationPerformed = true;
            result.Clear();

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case "+":
                    result.Text = (resultValue + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (resultValue - double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (resultValue * double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (resultValue / double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }

        }

        private void btntheme2_Click(object sender, EventArgs e)
        {
            btnDRG.BackColor = Color.RoyalBlue;
            btnlog.BackColor = Color.RoyalBlue;
            btnln.BackColor = Color.RoyalBlue;
            btnoff.BackColor = Color.RoyalBlue;
            btnhyp.BackColor = Color.RoyalBlue;
            btnsin.BackColor = Color.RoyalBlue;
            btncos.BackColor = Color.RoyalBlue;
            btntan.BackColor = Color.RoyalBlue;
            btnpie.BackColor = Color.RoyalBlue;
            btn1byx.BackColor = Color.RoyalBlue;
            btnsqroot.BackColor = Color.RoyalBlue;
            btnsquare.BackColor = Color.RoyalBlue;
            btnsumenation.BackColor = Color.RoyalBlue;
            btnEE.BackColor = Color.RoyalBlue;
            btnclose.BackColor = Color.RoyalBlue;
            btnopen.BackColor = Color.RoyalBlue;
            btnsto.BackColor = Color.RoyalBlue;
            btnRCL.BackColor = Color.RoyalBlue;
            btnENG.BackColor = Color.RoyalBlue;
            btnarrow.BackColor = Color.RoyalBlue;


            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn9.BackColor = Color.Black;
            btn0.BackColor = Color.Black;
            btn00.BackColor = Color.Black;
            btndot.BackColor = Color.Black;

            btnplus.BackColor = Color.SeaGreen;
            btndiv.BackColor = Color.SeaGreen;
            btnminus.BackColor = Color.SeaGreen;
            btnmul.BackColor = Color.SeaGreen;
            btnequal.BackColor = Color.SeaGreen;

            btntheme1.BackColor = Color.MediumSlateBlue;
            btntheme2.BackColor = Color.MediumSlateBlue;


        }

        private void btntheme1_Click(object sender, EventArgs e)
        {
            btnDRG.BackColor = Color.Black;
            btnlog.BackColor = Color.Black;
            btnln.BackColor = Color.Black;
            btnoff.BackColor = Color.Black;
            btnhyp.BackColor = Color.Black;
            btnsin.BackColor = Color.Black;
            btncos.BackColor = Color.Black;
            btntan.BackColor = Color.Black;
            btnpie.BackColor = Color.Black;
            btn1byx.BackColor = Color.Black;
            btnsqroot.BackColor = Color.Black;
            btnsquare.BackColor = Color.Black;
            btnsumenation.BackColor = Color.Black;
            btnEE.BackColor = Color.Black;
            btnclose.BackColor = Color.Black;
            btnopen.BackColor = Color.Black;
            btnsto.BackColor = Color.Black;
            btnRCL.BackColor = Color.Black;
            btnENG.BackColor = Color.Black;
            btnarrow.BackColor = Color.Black;


            btn1.BackColor = Color.RoyalBlue;
            btn2.BackColor = Color.RoyalBlue;
            btn3.BackColor = Color.RoyalBlue;
            btn4.BackColor = Color.RoyalBlue;
            btn5.BackColor = Color.RoyalBlue;
            btn6.BackColor = Color.RoyalBlue;
            btn7.BackColor = Color.RoyalBlue;
            btn8.BackColor = Color.RoyalBlue;
            btn9.BackColor = Color.RoyalBlue;
            btn0.BackColor = Color.RoyalBlue;
            btn00.BackColor = Color.RoyalBlue;
            btndot.BackColor = Color.RoyalBlue;

            btnplus.BackColor = Color.MediumSlateBlue;
            btndiv.BackColor = Color.MediumSlateBlue;
            btnminus.BackColor = Color.MediumSlateBlue;
            btnmul.BackColor = Color.MediumSlateBlue;
            btnequal.BackColor = Color.MediumSlateBlue;

            btntheme1.BackColor = Color.SeaGreen;
            btntheme2.BackColor = Color.SeaGreen;
        }
    }
}