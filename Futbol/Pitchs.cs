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
    public partial class Pitchs : Form
    {
        FootballHumayEntities db = new FootballHumayEntities();
        public Pitchs()
        {
            InitializeComponent();
        }


        private void Pitchs_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            dtgview.DataSource = db.Pitches.
                Select(m => new
                {
                    m.Pitch_Name,
                    m.Pitch_Number,
                    m.Price,
                  mode=m.Status==0 ? "Empty" : "Full"

                }).ToList();
        }

        private void BtnPitch_Click(object sender, EventArgs e)
        {
            string Pitchsname = txtpcname.Text;
            int Pitchsnumber =(int) nmpicnum.Value;
            Decimal Pitchsprice = numptc.Value;
            if (Extensions.isNotEmpty(new string[] {
                Pitchsname,
            }, string.Empty))
            {
                if (Pitchsprice != 0 && Pitchsnumber!=0)
                {
                    Pitch pc = null;
                    pc = new Pitch
                    {
                        Pitch_Name = Pitchsname,
                        Pitch_Number = Pitchsnumber.ToString(),
                        Price=Pitchsprice,

                        Status = 0
                        

                    };

                    db.Pitches.Add(pc);
                    db.SaveChanges();
                    FillDataGridView();
                    MessageBox.Show(pc.Pitch_Name + " Elave olundu" , "Succeffuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Xanalari doldurmaginiz xahish olunur";

            }
        }

      
    }
}
