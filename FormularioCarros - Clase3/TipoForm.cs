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
    public partial class TipoForm : Form
    {
        public bool Adding = true;
        public TipoForm()
        {
            InitializeComponent();
            ReadJson();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clearFields();
            ReadJson();
        }
        private void clearFields()
        {
            Adding = true;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkVisible.Checked = false;
        }
        private void SaveJson()
        {
            try
            {
                var tiposList = new List<Modelos.Tipo>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json"))
                {
                    var tiposInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json", Encoding.UTF8);
                    tiposList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Tipo>>(tiposInJson);
                }

                var tipo = new Modelos.Tipo();
                if (Adding == true) //Add new Item
                {
                    tipo = new Modelos.Tipo()
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
                    tipo = tiposList.FirstOrDefault(x => x.Id == Id);
                    if (tipo != null)
                    {
                        tiposList.Remove(tipo);
                        tipo.Name = txtNombre.Text;
                        tipo.Visible = chkVisible.Checked;
                        tipo.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                tiposList.Add(tipo);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(tiposList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El tipo fue creado con exito.");


                //Clear fields
                clearFields();

                //Read Json Method
                ReadJson();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void ReadJson()
        {
            var tiposList = new List<Modelos.Tipo>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json"))
            {
                var tiposInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json", Encoding.UTF8);
                tiposList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Tipo>>(tiposInJson);
                dgDatosTipo.DataSource = tiposList;

                txtId.Text = (tiposList.Count + 1).ToString();
            }
            else
            {
                txtId.Text = "1";
            }
        }

        private void dgDatosTipo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgDatosTipo.Rows[e.RowIndex].Selected = true;
                var rI = e.RowIndex;
                dgDatosTipo.CurrentCell = dgDatosTipo.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgDatosTipo, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var tiposList = new List<Modelos.Tipo>();

                if (File.Exists($"{ AppDomain.CurrentDomain.BaseDirectory}\\tipos.json"))
                {
                    var tiposInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json", Encoding.UTF8);
                    tiposList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelos.Tipo>>(tiposInJson);

                    var Id = Convert.ToInt32(dgDatosTipo.CurrentRow.Cells["Id"].Value);
                    var tipo = tiposList.FirstOrDefault(x => x.Id == Id);
                    if (tipo != null)
                    {
                        tiposList.Remove(tipo);

                        //Convert List to Json Object
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(tiposList);

                        //Write Json File
                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\tipos.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        ReadJson();
                    }
                }
            }
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDatosTipo.SelectedRows.Count != 0)
            {
                txtId.Text = dgDatosTipo.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgDatosTipo.CurrentRow.Cells["Name"].Value.ToString();
                chkVisible.Checked = (bool)dgDatosTipo.CurrentRow.Cells["Visible"].Value;
                Adding = false;

            }
        }
    }
}
