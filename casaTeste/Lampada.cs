using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casaTeste
{
    class Lampada
    {
        bool luz;
        string potencia;
        string voltagem;
        

        public bool Luz { get => luz; set => luz = value; }//crtl + R + E
        public string Potencia { get => potencia; set => potencia = value; }
        public string Voltagem { get => voltagem; set => voltagem = value; }

        public Lampada()
        {
            this.Luz = Luz;
            this.Potencia = "60w";
            this.Voltagem = "127v";
        }

        public bool Queimou()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(100);

            if (numeroAleatorio < 15)
            {
                return true;
                
            }
            else
            {
                return false;

            }

        }

        public void Ascender()
        {
            if (Queimou())
            {
                this.Luz = false;
            }
            else
            {
                this.Luz = true;
            }
        }


        public void Apagar()
        {
            this.Luz = false;
        }

        public bool LerStatus()
        {
            return this.Luz;
        }

        public string MostrarVoltagem()
        {
            return this.Voltagem;

        }

        public string MostrarPotencia()
        {
            return this.Potencia;
        }

        public void AlterarVoltagem(string valor)
        {
            this.Voltagem = valor;          
        }
        
        public void AlterarPotencia(string valor)
        {
            this.Potencia = valor;   
        }





    }
}
