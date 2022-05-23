using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _230522venan
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        public void updated()
        {
            dtTypePemain = new DataTable();
            sqlQuery = "SELECT p.player_id as player_id, p.player_name as player_name, p.birthdate as birth, n.nation as nationality, t.team_name as team_name, p.team_number as team_number FROM player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id group by 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int PosisiSekarang = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id as player_id, p.player_name as player_name, p.birthdate as birth, n.nation as nationality, t.team_name as team_name, p.team_number as team_number FROM player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id group by 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);

        }
        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            tbid.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tbname.Text = dtTypePemain.Rows[Posisi][1].ToString();
            dtpbirth.Value = Convert.ToDateTime(dtTypePemain.Rows[Posisi][2]);
            cbnationality.Text = dtTypePemain.Rows[Posisi][3].ToString();
            cbteam.Text = dtTypePemain.Rows[Posisi][4].ToString();
            teamnum.Text = dtTypePemain.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }

        private void bt_first_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void bt_last_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = $"UPDATE dt_type SET player_id '{tbid.Text}' , player_name = '{tbname.Text}', birth = {dtpbirth.Text}, nationality = {cbnationality.Text}, team_name = {cbteam.Text}, team_number = {teamnum.Text} WHERE player_id ='{tbid.Text}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                updated();

                MessageBox.Show("Data updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void lblavailable_Click(object sender, EventArgs e)
        {

        }

        private void cbnationality_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void cbteam_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
