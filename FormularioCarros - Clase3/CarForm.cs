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
        public bool Adding = true;
        public CarForm()
        {
            
            InitializeComponent();
            ReadJson();
            GetColors();
            GetModels();
            GetMarcas();
            GetTipos();

            //lblMsg.Text = AppDomain.CurrentDomain.BaseDirectory
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog cuadroDialog = new OpenFileDialog();
            if (cuadroDialog.ShowDialog()==DialogResult.OK)
            {
                pbFotoCarro.Image = new Bitmap(cuadroDialog.FileName);
                txtPicture.Text= cuadroDialog.FileName;
            }
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
                var modelsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(modelsInJson);

                cbModelo.DataSource = modelsList.Where(x => x.Visible).ToList();
                cbModelo.DisplayMember = "Name";
                cbModelo.ValueMember = "Id";
            }
        }
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GetMarcas()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json"))
            {
                var marcasInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", Encoding.UTF8);
                var marcasList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Marca>>(marcasInJson);

                cbMarca.DataSource = marcasList.Where(x => x.Visible).ToList();
                cbMarca.DisplayMember = "Name";
                cbMarca.ValueMember = "Id";
            }
        }

        private void btnTipoForm_Click(object sender, EventArgs e)
        {
            var frm = new TipoForm();
            frm.Show();
        }

        private void GetTipos()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json"))
            {
                var tiposInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json");
                var tiposList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Tipo>>(tiposInJson);
                cbTipo.DataSource = tiposList.Where(x => x.Visible).ToList();
                cbTipo.DisplayMember = "Name";
                cbTipo.ValueMember = "Id";
            }
            
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReadJson()
        {
            var modelsList = new List<Modelos.Modelo>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json"))
            {
                var modelsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json", Encoding.UTF8);
                modelsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(modelsInJson);
                dgDatosVehiculos.DataSource = modelsList;

                txtId.Text = (modelsList.Count + 1).ToString();
            }
            else
            {
                txtId.Text = "1";
            }
        }

        private void SaveJson()
        {
            try
            {
                var vehicleList = new List<Modelos.Vehicle>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json"))
                {
                    var vehiclesInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json", Encoding.UTF8);
                    vehicleList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Vehicle>>(vehiclesInJson);
                }

                var vehiculo = new Modelos.Vehicle();
                if (Adding == true) //Add new Item
                {
                    vehiculo = new Modelos.Vehicle
                    {
                        Id = int.Parse(txtId.Text),
                        ColorId = Convert.ToInt32(cbColor.SelectedValue),
                        ModeloId = Convert.ToInt32(cbModelo.SelectedValue),
                        MarcaId = Convert.ToInt32(cbMarca.SelectedValue),
                        Año = Convert.ToInt32(txtAño.Text),
                        TipoId = Convert.ToInt32(cbTipo.SelectedValue),
                        Matricula = txtMatricula.Text,
                        Descripcion = txtDescripcion.Text,
                        CreatedDate = DateTime.Now
                    };

                }
                else //Update Item
                {
                    var Id = Convert.ToInt32(txtId.Text);
                    vehiculo = vehicleList.FirstOrDefault(x => x.Id == Id);
                    if (vehiculo != null)
                    {
                        vehicleList.Remove(vehiculo);
                        
                        vehiculo.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                vehicleList.Add(vehiculo);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(vehicleList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El vehiculo fue creado con exito.");

                //Clear fields
                //clearFields();

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
            txtDescripcion.Text = string.Empty;
            txtAño.Text = string.Empty;
            txtMatricula.Text = string.Empty;

        }

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var vehiclesList = new List<Modelos.Vehicle>();

                if (File.Exists($"{ AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json"))
                {
                    var vehiclesInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json", Encoding.UTF8);
                    vehiclesList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Vehicle>>(vehiclesInJson);

                    var Id = Convert.ToInt32(dgDatosVehiculos.CurrentRow.Cells["Id"].Value);
                    var vehiculo = vehiclesList.FirstOrDefault(x => x.Id == Id);
                    if (vehiculo != null)
                    {
                        vehiclesList.Remove(vehiculo);

                        //Convert List to Json Object
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(vehiclesList);

                        //Write Json File
                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\vehiculos.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        ReadJson();
                    }
                }
            }
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDatosVehiculos.SelectedRows.Count != 0)
            {
                txtId.Text = dgDatosVehiculos.CurrentRow.Cells["Id"].Value.ToString();
                txtMatricula.Text = dgDatosVehiculos.CurrentRow.Cells["Matricula"].Value.ToString();
                txtAño.Text = dgDatosVehiculos.CurrentRow.Cells["Año"].Value.ToString();
                Adding = false;

            }
        }

        private void dgDatosVehiculos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgDatosVehiculos.Rows[e.RowIndex].Selected = true;
                var rI = e.RowIndex;
                dgDatosVehiculos.CurrentCell = dgDatosVehiculos.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgDatosVehiculos, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void cbColor_Click(object sender, EventArgs e)
        {
            GetColors();
        }
    }
}