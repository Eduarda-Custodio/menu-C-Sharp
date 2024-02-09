using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            while(opc != 13)
            {
                Console.WriteLine("************** TRABALHO **************");
                Console.WriteLine("1 - Par ou ímpar                  2 - Menor número");
                Console.WriteLine("3 - Aprovado/Reprovado            4- Aprovado/Reprovado 2");
                Console.WriteLine("5 - Soma                          6- Fatorial");
                Console.WriteLine("7 - Euclides                      8- conjunto de valores inteiros e positivos");
                Console.WriteLine("9 - Fibonacci                     10- Resistência");
                Console.WriteLine("11 - Distância entre dois pontos  12- IMC");
                Console.WriteLine("13- SAIR");
                Console.WriteLine("**************************************");
                Console.WriteLine("Digite uma opção: ");
                opc = int.Parse(Console.ReadLine());
                 switch (opc)
                {
                    case 1:

                        Console.WriteLine("Informe um número: ");
                        int num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine("Numero par: "+ num);
                        }
                        else
                        {
                            Console.WriteLine("Numero ímpar: " + num);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Informe o primeiro número: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o terceiro número: ");
                        int n3 = int.Parse(Console.ReadLine());

                        while (n1 == n2 || n1 == n3 || n2 == n3)
                        {
                            Console.WriteLine("Informe números diferentes!!");
                            Console.WriteLine("Informe o primeiro número: ");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o segundo número: ");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o terceiro número: ");
                            n3 = int.Parse(Console.ReadLine());
                        }
                        if (n1 < n2 && n1 < n3)
                        {
                            Console.WriteLine("O número menor é o : " + n1);
                        }
                        else if (n2 < n1 && n2 < n3)
                        {
                            Console.WriteLine("O número menor é o : " + n2);
                        }
                        else
                        {
                            Console.WriteLine("O número menor é o : " + n3);
                        }
                            break;
                    case 3:
                        float med, nota1, nota2, soma;
                        Console.WriteLine("Informe a primeira nota:" );
                        nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a segunda nota:" );
                        nota2 = float.Parse(Console.ReadLine());

                        med = (nota1 + nota2) / 2;
                        soma = nota1 + nota2;

                        if (med > 7)
                        {
                            Console.WriteLine("Parabéns você aprovou com a nota " + soma);
                            Console.WriteLine("Média: " + med);
                        }
                        else
                        {
                            Console.WriteLine("Você foi reprovado com a nota " + soma);
                            Console.WriteLine("Média: " + med);
                        }

                        break;
                    case 4:
                        float m, no1, no2;
                        Console.WriteLine("Informe a primeira nota:");
                        no1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a segunda nota:");
                        no2 = float.Parse(Console.ReadLine());

                        m = (no1 + no2) / 2;

                        if (m >= 7)
                        {
                            Console.WriteLine("APROVADO");
                        }
                        else if (m < 5)
                        {
                            Console.WriteLine("REPROVADO");
                        }
                        else
                        {
                            Console.WriteLine("RECUPERAÇÂO");
                        }
                        break;
                    case 5:
                        int num1, num2, s = 0, menor, i;

                        Console.WriteLine("Informe o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        for (i = 0; i < num2; i++)
                        {
                            s = num1 + num2;
                           
                        }
                        if(num1 < num2)
                        {
                            menor = num1;
                        }
                        else
                        {
                            menor = num2;
                        }
                        Console.WriteLine("A soma entre " + num1 + " e " + num2 + " = " + s + " e o menor número é o " + menor);
                        break;
                    case 6:
                        int nn, fatorial = 1;

                        Console.WriteLine("informe um número: ");
                        nn = int.Parse(Console.ReadLine());
                        if (nn == 0)
                        {
                            Console.WriteLine("O fatorial de 0 é 1 ");
                        }
                        else
                        {
                            for (i = 1; i <= nn; i++)
                            {
                                fatorial *= i;
                            }

                            Console.WriteLine("O fatorial de " + nn + " é " + fatorial);
                        }
                        break;
                    case 7:
                        int a, b, r;

                        Console.Write("Digite o primeiro número: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        b = int.Parse(Console.ReadLine());

                        while (b != 0)
                        {
                            r = a % b;
                            a = b;
                            b = r;
                        }
                        Console.WriteLine("O mdc é: " + a);
                        break;
                    case 8:
                        int v, maior = 0;

                        Console.Write("Informe um conjunto de valores inteiros e positivos (-1 para terminar): ");
                        v = int.Parse(Console.ReadLine());

                        while (v != -1)
                        {
                            if (v > maior)
                            {
                                maior = v;
                            }

                            Console.Write("Informe um conjunto de valores inteiros e positivo (-1 para terminar): ");
                            v = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("O maior valor: " + maior);
                        break;
                    case 9:
                        int j, k = 0, l = 1, g = 1;
                        Console.WriteLine("Informe um número: ");
                        j = int.Parse(Console.ReadLine());

                        while(g <= j)
                        {
                            Console.WriteLine(g);
                            g = k + l;
                            k = l;
                            l = g;
                        }
                        break;
                    case 10:
                        float r1, r2, res;

                        Console.WriteLine("Informe o primeiro registro: ");
                        r1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo registro: ");
                        r2 = float.Parse(Console.ReadLine());

                        res = (r1 * r2) / (r1 + r2);

                        Console.WriteLine("A resistência é: " + res);
                        break;
                    case 11:
                        double x1, x2, y1, y2;
                        Console.WriteLine("Digite a coordenada x do primeiro ponto:");
                        x1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a coordenada y do primeiro ponto:");
                        y1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a coordenada x do segundo ponto:");
                        x2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a coordenada y do segundo ponto:");
                        y2 = double.Parse(Console.ReadLine());
     
                        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                        Console.WriteLine("A distância entre os pontos é: " + distancia);   
                        break;
                    case 12:
                        Console.WriteLine("Digite seu nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite seu sexo (M ou F):");
                        char sexo = char.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu peso (em kg):");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite sua altura (em metros):");
                        double altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite sua data de nascimento (no formato dd/mm/aaaa):");
                        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                        int idade = DateTime.Now.Year - dataNascimento.Year;
                        if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
                        {
                            idade--;
                        }

                        double imc = peso / (altura * altura);
                        string situacaoImc;
                        if (imc < 17)
                        {
                            situacaoImc = "Muito baixo do peso";
                        }
                        else if (imc <= 18.49)
                        {
                            situacaoImc = "Abaixo do peso";
                        }
                        else if (imc <= 24.99)
                        {
                            situacaoImc = "Peso normal";
                        }
                        else if (imc <= 29.99)
                        {
                            situacaoImc = "Acima do peso";
                        }
                        else if (imc <= 34.99)
                        {
                            situacaoImc = "Obesidade I";
                        }
                        else if (imc <= 39.99)
                        {
                            situacaoImc = "Obesidade severa II";
                        }
                        else
                        {
                            situacaoImc = "Obesidade morbida III";
                        }
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Sexo: " + sexo);
                        Console.WriteLine("Idade: " + idade + " anos");
                        Console.WriteLine("Peso: " + peso + " kg");
                        Console.WriteLine("Altura: " + altura);
                        Console.WriteLine("IMC: " + imc);
                        Console.WriteLine("Situação do IMC: " + situacaoImc);
                        break;
                    case 13:
                        break;
                    default:
                        Console.WriteLine("Opção inválida !");
                        break;
                }
            }
        }
    }
}
