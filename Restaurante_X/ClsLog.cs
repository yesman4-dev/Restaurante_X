using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_X
{
    class ClsLog
    {
        private static int v_IdUsuario;

        public static int IdUsuario
        {
            get { return v_IdUsuario; }
            set { v_IdUsuario = value; }
        }


        private static string v_Usuario;

        public static string Usuario
        {
            get { return v_Usuario; }
            set { v_Usuario = value; }
        }


        private static int v_CodEmpleado;

        public static int CodEmpleado
        {
            get { return v_CodEmpleado; }
            set { v_CodEmpleado = value; }
        }

        private static int v_Estado;

        public static int Estado
        {
            get { return v_Estado; }
            set { v_Estado = value; }
        }

        private static int v_Tipo_de_Usuario;

        public static int Tipo_de_Usuario
        {
            get { return v_Tipo_de_Usuario; }
            set { v_Tipo_de_Usuario = value; }
        }

        private static DateTime v_Ultimo_Login;

        public static DateTime Ultimo_Login
        {
            get { return v_Ultimo_Login; }
            set { v_Ultimo_Login = value; }
        }


        private static string v_Time_Login;

        public static string Time_Login
        {
            get { return v_Time_Login; }
            set { v_Time_Login = value; }
        }
        

    }
}
