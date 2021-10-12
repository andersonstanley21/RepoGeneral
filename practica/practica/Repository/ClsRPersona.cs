using practica.Data;
using practica.Negocio;
using practica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace practica.Repository
{
    class ClsRPersona : Service.Ipersona
    {
        public void create(Data.Ipersona persona)
        {
           
            using (Data.Ipersona conxonBD = new ClsPersona())
            {
                try
                {

                }
                catch
                {

                }
            }
        }

        public void create()
        {
            throw new NotImplementedException();
        }
    }
}
