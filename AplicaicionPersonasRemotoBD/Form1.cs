using System.Data;

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
    }
}
