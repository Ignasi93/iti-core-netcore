﻿using EjercicioToken.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioToken.Domain.Factories
{
    public static class TareasProgramadaFactory
    {

        public static TareaProgramada CrearTareaProgramada(string nombre, string identifier, string cron)
        {
            return new TareaProgramada(nombre, identifier, cron);
        }
    }
}
