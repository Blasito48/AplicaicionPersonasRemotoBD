using System.CodeDom;
using System.Data;
using System.Diagnostics;

//uso la libreria de Excel
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace AplicaicionPersonasRemotoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (ClaseFunciones.Func_Conectar())
            {
                MessageBox.Show("Conectado a SQL Server Remoto", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Excepcion: " + ClaseFunciones.excepcion);
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla Backspace (borrar)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClaseFunciones.Func_TraerDatos();
            //muestro el datatable en datagrid
            DgvPersonas.DataSource = dt;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //habilito los texbox
            TxtID.Enabled = true;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;
            //limpiar textbox
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            //habilito el guarda y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            //deshabilito los demas botones
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            //mando el foco al txtID
            TxtID.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //deshabilito los texbox
            TxtID.Enabled = false;
            TxtNombre.Enabled = false;
            TxtTelefono.Enabled = false;
            //limpiar textbox
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            //deshabilito el guardar y cancelar
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            //habilito los demas botones
            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnSalir.Enabled = true;
            //mando el foco
            BtnNuevo.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //creo un dialog result    
            DialogResult Rpta = new DialogResult();
            Rpta = MessageBox.Show("Desea Salir de la Aplicacion ?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Rpta == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //valido que usuario llene los datos
            if (TxtID.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTelefono.Text.Length > 0)
            {
                //inserta cuando el textbox ID esta habilitado
                if (TxtID.Enabled == true)
                {
                    if (ClaseFunciones.Func_Insertar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Guardada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro el datatable en datagrid
                        DgvPersonas.DataSource = dt;
                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //editar
                    if (ClaseFunciones.Func_Editar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Editada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro el datatable en datagrid
                        DgvPersonas.DataSource = dt;
                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Falta Ingresar Datos!!!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //capturo el id del datagrid
            long ideliminar = Convert.ToInt64(DgvPersonas.CurrentRow.Cells["ID"].Value.ToString());
            string name = DgvPersonas.CurrentRow.Cells["NOMBRE"].Value.ToString();
            //pregunto si quiere eliminar
            //creo un dialog result    
            DialogResult Rpta = new DialogResult();
            Rpta = MessageBox.Show("Desea Eliminar El ID " + ideliminar, "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Rpta == DialogResult.OK)
            {
                if (ClaseFunciones.Func_Eliminar(ideliminar))
                {
                    MessageBox.Show("Persona Eliminada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = ClaseFunciones.Func_TraerDatos();
                    //muestro el datatable en datagrid
                    DgvPersonas.DataSource = dt;
                    BtnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //habilito los texbox
            TxtID.Enabled = false;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;
            //capturar datos del datagridview
            TxtID.Text = DgvPersonas.CurrentRow.Cells["ID"].Value.ToString();
            TxtNombre.Text = DgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtTelefono.Text = DgvPersonas.CurrentRow.Cells["Telefono"].Value.ToString();
            //habilito el guarda y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            //deshabilito los demas botones
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            //mando el foco al txtID
            TxtNombre.Focus();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Courier New", 13, FontStyle.Bold);
            DataTable dt = new DataTable();
            dt = ClaseFunciones.Func_TraerDatos();
            //titulo
            e.Graphics.DrawString("Listado Personas", fuente, new SolidBrush(Color.Black), new PointF(300, 10));
            e.Graphics.DrawString("ID", fuente, new SolidBrush(Color.Black), new PointF(50, 50));
            e.Graphics.DrawLine(new Pen(Color.Aqua, 20), 0, 0, 300, 0);
            //recorro la tabla
            int fila = 80;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long id = Convert.ToInt64(dt.Rows[i]["ID"].ToString());
                string name = dt.Rows[i]["Nombre"].ToString();
                string tel = dt.Rows[i]["Telefono"].ToString();
                e.Graphics.DrawString(id.ToString(), fuente, new SolidBrush(Color.Black), new PointF(50, fila));
                fila = fila + 20;

            }

            //final de pagina
            e.HasMorePages = false;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            //creo un libro de excel
            XLWorkbook libro = new XLWorkbook();
            //crea una hoja de ese libro
            var hoja = libro.Worksheets.Add("Personas");
            //datos
            hoja.Cell("A1").Value = "Listado Personas";
            hoja.Cell("A2").Value = "ID";
            hoja.Cell("B2").Value = "Nombre";
            hoja.Cell("C2").Value = "Telefono";
            //creo un datatable y lo llamo de las funciones
            DataTable dt = ClaseFunciones.Func_TraerDatos();
            //variable para las filas los datos comienzan la fila 3
            int fila = 3;
            //recorre el datatable
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                //leer datatable
                hoja.Cell("A" + fila).Value = dt.Rows[i]["ID"].ToString();
                hoja.Cell("B" + fila).Value = dt.Rows[i]["Nombre"].ToString();
                hoja.Cell("C" + fila).Value = dt.Rows[i]["Telefono"].ToString();
                fila++;
            }
            //combinar y centrar la 1er fila
            var rangotitulo = hoja.Range("A1:C1");
            rangotitulo.Merge();
            //rango encabezados
            var rangoencabezados = hoja.Range("A2:C2");
            // Centrar horizontalmente
            rangoencabezados.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            // Centrar horizontalmente
            rangotitulo.Style.Alignment.Horizontal =XLAlignmentHorizontalValues.Center;
            // Centrar verticalmente
            rangotitulo.Style.Alignment.Vertical =XLAlignmentVerticalValues.Center;
            //negrilla a los titulos
            hoja.Cell("A1").Style.Font.Bold = true;
            hoja.Cell("A2").Style.Font.Bold = true;
            hoja.Cell("B2").Style.Font.Bold = true;
            hoja.Cell("C2").Style.Font.Bold = true;
            //auto ajusto las columnas
            hoja.Columns().AdjustToContents();
            //le pongo bordes
            var rango = hoja.Range("A2:C"+(fila-1));
            rango.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            rango.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            //guardo el libro de excel
            libro.SaveAs(@"D:\ListadoPersonas.xlsx");
            //prengunto si el libro existe
            if (File.Exists("D:\\ListadoPersonas.xlsx"))
            {
                Process p = new()
                {
                    StartInfo = new("D:\\ListadoPersonas.xlsx")
                    { UseShellExecute = true }
                };
                p.Start();
            }
        }
    }
}
