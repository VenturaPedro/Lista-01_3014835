using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista1
{

    public class Lista_1
    {
        static void Exercicio_1()
        {
            double salarioMinimo;
            double salarioPessoa;
            double salarioLiquido;

            Console.WriteLine("Informe o valor do salário-mínimo atual: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do salário da pessoa: ");
            salarioPessoa = double.Parse(Console.ReadLine());

            salarioLiquido = salarioPessoa - (salarioPessoa * 0.085);

            Console.WriteLine("A pessoa ganha " + (salarioLiquido / salarioMinimo).ToString("0.00") + " salários-mínimos líquidos \n \n");

            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();

        }
        public static void Exercicio_2()
        {
            int valorMetros;
            float valorCentimetros;
            double valorMilimetros;
            Console.WriteLine("Informe um valor em metros: ");
            valorMetros = int.Parse(Console.ReadLine());


            valorCentimetros = valorMetros * 100;

            valorMilimetros = valorCentimetros * 10;

            //valorMilimetros = String.Format("{0,12:0,000.00}", valorMilimetros);

            Console.WriteLine("{0} metros tem {1} centimetros e {2} milimetros \n", valorMetros, String.Format("{0:0,000}", valorCentimetros), String.Format("{0:0,000}", valorMilimetros));


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        public static void Exercicio_3()
        {
            float ValorFahrenheit, GrausCelsius;

            Console.WriteLine(" Entre com um valor para graus Fahrenheit ºF ");
            ValorFahrenheit = float.Parse(Console.ReadLine());

            GrausCelsius = (ValorFahrenheit - 32) * 5 / 9;
            //(45 °F − 32) × 5/9 = 7,222 °C

            Console.WriteLine("O valor {0} em Fahrenheit é equivalente a {1} ºC", ValorFahrenheit, GrausCelsius);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_4()
        {
            float PesoEmKg, AlturaEmMetros, Imc;
            Console.WriteLine("Vamos calcular o seu IMC (Índice de Massa Corporal)");

            Console.WriteLine("Qual seu peso em KG?");
            PesoEmKg = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura em Metros?");
            AlturaEmMetros = float.Parse(Console.ReadLine());

            Imc = PesoEmKg / (AlturaEmMetros * AlturaEmMetros);

            Console.WriteLine("Seu IMC é de {0}", Imc);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_5()
        {
            int[] ValoresNumeros = new int[100];
            int[] ValoresPesos = new int[100];
            //int[] ValoresNumeros, ValoresPesos;
            int valor, valor2;
            float MediaPonderada;
            Console.WriteLine("Precisarei que entre com 3 numeros e 3 pesos");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Precisarei que entre com numero {0}:", i);
                valor = int.Parse(Console.ReadLine());
                ValoresNumeros[i] = valor;

            }
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("!Agora! Precisarei que entre com o peso {0}:", i);
                valor2 = int.Parse(Console.ReadLine());
                ValoresPesos[i] = valor2;

            }

            MediaPonderada = (ValoresNumeros[1] * ValoresPesos[1] + ValoresNumeros[2] * ValoresPesos[2] + ValoresNumeros[3] * ValoresPesos[3]) / (ValoresPesos[1] + ValoresPesos[2] + ValoresPesos[3]);

            Console.WriteLine(" A media ponderada desses dados é {0}", MediaPonderada);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_6()
        {
            int ValorDeA, ValorDeB, ValorDeC;

            Console.WriteLine("Vamos calcular o DELTA ");
            Console.WriteLine("Formula D = b2 – 4ac ");

            Console.WriteLine("Entre com um valor inteiro para A : ");
            ValorDeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um valor inteiro para B : ");
            ValorDeB = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um valor inteiro para C : ");
            ValorDeC = int.Parse(Console.ReadLine());

            double delta_p1 = Math.Sqrt(ValorDeB * ValorDeB);
            double delta_p2 = Math.Sqrt(4 * ValorDeA * ValorDeC);

            double delta = (delta_p1 - delta_p2);

            double a1 = (-ValorDeB + (delta)) / (2 * ValorDeA);
            double a2 = (-ValorDeB - (delta)) / (2 * ValorDeA);

            Console.WriteLine("Valor do A1 = {0}", a1);
            Console.WriteLine("Valor do A2 = {0}", a2);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_7()
        {

            float ValorAumento, Salario, SalarioNovo;
            string Aumento;
            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâ,êîôûãõç\s]";
            string replacement = "";


            Console.WriteLine("Entre com o seu salário: ");
            Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade em aumento: ");
            Aumento = (Console.ReadLine());


            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(Aumento, replacement);

            int Convertido = Int32.Parse(result);

            Console.WriteLine(Convertido);

            float Conversion = Convertido;

            ValorAumento = 1 + (Conversion / 100);

            SalarioNovo = ValorAumento * Salario;
            Console.WriteLine(SalarioNovo);

            Console.WriteLine("Com o aumento de {0} o salário de {1} passa a ser de {2}", Aumento, Salario, SalarioNovo);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }

        static void Exercicio_8()
        {
            float Reais, Dolares, ValorFinal;

            Console.WriteLine("Entre com o valor em Real:");
            Reais = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a contação do Dólar");
            Dolares = float.Parse(Console.ReadLine());

            ValorFinal = Reais / Dolares;

            Console.WriteLine("Valor em dólar seu real: {0:C2}$", ValorFinal);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();

        }
        static void Exercicio_9()
        {

            Console.Write("Entre com um valor :");
            int Valor = int.Parse(Console.ReadLine());

            int antecessor = 3 * (Valor - 1);
            int sucessor = 2 * (Valor + 1);

            Console.WriteLine("A soma do do antecessor do seu triplo é = {0}", antecessor);
            Console.WriteLine("A soma do do suecessor do seu dobro é = {0}", sucessor);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }

        static void Exercicio_10()
        {
            int numero = 0;

            while (true)
            {
                Console.WriteLine("Digite um número inteiro de 4 dígitos:");
                string input = Console.ReadLine();

                if (input.Length == 4 && int.TryParse(input, out numero))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("O número deve ter exatamente 4 dígitos. Tente novamente.");
                }
            }

            int unidade = numero % 10;
            int dezena = (numero / 10) % 10;
            int centena = (numero / 100) % 10;
            int milhar = (numero / 1000) % 10;

            Console.WriteLine(milhar);
            Console.WriteLine(centena);
            Console.WriteLine(dezena);
            Console.WriteLine(unidade);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }

        static void Exercicio_11()
        {
            double ValorInicial = 1000;
            double ValorFinal;
            double RendaDia1 = 12.40, RendaDia2 = 1.8, RendaDia3 = 5.6, RendaDia4 = 4.5;

            Console.WriteLine("Marquesito, aluno do Instituto, começou a investir em criptomoedas. De início ele tem R$1000,00 \r\npara realizar seu primeiro investimento. No primeiro dia, seu patrimônio caiu 12,4%, no segundo \r\nsubiu 1,8%, no terceiro subiu 5,6% e, no quarto caiu 4,5%. Crie um código para calcular qual o valor \r\natual dos investimentos de Marquesito.\r \n \n");


            ValorFinal = ValorInicial - ((ValorInicial * (RendaDia1 / 100)));
            ValorFinal = ValorFinal + ((ValorFinal * RendaDia2 / 100));
            ValorFinal = ValorFinal + ((ValorFinal * RendaDia3 / 100));
            ValorFinal = ValorFinal - ((ValorFinal * RendaDia4 / 100));


            Console.WriteLine("Com base nos calculos o valor atual de investimento de MArquesito é de {0:C2}", ValorFinal);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_12()
        {

            Console.WriteLine("Qual a sua altura?: ");
            double Altura = double.Parse(Console.ReadLine());

            double PesoIdealHomens = (72.7 * Altura) - 58;
            double PesoIdealMulheres = (62.1 * Altura) - 44.7;

            Console.WriteLine("Se você for Mulher seu Peso ideal é : {0:C3} Kg", PesoIdealMulheres);
            Console.WriteLine("Se você for Homem seu Peso ideal é : {0:C3} Kg", PesoIdealHomens);


            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }

        static int Main(string[] args)
        {
            int ValorExercicios;

            do
            {
                Console.WriteLine("----ENTRE COM O VALOR DO EXERCICIO------ ");
                Console.WriteLine("---------------------------------------- ");
                Console.WriteLine("---------------------------------------- ");
                Console.WriteLine("CALCULO DE SALARIO-------------------- 1 ");
                Console.WriteLine("CALCULO DE METROS PARA CM E MM-------- 2 ");
                Console.WriteLine("CALCULO DE ºF para ºC----------------- 3 ");
                Console.WriteLine("CALCULO DE IMC------------------------ 4 ");
                Console.WriteLine("CALCULO DE MÉDIA PONDERADA------------ 5 ");
                Console.WriteLine("CALCULO DE DELTA---------------------- 6 ");
                Console.WriteLine("CALCULO DE AUMENTO DE SÁLARIO--------- 7 ");
                Console.WriteLine("CALCULO DE DÓLAS PARA REAL------------ 8 ");
                Console.WriteLine("CALCULO DE SUCESSOR------------------- 9 ");
                Console.WriteLine("4 DIGITOS LINHA POR LINHA------------ 10 ");
                Console.WriteLine("CALCULO DE CRIPTOMOEDAS--------------- 11 ");
                Console.WriteLine("CALCULO DE PESO IDEAL----------------- 12 ");
                Console.WriteLine("PARA SAIR----------------------------- 0 ");
                Console.WriteLine("----------------------------------------\n ");
                Console.WriteLine("Qual sera o exercicio da vez?: ");

                ValorExercicios = int.Parse(Console.ReadLine());

                switch (ValorExercicios)
                {
                    case 0:
                        Console.WriteLine("Até a próxima");
                        Console.ReadKey();
                        break;
                    case 1:
                        Exercicio_1();
                        break;
                    case 2:
                        Exercicio_2();
                        break;
                    case 3:
                        Exercicio_3();
                        break;
                    case 4:
                        Exercicio_4();
                        break;
                    case 5:
                        Exercicio_5();
                        break;
                    case 6:
                        Exercicio_6();
                        break;
                    case 7:
                        Exercicio_7();
                        break;
                    case 8:
                        Exercicio_8();
                        break;
                    case 9:
                        Exercicio_9();
                        break;
                    case 10:
                        Exercicio_10();
                        break;
                    case 11:
                        Exercicio_11();
                        break;
                    case 12:
                        Exercicio_12();
                        break;
                    default:
                        Console.WriteLine("Não possui uma lista correspondente ao seu pedido");
                        Console.ReadKey();
                        break;
                }
            } while (ValorExercicios != 0);
            return 0;
        }
    }
}