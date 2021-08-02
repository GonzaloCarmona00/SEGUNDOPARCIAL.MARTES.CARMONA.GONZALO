using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class LogicaDatos
    {
        /// <summary>
        /// Carga la matriz productos 
        /// </summary>
        /// <param name="auxMatriz"></param>
        static public void CARGAR_MATRIZ_PRODUCTOS(string[,] auxMatriz)
        {
            auxMatriz[0, 0] = "0";
            auxMatriz[1, 0] = "1";
            auxMatriz[2, 0] = "2";
            auxMatriz[3, 0] = "3";
            auxMatriz[4, 0] = "4";
            auxMatriz[5, 0] = "5";
            auxMatriz[6, 0] = "6";
            auxMatriz[7, 0] = "7";
            auxMatriz[8, 0] = "8";
            auxMatriz[9, 0] = "9";
            auxMatriz[0, 1] = null;
            auxMatriz[1, 1] = "Hamburguesa";
            auxMatriz[2, 1] = "Pan";
            auxMatriz[3, 1] = null;
            auxMatriz[4, 1] = "Huevo";
            auxMatriz[5, 1] = "Fetas cheddar";
            auxMatriz[6, 1] = null;
            auxMatriz[7, 1] = "Papas fritas";
            auxMatriz[8, 1] = "Coca Cola";
            auxMatriz[9, 1] = "Cerveza Amber";
            auxMatriz[0, 2] = null;
            auxMatriz[1, 2] = "Comestible";
            auxMatriz[2, 2] = "Comestible";
            auxMatriz[3, 2] = null;
            auxMatriz[4, 2] = "Comestible";
            auxMatriz[5, 2] = "Comestible";
            auxMatriz[6, 2] = null;
            auxMatriz[7, 2] = "Comestible";
            auxMatriz[8, 2] = "Bebida";
            auxMatriz[9, 2] = "Bebida";
        }
        /// <summary>
        /// Carga la matriz de los numeros de los productos
        /// </summary>
        /// <param name="auxMatriz"></param>
        static public void CARGAR_MATRIZ_NUMEROS(int[,] auxMatriz) 
        {
            auxMatriz[0, 0] = 0;
            auxMatriz[1, 0] = 50;
            auxMatriz[2, 0] = 80;
            auxMatriz[3, 0] = 0;
            auxMatriz[4, 0] = 15;
            auxMatriz[5, 0] = 10;
            auxMatriz[6, 0] = 0;
            auxMatriz[7, 0] = 200;
            auxMatriz[8, 0] = 35;
            auxMatriz[9, 0] = 250;
            auxMatriz[0, 1] = 0;
            auxMatriz[1, 1] = 200;
            auxMatriz[2, 1] = 100;
            auxMatriz[3, 1] = 0;
            auxMatriz[4, 1] = 20;
            auxMatriz[5, 1] = 200;
            auxMatriz[6, 1] = 0;
            auxMatriz[7, 1] = 300;
            auxMatriz[8, 1] = 124;
            auxMatriz[9, 1] = 4;                    
            auxMatriz[0, 2] = 0;                    
            auxMatriz[1, 2] = 2;                    
            auxMatriz[2, 2] = 1;                    
            auxMatriz[3, 2] = 0;                    
            auxMatriz[4, 2] = 30;                   
            auxMatriz[5, 2] = 2;                    
            auxMatriz[6, 2] = 0;                    
            auxMatriz[7, 2] = 64;                   
            auxMatriz[8, 2] = 6;
            auxMatriz[9, 2] = 6;
            auxMatriz[0, 3] = 0;
            auxMatriz[1, 3] = 170;
            auxMatriz[2, 3] = 85;
            auxMatriz[3, 3] = 0;
            auxMatriz[4, 3] = 20;
            auxMatriz[5, 3] = 180;
            auxMatriz[6, 3] = 0;
            auxMatriz[7, 3] = 300;
            auxMatriz[8, 3] = 124;
            auxMatriz[9, 3] = 4;
            auxMatriz[0, 4] = 0;
            auxMatriz[1, 4] = 85;
            auxMatriz[2, 4] = 120;
            auxMatriz[3, 4] = 0;
            auxMatriz[4, 4] = 50;
            auxMatriz[5, 4] = 30;
            auxMatriz[6, 4] = 0;
            auxMatriz[7, 4] = 350;
            auxMatriz[8, 4] = 50;
            auxMatriz[9, 4] = 375;

        }
        /// <summary>
        /// Carga el array de la cantidad de unidades que hay de cada producto
        /// </summary>
        /// <param name="auxMatriz"></param>
        /// <param name="auxArr"></param>
        /// <param name="numUn"></param>
        /// <param name="numDos"></param>
        static public void CARGAR_ARRAY_UNIDADES_PRODUCTOS(int[,] auxMatriz, int[] auxArr, int numUn, int numDos)
        {
            for(int i = 0; i < auxMatriz.GetLength(0); i++)
            {
                auxArr[i] = auxMatriz[i, numUn] * auxMatriz[i, numDos];
            }
        }
        static public void LOGICA_MOSTRAR_ARRAY(string[] auxArr)
        {
            for (int i = 0; i < auxArr.Length; i++)
            {
                Console.Write("|");
                Console.Write($" {auxArr[i],-23}");
            }
        }
        /// <summary>
        /// Metodo que se utiliza para cargar los titulos de las matrices
        /// </summary>
        /// <param name="auxArr"></param>
        /// <param name="auxNumArr"></param>
        static public void MOSTRAR_ARRAY_PRODUCTOS(string[] auxArr, string[]auxNumArr)
        {
            Console.Clear();
            Console.WriteLine("RESTAURANTE LOS PRIMOS");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            LOGICA_MOSTRAR_ARRAY(auxArr);
            LOGICA_MOSTRAR_ARRAY(auxNumArr);
            Console.Write("|");
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine();
        }
        /// <summary>
        /// Metodo que se utiliza para mostrar toda la matriz con sus diferentes filas y espacio de columnas
        /// </summary>
        static public void MOSTRAR_MATRIZ_PRODUCTOS()
        {
            for (int f = 0; f < Program.MATRIZ_PRODUCTOS.GetLength(0); f++)
            {
                Console.Write("|");
                for (int c = 0; c < Program.MATRIZ_PRODUCTOS.GetLength(1); c++) 
                {
                    Console.Write($" {Program.MATRIZ_PRODUCTOS[f, c],-23 }|");
                }
                for (int d = 0; d < Program.NUMEROS_MATRIZ_PRODUCTOS.GetLength(1); d++)
                {
                    Console.Write($" {Program.NUMEROS_MATRIZ_PRODUCTOS[f, d],-23 }|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
            Console.ReadLine();
        }
        /// <summary>
        /// Metodo que me permite agregar productos al stock
        /// </summary>  primero tiene que confirmar que no haya otro producto en el espacio que ingresamos y una vez hecho eso te pide los datos a completar, 
        /// se utilizan dos for uno para rellenar la matriz productos y otra para llenar la matriz numeros de productos
        /// <param name="auxMatriz"></param>
        /// <param name="auxMatrizNum"></param>
        static public void AGREGAR_PRODUCTOS_STOCK(string[,] auxMatriz, int[,] auxMatrizNum)
        {
            string STRING_INGRESADO;
            int INT_INGRESADO;
            string ID_INGRESADO_STRING = Funciones.INGRESAR_ID();
            for (int i = 0; i < auxMatriz.GetLength(0); i++)
            {
                if (auxMatriz[i, 0] == ID_INGRESADO_STRING)
                {
                    for (int j = 1; j < auxMatriz.GetLength(1); j++)
                    {
                        if (auxMatriz[i, j] == null)
                        {
                            Console.WriteLine($"Ingrese {Program.ARRAY_TITULO_PRODUCTOS[j]}");
                            STRING_INGRESADO = Console.ReadLine();
                            auxMatriz[i, j] = STRING_INGRESADO;
                        }
                        else
                        {
                            Console.WriteLine("No puedes agregar un producto en este espacio, ya hay uno existente");
                            Console.ReadLine();
                            break;
                        }
                    }
                    for (int k = 0; k < auxMatrizNum.GetLength(1); k++)
                    {
                        if(auxMatrizNum[i,k] == 0)
                        {
                            Console.WriteLine($"Ingrese {Program.ARRAY_TITULO_NUMEROS_PRODUCTOS[k]}");
                            INT_INGRESADO = Funciones.VALIDAR_ENTERO(0, 1000);
                            auxMatrizNum[i, k] = INT_INGRESADO;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Metodo que permite eliminar productos del stock
        /// </summary>  Primero tiene que confirmar que si haya otro producto en el espacio que ingresamos y despues va eliminando todos los valors, 
        /// El codigo es un poco mas sencillo porque no estoy pidiendo intercambio con el usuario simplemente elimino todo sin preguntar.
        /// <param name="auxMatriz"></param>
        /// <param name="auxMatrizNum"></param>
        static public void ELIMINAR_PRODUCTOS_STOCK(string[,] auxMatriz, int[,] auxMatrizNum)
        {
            string ID_INGRESADO_STRING = Funciones.INGRESAR_ID();
            for(int i = 0; i < auxMatriz.GetLength(0); i++)
            {
                if (auxMatriz[i, 0] == ID_INGRESADO_STRING)
                {
                    for (int j = 1; j < auxMatriz.GetLength(1); j++)
                    {
                            auxMatriz[i, j] = null;
                    }
                    for (int k = 0; k < auxMatrizNum.GetLength(1); k++)
                    {
                        auxMatrizNum[i, k] = 0;
                    }
                }
            }
        }
        /// <summary>
        /// Metodo que permite editar productos del stock
        /// </summary> Es practicamente el mismo codigo que en agregar producton la unica diferencia que aca tiene que haber un producto en el espacio ingresado, 
        /// asi si es posible editarlo
        /// <param name="auxMatriz"></param>
        /// <param name="auxMatrizNum"></param>
        static public void EDITAR_PRODUCTOS_STOCK(string[,] auxMatriz, int[,] auxMatrizNum)
        {
            string STRING_INGRESADO;
            int INT_INGRESADO;
            string ID_INGRESADO_STRING = Funciones.INGRESAR_ID();
            for (int i = 0; i < auxMatriz.GetLength(0); i++)
            {
                if (auxMatriz[i, 0] == ID_INGRESADO_STRING)
                {
                    if (auxMatriz[i, 0] == ID_INGRESADO_STRING)
                    {
                        for (int j = 1; j < auxMatriz.GetLength(1); j++)
                        {
                            if (auxMatriz[i, j] == null)
                            {
                                Console.WriteLine("No puedes editar un producto que no existe");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Ingrese {Program.ARRAY_TITULO_PRODUCTOS[j]}");
                                STRING_INGRESADO = Console.ReadLine();
                                auxMatriz[i, j] = STRING_INGRESADO;
                            }
                        }
                        for (int k = 0; k < auxMatrizNum.GetLength(1); k++)
                        {
                            if (auxMatrizNum[i, k] == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Ingrese {Program.ARRAY_TITULO_NUMEROS_PRODUCTOS[k]}");
                                INT_INGRESADO = Funciones.VALIDAR_ENTERO(0, 1000);
                                auxMatrizNum[i, k] = INT_INGRESADO;
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Carga el id de la matriz estadistica
        /// </summary>
        /// <param name="auxMatriz"></param>
        static public void CARGAR_ID_MATRIZ_ESTADISTICA(int[,] auxMatriz)
        {
            auxMatriz[0, 0] = 0;
            auxMatriz[1, 0] = 1;
            auxMatriz[2, 0] = 2;
            auxMatriz[3, 0] = 3;
            auxMatriz[4, 0] = 4;
            auxMatriz[5, 0] = 5;
            auxMatriz[6, 0] = 6;
            auxMatriz[7, 0] = 7;
            auxMatriz[8, 0] = 8;
            auxMatriz[9, 0] = 9;
        }
        /// <summary>
        /// Carga todo lo que queda de la matriz estadistica
        /// La matriz estadistica se basa en datos para el restaurante, por eso esta compuesta por algunas ecuaciones matematicas, los ifs estan para que no salten errores
        /// si se multiplican o dividen dos 0, como nosostros ya sabemos que si pasa eso el resultado va a ser 0 simplemente si hay algun 0 entre los productos no se carga
        /// y queda en 0
        /// </summary>
        static public void CARGAR_MATRIZ_ESTADISTICA()
        {
            for (int i = 0; i < Program.NUMEROS_MATRIZ_PRODUCTOS.GetLength(0); i++)
            {
                if (Program.MATRIZ_ESTADISTICAS[i, 1] != 0 || Program.NUMEROS_MATRIZ_PRODUCTOS[i, 0] != 0 || Program.NUMEROS_MATRIZ_PRODUCTOS[i, 3] != 0)
                    Program.MATRIZ_ESTADISTICAS[i, 1] = Program.NUMEROS_MATRIZ_PRODUCTOS[i, 4] * Program.NUMEROS_MATRIZ_PRODUCTOS[i, 3];
                if (Program.MATRIZ_ESTADISTICAS[i, 2] != 0 || Program.UNIDADES_PRODUCTOS_STOCK[i] != 0 || Program.UNIDADES_PRODUCTOS_VENDIDOS[i] != 0)
                    Program.MATRIZ_ESTADISTICAS[i, 2] = Program.UNIDADES_PRODUCTOS_STOCK[i] - Program.UNIDADES_PRODUCTOS_VENDIDOS[i];
                if (Program.MATRIZ_ESTADISTICAS[i, 3] != 0 || Program.NUMEROS_MATRIZ_PRODUCTOS[i, 0] != 0 || Program.NUMEROS_MATRIZ_PRODUCTOS[i, 1] != 0)
                    Program.MATRIZ_ESTADISTICAS[i, 3] = Program.NUMEROS_MATRIZ_PRODUCTOS[i, 0] * Program.NUMEROS_MATRIZ_PRODUCTOS[i, 1];
                if (Program.MATRIZ_ESTADISTICAS[i, 4] != 0 || Program.MATRIZ_ESTADISTICAS[i, 1] != 0 || Program.MATRIZ_ESTADISTICAS[i, 3] != 0)
                    Program.MATRIZ_ESTADISTICAS[i, 4] = Program.MATRIZ_ESTADISTICAS[i, 1] / Program.MATRIZ_ESTADISTICAS[i, 3];
            }
        }
        /// <summary>
        /// Muestra la matriz estadistica
        /// </summary>
        static public void MOSTRAR_MATRIZ_ESTADISTICA()
        {
            for (int f = 0; f < Program.MATRIZ_ESTADISTICAS.GetLength(0); f++)
            {
                Console.Write("|");
                for (int c = 0; c < Program.MATRIZ_ESTADISTICAS.GetLength(1); c++)
                {
                    if(c == 1 || c == 3)
                        Console.Write($"${Program.MATRIZ_ESTADISTICAS[f, c],-23 }|");
                    else if(c == 4)
                        Console.Write($" {Program.MATRIZ_ESTADISTICAS[f, c],-23 }|");
                    else
                        Console.Write($" {Program.MATRIZ_ESTADISTICAS[f, c],-23 }|");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Muestra el array de la matriz estadistica
        /// </summary>
        /// <param name="auxArr"></param>
        static public void MOSTRAR_ARRAY_ESTADISTICA(string[] auxArr)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            LOGICA_MOSTRAR_ARRAY(auxArr);
            Console.Write("|");
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
