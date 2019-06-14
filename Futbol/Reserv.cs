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
    public partial class Reserv : Form
    {
        public Reserv()
        {
            InitializeComponent();
        }

        private void Btnreserv_Click(object sender, EventArgs e)
        {
            reservation rsv = new reservation();
            rsv.ShowDialog();
        }

        private void Btnpitchs_Click(object sender, EventArgs e)
        {
            Pitchs pic = new Pitchs();
            pic.ShowDialog();
        }

        private void Btnroom_Click(object sender, EventArgs e)
        {
            RoomsDash rm = new RoomsDash();
            rm.ShowDialog();
        }

        private void Btnclients_Click(object sender, EventArgs e)
        {
            ClientDashboard clnt = new ClientDashboard();
            clnt.ShowDialog();

        }
    }
}
