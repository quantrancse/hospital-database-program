using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;

namespace LoginPanel
{
	public partial class ListPatient : MaterialForm
	{
		public ListPatient()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

        OleDbConnection con = new OleDbConnection(Program.Oleconn);
        private void Btn_back_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm = new Menu();
			this.Close();
			Program.Context.MainForm.Show();
		}

        private void Btn_list_Click(object sender, EventArgs e)
        {
            String where_con = "", doctor_id;
            if (!string.IsNullOrEmpty(txb_did.Text))
            {
                where_con += "eid = '" + txb_did.Text + "'";
            }
            if (!string.IsNullOrEmpty(txb_dfname.Text))
            {
                if (!string.IsNullOrEmpty(where_con))
                {
                    where_con += " AND ";
                }
                where_con += "efname = '" + txb_dfname.Text + "'";
            }
            if (!string.IsNullOrEmpty(txb_dlname.Text))
            {
                if (!string.IsNullOrEmpty(where_con))
                {
                    where_con += " AND ";
                }
                where_con += "elname = '" + txb_dlname.Text + "'";
            }
            if (string.IsNullOrEmpty(where_con))
            {
                where_con += "eid = ''";
            }

            String selectid = "SELECT eid FROM employee where " + where_con;
            con.Open();
            OleDbCommand command = new OleDbCommand(selectid, con);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                doctor_id = reader.GetString(0);
            }
            catch
            {
                doctor_id = "";
            }
            con.Close();

            if (string.IsNullOrEmpty(doctor_id))
            {
                MessageBox.Show("Doctor not found!", "Notification");
            }
            else
            {
                con.Open();
                String searchquery = "SELECT pid, (pfname || ' ' || plname) AS Name, pdob AS Date_of_birth, pgenre AS genre, pphone AS phone, paddress AS address, trid AS Treatment_ID, trstart AS Treatment_Start_Date, trend AS Treatment_End_Date, Trresult AS Treatment_Result, p_admissiondate AS Admission_DATE, p_dischargedate AS Discharge_date, p_diagnosis AS Diagnosis, pfee AS Fee, psickroom AS Sickroom FROM ((inpatient natural join treatment) join patient on pid_in = pid join employee on eid_doc = eid) where " + where_con + "ORDER BY pid ASC";
                OleDbDataAdapter oda = new OleDbDataAdapter(searchquery, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                this.dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void ListPatient_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
