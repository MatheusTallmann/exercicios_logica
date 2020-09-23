using System;

namespace primeiraLista
{
    class primeiraLista
    {
        // Os números de 1 a 10 de forma crescente.
        // Os números de 1 a 10 de forma decrescente.
        // Os números de 1 a 10 de forma crescente, mas apenas aqueles que forem par.
        static void Exercise1()
		{
			var increment = 1;

			System.Console.WriteLine("crescente");
			while (increment < 11)
			{
				System.Console.WriteLine(increment);
				increment++;
			}

			var decrement = 10;

			System.Console.WriteLine("decrescente");
			while (decrement > 0)
			{
				System.Console.WriteLine(decrement);
				decrement--;
			}

			var counter = 2;
			System.Console.WriteLine("apenas os pares");
			while (counter < 11)
			{
				if (counter % 2 == 0)
				{
					System.Console.WriteLine(counter);
				}
				counter++;
			}
		}
        
        // Imprimir a soma dos números inteiros de 1 a 100.
        static void Exercise2()
		{
			var counter = 1;
			var sum = 0;

			while (counter < 101)
			{
				sum += counter;
				counter++;
			}

			System.Console.WriteLine("a soma dos números inteiros entre 1 e 100 é");
			System.Console.WriteLine(sum);
		}
		
        // Imprimir todo os números ímpares menores de 200
        static void Exercise3()
		{
            System.Console.WriteLine("números ímpares menores de 200");
            
            for(int counter = 1; counter < 200; counter +=2)
            {
                System.Console.WriteLine(counter);
            }

		}
        
        // Calcular a média de idade de uma turma qualquer. O algoritmo 
        // deve parar quando for digitada a idade igual a zero.
		static void Exercise4()  
		{
			var sum = 0.0;

            for (int counter = 0; true; counter++)
            {
                System.Console.WriteLine("Digite uma idade:");
                var result = Console.ReadLine();

                if (result == "0")
                {
                    var average = (sum / counter).ToString("0.00");
			        System.Console.WriteLine($"A média da turma é: {average}");
                    break;
                }
            	sum += Int32.Parse(result);

            }
		}
       
        // Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados, o programa deve mostrar 
        // apenas porcentagem de mulheres que estão com idade entre 18 e 35. 
		static void Exercise5()
		{
			var womenBetween18And35 = 0;

            for (int counter = 0; counter < 5; counter++)
            {
                System.Console.WriteLine("Qual é seu nome?");
                Console.ReadLine();

                var age = Int32.Parse(Console.ReadLine());

                if (age > 17 && age < 36)
                {
                    womenBetween18And35++;                    
                }
            }
            System.Console.WriteLine("Porcentagem de mulheres que tem entre 18 e 35 anos");

			var percentage = (womenBetween18And35 * 100) / 5;
			System.Console.WriteLine($"{percentage}%");
		}

