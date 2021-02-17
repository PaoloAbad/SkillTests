using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillTest_PaoloGabrielAbad.Controller;

namespace SkillTest_PaoloGabrielAbad
{
    public partial class form_Sorter : Form, ISortCharacters
    {
        public form_Sorter()
        {
            InitializeComponent();
        }

        public string Input { get { return textBox_Input.Text; } set { textBox_Input.Text = value; } }

        public Label Output { get; set; }

        private void sort_Button_Click(object sender, EventArgs e)
        {
            SortedList cList = new SortedList();

            string[] list = textBox_Input.Text.ToCharArray();
        }
    }
}
