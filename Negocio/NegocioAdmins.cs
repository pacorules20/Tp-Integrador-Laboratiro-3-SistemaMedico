using Datos;

namespace Negocio
{
    public class NegocioAdmins
    {
        //Funcion de Verificado de Login Administrativo  

        public string VerificarLoginAdmin(string userName, string PWD)
        {
            DatosMedicos dat = new DatosMedicos();

            //Consigue el nombre del admin, si las credenciales son validas

            string nombre = dat.LoginAdmin(userName, PWD);
            return nombre;
        }
    }
}