		static void Exercise6()
		{
			const string registerMode = "1";
			const string votesMode = "2";
			const string resultMode = "3";

            var candidates = new (string name, int votes)[3];
			
			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a baixo:");
				System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
				System.Console.WriteLine($"{votesMode}) Votar");
				System.Console.WriteLine($"{resultMode}) Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == resultMode)
				{
					break;
				}

				if (mode == registerMode)
				{
					var password = "";
					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

                    for (int i = 0; i < candidates.Length; i++)
                    {                   
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
				}

				if (mode == votesMode)
				{
                    for (int i = 0; i < candidates.Length; i++)
                    {
					    System.Console.WriteLine($"Vote {i + 1} para o candidato: {candidates[i].name}"); 
                    }

					var vote = Int32.Parse(Console.ReadLine());
					candidates[vote - 1].votes++;
				}
			}

            var winner = candidates[0];
            var isDraw = false;
            var drawCandidates = winner.name;

            for (int i = 1; i < candidates.Length; i++)
            {
                var currentCandidate = candidates[i];

                if (currentCandidate.votes > winner.votes)
                {
                    winner = currentCandidate;
                    drawCandidates = currentCandidate.name;
                }
                else if (currentCandidate.votes == winner.votes)
                {
                    isDraw = true;
                    drawCandidates += $", {currentCandidate.name}";
                }
            }

			if (isDraw)
			{
				System.Console.WriteLine($"Segundo turno entre: {drawCandidates}!");
			}
			else
			{
				System.Console.WriteLine($"O vencedor é: {winner.name}");
				System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			}
		}
       
        // Calcular a quantidade de dinheiro gasto por um fumante. Dados: o numero de anos que ele fuma,
        //  o nº de cigarros fumados por dia e o preço de uma carteira.
        static void Exercise7()
        {
            const int numberCigarettesWallet = 20;
            const int daysInYear = 365;

            System.Console.WriteLine("Por quantos anos você fuma?");
            var yearsSmoking = Int32.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Quantos cigarros você fuma por dia?");
            var cigarettes = Int32.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Quanto custa a carteira de cigarro?");
            var walletPrice = double.Parse(System.Console.ReadLine());

            var cigarettesPrice = walletPrice / numberCigarettesWallet;
            var totalCigarettesSmoked = yearsSmoking * cigarettes * daysInYear;
            
            var totalCost = totalCigarettesSmoked * cigarettesPrice; 
            System.Console.WriteLine($"R${totalCost.ToString("00.00")}");
        }
       
        // Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y    
        static void Exercise8()
        {
            System.Console.WriteLine("Forneça um número");
            var firstNumber = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Forneça outro número");
            var secondNumber = Int32.Parse(Console.ReadLine());

            var result = firstNumber % secondNumber;

            if (result != 0)
            {
                System.Console.WriteLine("O primeiro número digitado não é multiplo do segundo!");
            }
            else 
            {
                System.Console.WriteLine("O primeiro número digitado é multiplo do segundo!");
            }
        }
		
        // Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é 
        // maior que a soma dos outros dois
        static void Exercise9()
		{
            System.Console.WriteLine("Forneça um número real:");
            var firstNumber = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Forneça um número real:");
            var secondNumber = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Forneça um número real:");
            var thirdNumber = double.Parse(System.Console.ReadLine());

            if (firstNumber > (secondNumber + thirdNumber))
            {
                System.Console.WriteLine("O primeiro número é maior que a soma dos dois últimos números.");
            }
            else
            {
                System.Console.WriteLine("O primeiro número não é maior que a soma dos dois últimos números.");
            }
		}
        
        // Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, 
        // ou a mensagem "A = B" caso sejam iguais.
        static void Exercise10()
        {
            System.Console.WriteLine("Forneça um número real:");
            var aNumber = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Forneça outro número real:");
            var bNumber = double.Parse(System.Console.ReadLine());

            if (aNumber > bNumber)
            {
                System.Console.WriteLine("O primeiro número fornecido é maior que o segundo.");
            }
            else if(aNumber < bNumber)
            {
                System.Console.WriteLine("O segundo número fornecido é maior que o primeiro.");
            }
            else
            {
                System.Console.WriteLine("Os números fornecidos são iguais.");
            }

        }
        
        // Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e 
        // imprimir o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
		static void Exercise11()
		{
            var firstNumber = 0;
            Console.WriteLine("Forneça um número");
            var firstInput = Console.ReadLine();
            
            var secondNumber = 0;
            Console.WriteLine("Forneça um número");
            var secondInput = Console.ReadLine();
            
            try
            {
                firstNumber = Int32.Parse(firstInput);
                secondNumber = Int32.Parse(secondInput);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Um dos números está em formato inválido");
                System.Console.WriteLine("Tente novamente com outros números");
            }

            if (secondNumber != 0)
            {
                System.Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                System.Console.WriteLine("DIVISÃO POR ZERO");
            }
        }
        
        //Ler 4 números inteiros e calcular a soma dos que forem
        static void Exercise12()
        {
            System.Console.WriteLine("Forneça um número inteiro:");
            var firstNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Forneça um número inteiro:");
            var secondNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Forneça um número inteiro:");
            var thirdNumber = int.Parse(System.Console.ReadLine());

             System.Console.WriteLine("Forneça um número inteiro:");
            var fourthNumber = int.Parse(System.Console.ReadLine());

            var result = firstNumber + secondNumber + thirdNumber + fourthNumber;

            System.Console.WriteLine($"O total da soma dos números é:{result}");
        
            
        }
		
        // Ler 10 valores e determinar o maior dentre eles.
        static void Exercise13()
		{
            var biggestNumber = double.MinValue;

            for (int counter = 0; counter < 10; counter++)
            {
                System.Console.WriteLine("Forneça um número:");
                var input = Int32.Parse(System.Console.ReadLine());
                
                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }
            }
            System.Console.WriteLine("O maior número é:");
            System.Console.WriteLine(biggestNumber);

		}

