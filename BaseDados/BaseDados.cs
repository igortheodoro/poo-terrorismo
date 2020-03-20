using System;


namespace Terrorismo
{
    class BaseDados
    {
        private Ataques[] vet;
        private int index;

        public BaseDados(){
          vet = new Ataques[10];
          index = 0;
        }

        public void Inserir(Ataques obj){
          vet[index] = obj;
          index++;
        }

        public void getDados(){
          for (int i =0; i < vet.Length; i++)
              Console.WriteLine(vet[i]);
        }
        public void getTerrorismos200(){
           for (int i = 0; i < vet.Length; i++)
                if (vet[i].getMortos() > 200)
                    Console.WriteLine("-" + vet[i].getTipoNome());
        }

        public int getReligiosos(){
          int cont = 0;

            for (int i = 0; i < vet.Length; i++)
                if (vet[i].getTipo() == 5)
                    cont++;

          return cont;
        } 

        public double GetLtr(){
          double ltr;
          int nla = 0, qm = 0, qf = 0, naf = 0;

          for(int i = 0; i < vet.Length; i++){
            nla = nla + vet[i].getLocais();
            qm = qm + vet[i].getMortos();
            qf = qf + vet[i].getFeridos();
            naf = naf + vet[i].getFalsos();
          }

          ltr = (nla + qm * 5 + naf + qf * 3) / 10;

          return ltr;
        }
    }
}
