using Npgsql;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;


namespace Maps {
    public partial class Form1 : Form {
        DataBase db;
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        int current_user_id;
        GMapOverlay homeOverlay = new GMapOverlay("Home");
        public Form1(DataBase db, int id) {
            InitializeComponent();
            this.db = db;
            current_user_id = id;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void mapView_Load(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"select * from users where user_id = {current_user_id}", db.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            helloBox.Text = $"Вітаємо, {dt.Rows[0][1]}";
            if (dt.Rows[0][3].ToString() != "") {
                GMarkerGoogle home = new GMarkerGoogle(new PointLatLng (double.Parse(dt.Rows[0][4].ToString()), double.Parse(dt.Rows[0][3].ToString())), GMarkerGoogleType.green);
                home.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(home);
                home.ToolTipText = $"Точка дому користувача {dt.Rows[0][1]}";
                homeOverlay.Markers.Add(home);
                map.Overlays.Add(homeOverlay);
            }
        }


        private void map_Load(object sender, EventArgs e) {
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.MapProviders.GMapProvider.Language = GMap.NET.LanguageType.Ukrainian;
            map.MinZoom = 2;
            map.MaxZoom = 17;
            // whole world zoom
            map.Zoom = 10;
            // lets the map use the mousewheel to zoom
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            map.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            map.DragButton = MouseButtons.Left;
            map.Position = new GMap.NET.PointLatLng(50.434152350000005, 30.558650567373554);
            map.ShowCenter = false;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
           
        }

        private void setRadio(RadioButton rb, double latitude, double longitude, string description) {
            if (rb.Checked) {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red);
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = description;
                markersOverlay.Markers.Add(marker);
                map.Overlays.Add(markersOverlay);
            }
            else {
                map.Overlays.Remove(markersOverlay);
                markersOverlay.Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton1, 50.434152350000005, 30.558650567373554, "Києво-Печерська Лавра");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton2, 50.45291165, 30.514248702371276, "Національний заповідник “Софія Київська”");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton3, 50.4265165, 30.5630368, "Монумент “Батьківщина-мати”");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton4, 50.44885255, 30.51336630335141, "Золоті ворота");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton5, 50.45920308108063, 30.52718907594681, "Набережна Дніпра");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton6, 50.4612128, 30.5162203, "Андріївський узвіз");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton7, 50.42678404512451, 30.517423152923588, "Миколаївський костел");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton8, 50.4450683, 30.5286211, "Будинок з химерами");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton9, 50.4583302, 30.51613888552464, "Музей Історії України");
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton10, 50.45024305, 30.524061141975686, "Майдан Незалежності");
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton11, 50.448105749999996, 30.537436055000008, "Маріїнський палац");
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton12, 50.4336991, 30.51670524388598, "Оперний театр");
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton13, 50.475933100000006, 30.45327316821306, "Бабин Яр");
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton14, 50.438487, 30.555764662819147, "Парк Вічної Слави");
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton15, 50.3532648, 30.5041828, "Парк-музей Пирогово");
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton16, 50.44512785, 30.517553692067597, "Музей історії міста Києва"); 
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e) {
            setRadio(radioButton17, 50.42907369878895, 30.568900108337406, "Пам'ятник засновникам Києва");
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e) {
            //double lng = double.Parse();
            double lat;
            if (MessageBox.Show($"Додати точку дому на цьому місці?\n{map.FromLocalToLatLng(e.X, e.Y).Lng.ToString().Replace(",", ".")} {map.FromLocalToLatLng(e.X, e.Y).Lat.ToString().Replace(",", ".")}", "Підтвердження", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) {
                string querry = $"update users  set home_point_long = {map.FromLocalToLatLng(e.X, e.Y).Lng.ToString().Replace(",", ".")} , home_point_latit = '{map.FromLocalToLatLng(e.X, e.Y).Lat.ToString().Replace(",", ".")}' where user_id = {current_user_id}";
                NpgsqlCommand cmd = new NpgsqlCommand(querry, db.GetConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Точку дому успішно збережено!");
            }
            homeOverlay.Markers.Clear();
            Form1_Load(sender, e);
        }

        private void map_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e) {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e) {

        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e) {
            homeOverlay.Markers.Clear();
            Form1_Load(sender,e);
        }

        private void завершитиРоботуToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e) {
            if (MessageBox.Show($"Видалити дану точку дому?\n{map.FromLocalToLatLng(e.X, e.Y).Lng.ToString().Replace(",", ".")} {map.FromLocalToLatLng(e.X, e.Y).Lat.ToString().Replace(",", ".")}", "Підтвердження", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) {
                string querry = $"update users  set home_point_long = NULL , home_point_latit = NULL where user_id = {current_user_id}";
                NpgsqlCommand cmd = new NpgsqlCommand(querry, db.GetConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Точку дому успішно збережено!");
            }
            homeOverlay.Markers.Clear();
            Form1_Load(item, e);
        }
    }
}