using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Componente_Generico
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e) { 
        }
        
            public static class InputValidator
        {
            
            public static bool SoloNumeros(string texto)
            {
               
                foreach (char c in texto)
                {
                    if (c < 48 || c > 57) 
                    {
                        return false; // regresa un falso si se encuentra un valor fuera de entre 48 y 57 
                    }
                }
                return texto.Length > 0; //regresa un verdadero si no encuentra vacia la lista
            }

        


        public static bool SoloLetras(string texto)
            {
                foreach (char i in texto)
                {
                    if (!((i >= 65 && i <= 90) || (i >= 97 && i <= 122)))
                    {
                        return false; //igual que en la clase de arriba 
                    }
                }
                return texto.Length > 0; //igual que en la clase de arriba 
            }
        }
        public static class RFCValidator
        {
           
            public static bool RFCValido(string rfc)
            {
                //primeros 4 caracteres letras mayusculas luego 6 numreos en base a la fecha (formato de mexico) y ultimos 2 o 3 valores alfanumericos
                return Regex.IsMatch(rfc, @"^[A-ZÑ&]{4}\d{6}[A-Z0-9]{2,3}$", RegexOptions.IgnoreCase);
            }

            
            public static string CorregirRFC(string rfc)
            {
                return rfc.Trim().ToUpper(); // quita los espacios y convierte en mayúsculas
            }
        }
    }
    }

