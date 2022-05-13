using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class cNegocio
    {
        CapaDatos.cDatos objd = new CapaDatos.cDatos();
        public DataTable N_Login(CapaEntidades.cEntidades obje)
        {
            return objd.D_Login(obje);
        }

    }
}
