using System;
using System.Collections.Generic;
using Xunit;

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
    }
}
