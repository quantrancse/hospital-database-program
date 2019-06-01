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
	public partial class SearchPatient : MaterialForm
	{
		public SearchPatient()
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

        private void Btn_search_Click(object sender, EventArgs e)
        {
            String patient_id;
            String where_con = "";

            if (!string.IsNullOrEmpty(txb_pid.Text))
            {
                where_con += "pid = '" + txb_pid.Text + "'";
            }
            if (!string.IsNullOrEmpty(txb_pfname.Text))
            {
                if (!string.IsNullOrEmpty(where_con))
                {
                    where_con += " AND ";
                }
                where_con += "pfname = '" + txb_pfname.Text + "'";
            }
            if (!string.IsNullOrEmpty(txb_plname.Text))
            {
                if (!string.IsNullOrEmpty(where_con))
                {
                    where_con += " AND ";
                }
                where_con += "plname = '" + txb_plname.Text + "'";
            }
            if (string.IsNullOrEmpty(where_con))
            {
                where_con += "pid = ''";
            }

            String selectid = "SELECT pid FROM patient where " + where_con;
            con.Open();
            OleDbCommand command = new OleDbCommand(selectid, con);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                patient_id = reader.GetString(0);
            }
            catch
            {
                patient_id = "";
            }
            con.Close();


            if (string.IsNullOrEmpty(patient_id))
            {
                MessageBox.Show("Patient not found!", "Notification");
            }
            else
            {
                if (patient_id[0] == 'I')
                {
                    con.Open();
                    String searchquery = searchquery = "SELECT (pfname || ' ' || plname) AS Name, pphone AS Phone, trstart AS Treatment_Start_Date, trend AS Treatment_End_Date, trresult AS Treatment_Result, p_admissiondate AS Admission_DATE, p_dischargedate AS Discharge_date FROM (patient INNER JOIN treatment ON pid = pid_in INNER JOIN inpatient ON treatment.pid_in = inpatient.pid_in) where pid = '" + patient_id + "'";
                    OleDbDataAdapter oda = new OleDbDataAdapter(searchquery, con);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    con.Open();
                    String searchquery = searchquery = "SELECT (pfname || ' ' || plname) AS Name, pphone AS Phone, exdate AS Examination_Date, exseconddate AS Second_examination_date FROM (patient JOIN examination ON pid = pid_out) where pid = '" + patient_id + "'";
                    OleDbDataAdapter oda = new OleDbDataAdapter(searchquery, con);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

    }
}