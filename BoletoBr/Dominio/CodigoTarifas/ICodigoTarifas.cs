﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletoBr.Bancos;
using BoletoBr.Interfaces;

namespace BoletoBr.Dominio.CodigoTarifas
{
    public interface ICodigoTarifas
    {
        IBanco Banco { get; }
        int Codigo { get; set; }
        string Descricao { get; }
    }
}
