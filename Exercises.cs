using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace primeiraLista
{
    public class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }
        public int Exercise2()
        {
            var counter = 1;
			var sum = 0;

			while (counter < 101)
			{
				sum += counter;
				counter++;
			}
            return sum;
        }
        public int[] Exercise3()
        {                 
            var counter = new int[100];

            var count = 1;
            for (int i= 0; i < 100; i++)
            {
                counter[i] = count;
                count += 2;
            }

            return counter;
        }    
        public double Exercise4(List<int> ages)
		{
            double sum = 0.0;

            var answers = ages.Count;

            foreach (var item in ages)
            {
				sum += item;
            }

            var average = (sum / answers);

            return average;
		}
        public double Exercise5(List<double> womenAge)
        {
            double womanBeetween18And36 = 0;
            
            foreach (var age in womenAge)
            {
                if (age >= 18 && age <= 35)
                {
                    womanBeetween18And36++;
                }
            }

            return (100.0/womenAge.Count)*womanBeetween18And36;
        }   
        public double Exercise7(int yearsSmoking, int cigarettesPerDay, double price)
        // Calcular a quantidade de dinheiro gasto por um fumante. Dados: o numero de anos que ele fuma,
        //  o nº de cigarros fumados por dia e o preço de uma carteira.
        {
            const int numberCigarettesWallet = 20;
            const int daysInYear = 365;

            var cigarettesPrice = price / numberCigarettesWallet;
            var totalCigarettesSmoked = yearsSmoking * cigarettesPerDay * daysInYear;

            return totalCigarettesSmoked * cigarettesPrice; 
        }

        public string Exercise8(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber == 0 ? "É multiplo" : "Não é multiplo";     
        }

        public string Exercise9(int firstNumber, int secondNumber, int thirdNumber)
        {
            
            return firstNumber > (secondNumber + thirdNumber) == true ? "O primeiro é maior!" : "O primeiro não é maior!";
            
            // if (firstNumber > (secondNumber + thirdNumber))
            // {
            //     return "O primeiro é maior!";
            // }
            // else
            // {
            //     return "O primeiro não é maior!";
            // }
        }
        public string Exercise10(int firstNumber, int secondNumber)
        // Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, 
        // ou a mensagem "A = B" caso sejam iguais.
        {
            if (firstNumber == secondNumber)
            {
                return "Eles são iguais!";
            }
            else
            {
                return firstNumber > secondNumber == true ? "O primeiro é maior!" : "O segundo é maior!";              
            }
        }
        public int Exercise11(int firstNumber, int secondNumber)
        // Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e 
        // imprimir o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO"
        {
            return firstNumber / secondNumber;
        }
        // public List<int> Exercise12(List<int> numbers)
        // {   
        //     return numbers;
        // }








        public int Exercise13(List<int> numbers)
        {
            var biggestNumber = int.MinValue;

            foreach (var item in numbers)
            {
                if (item > biggestNumber)
                {
                    biggestNumber = item;
                }
            }
            return biggestNumber;
        }
    }
}
