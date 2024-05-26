using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Maps {
    public partial class Registration : Form {
        DataBase db = new DataBase();
        public Registration(DataBase db) {
            InitializeComponent();
            passBox.UseSystemPasswordChar = true;
            repPass.UseSystemPasswordChar = true;
            this.db = db;
        }

        private void Registration_Load(object sender, EventArgs e) {

        }

        

        private void label4_Click(object sender, EventArgs e) {
            if (passBox.UseSystemPasswordChar == true) {
                passBox.UseSystemPasswordChar = false;
                repPass.UseSystemPasswordChar = false;
            }
            else {
                passBox.UseSystemPasswordChar = true;
                repPass.UseSystemPasswordChar = true;
            }
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"select * from users where user_name ='{logBox.Text}'", db.GetConnection());
            adapter.Fill(dt);
            if (dt.Rows.Count != 0) {
                MessageBox.Show("Такий користувач вже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else {
                if (passBox.Text == repPass.Text && logBox.Text != "" && passBox.Text != "") {
                    NpgsqlCommand cmd = new NpgsqlCommand($"insert into users( user_name, user_password) values('{logBox.Text}','{passBox.Text}')", db.GetConnection());
                    cmd.ExecuteNonQuery();
                    Form1 mainmenu = new Form1(db, int.Parse(dt.Rows[0][0].ToString()));
                    mainmenu.Show();
                    this.Close();
                }

                else {
                    passLab.BackColor = Color.Red;
                    repLab.BackColor = Color.Red;
                }
            }
            }
            
           
        }
}
