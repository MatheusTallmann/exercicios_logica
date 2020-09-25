using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace primeiraLista
{
    public class ExercisesTest
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            Assert.Collection(
                returnedValues,
                item1 => { Assert.Equal(2, item1); },
                item2 => { Assert.Equal(4, item2); },
                item3 => { Assert.Equal(6, item3); },
                item4 => { Assert.Equal(8, item4); },
                item5 => { Assert.Equal(10, item5); }
            );            
        }

        [Fact]
        public void should_return_all_odd_numbers_less_than_200()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] numbers = exercises.Exercise3();
            var expectedNumber = new int[]
            {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 
                21, 23, 25, 27, 29, 31, 33, 35, 37,
                39, 41, 43, 45, 47, 49, 51, 53, 55,
                57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91,
                93, 95, 97, 99, 101, 103, 105, 107,
                109, 111, 113, 115, 117, 119, 121, 
                123, 125, 127, 129, 131, 133, 135, 
                137, 139, 141, 143, 145, 147, 149, 
                151, 153, 155, 157, 159, 161, 163, 165, 
                167, 169, 171, 173, 175, 177, 179, 181, 
                183, 185, 187, 189, 191, 193, 195, 197, 199
            };
        }
            
        [Fact]
        public void should_return_5050()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var sum = exercises.Exercise2();

            //Deve / Asserção
            Assert.Equal(5050, sum);
        }
        [Fact]
        public void should_return_7_when_passed_5_and_9()
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // criando uma lista com o número 5 na primeira posição e o número 9 na segunda
            var myList = new List<int>(){5, 9};

            // Quando / Ação
            double result = exercises.Exercise4(myList);

            // Deve / Asserções
            Assert.Equal(7, result);
        }


        [Theory]
        [InlineData(new int[3]{4, 6, 8}, 6)]
        [InlineData(new int[2]{4, 6}, 5)]
        [InlineData(new int[4]{1, 2, 3, 4}, 2.5)]
        public void should_return_the_average_between_ages(int[] ages, double expected)
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            double result = exercises.Exercise4(ages.ToList());

            // Deve / Asserções
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[5]{22, 35, 32, 11, 55}, 60)]
        public void should_return_percentage_of_ages_between_18_and_35(double[] ages, double expected)
        {
            var exercises = new Exercises();

            double result = exercises.Exercise5(ages.ToList());

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2, 5, 365)]
        [InlineData(25, 20, 7, 63874.99999999999)]
        public void should_return_365_when_smoked_(int yearSmoked, int cigarretsPerDay, double price, double expected)
        // Calcular a quantidade de dinheiro gasto por um fumante. Dados: o numero de anos que ele fuma,
        //  o nº de cigarros fumados por dia e o preço de uma carteira.
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var expectedValue = exercises.Exercise7(yearSmoked, cigarretsPerDay, price);

            //Deve / Asserção
            Assert.Equal(expected, expectedValue);
        }
        [Theory]
        [InlineData(6, 2, "É multiplo")]
        [InlineData(12, 6, "É multiplo")]
        [InlineData(49, 7, "É multiplo")]
        [InlineData(81, 9, "É multiplo")]
        public void should_return_is_multiple_when_6_and_2_is_passed(int firstNumber, int secondNumber, string expected)
        //Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var returnedValue = exercises.Exercise8(firstNumber, secondNumber);

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
        [Theory]
        [InlineData(6, 2, 3, "O primeiro é maior!")]
        [InlineData(34, 32, 1, "O primeiro é maior!")]
        [InlineData(86, 54, 21, "O primeiro é maior!")]
        [InlineData(524, 134, 343, "O primeiro é maior!")]
        public void should_return_is_bigger_when_firtNumber_is_bigger(int firstNumber, int secondNumber, int thirdNumber, string expected)
        // Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é 
        // maior que a soma dos outros dois
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise9(firstNumber, secondNumber, thirdNumber);

            //Deve / Asserção
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(6, 2, "O primeiro é maior!")]
        [InlineData(11, 22, "O segundo é maior!")]
        [InlineData(7, 12, "O segundo é maior!")]
        [InlineData(7, 7, "Eles são iguais!")]
        public void should_return_the_biggest_number(int firstNumber, int secondNumber, string expected)
        // Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, 
        // ou a mensagem "A = B" caso sejam iguais.
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise10(firstNumber, secondNumber);
            
            //Deve / Asserção
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(12, 3, 4)]
        [InlineData(56, 8, 7)]

        // [InlineData(7, 0, "DIVISÃO POR ZERO")]
        public void should_return_the_division(int firstNumber, int secondNumber, int expected)
        // Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e 
        // imprimir o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise11(firstNumber, secondNumber);
            
            // Deve / Asserção
            Assert.Equal(expected, result);
        }

        // [Theory]
        // [InlineData(new int[4]{6, 2, 3, 3}, 8)]
        // [InlineData(new int[4]{6, 2, 2, 3}, 10)]
        // [InlineData(new int[4]{10, 4, 6, 2}, 22)]
        // public void should_return_(int[] numbers, double expected)
        // //Ler 4 números inteiros e calcular a soma dos que forem pares.
        // {
        //     // Dado / Setup
        //     var exercises = new Exercises();
            
        //     // Quando / Ação
        //     var result = exercises.Exercise12(numbers.ToList());
            
        //     //Deve / Asserção
        //     Assert.Equal(expected, result);
        // }

        [Theory]
        [InlineData(new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 10)]
        [InlineData(new int[10]{23, 42, 12, 34, 76, 43, 867, 645, 44, 10}, 867)]

        public void should_return_(int[] numbers, int expected)
        // Ler 10 valores e determinar o maior dentre eles.
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise13(numbers.ToList());
            
            //Deve / Asserção
            Assert.Equal(expected, result);
        }
    }
}
