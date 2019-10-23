using System;

namespace Clases
{
    public class Cuenta
    {
        private String usuarioRegistrado = "user";
        private String contraRegistada = "pass";
        private String ruta = "form";

        public String usuario { get; set; }
        public String contrasena { get; set; }

        public String validar()
        {
            if (usuarioRegistrado.Equals(usuario) && contraRegistada.Equals(contrasena))
            {
                return ruta;
            }
            else
            {
                return "login";
            }
        }
    }
}
