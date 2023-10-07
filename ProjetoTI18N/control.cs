using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class control
    {
        Calculadora calc; //Conectando a variável calc a classe Calculadora
        public control()
        {
            calc = new Calculadora();//Instanciando, calc é um objeto de calculadora
        }//fim do construtor

        //método coletar para mostrar na tela

        public void ColetarNum1()
        {

            Console.WriteLine("informe um número:");
            calc.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
        }
        //fim do método coletarNum1
        public void ColetarNum2()
        {

            Console.WriteLine("informe um número:");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do método coletarNum2

        // Criando menu
        public void Menu()
        {
        
        
        }


    }//fim da classe
}//fim do metodo
