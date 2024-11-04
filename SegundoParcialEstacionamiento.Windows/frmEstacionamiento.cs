namespace SegundoParcialEstacionamiento.Windows
{
    public partial class frmEstacionamiento : Form
    {
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmVehiculosAE frm = new frmVehiculosAE() { Text = "Ingresar Vehículo" };
            frm.ShowDialog();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
