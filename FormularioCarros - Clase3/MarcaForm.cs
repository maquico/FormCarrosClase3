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
    public partial class MarcaForm : Form
    {
        public bool Adding { get; set; } = true;
        public MarcaForm()
        {
            InitializeComponent();

            ReadJson();
        }

        private void ReadJson()
        {
            var marcasList = new List<Modelos.Modelo>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json"))
            {
                var marcasInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", Encoding.UTF8);
                marcasList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(marcasInJson);
                dgDatosMarca.DataSource = marcasList;

                txtId.Text = (marcasList.Count + 1).ToString();
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
                var marcasList = new List<Modelos.Marca>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json"))
                {
                    var marcasInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", Encoding.UTF8);
                    marcasList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Marca>>(marcasInJson);
                }

                var marca = new Modelos.Marca();
                if (Adding == true) //Add new Item
                {
                    marca = new Modelos.Marca()
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
                    marca = marcasList.FirstOrDefault(x => x.Id == Id);
                    if (marca != null)
                    {
                        marcasList.Remove(marca);
                        marca.Name = txtNombre.Text;
                        marca.Visible = chkVisible.Checked;
                        marca.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                marcasList.Add(marca);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(marcasList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("La marca fue creada con exito.");

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
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            clearFields();
            ReadJson();
        }
    }
}
    
