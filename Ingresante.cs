﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2
{
    internal class Ingresante
    {
        string nombre;
        string direccion;
        int edad;
        string cuit;
        string genero;
        string pais;
        string[] curso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public Ingresante(string nombre, string direccion, int edad, string cuit, string genero, string[] curso, string pais)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Curso = curso;
            this.Pais = pais;
        }

        // Método para mostrar información del registro del ingresante
        public string Mostrar()
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                if ((curso[i].Contains("C#")) || (curso[i].Contains("C++")) || (curso[i].Contains("JavaScript")))
                {
                    strBuilder.Append(curso[i] + " - ");
                }
            }

            return ($"Nombre del alumno: {Nombre} \nEdad: {Edad} \nCuit: {Cuit} \nGénero: {Genero} \nPaís: {Pais} \nCursos seleccionados: {strBuilder}");
        }

    }
}
