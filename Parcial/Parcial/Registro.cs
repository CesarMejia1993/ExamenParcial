using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Registro
    {
        string idDepto;
        string medicionMm;
        DateTime fechaRegistro;

        public string IdDepto
        {
            get
            {
                return idDepto;
            }

            set
            {
                idDepto = value;
            }
        }

        public string MedicionMm
        {
            get
            {
                return medicionMm;
            }

            set
            {
                medicionMm = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }

            set
            {
                fechaRegistro = value;
            }
        }
    }
}
