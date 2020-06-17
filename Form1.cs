using System;
using System.Text;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class Form1 : Form
    {
        // Variable con valores ASCII en un arreglo de char
        private char[] ASCII = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();
        // Variable para cambiar de modo
        bool Encriptar = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validamos que todos los campos esten completos
            if(Encriptar)
            {
                if (TxtClave.Text.Length == 0 || TxtLlano.Text.Length == 0)
                    MessageBox.Show("Los campos no deben ser vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    TxtCifrado.Text = EncriptaTexto(TxtLlano.Text, TxtClave.Text);
            }
            else
            {
                if (TxtClave.Text.Length == 0 || TxtCifrado.Text.Length == 0)
                    MessageBox.Show("Los campos no deben ser vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    TxtLlano.Text = EncriptaTexto(TxtCifrado.Text, TxtClave.Text);
            }
        }

        // Metodo para encriptar y desencriptar una palabra u oracion requiere texto (string) y clave (string)
        private string EncriptaTexto(string texto, string clave)
        {
            StringBuilder resultado = new StringBuilder();
            try
            {
                // definimos las variables para el arreglo de caracteres
                // ASCII y preparamos el mapa de caracteres vacio
                char[] ascii = ASCII;
                char[,] mapa = new char[95, 95];
                // Llenamos el mapa
                for (int i = 0; i < ascii.Length; i++)
                {
                    for (int j = 0; j < ascii.Length; j++)
                        mapa[i, j] = ascii[j];
                    // recorremos el arreglo para que no lo copie igual y crear
                    // el mapa de cifrado
                    ascii = RecorrerArreglo(ascii);
                }
                if (texto.ToCharArray().Length > clave.ToCharArray().Length)
                {
                    // Si la palabra es mas larga de la clave igualamos
                    // la longitud de la clave
                    // StringBuilder es una clase para crear objetos String
                    StringBuilder NuevaClave = new StringBuilder();
                    int j = 0;
                    for (int i = 0; i < texto.ToCharArray().Length; i++)
                    {
                        // Repetimos los valores cuando se acaban
                        j = j >= clave.ToCharArray().Length ? 0 : j;
                        NuevaClave.Append(clave[j]);
                        j++;
                    }
                    // Reasignamos la clave
                    clave = NuevaClave.ToString();
                }
                // Creamos la palabra cifrada usando el mapa de 
                // caracteres ASCII
                for (int i = 0; i < texto.ToCharArray().Length; i++)
                    resultado.Append(mapa[texto[i] - 32, clave[i] - 32]);

            }
            catch (Exception ex)
            {
                // En caso de algun error extraño lo mostramos para evitar 
                // que la aplicacion se cierre
                MessageBox.Show($"Error al convertir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // regresamos el resultado final de la palabra codificada o decodificada
            return resultado.ToString();
        }

        // Metodo para ir recorriendo automaticamente el arreglo requiere un arreglo de char
        static char[] RecorrerArreglo(char[] Arreglo)
        {
            // Preparamos variables
            char[] Auxiliar = new char[Arreglo.Length];
            Auxiliar[0] = Arreglo[0];
            for (int i = 1; i < Arreglo.Length; i++)
            {
                // Reordenamos
                if (i == Arreglo.Length - 1)
                {
                    Arreglo[0] = Arreglo[i];
                    Arreglo[i] = Auxiliar[i - 1];
                }
                else
                {
                    Auxiliar[i] = Arreglo[i];
                    Arreglo[i] = Auxiliar[i - 1];
                }
            }
            return Arreglo;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void encriptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Encriptar";
            TxtCifrado.ReadOnly = true;
            TxtLlano.ReadOnly = false;
            TxtLlano.Text = "";
            TxtClave.Text = "";
            TxtCifrado.Text = "";
            LblTitulo.Text = "Encriptar";
            Encriptar = true;
        }

        private void desencriptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Desencriptar";
            TxtCifrado.ReadOnly = false;
            TxtLlano.ReadOnly = true;
            TxtLlano.Text = "";
            TxtClave.Text = "";
            TxtCifrado.Text = "";
            LblTitulo.Text = "Desencriptar";
            Encriptar = false;
        }

    }
}
