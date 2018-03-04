using System.Text;

namespace VigenereWeb.Services
{

    public class SeguridadService : ISeguridadService<string>
    {
        //static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            StringBuilder msjDesEnc = new StringBuilder();
            return msjDesEnc.ToString();
        }



        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();

            return msjEncriptado.ToString();
        }
    }


}