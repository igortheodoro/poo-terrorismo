using System;

namespace Terrorismo
{
    class Ataques
    {
        private int Tipo, Locais, Mortos, Feridos, Falsos;

        public Ataques(int Tipo, int Locais, int Mortos, int Feridos, int Falsos)
        {
            this.Tipo = Tipo;
            this.Locais = Locais;
            this.Mortos = Mortos;
            this.Feridos = Feridos;
            this.Falsos = Falsos;
        }

        public int getTipo()
        {
            return Tipo;
        }

        public int getFalsos()
        {
            return Falsos;
        }

        public int getFeridos()
        {
            return Feridos;
        }

         public int getLocais()
        {
            return Locais;
        }

        public string getTipoNome()
        {
            string[] nomeAtaq = new string[6] {"", "terrorismo físico", "terrorismo psicológico", "terrorismo de Estado", "terrorismo econômico", "terrorismo religioso" };
            string ataque = "";

            for (int i = 1; i <= 5; i++)
            {
                if (Tipo == i)
                {
                    ataque = nomeAtaq[i];
                }
            }

            return ataque;
        }
        public int getMortos()
        {
            return Mortos;
        }

        public override string ToString()
        {
            return "\n Tipo: " + getTipoNome()
                + "\n Local: " + Locais
                + "\n Mortos: " + Mortos
                + "\n Feridos: " + Feridos
                + "\n Ataques falsos: " + Falsos;
        }
    }
}
