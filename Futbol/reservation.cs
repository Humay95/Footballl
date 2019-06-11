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
    public partial class reservation : Form
    {
        FootballHumayEntities db = new FootballHumayEntities();

        public reservation()
        {
            InitializeComponent();
        }

        private void Btnrsrv_Click(object sender, EventArgs e)
        {
            string firstname = txtfirstname.Text;
            string lastname = txtLastName.Text;
            string phonenumber = txtPhone.Text;
            string pitchname = comboPitchName.Text;
            string pitchnumber = combopitchNumber.Text;
            string roomnumber = comboRoomNumber.Text;
            DateTime datefrom = dateFrom.Value;
            DateTime dateto = dateTo.Value;
            Decimal ReservPrice = NumPrice.Value;
            if (Extensions.isNotEmpty(new string[]
            {
               firstname,lastname,phonenumber,pitchname,pitchnumber,roomnumber,
            }, string.Empty))
            {
                int clientId = 0;
                Client selectedClnt = null;
                int RoomId = db.Rooms.FirstOrDefault(rm => rm.Rooms_Number == pitchname).Id;
                int Pt = db.Pitches.FirstOrDefault(pitc => pitc.Pitch_Name == pitchname).Id;
                Task clientTask = Task.Factory.StartNew(() =>
                  {
                      selectedClnt = db.Clients.Add(new Client
                      {
                          First_Name = firstname,
                          Last_Name = lastname,
                          Phone=Convert.ToInt32(phonenumber),

                      });
                      db.SaveChanges();
                  });
                clientTask.Wait();
                if (clientTask.IsCompleted)
                {
                    clientId = selectedClnt.Id;
                }
               
                }

                //Client Clt = db.Clients.Add(new Client
                //{
                //    First_Name = firstname,
                //    Last_Name = lastname,
                //    Phone = Convert.ToInt32(phonenumber)
                //});
                //db.SaveChanges();
            



            void FillDataGridView()
            {
                dtgview.DataSource = db.Reservations.
                    Select(m => new
                    {
                        m.Client.First_Name,
                        m.Client.Last_Name,
                        m.Client.Phone,
                        m.Pitch.Pitch_Name,
                        m.Pitch.Pitch_Number,
                        m.Room.Rooms_Number,
                        m.Reservation_Date,

                    }).ToList();
            }

        }
    }
}
