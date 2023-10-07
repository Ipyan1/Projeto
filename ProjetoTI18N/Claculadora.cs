using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Calculadora
    {
        private double num1;
        private double num2;

        //Método Construtor -> Instância as variáveis na memória do computador
        public Calculadora()
        {
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;

        }//fim do Método construtor


        //Métodos Modificadores = GET e SET
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }//fim do método ConsultarNum1

        public double ConsultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }// Fim do método ConsultarNum2

        // Métodos

        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;

        }//fim do Somar

        public double Subtrair()
        {
            return ConsultarNum1 + ConsultarNum2;

        }//fim do Subtrair

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;

            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            
            }
        }//fim do Dividir

        public double Multiplicar()
        {
            return ConsultarNum1 + ConsultarNum2;

        }//fim do Multiplicar


    }//fim da classe
}//fim do projeto
