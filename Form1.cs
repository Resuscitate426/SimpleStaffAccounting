using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SimpleStaffAccounting
{
    public partial class Form1 : Form
    {
        SQLiteConnection DB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtBorn.Format = DateTimePickerFormat.Custom;
            DB = new SQLiteConnection("Data Source = maindata.db");
            DB.Open();
        }

        void SearchByParameter()
        {
            listSearch.Items.Clear();
            SQLiteCommand SearchCMD = DB.CreateCommand();
            SearchCMD.CommandText = "select * from Personal where Имя like '%' || @name || '%' and Фамилия like '%' || @fam || '%' and Отчество like '%' || @otch || '%' and Должность like '%' || @spot || '%'";
            SearchCMD.Parameters.Add("@name", DbType.String).Value = tbSearchName.Text.ToUpper();
            SearchCMD.Parameters.Add("@fam", DbType.String).Value = tbSearchFam.Text.ToUpper();
            SearchCMD.Parameters.Add("@otch", DbType.String).Value = tbSearchOtch.Text.ToUpper();
            SearchCMD.Parameters.Add("@spot", DbType.String).Value = cbSearchSpot.Text.ToUpper();
            SQLiteDataReader sql = SearchCMD.ExecuteReader();

            if (sql.HasRows)
            {
                while (sql.Read())
                {
                    listSearch.Items.Add(sql["Фамилия"] + " " + sql["Имя"] + " " + sql["Отчество"] + " || " + sql["ДатаРождения"]);
                    listSearch.Items.Add("Должность: " + sql["Должность"] + " Оклад: " + sql["Оклад"]);
                    listSearch.Items.Add(new string('-', 20));
                }
            }
            else
            {
                listSearch.Items.Clear();
                listSearch.Items.Add("Не найдено");
            }
        }

        void ClearFieldOnAdd()
        {
            tbFam.Text = String.Empty;
            tbName.Text = String.Empty;
            tbOtch.Text = String.Empty;
            tbSalary.Text = String.Empty;
            cbSpot.Text = null;
            dtBorn.Value = dtBorn.MinDate;
        }

        void ClearFieldOnSearch()
        {
            tbSearchFam.Text = String.Empty;
            tbSearchName.Text = String.Empty;
            tbSearchOtch.Text = String.Empty;
            cbSearchSpot.Text = null;
            listSearch.Items.Clear();
        }

        void StopNumbers(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (tbFam.Text == String.Empty || tbName.Text == String.Empty
                || tbOtch.Text == String.Empty || tbSalary.Text == String.Empty
                || cbSpot.Text == null)
            {
                MessageBox.Show("Одно или несколько обязательных полей не заполнены!", "Ошибка");
            }
            else
            {
                SQLiteCommand AddCMD = DB.CreateCommand();
                AddCMD.CommandText = "insert into Personal(Имя, Фамилия, Отчество, ДатаРождения, Должность, Оклад)  values(@name, @fam, @otch, @born, @spot, @salary)";
                AddCMD.Parameters.Add("@name", DbType.String).Value = tbName.Text.ToUpper();
                AddCMD.Parameters.Add("@fam", DbType.String).Value = tbFam.Text.ToUpper();
                AddCMD.Parameters.Add("@otch", DbType.String).Value = tbOtch.Text.ToUpper();
                AddCMD.Parameters.Add("@born", DbType.Date).Value = dtBorn.Value;
                AddCMD.Parameters.Add("@spot", DbType.String).Value = cbSpot.Text.ToUpper();
                AddCMD.Parameters.Add("@salary", DbType.String).Value = tbSalary.Text.ToUpper();
                AddCMD.ExecuteNonQuery();
                MessageBox.Show("Сотрудник добавлен!", "Готово");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tbSearchFam.Text == String.Empty && tbSearchName.Text == String.Empty
                && tbSearchOtch.Text == String.Empty && cbSearchSpot.SelectedItem == null)
            {
                MessageBox.Show("Ошибка! Введите хотя бы 1 параметр", "Ошибка");
            }
            else
            {
                SearchByParameter();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearFieldOnSearch();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            ClearFieldOnAdd();
        }

        private void TbSearchFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbSearchOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopNumbers(sender, e);
        }

        private void TbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchByParameter();
        }
    }
}
