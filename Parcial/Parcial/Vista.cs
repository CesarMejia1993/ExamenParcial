using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Vista
    {
        string idDepto;
        string nombreDepto;
        string medicionMm;
        DateTime fechaReg;

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

        public string NombreDepto
        {
            get
            {
                return nombreDepto;
            }

            set
            {
                nombreDepto = value;
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

        public DateTime FechaReg
        {
            get
            {
                return fechaReg;
            }

            set
            {
                fechaReg = value;
            }
        }
    }
}
