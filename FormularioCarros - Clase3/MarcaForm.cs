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
            var marcasList = new List<Modelos.Marca>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json"))
            {
                var marcasInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", Encoding.UTF8);
                marcasList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Marca>>(marcasInJson);
                dgDatosMarca.DataSource = marcasList;

                txtId.Text = (marcasList.Count + 1).ToString();
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

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            clearFields();
            ReadJson();
        }
        private void dgDatosMarca_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgDatosMarca.Rows[e.RowIndex].Selected = true;
                var rI = e.RowIndex;
                dgDatosMarca.CurrentCell = dgDatosMarca.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgDatosMarca, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var marcaList = new List<Modelos.Marca>();

                if (File.Exists($"{ AppDomain.CurrentDomain.BaseDirectory}\\marcas.json"))
                {
                    var marcasInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", Encoding.UTF8);
                    marcaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Marca>>(marcasInJson);

                    var Id = Convert.ToInt32(dgDatosMarca.CurrentRow.Cells["Id"].Value);
                    var marca = marcaList.FirstOrDefault(x => x.Id == Id);
                    if (marca != null)
                    {
                        marcaList.Remove(marca);

                        //Convert List to Json Object
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(marcaList);

                        //Write Json File
                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\marcas.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        ReadJson();
                    }
                }
            }
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDatosMarca.SelectedRows.Count != 0)
            {
                txtId.Text = dgDatosMarca.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgDatosMarca.CurrentRow.Cells["Name"].Value.ToString();
                chkVisible.Checked = (bool)dgDatosMarca.CurrentRow.Cells["Visible"].Value;
                Adding = false;

            }
        }
    }
}
    
