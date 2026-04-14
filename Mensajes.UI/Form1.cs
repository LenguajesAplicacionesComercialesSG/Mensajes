namespace Mensajes.UI
{
    public partial class Form1 : Form
    {
        BL.GestorMensaje gestorMensaje;
        string[] nombres = new string[1000];
        public Form1()
        {
            InitializeComponent();
            gestorMensaje = new BL.GestorMensaje();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (!this.isValid())
            {
                MessageBox.Show("Debe ingresar un nombre y un apellido");
                return;
            }


            string mensajeConcatenado = gestorMensaje.procesarDatos(txtNombre.Text, txtApellido.Text);

            MessageBox.Show(mensajeConcatenado);

            this.limpiarCampos();

        }


        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private bool isValid()
        {

            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
