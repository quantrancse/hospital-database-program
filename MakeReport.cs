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
using DGVPrinterHelper;

namespace LoginPanel
{
	public partial class MakeReport : MaterialForm
	{
        public String patient_id, fname = "", lname = "";
        public int price_sum = 0;
        public MakeReport()
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

        private void Btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentime = DateTime.Now;
                DGVPrinter printer = new DGVPrinter();
                printer.PageNumbers = false;
                printer.Title = "Patient Payment Report";
                printer.SubTitle = "Name: " + fname + " " + lname + " | Total Price: " + price_sum.ToString();
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.PorportionalColumns = true;
                printer.Footer = string.Format("Date {0}", currentime.ToString("dd/MM/yyyy hh:mm tt"));
                printer.FooterSpacing = 15;
                printer.PageSeparator = " / ";
                printer.PageText = "123";
                printer.PrintPreviewDataGridView(dataGridView1);
            }
            catch
            {
                MessageBox.Show("Nothing to print!", "Notification");
            }
            
        }

        private void MakeReport_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            id.Text = "";
            pname.Text = "";
            dob.Text = "";
            type.Text = "";
            genre.Text = "";
            phone.Text = "";
            address.Text = "";
        }

        private void Btn_check_Click(object sender, EventArgs e)
        {
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

            String selectid = "SELECT pid, pfname, plname, pdob, pgenre, pphone, paddress FROM patient where " + where_con;
            OleDbCommand command = new OleDbCommand(selectid, con);
            con.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                patient_id = reader.GetString(0);
                id.Text = patient_id;
                fname = reader.GetString(1);
                lname = reader.GetString(2);
                pname.Text = fname + " " + lname;
                dob.Text = reader.GetDateTime(3).ToString().Split(' ')[0];
                if (reader.GetString(4).Equals("M"))
                {
                    genre.Text = "Male";
                } 
                else if (reader.GetString(4).Equals("F"))
                {
                    genre.Text = "Female";
                }
                phone.Text = reader.GetString(5);
                address.Text = reader.GetString(6);
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
                    type.Text = "In Patient";
                    String searchquery = "SELECT (efname || ' ' || elname) AS Doctor_Name, mname AS Medication_Name, meffects AS Medication_Effects, mprice AS Price FROM (medication INNER JOIN uses_treat ON medication.mid = uses_treat.mid INNER JOIN employee ON eid_doc = eid) where pid_in = '" + patient_id + "'";
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(searchquery, con);
                    OleDbDataReader read_sum = cmd.ExecuteReader();
                    price_sum = 0;
                    while (read_sum.Read())
                    {
                        price_sum += int.Parse(read_sum.GetString(3));
                    }

                    OleDbDataAdapter oda = new OleDbDataAdapter(searchquery, con);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                    con.Close();
                    show_price.Text = price_sum.ToString();
                }
                else
                {
                    type.Text = "Out Patient";
                    String searchquery_countsum = "SELECT mprice FROM (medication JOIN uses_exam ON medication.mid = uses_exam.mid) where pid_out = '" + patient_id + "'";
                    String searchquery_countfee = "SELECT exfee FROM examination where examination.pid_out = '" + patient_id + "'";
                    String searchquery = "SELECT (efname || ' ' || elname) AS Doctor_Name, mname AS Medication_Name, meffects AS Medication_Effects, mprice AS Price, exdate AS Examination_Date, exfee AS Examination_Fee, exdiagnosis AS Examination_Diagnosis FROM (medication INNER JOIN uses_exam ON medication.mid = uses_exam.mid INNER JOIN examination ON examination.exid = uses_exam.exid INNER JOIN employee ON examination.eid_doc = employee.eid) where examination.pid_out = '" + patient_id + "'";

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(searchquery_countsum, con);
                    OleDbDataReader read_sum = cmd.ExecuteReader();

                    OleDbCommand cmd2 = new OleDbCommand(searchquery_countfee, con);
                    OleDbDataReader read_fee = cmd2.ExecuteReader();

                    price_sum = 0;
                    while (read_sum.Read())
                    {
                        price_sum += int.Parse(read_sum.GetString(0));
                    }
                    
                    while (read_fee.Read())
                    {
                        price_sum += int.Parse(read_fee.GetString(0));
                    }

                    OleDbDataAdapter oda = new OleDbDataAdapter(searchquery, con);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                    con.Close();
                    show_price.Text = price_sum.ToString();
                }
            }
        }
    }
}
