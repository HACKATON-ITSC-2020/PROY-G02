using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonGrupo02.CapaNegocio
{
    public static class MetodosGenericos 
    {
        /*con este metodo le pasamos por parametro un textbox y generamos un efecto visual donde 
         * inicie el con un texto en gris y al escribir dentro del control se borre el contenido y 
         * cambie el color a negro*/
        public static void Init(this TextBox textBox, string prompt)
        {
            //asi inicia
            textBox.Text = prompt;
            textBox.ForeColor = Color.DarkGray;
            


            //cuando tiene el foco
            textBox.GotFocus += (source, ex) =>
            {
                //si se cambia el color porque se escribio

                if (((TextBox)source).ForeColor == Color.Black)
                    return;
                //si es diferente a vacio o nulo

                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            //Cuando se va el foco
            textBox.LostFocus += (source, ex) =>
            {
                TextBox t = ((TextBox)source);
                //si no se escribio vuelve al estado original "prompt"
                if (t.Text.Length == 0)
                {
                    t.Text = prompt;
                    t.ForeColor = Color.Silver;
                    return;
                }
            };

            //Metodo tipo arrow para que al apretar "Enter" pase al siguiente tabindex
            textBox.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

        }



    }
}
