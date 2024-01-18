namespace Is_Fe_content_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        public void illAge(object sender, EventArgs e)
        {
            try
            {
                int te1 = 0;
                te1 = Convert.ToInt32(textA.Text);
                if (te1 < 18 || te1 > 65)
                {

                    checkS.Enabled = false;
                    checkS.Checked = false;
                    checkF.Enabled = false;
                    checkF.Checked = false;
                    textP.Enabled = false;
                    textP.Text = "";
                    button1.Visible = false;
                    label3.Visible = false;
                }
                else
                {
                    checkS.Enabled = true;
                    checkF.Enabled = true;
                    textP.Enabled = true;
                    textP.Visible = true;
                    
                    label3.Visible = true;
                    checkS.Visible = true;
                    checkF.Visible = true;

                }

            }catch (Exception ex)
            {

            }
        }

        public void no_single_fe(object sender, EventArgs e)
        {
            try
            { 
                if (checkS.Checked && checkF.Checked)
                {
                    button1.Visible = true;
                }
                else
                {
                    button1.Visible = false;

                }
            }
            catch (Exception ex)
            {
                label4.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textN.Text == "" || textN.Text == String.Empty || textA.Text == "" || textA.Text == String.Empty || textP.Text == "" || textP.Text == String.Empty)
                {
                    label4.Text = "Enter Your Info pls :(";
                }
                else
                {
                    label4.Text = "Got your number XD";

                }
            }
            catch (Exception ex)
            {
                label4.Text = "";
            }
        }
    }
}
