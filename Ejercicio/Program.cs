using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static public string[,] MATRIZ_PRODUCTOS = new string[10, 3];
        static public int[,] MATRIZ_ESTADISTICAS = new int[10,5];
        static public int[] UNIDADES_PRODUCTOS_STOCK = new int [10];
        static public int[] UNIDADES_PRODUCTOS_VENDIDOS = new int[10];
        static public string[] ARRAY_TITULO_PRODUCTOS = new string[3] { "ID", "NOMBRE", "CATEGORIA" };
        static public string[] ARRAY_TITULO_NUMEROS_PRODUCTOS = new string[5] {"PRECIO DE PACKS(COMPRA)", "CANTIDAD DE PACKS", "UNIDADES POR PACKS", "PACKS VENDIDOS", "PRECIO DE PACKS(VENTA)" };
        static public string[] ARRAY_TITULO_ESTADISTICAS = new string[5] {"ID PRODUCTOS", "DINERO RECAUDADO", "UNIDADES RESTANTES", "GASTOS", "PROFIT" };
        static public int[,] NUMEROS_MATRIZ_PRODUCTOS = new int[10, 5];
        static public void INICIAR_APP()
        {
            LogicaDatos.CARGAR_MATRIZ_PRODUCTOS(MATRIZ_PRODUCTOS);
            LogicaDatos.CARGAR_MATRIZ_NUMEROS(NUMEROS_MATRIZ_PRODUCTOS);
            LogicaDatos.CARGAR_ID_MATRIZ_ESTADISTICA(MATRIZ_ESTADISTICAS);
        }
        static void Main(string[] args)
        {
            INICIAR_APP();
            Menú.MENU_PRINCIPAL();
            Console.ReadKey();
        }
    }
}
