namespace Mensajes.BL
{
    public class GestorMensaje
    {


        public string procesarDatos(string Nombre, string Apellido)
        {

            string mensaje = Nombre + " " + Apellido;

            return mensaje;

        }

        public string procesarDatos(string Nombre, string Apellido, string Correo)
        {
            string mensaje = "Hola, " + Nombre + " " + Apellido + " " + Correo;
            return mensaje;
        }

    }
}
