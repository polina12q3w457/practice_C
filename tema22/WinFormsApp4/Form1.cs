using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearControls(this);
        }

        private void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is GroupBox)
                {
                    ClearControls(c);
                }
                else if (c is DomainUpDown)
                {
                    ((DomainUpDown)c).Items.Clear();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formData = "";
            formData += "�������: " + textBox1.Text + "\n";
            formData += "���: " + textBox2.Text + "\n";
            formData += "��������: " + textBox3.Text + "\n";
            string gender = "";

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        gender = radioButton.Text;
                        break;
                    }
                }
            }
            formData += "���: " + gender + " ";
            formData += "���� ��������: " + comboBox1.Text + " " + comboBox2.Text + " " + textBox10.Text + " ";
            formData += "����� ����������: " + textBox5.Text + " ";
            formData += "����� ����������� �����: " + textBox6.Text + " ";
            formData += "��������� �������: " + comboBox6.Text + " " + textBox6.Text + " ";
            string practice = "";

            foreach (Control control in groupBox3.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        gender = radioButton.Text;
                        break;
                    }
                }
            }
            formData += "���� ������: " + practice + "\n";
            string information = "";

            foreach (Control control in groupBox4.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkbox = control as CheckBox;
                    if (checkbox.Checked)
                    {
                        gender = checkbox.Text;
                        break;
                    }
                }
            }
            formData += "������ ��������: " + information + " ";
            formData += "����� ���������� �����: �� " + textBox8.Text + " " + "��" + textBox10.Text + " ";
            string chart = "";

            foreach (Control control in groupBox6.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        gender = radioButton.Text;
                        break;
                    }
                }
            }
            formData += "�������������� ������ ������:" + chart + " ";
            textBox4.Text = formData;
        }
    }
}
