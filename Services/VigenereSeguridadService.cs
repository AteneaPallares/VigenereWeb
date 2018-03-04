
using System;
using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjDesEncriptado = new StringBuilder();
            
            int i=0;
            int x=0;
            foreach(var y in clave){
                if(char.IsLetter(y)){
                    x++;
                }
            }
            if(x==0){
                x=1;
            }
            int[] num=new int[x];
            foreach(var m in clave){
                if(char.IsLetter(m)){
                    var numero=ABECEDARIO.IndexOf(char.ToUpper(m));
                    var res=numero;
                    num[i]=res%27;
                    i++;
                    }
            }
            int h=0;
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(h>x-1){
                        h=0;
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraDesEnc = (posLetra - num[h]) % ABECEDARIO.Length;
                    /// Esto es lo mismo que un if(posLetraDesEnc < 0){posLetraDesEnc += ABECEDARIO.Length} else {posLetraDesEnc}
                    if(posLetraDesEnc<0){
                        posLetraDesEnc=ABECEDARIO.Length+posLetraDesEnc;
                    }
                    var letraEnc = ABECEDARIO[posLetraDesEnc];
                    if (char.IsUpper(letra))
                    {
                        msjDesEncriptado.Append(letraEnc);

                    }
                    else
                    {
                        msjDesEncriptado.Append(char.ToLower(letraEnc));
                    }
                    h++;

                }
                else
                {
                    msjDesEncriptado.Append(letra);
                }
            
            }

            return msjDesEncriptado.ToString();
        }



        //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();
            
            int i=0;
            int x=0;
            foreach(var y in clave){
                if(char.IsLetter(y)){
                    x++;
                }
            }
            if(x==0){
                x=1;
            }
            int[] num=new int[x];
            foreach(var m in clave){
                if(char.IsLetter(m)){
                    var numero=ABECEDARIO.IndexOf(char.ToUpper(m));
                    var res=numero;
                    num[i]=res%27;
                    i++;
                    }
            }
            int h=0;
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(h>x-1){
                        h=0;
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraDesEnc = (posLetra + num[h]) % ABECEDARIO.Length;
                    /// Esto es lo mismo que un if(posLetraDesEnc < 0){posLetraDesEnc += ABECEDARIO.Length} else {posLetraDesEnc}
                    var letraEnc = ABECEDARIO[posLetraDesEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letraEnc);

                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letraEnc));
                    }
                    h++;

                }
                else
                {
                    msjEncriptado.Append(letra);
                }
            
            }

            return msjEncriptado.ToString();
        }
    }


}