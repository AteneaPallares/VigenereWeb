
namespace VigenereWeb.Services
{


    public interface ISeguridadService<T>
    {
        
        string Encriptar(string Mensaje, string clave);
        string DesEncriptar(string Mensaje, string clave);
    }

}