		// Ler três valores e colocá-los em ordem.
        static void Exercise14()
		{
            var biggestValue = double.MinValue;
            var mediumValue = double.MinValue;
            var smallerValue = double.MinValue;

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Forneça um número:");
                var input = double.Parse(System.Console.ReadLine());
            
            
                if (input > biggestValue)
                {
                    smallerValue = mediumValue;
                    mediumValue = biggestValue;
                    biggestValue = input;
                }
                else if (input > mediumValue)
                {
                    smallerValue = mediumValue;
                    mediumValue = input;   
                }
                else
                {
                    smallerValue = input;
                }
            }

            System.Console.WriteLine(biggestValue);
            System.Console.WriteLine(mediumValue);
            System.Console.WriteLine(smallerValue);
		}

        // Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
		static void Exercise15()
        {
            var multiple3 = 0;
            var multiple5 = 0;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Forneça um número:");
                var input = int.Parse(System.Console.ReadLine());
            
                if (input % 3 == 0)
                {
                    multiple3++; 

                    if (input % 5 == 0)
                    {
                        multiple5++;
                    }
                }
                else if(input % 5 == 0)
                {
                    multiple5++;
                }         
            }

            System.Console.WriteLine($"Total de múltiplos de 3:{multiple3}");
            System.Console.WriteLine($"Total de múltiplos de 5:{multiple5}");
        }
        
        // Ler o salário de uma pessoa e imprimir o Salário Líquido de 
        // acordo com a redução do imposto descrito ao lado:
        // Menor ou igual a R$ 600,00 - ISENTO
        // Maior que R$ 600,00 e menor ou igual a 1200 - 20% desconto
        // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
        // Maior que R$ 2.000,00 - 30% desconto
        static void Exercise16()
        {
            var totalSalary = 0.0;
            System.Console.WriteLine("Qual é o seu salário?");
            var salary = double.Parse(System.Console.ReadLine());

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
            
            System.Console.WriteLine($"Seu salário com descontos de impostos:{totalSalary}");
        }
        
        // Imprimir a tabuada de qualquer número fornecido pelo usuário até que o usuário forneça o valor –1.
        static void Exercise17()
		{
            while (true)
            {
                System.Console.WriteLine("Forneça um número:");
                var input = Int32.Parse(System.Console.ReadLine());

                if (input == -1)
                {
                    break;
                }

                for (int multiplier = 0; multiplier < 11; multiplier++)
                {
                    var result = input * multiplier;
                    System.Console.WriteLine(result);
                }
              
            }
        }

        // As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
        // compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
        // escreva o custo total da compra. 

        static void Exercise18()
        {
            var apples = 1.30;
            var apples12 = 1.00;
            var totalCost = 0.00;

            System.Console.WriteLine("Quantas maçãs você comprou?");
            var input = Int32.Parse(Console.ReadLine());

            if (input < 12)
            {
                totalCost = input * apples;
                System.Console.WriteLine($"Custo total foi de: R$ {totalCost.ToString("0.00")}");
            }
            else
            {
                totalCost = input * apples12;
                System.Console.WriteLine($"Custo total foi de: R$ {totalCost.ToString("0.00")}");
            }
        }  
        static void Main(string[] args)
        {
           Exercise7();
        }
    }
}
    
