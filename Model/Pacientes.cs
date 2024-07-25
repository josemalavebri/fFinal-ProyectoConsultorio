﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pacientes : IEntidad
    {
        private int id;
        private int cedula;
        private int edad;
        private string nombre;
        private string apellido;
        private string correo;
        private int telefono;

        public Pacientes()
        {
            id = 0;
            cedula = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            telefono = 0;
            correo = string.Empty;
        }

        public Pacientes(int id, int cedula, string nombre, string apellido, string correo, int telefono, int edad)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;
            this.Edad = edad;
        }

        public int Id { get => id; set => id = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return Nombre+" "+Apellido;
        }
    }
}
