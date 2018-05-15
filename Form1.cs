using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public struct goods
{
    public string name;
    public DateTime date;
    public int num;
}

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        goods[] array = new goods[10];
        int count = 0;
        int thisMounth;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {
            thisMounth = monthCalendar1.TodayDate.Month;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array[count].name = textBox1.Text;
            //monthCalendar1.SetDate(new DateTime(2011, 7, 7));
            array[count].date = monthCalendar1.SelectionRange.Start;
            array[count].num = (int)numericUpDown1.Value;
            ++count;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { (i+1).ToString(), array[i].name, array[i].num.ToString(), array[i].date.ToString() });
                listView1.Items.Add(item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        { int j = 1;
            for (int i = 0; i < count; i++)
            {
                if (monthCalendar1.SelectionRange.Start.Month == thisMounth)
                {
                    ListViewItem item = new ListViewItem(new string[] { j.ToString(), array[i].name, array[i].num.ToString(), array[i].date.ToString() });
                    listView1.Items.Add(item);
                    ++j;
                }
        }
        }
    }
}
