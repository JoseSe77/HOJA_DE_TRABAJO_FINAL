﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOJA_DE_TRABAJO_FINAL
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private double Altura;
        public Persona(string nombre, string apellido, int edad, double altura)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Altura = altura;
        }

        public string NombreCompleto()
        {
            string nombreCompleto = Nombre + " " + Apellido;
            return nombreCompleto;
        }

        public double AlturaEnMetros()
        {
            double alturaEnMetros = Altura / 100;
            return alturaEnMetros;
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "0";
            while (opcion == "0")
            {
                Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623");
                Console.WriteLine("\nIngrese una opción: \n");

                Console.WriteLine("1. EJERCICIO 1 PERSONAS");
                Console.WriteLine("2. EJERCICIO 2 MATRIZ");
                Console.WriteLine("3. SALIR");

                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case ("1"):
                        Console.Clear();
                        Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623");

                        Console.WriteLine("\nIngrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("\nIngrese el apellido de la persona: ");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("\nIngrese la edad de la persona: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nIngrese la altura de la persona en centímetros: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.Clear();

                        Persona personita = new Persona(nombre, apellido, edad, altura);
                        Console.WriteLine("\nEl nombre completo de la persona es: " + personita.NombreCompleto());

                        Console.WriteLine("\nLa altura de la persona es: " + personita.AlturaEnMetros() + " metros");

                        Console.WriteLine("\nLa edad de la persona es: " + edad + " años");

                        Console.ReadKey();
                        Console.Clear();
                        opcion = "0";
                        break;

                    case ("2"):
                        Console.Clear();
                        Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623");

                        int filas, columnas = 0;
                        
                        
                        Console.WriteLine("\nIngrese la cantidad de filas para la matriz: ");
                        filas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nIngrese la cantidad de columnas para la matriz: ");
                        columnas = Convert.ToInt32(Console.ReadLine());

                        int[,] matriz = new int[filas, columnas];
                        int cont2 = 0;
                        int cont3 = 0;

                        for (int i = 0; i < columnas; i++)
                        {
                            cont2++;
                            matriz[0, i] = cont2;
                        }

                        for (int cont = 1; cont < filas; cont++)
                        {
                            for (int i = 0; i < columnas; i++)
                            { 
                                matriz[cont, i] = matriz[0, i] + matriz[cont3, i];
                            }
                            cont3++;
                        }

                        Console.Clear();
                        Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623\n");
                        for (int i = 0; i < filas; i++)
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                Console.Write(matriz[i, j] + "   |   ");
                            }
                            Console.WriteLine();
                        }


                        Console.ReadKey();
                        Console.Clear();
                        opcion = "0";
                        break;

                    case ("3"):
                        opcion = "1";
                        Console.Clear();
                        Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623");
                        Console.WriteLine("\nHasta pronto!\n");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Trabajo Supervisado - José Pablo Sosa España - 1057623");
                        Console.WriteLine("\nEsa no es una opción del menú.");
                        opcion = "0";
                        break;
                }
            }
        }
    }
}
