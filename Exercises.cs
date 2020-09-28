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
        
        //Ler 4 números inteiros e calcular a soma dos que forem pares.       
        public int Exercise12(List<int> numbers)
        {   
            // var total = 0;

            // for (int i = 0; i < numbers.Count; i++)
            // {
            //     if (numbers[i] % 2 == 0)
            //     {
            //         total += numbers[i];
            //     }
            // }
            // return total;
            return numbers.Where(item => item % 2 == 0).Sum();
        }

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
        public string Exercise14(int firstNumber, int secondNumber, int thirdNumber)
		// Ler três valores e colocá-los em ordem.
        {
            var MinValue = 0;
            
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                MinValue = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = MinValue;
            }
            
            if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                MinValue = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = MinValue;
            }
            
            if (firstNumber > secondNumber)
            {
                MinValue = secondNumber;
                secondNumber = firstNumber;
                firstNumber = MinValue;
            }

            return $"{firstNumber}, {secondNumber}, {thirdNumber}";
        }
        public string Exercise15(List<int> numbers)
        // Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
        {
            var multiple3 = 0;
            var multiple5 = 0;

            for (int i = 0; i < 10; i++)
            {
            
                if (numbers[i] % 3 == 0)
                {
                    multiple3++; 

                    if (numbers[i] % 5 == 0)
                    {
                        multiple5++;
                    }
                }
                else if(numbers[i] % 5 == 0)
                {
                    multiple5++;
                }         
            }
            return $"{multiple3}, {multiple5}";
        }
        public double Exercise16(double salary)
        // Ler o salário de uma pessoa e imprimir o Salário Líquido de 
        // acordo com a redução do imposto descrito ao lado:
        // Menor ou igual a R$ 600,00 - ISENTO
        // Maior que R$ 600,00 e menor ou igual a 1200 - 20% desconto
        // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
        // Maior que R$ 2.000,00 - 30% desconto
        {
            var totalSalary = 0.0;

            if (salary <= 600)
            {
                totalSalary = salary;
            }
            else if (salary > 600 && salary <= 1200)
            {
                totalSalary = salary * 0.8;
            }
            else if (salary > 1200 && salary <= 2000)
            {
                totalSalary = salary * 0.75;
            }
            else 
            {
                totalSalary = salary * 0.7;
            }
            return totalSalary;
        }
    }
}
