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
        public string marcaDelModelo { get; set; }
        public string tipoDelModelo { get; set; }
        public ModelForm()
        {
            InitializeComponent();
            GetTipos();
            GetMarcas();
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
                    marcaDelModelo = cbMarca.SelectedText;
                    tipoDelModelo = cbTipo.SelectedText;
                    modelo = new Modelos.Modelo()
                    {
                        
                        Id = int.Parse(txtId.Text),
                        Name = txtNombre.Text,
                        Visible = chkVisible.Checked,
                        TipoId = Convert.ToInt32(cbTipo.SelectedValue),
                        MarcaId = Convert.ToInt32(cbMarca.SelectedValue),
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
                        modelo.TipoId = Convert.ToInt32(cbTipo.SelectedValue);
                        modelo.MarcaId = Convert.ToInt32(cbMarca.SelectedValue);
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

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var modelosList = new List<Modelos.Modelo>();

                if (File.Exists($"{ AppDomain.CurrentDomain.BaseDirectory}\\modelos.json"))
                {
                    var modelosInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", Encoding.UTF8);
                    modelosList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Modelo>>(modelosInJson);

                    var Id = Convert.ToInt32(dgDatosModelo.CurrentRow.Cells["Id"].Value);
                    var modelo = modelosList.FirstOrDefault(x => x.Id == Id);
                    if (modelo != null)
                    {
                        modelosList.Remove(modelo);

                        //Convert List to Json Object
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(modelosList);

                        //Write Json File
                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\modelos.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        ReadJson();
                    }
                }
            }
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDatosModelo.SelectedRows.Count != 0)
            {
                txtId.Text = dgDatosModelo.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgDatosModelo.CurrentRow.Cells["Name"].Value.ToString();
                chkVisible.Checked = (bool)dgDatosModelo.CurrentRow.Cells["Visible"].Value;
                Adding = false;

            }
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

        private void dgDatosModelo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                dgDatosModelo.Rows[e.RowIndex].Selected = true;
                var rI = e.RowIndex;
                dgDatosModelo.CurrentCell = dgDatosModelo.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgDatosModelo, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}

