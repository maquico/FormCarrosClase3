using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCarros___Clase3
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
            GetColors();
            GetModels();

            //lblMsg.Text = AppDomain.CurrentDomain.BaseDirectory
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnColorForm_Click(object sender, EventArgs e)
        {
            var frm = new ColorForm();
            frm.ShowDialog();
        }
        
        private void btnModelForm_Click(object sender, EventArgs e)
        {
            var frm = new ModelForm();
            frm.Show();
        }

        private void btnMarcaForm_Click(object sender, EventArgs e)
        {
            var frm = new MarcaForm();
            frm.Show();
        }

        private void GetColors()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {
                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                var colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Color>>(colorsInJson);

                cbColor.DataSource = colorList.Where(x => x.Visible).ToList();
                cbColor.DisplayMember = "Name";
                cbColor.ValueMember = "Id";

            }

        }

        private void GetModels()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json"))
            {
                var modelsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", Encoding.UTF8);
                var modelsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Color>>(modelsInJson);

                cbModelo.DataSource = modelsList.Where(x => x.Visible).ToList();
                cbModelo.DisplayMember = "Name";
                cbModelo.ValueMember = "Id";
            }
        }
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}