using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_pr1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Cancel_Click(object sender, EventArgs e)//Выход из текущего окна
        {
            Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Переход по ссылке при нажатии на нее
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }
    }
}
