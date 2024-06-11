using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    internal static class Funciones
    {
        
        public static int CalcularDigito(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }
       

        //Método para verificar si el CUIT ingresado es correcto.
        public static bool ValidarCuit(string cuit)
        {
            if (cuit == null)  // Verifica si no se ingresa nada.
            {
                return false;
            }

            cuit = cuit.Replace("-", string.Empty); // Los espacios vacíos son reemplazados por guiones.

            if (cuit.Length != 11)  // Verifica que la cantidad de dígitos sea igual a 11
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigito(cuit);  // Se almacena el código de verificación
                int digito = int.Parse(cuit.Substring(10)); // Se almacena la subcadena que comienza en la posición 10
                return calculado == digito;     // Si se verifica que el código de verificación es igual al dígito del CUIT, se retorna true
            }
        }
        
        
    }
}
