using System.Diagnostics.Eventing.Reader;

namespace Hanging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string text;
        public char[] word;
        public int hp;
        public int hptrue;



        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text; // �������� ��� ���������� 
            hp = 0;
            label1.Text = null;
            textBox1.Text = null; //
            word = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += '.';
                word[i] = '.';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool words = false;

            if (textBox2.Text.Length == 1) // ��� ����� �����
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (textBox2.Text[0] == text[i])
                    {
                        words = true;
                        hptrue++;
                        word[i] = text[i];
                        label1.Text = null;
                    }

                }



                if (words == true)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += word[i];
                    }
                    if (hptrue == text.Length)
                    {
                        MessageBox.Show("�� �������!");

                    }

                }
                else
                {
                    hp++;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (hp == 11)
                    {
                        MessageBox.Show("�� ��������! ");
                        label1.Text = null;
                        label1.Text = text;
                    }
                }
            }
            else if (textBox2.Text.Length > 1) // ��� ������� ������ 
            {
                if (textBox2.Text == text)
                {
                    label1.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += text[i];
                    }
                    MessageBox.Show("�� �������!");
                }
                else
                {
                    hp = 10;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    MessageBox.Show("�� ��������!");
                    label1.Text = null;
                    label1.Text = text;
                }

            }
            textBox2.Text = null;
        }


    }
}