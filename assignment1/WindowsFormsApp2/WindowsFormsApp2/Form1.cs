using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void tetResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text += btn.Text;
        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            Single r;

            // 获取文本框 txtResult 中的文本
            string t = tetResult.Text;

            // 寻找文本中第一个空格的位置
            int space = t.IndexOf(' ');

            // 从文本中提取第一个操作数 s1（空格前的部分）
            string s1 = t.Substring(0, space);

            // 从文本中提取操作符 op（空格后的第一个字符）
            char op = Convert.ToChar(t.Substring(space + 1, 1));

            // 从文本中提取第二个操作数 s2（空格后两个字符以后的部分）
            string s2 = t.Substring(space + 3);

            // 将操作数转换为 Single 类型
            Single arg1 = Convert.ToSingle(s1);
            Single arg2 = Convert.ToSingle(s2);

            // 使用 switch 语句根据操作符进行计算
            switch (op)
            {
                case '+':
                    r = arg1 + arg2;
                    break;
                case '-':
                    r = arg1 - arg2;
                    break;
                case '*':
                    r = arg1 * arg2;
                    break;
                case '/':
                    // 如果除数为零，则抛出异常
                    if (arg2 == 0)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        // 否则执行除法操作
                        r = arg1 / arg2;
                        break;
                    }
                default:
                    // 如果操作符不是+、-、*、/之一，抛出异常
                    throw new ApplicationException();
            }

            // 将计算结果显示在文本框 txtResult 中
            tetResult.Text = r.ToString();
        }

        private void btnjia_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text = tetResult.Text + " " + btn.Text + " ";
        }

        private void btnjian_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text = tetResult.Text + " " + btn.Text + " ";
        }

        private void btnchen_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text = tetResult.Text + " " + btn.Text + " ";
        }

        private void btnchu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tetResult.Text = tetResult.Text + " " + btn.Text + " ";
        }

        private void buttonclean_Click(object sender, EventArgs e)
        {
            tetResult.Text = "";
        }
    }
}
