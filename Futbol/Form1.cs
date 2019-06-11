
using Futbol.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol
{
    public partial class adminDashboard : Form
    {
        FootballHumayEntities db = new FootballHumayEntities();
        public adminDashboard()
        {
            InitializeComponent();
        }

 

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            bool allEmpty = Extensions.isNotEmpty(new string[] {


                Email, Password
            }, String.Empty);
           
            if (allEmpty)
            {
                string adminName = db.Admins.First(ad => ad.Id == 1).Email;
                string adminPassword = db.Admins.First(ad => ad.Id == 1).Password;
                if (Email==adminName && Password==adminPassword)
                {
                    Reserv rsv = new Reserv();
                    rsv.ShowDialog();
                    
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Email ve parol dogru deyil";
                }
              
            }
            
        }

     
    }
}
