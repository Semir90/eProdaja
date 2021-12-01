using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Flurl.Http;
using Flurl;

namespace eProdaja.WinUI
{
    public partial class frmCovidPasos : Form
    {
        APIService kupciService = new APIService("Kupci");
        APIService covidPasosService = new APIService("CovidPasos");
        public frmCovidPasos()
        {
            InitializeComponent();
        }

        private async void frmCovidPasos_Load(object sender, EventArgs e)
        {
            await LoadKupci();
        }

        private async Task LoadKupci()
        {
            var kupci = await kupciService.GetAll<List<Kupci>>();
            cmbxKupci.DataSource = kupci;
            cmbxKupci.DisplayMember = "Ime";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
