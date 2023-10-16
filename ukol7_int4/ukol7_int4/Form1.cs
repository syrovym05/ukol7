using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ukol7_int4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog.Color = SystemColors.Control;
            this.CenterToScreen();
            this.ShowIcon = false;
            this.Text = "Ukol 4";
        }

        ColorDialog colorDialog = new ColorDialog();
        

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;

            Form form2 = new Form();
            form2.ShowIcon = false;
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Size = new Size(x,y);
            form2.Text = textBox1.Text;
            form2.BackColor = colorDialog.Color;
            form2.MinimumSize = new Size(200, 100);
            


            if (checkBox1.Checked) form2.FormBorderStyle = FormBorderStyle.Sizable;
            else form2.FormBorderStyle = FormBorderStyle.None;

            Button zpet = new Button();
            //zpet.Location = new Point(15, 20);
            zpet.Location = new Point(form2.Width / 2 -80, form2.Height / 2 - 7);
            zpet.Text = "Zpìt";
            zpet.DialogResult = DialogResult.OK;
            zpet.BackColor = SystemColors.Control;
            zpet.ForeColor = SystemColors.ControlText;



            Button konec = new Button();
            konec.DialogResult = DialogResult.Cancel;
            //konec.Location = new Point(95, 20);     
            konec.Location = new Point(form2.Width / 2 , form2.Height / 2 -7);
            konec.Text = "Konec";
            konec.BackColor = SystemColors.Control;
            konec.ForeColor = SystemColors.ControlText;
     

            form2.Controls.Add(zpet);
            form2.Controls.Add(konec);

            this.Hide();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                form2.Close();
                this.Show();
            }
            else this.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();                                
        }
    }
}