﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Departamento
    {
        string idDepto;
        string nombreDepto;

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
    }
}
