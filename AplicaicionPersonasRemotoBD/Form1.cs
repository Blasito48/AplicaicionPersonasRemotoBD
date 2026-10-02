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
    }
}
