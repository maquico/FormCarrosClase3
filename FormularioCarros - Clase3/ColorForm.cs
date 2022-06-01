using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace FormularioCarros___Clase3
{
    public partial class ColorForm : Form
    {
        public bool Adding { get; set; } = true;
        public ColorForm()
        {
            InitializeComponent();

            ReadJson();
        }

        private void ReadJson()
        {
            var colorList = new List<Modelos.Color>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {
                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Color>>(colorsInJson);
                dgDatosColor.DataSource = colorList;

                txtId.Text = (colorList.Count + 1).ToString();
            }
            else
            {
                txtId.Text = "1";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void SaveJson()
        {
            try
            {
                var colorList = new List<Modelos.Color>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
                {
                    var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                    colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Color>>(colorsInJson);
                }

                var color = new Modelos.Color();
                if (Adding == true) //Add new Item
                {
                    color = new Modelos.Color
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
                    color = colorList.FirstOrDefault(x => x.Id == Id);
                    if (color != null)
                    {
                        colorList.Remove(color);
                        color.Name = txtNombre.Text;
                        color.Visible = chkVisible.Checked;
                        color.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                colorList.Add(color);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(colorList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El color fue creado con exito.");

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
            clearFields();
            ReadJson();
        }


    }
}
