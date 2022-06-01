using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCarros___Clase3
{
    public partial class ModelForm : Form
    {
        public bool Adding { get; set; } = true;
        public ModelForm()
        {
            InitializeComponent();

            ReadJson();
        }

        private void ReadJson()
        {
            var modelsList = new List<Modelos.Modelo>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json"))
            {
                var modelsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", Encoding.UTF8);
                modelsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(modelsInJson);
                dgDatosModelo.DataSource = modelsList;

                txtId.Text = (modelsList.Count + 1).ToString();
            }
            else
            {
                txtId.Text = "1";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveJson()
        {
            try
            {
                var modelsList = new List<Modelos.Modelo>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json"))
                {
                    var modelsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", Encoding.UTF8);
                    modelsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(modelsInJson);
                }

                var modelo = new Modelos.Modelo();
                if (Adding == true) //Add new Item
                {
                    modelo = new Modelos.Modelo()
                    {
                        Id = int.Parse(txtId.Text),
                        Name = txtNombre.Text,
                        Visible = chkVisible.Checked,
                        CreatedDate = DateTime.Now
                    };

                }
                else //Update Item
                {
                    var Id = Convert.ToInt32(txtId.Text);
                    modelo = modelsList.FirstOrDefault(x => x.Id == Id);
                    if (modelo != null)
                    {
                        modelsList.Remove(modelo);
                        modelo.Name = txtNombre.Text;
                        modelo.Visible = chkVisible.Checked;
                        modelo.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                modelsList.Add(modelo);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(modelsList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El modelo fue creado con exito.");

                //Clear fields
                clearFields();

                //Read Json Method
                ReadJson();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void clearFields()
        {
            Adding = true;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkVisible.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            clearFields();
            ReadJson();
        }
    }
}

