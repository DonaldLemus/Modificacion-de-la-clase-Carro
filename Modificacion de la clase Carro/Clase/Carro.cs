using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificacion_de_la_clase_Carro.Clase
{
    internal class micarro
    {
        public string Marca {get;}
        public string Color {get;}
        public int MAXKPH {get;}

        private int encendido = 0;
        private int velocidad_actual = 0;

        public micarro(string marca, string color, int maxkph)
        {
            Marca = marca;
            Color = color;
            MAXKPH = maxkph;
            encendido = 0;
            this.velocidad_actual = 0;
        }
        public string encerdermotor()
        {
            string mensaje = " ";
            if (encendido == 0)
            {
                encendido = 1;
                mensaje = "\nCarro encedido";
                velocidad_actual = 0;
            }
            else
            {
               mensaje = "\nEl carro ya estaba encendido";
            }
            return mensaje;
        }
        public string acelerar()
        {
            if (encendido == 0)
            {
                return $"El carro está apagado";
            }
            string mensaje = "";
            if(velocidad_actual < MAXKPH)
            {
                    velocidad_actual += 20;
                    mensaje = $"Has acelerado 20 KPH";                
            }
            else
            {
                velocidad_actual = MAXKPH;
                mensaje = "Vas a velocidad Maxima, no puedes acelerar mas";
            }
            return mensaje;
        }

        public string getvelocidad()
        {
            string mensaje = $"Vamos a {velocidad_actual} KPH\n";
            return mensaje;
        }

        public string desacelerar()
        {
            string mensaje = " ";
            if(velocidad_actual > 0)
            {
                velocidad_actual -= 15;
                mensaje = $"Has desacelerado, vas a {velocidad_actual} KPH";
            }
            if(velocidad_actual < 0)
            {
                velocidad_actual = 0;
                mensaje = $"\nLa velocidad es 0";
            }
            return mensaje;
        }

        public string frenar()
        {
            string mensaje = " ";
            if(velocidad_actual > 0)
            {
                mensaje = $"\nEl carro ha frenado un poco";
                velocidad_actual = velocidad_actual - 5;
            }
            return mensaje;
        }

        public string bocinar()
        {
            string mensaje = "\nBocina bip bip\n";
            return mensaje;
        }

        public string apagarmotor()
        {
            string mensaje = " ";
            if (velocidad_actual == 0)
            {
                mensaje = $"\nEl carro se ha apagado";
            }
            else
            {
                mensaje = $"\nEl carro ya esta apagado";
            }
            return mensaje;
        }

        public string frenartodo()
        {
            string mensaje = " ";
            if(velocidad_actual == 0)
            {
                mensaje = "El carro se ha frenado por completo";
            }
            else
            {
                mensaje = "Disminuya mas su velocidad para frenar por completo\n";
            }
            return mensaje;
        }

        public string informacion()
        {
            return $"Carro: \nMarca: {Marca} Color: {Color} Velocidad Maxima: {MAXKPH}\n";
        }

    }
}
