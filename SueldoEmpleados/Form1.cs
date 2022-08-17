namespace SueldoEmpleados
{
    public partial class frmPagoEmpleado : Form
    {
        public frmPagoEmpleado()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Ingresando datos
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            //Calcular
            double sueldobasico = costo * horas;
            double bonificacion = sueldobasico * 0.2;
            double sueldobruto = sueldobasico + bonificacion;
            double descuento = (sueldobruto * 12) / 100;
            double sueldoneto = sueldobruto - descuento;

            //Imprimiendo datos
            lblSueldoBasico.Text = sueldobasico.ToString();
            lblSueldoBruto.Text = sueldobruto.ToString();
            lblSueldoNeto.Text = sueldoneto.ToString();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de salir?", 
                                             "Pago a Empleados", 
                                             MessageBoxButtons.YesNo, 
                                             MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lblSueldoBasico.Text = "";
            lblSueldoBruto.Text = "";
            lblSueldoNeto.Text = "";
        }
    }
}