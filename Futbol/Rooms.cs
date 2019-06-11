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
    public partial class RoomsDash : Form
    {
        FootballHumayEntities db = new FootballHumayEntities();
        public RoomsDash()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            dtgview.DataSource = db.Rooms.
            Select(m => new
            {
                m.Rooms_Number,
                m.Person_Count,
                m.Status,
            }).ToList();



    }

        private void Btnrmsadd_Click(object sender, EventArgs e)
        {
            string number = txtroom.Text;
            int count = (int)num.Value;
            if (number != string.Empty && count != 0)
            {
                Room rm = null;
                rm = new Room
                {
                    Rooms_Number = number,
                    Person_Count=count,
                };
                db.Rooms.Add(rm);
                db.SaveChanges();
                FillDataGridView();
                MessageBox.Show(rm.Rooms_Number + " Elave olundu", "Succeffuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblError.Text = "Xanalari doldurmaginiz xahish olunur";
                lblError.Visible = true;
            }
        }

    }
       
}
