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
    public partial class Authorization : Form {
        public DataBase db;
        
        public Authorization(DataBase data) {
            db = data;
            InitializeComponent();
            passBox.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            Registration reg = new Registration(db);
            reg.Show();
            
        }

        private void label4_Click(object sender, EventArgs e) {
            if (passBox.UseSystemPasswordChar == false)
                passBox.UseSystemPasswordChar = true;
            else
                passBox.UseSystemPasswordChar = false;

        }

        private void Authorization_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"select * from users where user_name = '{logBox.Text}' and user_password = '{passBox.Text}'", db.GetConnection());
            adapter.Fill(dt);
            if(dt.Rows.Count == 1) {
                Form1 mainmenu = new Form1(db, int.Parse(dt.Rows[0][0].ToString()));
                mainmenu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Користувача не існує або\nневірний логін/пароль!","Помилка!", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }
    }
}
