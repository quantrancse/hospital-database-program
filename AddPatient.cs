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
	public partial class AddPatient : MaterialForm
	{
		public AddPatient()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

        OleDbConnection con = new OleDbConnection(Program.Oleconn);

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void LoadInQuery()
        {
            con.Open();
            String showquery = "SELECT * FROM patient join inpatient on pid = pid_in";
            OleDbDataAdapter oda = new OleDbDataAdapter(showquery, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            this.dataGridView2.DataSource = dt;
            con.Close();
        }

        private void LoadOutQuery()
        {
            con.Open();
            String showquery = "SELECT * FROM patient join outpatient on pid = pid_out";
            OleDbDataAdapter oda = new OleDbDataAdapter(showquery, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            this.dataGridView1.DataSource = dt;
            con.Close();
        }
        private void AddPatient_Load(object sender, EventArgs e)
		{
            LoadInQuery();
            LoadOutQuery();
			panel_out.Show();
            dataGridView1.Show();
            rdbtn_out.Checked = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

		private void Rdbtn_in_CheckedChanged_1(object sender, EventArgs e)
		{
			if (rdbtn_in.Checked == true)
			{
				panel_out.Hide();
                dataGridView1.Hide();
                ClearTextBoxes();
            }
		}

		private void Rdbtn_out_CheckedChanged_1(object sender, EventArgs e)
		{
			if (rdbtn_out.Checked == true)
			{
				panel_out.Show();
                dataGridView1.Show();
                ClearTextBoxes();
            }
		}

		private void Btn_back_Click_1(object sender, EventArgs e)
		{
			Program.Context.MainForm = new Menu();
			this.Close();
			Program.Context.MainForm.Show();
		}

        private void Btn_addout_Click(object sender, EventArgs e)
        {
            Boolean check_fail = false;
            if (string.IsNullOrEmpty(txb_id.Text))
            {
                MessageBox.Show("Please insert patient ID!", "Notification");
            }
            else if (txb_id.Text[0] != 'O' || txb_id.Text[1] != 'P' || txb_id.Text.Length < 3)
            {
                MessageBox.Show("Invalid patient ID!", "Notification");
            }
            else
            {
                con.Open();
                String addpoutquery = "INSERT INTO patient VALUES ('" + txb_id.Text + "', '" + txb_fname.Text + "', '" + txb_lname.Text + "', TO_DATE('" + txb_dob.Text + "', 'mm/dd/yyyy'), '" + txb_genre.Text + "', '" + txb_phone.Text + "', '" + txb_address.Text + "')";
                String addoutquery = "INSERT INTO outpatient VALUES ('" + txb_id.Text + "', '" + txb_docidout.Text + "')";
                OleDbDataAdapter oda1 = new OleDbDataAdapter(addpoutquery, con);
                OleDbDataAdapter oda2 = new OleDbDataAdapter(addoutquery, con);
                DataTable dt = new DataTable();
                try
                {
                    oda1.Fill(dt);
                    oda2.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Invalid Input! Please try again", "Notification");
                    check_fail = true;
                }
                if (check_fail)
                {
                    String delete_query = "DELETE FROM patient where pid = '" + txb_id.Text + "'";
                    OleDbDataAdapter oda3 = new OleDbDataAdapter(delete_query, con);
                    oda3.Fill(dt);
                    con.Close();
                }
                else
                {
                    con.Close();
                    LoadOutQuery();
                    MessageBox.Show("Add new patient successful!");
                    ClearTextBoxes();
                }
            }
        }

        private void Btn_addin_Click(object sender, EventArgs e)
        {
            Boolean check_fail = false;
            if (string.IsNullOrEmpty(txb_id.Text))
            {
                MessageBox.Show("Please insert patient ID!", "Notification");
            }
            else if (txb_id.Text[0] != 'I' || txb_id.Text[1] != 'P' || txb_id.Text.Length < 3)
            {
                MessageBox.Show("Invalid patient ID!", "Notification");
            }
            else
            {
                con.Open();
                String addpatientquery = "INSERT INTO patient VALUES ('" + txb_id.Text + "', '" + txb_fname.Text + "', '" + txb_lname.Text + "', TO_DATE('" + txb_dob.Text + "', 'mm/dd/yyyy'), '" + txb_genre.Text + "', '" + txb_phone.Text + "', '" + txb_address.Text + "')";
                String addinquery = "INSERT INTO inpatient VALUES ('" + txb_id.Text + "', TO_DATE('" + txb_admdate.Text + "', 'mm/dd/yyyy')" + ", TO_DATE('" + txb_disdate.Text + "', 'mm/dd/yyyy'), '" + txb_diano.Text + "', '" + txb_fee.Text + "', '" + txb_docidin.Text + "', '" + txb_nurid.Text + "', '" + txb_sroom.Text + "')";
                OleDbDataAdapter oda1 = new OleDbDataAdapter(addpatientquery, con);
                OleDbDataAdapter oda2 = new OleDbDataAdapter(addinquery, con);
                DataTable dt = new DataTable();
                try
                {
                    oda1.Fill(dt);
                    oda2.Fill(dt);
                    this.dataGridView2.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Invalid Input! Please try again", "Notification");
                    check_fail = true;
                }
                if (check_fail)
                {
                    String delete_query = "DELETE FROM patient where pid = '" + txb_id.Text + "'";
                    OleDbDataAdapter oda3 = new OleDbDataAdapter(delete_query, con);
                    oda3.Fill(dt);
                    con.Close();
                } else
                {
                    con.Close();
                    LoadInQuery();
                    MessageBox.Show("Add new patient successful!");
                    ClearTextBoxes();
                }
            }
        }
    }
}
