﻿using ProyectoSimulacro406030V2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimulacro406030V2.Datos.Interfaz
{
    public interface IOrdenRetiroDao
    {
        List<Material> GetMaterial();
    }
}
