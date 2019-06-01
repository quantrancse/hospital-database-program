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
using System.Data.SqlClient;

namespace LoginPanel
{
	public partial class Menu : MaterialForm
	{
		public Menu()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		private void Btn_logout_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure to logout?", "Notification", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Program.Context.MainForm = new LoginPanel();
				this.Close();
				Program.Context.MainForm.Show();
			}
		}

		private void Btn_search_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm = new SearchPatient();
			this.Close();
			Program.Context.MainForm.Show();
		}

		private void Btn_list_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm = new ListPatient();
			this.Close();
			Program.Context.MainForm.Show();
		}

		private void Btn_add_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm = new AddPatient();
			this.Close();
			Program.Context.MainForm.Show();
		}

		private void Btn_makerp_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm = new MakeReport();
			this.Close();
			Program.Context.MainForm.Show();
		}
       
    }
}
