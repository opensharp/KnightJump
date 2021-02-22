using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace 骑士跳
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[64];
        int value = 0;
        int count = 0;
        int end = 0;
        int start = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 64; i++)
            {
                btn[i] = new Button();
                btn[i].Location = new System.Drawing.Point(10 + 50 * (i % 8), 10 + 50 * (i / 8));
                btn[i].Name = i.ToString();
                btn[i].Size = new System.Drawing.Size(45, 45);
                btn[i].FlatAppearance.BorderColor = System.Drawing.Color.Red;
                btn[i].FlatAppearance.BorderSize = 3;
                btn[i].Click += new System.EventHandler(this.btn_Click);
                Controls.Add(btn[i]);
            }
GET:        string a = Interaction.InputBox("\n\n请在200-500之间任意选择一个的3位数！", "", "", -1, -1);
            if (a == "")
            {
                MessageBox.Show("请正确输入数字！");
                goto GET;
            }
            else
            {
                Text = "骑士跳    目标数字为：" + a;
                try
                {
                    value = int.Parse(a);
                }
                catch { }
            }
        }
        private void btn_Click(object sender, System.EventArgs e)
        {
            count++;
            Button temp = ((Button)sender);
            if (count == 1)
            {
                temp.Text = Interaction.InputBox("\n\n请输入起点的数字！", "", "", -1, -1);
                if (temp.Text == "")
                {
                    MessageBox.Show("请正确输入数字！");
                    count--;
                }
                else
                {
                    temp.Enabled = false;
                    temp.BackColor = Color.HotPink;
                    start = int.Parse(temp.Name);
                }
            }
            else if (count == 2)
            {
                temp.Enabled = false;
                temp.BackColor = Color.HotPink;
                temp.Text = "终点";
                end = int.Parse(temp.Name);
                if (start == 0)
                {
                    btn[10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 1)
                {
                    btn[11].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[16].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 6)
                {
                    btn[12].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[23].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 7)
                {
                    btn[13].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[22].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 8)
                {
                    btn[2].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[25].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 15)
                {
                    btn[5].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[30].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 48)
                {
                    btn[32].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[58].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 55)
                {
                    btn[38].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[61].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 56)
                {
                    btn[41].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[50].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 57)
                {
                    btn[40].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[51].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 62)
                {
                    btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[47].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[52].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 63)
                {
                    btn[53].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[46].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 16)
                {
                    btn[1].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[26].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[33].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 24)
                {
                    btn[9].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[34].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[41].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 32)
                {
                    btn[17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[26].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[49].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 40)
                {
                    btn[25].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[34].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[50].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[57].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 23)
                {
                    btn[6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[13].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[29].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[38].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 31)
                {
                    btn[14].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[37].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[46].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 39)
                {
                    btn[22].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[29].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[54].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (start == 47)
                {
                    btn[30].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[37].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[53].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn[62].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else
                {
                    if (start % 8 > 1)
                    {
                        try
                        {
                            btn[start + 6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                        try
                        {
                            btn[start - 10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                    }
                    if (start % 8 < 6)
                    {
                        try
                        {
                            btn[start - 6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                        try
                        {
                            btn[start + 10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                    }
                    if (start / 8 > 1)
                    {
                        try
                        {
                            btn[start - 15].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                        try
                        {
                            btn[start - 17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                    }
                    if (start / 8 < 6)
                    {
                        try
                        {
                            btn[start + 15].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                        try
                        {
                            btn[start + 17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        }
                        catch { }
                    }
                }
            }
            else if (count == 64)
            {
                temp.Text = Interaction.InputBox("\n\n请输入要填写的数字！", "", "", -1, -1);
                if (temp.Text == "")
                {
                    MessageBox.Show("请正确输入数字！");
                    count--;
                }
                else
                {
                    for (int i = 0; i < 64; i++)
                    {
                        btn[i].FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                    }
                    temp.Enabled = false;
                    temp.BackColor = Color.SkyBlue;
                    btn[end].Enabled = true;
                    btn[end].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
            }
            else if (count == 65)
            {
                temp.Text = Interaction.InputBox("\n\n请输入终点的数字！", "", "", -1, -1);
                if (temp.Text == "")
                {
                    MessageBox.Show("请正确输入数字！");
                    count--;
                }
                else
                {
                    for (int i = 0; i < 64; i++)
                    {
                        btn[i].FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                    }
                    temp.Enabled = false;
                    int check1 = 0;
                    int check2 = 0;
                    bool right = false;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            check1 += int.Parse(btn[i * 8 + j].Text);
                            check2 += int.Parse(btn[i + j * 8].Text);
                        }
                        if (check1 != value)
                        {
                            MessageBox.Show("第" + (i + 1).ToString() + "行结果" + check1.ToString() + "不正确！");
                            right = true;
                        }
                        if (check2 != value)
                        {
                            MessageBox.Show("第" + (i + 1).ToString() + "列结果" + check2.ToString() + "不正确！");
                            right = true;
                        }
                        check1 = 0;
                        check2 = 0;
                    }
                    if (!right)
                    {
                        MessageBox.Show("经检验结果正确！");
                    }
                }
            }
            else
            {
                temp.Text = Interaction.InputBox("\n\n请输入要填写的数字！", "", "", -1, -1);
                if (temp.Text == "")
                {
                    MessageBox.Show("请正确输入数字！");
                    count--;
                }
                else
                {

                    temp.Enabled = false;
                    temp.BackColor = Color.SkyBlue;
                    for (int i = 0; i < 64; i++)
                    {
                        btn[i].FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                    }
                    if (int.Parse(temp.Name) == 0)
                    {
                        btn[10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 1)
                    {
                        btn[11].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[16].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 6)
                    {
                        btn[12].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[23].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 7)
                    {
                        btn[13].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[22].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 8)
                    {
                        btn[2].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[25].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 15)
                    {
                        btn[5].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[30].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 48)
                    {
                        btn[32].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[58].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 55)
                    {
                        btn[38].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[61].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 56)
                    {
                        btn[41].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[50].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 57)
                    {
                        btn[40].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[51].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 62)
                    {
                        btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[47].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[52].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 63)
                    {
                        btn[53].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[46].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 16)
                    {
                        btn[1].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[26].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[33].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 24)
                    {
                        btn[9].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[18].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[34].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[41].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 32)
                    {
                        btn[17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[26].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[42].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[49].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 40)
                    {
                        btn[25].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[34].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[50].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[57].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 23)
                    {
                        btn[6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[13].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[29].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[38].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 31)
                    {
                        btn[14].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[21].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[37].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[46].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 39)
                    {
                        btn[22].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[29].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[45].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[54].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else if (int.Parse(temp.Name) == 47)
                    {
                        btn[30].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[37].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[53].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn[62].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    }
                    else
                    {
                        if (int.Parse(temp.Name) % 8 > 1)
                        {
                            try
                            {
                                btn[int.Parse(temp.Name) + 6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                            try
                            {
                                btn[int.Parse(temp.Name) - 10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                        }
                        if (int.Parse(temp.Name) % 8 < 6)
                        {
                            try
                            {
                                btn[int.Parse(temp.Name) - 6].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                            try
                            {
                                btn[int.Parse(temp.Name) + 10].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                        }
                        if (int.Parse(temp.Name) / 8 > 1)
                        {
                            try
                            {
                                btn[int.Parse(temp.Name) - 15].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                            try
                            {
                                btn[int.Parse(temp.Name) - 17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                        }
                        if (int.Parse(temp.Name) / 8 < 6)
                        {
                            try
                            {
                                btn[int.Parse(temp.Name) + 15].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                            try
                            {
                                btn[int.Parse(temp.Name) + 17].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            }
                            catch { }
                        }
                    }
                }
            }
        }
    }
}
