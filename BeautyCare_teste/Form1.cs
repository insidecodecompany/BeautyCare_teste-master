using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BeautyCare_teste
{
    public partial class telalogin : Form
    {
        Thread nt;
        public telalogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(home);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void home()
        {
            Application.Run(new telahome());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //teste
            //teste2
        }
    }
}
