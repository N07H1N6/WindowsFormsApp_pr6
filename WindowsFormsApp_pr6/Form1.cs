using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            try//Проверка данных
            {
                if (String.IsNullOrEmpty(tb_name.Text))
                {
                    errorProvider1.SetError(tb_name, "Не указано имя пациента!");
                }
                else if (tb_name.Text.Length > 10)
                {
                    errorProvider1.SetError(tb_name, "Слишком длинное имя!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(tb_name, "Некорректное имя!");
            }
        }
    

        private void tb_surname_TextChanged(object sender, EventArgs e)
        {
        try//Проверка данных
        {
            if (String.IsNullOrEmpty(tb_name.Text))
            {
                errorProvider2.SetError(tb_surname, "Не указана фамилия пациента!");
            }
            else if (tb_surname.Text.Length > 15)
            {
                errorProvider2.SetError(tb_surname, "Слишком длинная фамилия!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        catch (FormatException)
        {
            errorProvider2.SetError(tb_surname, "Некорректная фамилия!");
        }
    }


        private void tb_diseases_TextChanged(object sender, EventArgs e)
        {
            try//Проверка данных
            {
                if (String.IsNullOrEmpty(tb_diseases.Text))
                {
                    errorProvider3.SetError(tb_diseases, "Не указан номер болезни!");
                }
                
                
                else
                {
                    errorProvider3.Clear();
                }
            }
            catch (FormatException)
            {
                errorProvider3.SetError(tb_diseases, "Некорректное значение номера болезни!");
            }
        }
        private void btn_message_Click(object sender, EventArgs e)
        {
            try//Проверка данных
            {
                if (Int32.Parse(tb_diseases.Text) <= 0)//Проверка данных
                {
                    MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_name.Clear();
                    tb_surname.Clear();
                    tb_diseases.Clear();
                }
                else if (Int32.Parse(tb_diseases.Text) <= 0)
                {
                    errorProvider3.SetError(tb_diseases, "Некорректное значение номера болезни!");

                }
                else if (tb_diseases.Text.Length > 5)
                {
                    errorProvider3.SetError(tb_diseases, "Слишком длинный номер болезни!");
                }
                else
                {
                    Hospital_singleton hospital_Singleton = Hospital_singleton.GetInstance(Convert.ToInt32(tb_diseases.Text));
                    Random_singleton random_Singleton = Random_singleton.GetInstance();
                    string get_rand = random_Singleton.get_rand.ToString();
                    string get_value = hospital_Singleton.get.ToString();
                    MessageBox.Show("Имя:" + tb_name.Text + "\nФамилия:" + tb_surname.Text + "\nБолезнь/Травма:" + get_value, "Информация о пациенте", MessageBoxButtons.OK);
                    MessageBox.Show(get_rand, "Случайное событие", MessageBoxButtons.OK);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_name.Clear();
                tb_surname.Clear();
                tb_diseases.Clear();
            }
           
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_diseases.Clear();
            tb_name.Clear();
            tb_surname.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_diseases.ForeColor = SystemColors.GrayText;
            tb_diseases.Font = new Font(tb_diseases.Font, FontStyle.Italic);
            tb_diseases.Text = "Введите номер болезни из списка";
        }

        private void tb_diseases_Click(object sender, EventArgs e)
        {
            tb_diseases.Clear();
            tb_diseases.ForeColor = SystemColors.WindowText;
            tb_diseases.Font = new Font(tb_diseases.Font, FontStyle.Regular);
        }
    }
}
