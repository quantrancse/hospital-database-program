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
	public partial class LoginPanel : MaterialForm
	{
		public LoginPanel()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		private Boolean check_login(String username, String password)
		{
            Program.Oleconn = "Provider=ORAOLEDB.ORACLE;Data Source=XE;User ID=manager;Password=" + password + ";Unicode=True";
            using (var con = new OleDbConnection(Program.Oleconn))
            {
                try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

		private void Btn_login_Click(object sender, EventArgs e)
		{
			if (check_login(txb_username.Text, txb_password.Text))
			{
				Program.Context.MainForm = new Menu();
				this.Close();
				Program.Context.MainForm.Show();
			}
			else
				MessageBox.Show("Connect to the Database Fail", "Notification");
		}

	}
}
