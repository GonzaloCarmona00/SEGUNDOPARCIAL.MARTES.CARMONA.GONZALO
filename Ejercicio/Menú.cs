using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Menú
    {
        /// <summary>
        /// Son las opciones solo del menu principal
        /// </summary>
        static public void OPCIONES_MENU_PRINCIPAL()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL RESTAURANTE LOS PRIMOS");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      1. Ver stock");
            Console.WriteLine("      2. Editar stock");
            Console.WriteLine("      3. Ver datos");
            Console.WriteLine("      4. Salir");
            Console.ResetColor();
            Console.WriteLine("ELIGA UNA DE LAS OPCIONES");
        }
        /// <summary>
        /// Menu principal, es el que me hace navegar por todo mi programa dandome distintas opciones y dandole uso a todos los metodos
        /// </summary>
        static public void MENU_PRINCIPAL()
        {
            int OPCION_INGRESADA;
            bool SEGUIR_EN_LA_APP = true;
            while (SEGUIR_EN_LA_APP)
            {
                OPCIONES_MENU_PRINCIPAL();
                OPCION_INGRESADA = Funciones.VALIDAR_ENTERO(1, 4);
                Console.Clear();
                switch (OPCION_INGRESADA)
                {
                    case 1:
                        LogicaDatos.MOSTRAR_ARRAY_PRODUCTOS(Program.ARRAY_TITULO_PRODUCTOS,Program.ARRAY_TITULO_NUMEROS_PRODUCTOS);
                        LogicaDatos.MOSTRAR_MATRIZ_PRODUCTOS();
                        break;
                    case 2:
                        SUB_MENU_EDITAR_PRODUCTOS();
                        break;
                    case 3:
                        LogicaDatos.CARGAR_ARRAY_UNIDADES_PRODUCTOS(Program.NUMEROS_MATRIZ_PRODUCTOS, Program.UNIDADES_PRODUCTOS_STOCK, 1, 2);
                        LogicaDatos.CARGAR_ARRAY_UNIDADES_PRODUCTOS(Program.NUMEROS_MATRIZ_PRODUCTOS, Program.UNIDADES_PRODUCTOS_VENDIDOS, 2, 3);
                        LogicaDatos.CARGAR_MATRIZ_ESTADISTICA();
                        LogicaDatos.MOSTRAR_ARRAY_ESTADISTICA(Program.ARRAY_TITULO_ESTADISTICAS);
                        LogicaDatos.MOSTRAR_MATRIZ_ESTADISTICA();
                        break;
                    case 4:
                        SEGUIR_EN_LA_APP = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Opciones del submenu
        /// </summary>
        static public void OPCIONES_SUB_MENU_EDITAR_PRODUCTOS()
        {
            Console.Clear();
            Console.WriteLine("HAMBURGUESERIA LOS PRIMOS");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     1. Eliminar productos del stock");
            Console.WriteLine("     2. Editar productos del stock");
            Console.WriteLine("     3. Agregar productos al stock");
            Console.WriteLine("     4. Volver al menu principal");
            Console.ResetColor();
            Console.WriteLine("ELIGA UNA OPCION");
        }
        /// <summary>
        /// Submenu que me da disintas opciones que puedo realizar con los productos
        /// </summary>
        static public void SUB_MENU_EDITAR_PRODUCTOS()
        {
            int OPCION_INGRESADA;
            bool SEGUIR_SUB_MENU = true;
            while (SEGUIR_SUB_MENU)
            {
                OPCIONES_SUB_MENU_EDITAR_PRODUCTOS();
                OPCION_INGRESADA = Funciones.VALIDAR_ENTERO(1, 4);
                switch (OPCION_INGRESADA)
                {
                    case 1:
                        LogicaDatos.ELIMINAR_PRODUCTOS_STOCK(Program.MATRIZ_PRODUCTOS, Program.NUMEROS_MATRIZ_PRODUCTOS);
                        break;
                    case 2:
                        LogicaDatos.EDITAR_PRODUCTOS_STOCK(Program.MATRIZ_PRODUCTOS, Program.NUMEROS_MATRIZ_PRODUCTOS);
                        break;
                    case 3:
                        LogicaDatos.AGREGAR_PRODUCTOS_STOCK(Program.MATRIZ_PRODUCTOS, Program.NUMEROS_MATRIZ_PRODUCTOS);
                        break;
                    case 4:
                        SEGUIR_SUB_MENU = false;
                        break;
                }
            }
        }
    }
}
