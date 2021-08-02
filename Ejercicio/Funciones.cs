using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Funciones
    {
        /// <summary>
        /// Valida si el valor ingresado es un entero, el limite minimo y el maximo pueden variar pero determina que el numero ingresado se encuentre en ese rango
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public int VALIDAR_ENTERO(int min, int max)
        {
            int opcion;
            bool esNum = int.TryParse(Console.ReadLine(), out opcion);
            while (!esNum || opcion < min || opcion > max)
            {
                Console.WriteLine("Valor invalido");
                esNum = int.TryParse(Console.ReadLine(), out opcion);
            }
            return opcion;
        }
        /// <summary>
        /// Pide el id y valida que sea un numero
        /// </summary>
        /// <returns></returns>
        static public string INGRESAR_ID()
        {
            Console.Clear();
            int ID_INGRESADO;
            string ID_INGRESADO_STRING;
            Console.WriteLine("Ingrese el id del producto");
            ID_INGRESADO = VALIDAR_ENTERO(0, 10);
            ID_INGRESADO_STRING = ID_INGRESADO.ToString();
            return (ID_INGRESADO_STRING);
        }
    }
}
