using System;

class CalculadoraCientifica
{
    static void Main()
    {
        int opcao;
        
        do
        {
            MostrarMenuPrincipal();
            opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    MenuBasicas();
                    break;
                case 2:
                    MenuPotenciaRaiz();
                    break;
                case 3:
                    MenuTrigonometria();
                    break;
                case 4:
                    MenuLogaritmos();
                    break;
                case 5:
                    MenuComplexos();
                    break;
                case 0:
                    Console.WriteLine("\nSaindo... Obrigado por usar a calculadora!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Pausa();
                    break;
            }
            
        } while (opcao != 0);
    }

    static void MostrarMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("================================================");
        Console.WriteLine("         CALCULADORA CIENTÍFICA (C#)");
        Console.WriteLine("================================================");
        Console.WriteLine("1. Operações Básicas");
        Console.WriteLine("2. Potência e Raízes");
        Console.WriteLine("3. Trigonometria");
        Console.WriteLine("4. Logaritmos");
        Console.WriteLine("5. Números Complexos");
        Console.WriteLine("0. Sair");
        Console.WriteLine("================================================");
        Console.Write("Escolha uma opção: ");
    }

    static void MenuBasicas()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("--- OPERAÇÕES BÁSICAS ---");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            if (op >= 1 && op <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double b = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {a} × {b} = {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                            Console.WriteLine("Erro: Divisão por zero não permitida!");
                        else
                            Console.WriteLine($"Resultado: {a} ÷ {b} = {a / b}");
                        break;
                }
            }
            else if (op != 0)
            {
                Console.WriteLine("Opção inválida!");
            }

            if (op != 0) Pausa();

        } while (op != 0);
    }

    static void MenuPotenciaRaiz()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("--- POTÊNCIA E RAÍZES ---");
            Console.WriteLine("1. Potência (x^y)");
            Console.WriteLine("2. Raiz Quadrada");
            Console.WriteLine("3. Raiz Cúbica");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Digite a base: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Digite o expoente: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado: {a}^{b} = {Math.Pow(a, b)}");
                    break;
                case 2:
                    Console.Write("Digite o número: ");
                    a = double.Parse(Console.ReadLine());
                    if (a < 0)
                        Console.WriteLine("Erro: Raiz quadrada de número negativo não é real!");
                    else
                        Console.WriteLine($"Resultado: √{a} = {Math.Sqrt(a)}");
                    break;
                case 3:
                    Console.Write("Digite o número: ");
                    a = double.Parse(Console.ReadLine());
                    if (a < 0)
                        Console.WriteLine($"Resultado: ∛{a} = -{Math.Pow(-a, 1.0/3.0)}");
                    else
                        Console.WriteLine($"Resultado: ∛{a} = {Math.Pow(a, 1.0/3.0)}");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (op != 0) Pausa();

        } while (op != 0);
    }

    static void MenuTrigonometria()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("--- TRIGONOMETRIA (ângulos em graus) ---");
            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Cosseno");
            Console.WriteLine("3. Tangente");
            Console.WriteLine("4. Arco Seno (inverso)");
            Console.WriteLine("5. Arco Cosseno (inverso)");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Digite o ângulo em graus: ");
                    double ang = double.Parse(Console.ReadLine());
                    double rad = ang * Math.PI / 180;
                    
                    if (op == 1)
                        Console.WriteLine($"sen({ang}°) = {Math.Sin(rad):F4}");
                    else if (op == 2)
                        Console.WriteLine($"cos({ang}°) = {Math.Cos(rad):F4}");
                    else
                        Console.WriteLine($"tan({ang}°) = {Math.Tan(rad):F4}");
                    break;
                
                case 4:
                    Console.Write("Digite o valor (entre -1 e 1): ");
                    double val = double.Parse(Console.ReadLine());
                    if (val >= -1 && val <= 1)
                        Console.WriteLine($"arcsen({val}) = {Math.Asin(val) * 180 / Math.PI:F2}°");
                    else
                        Console.WriteLine("Erro: Valor fora do domínio (-1 a 1)");
                    break;
                
                case 5:
                    Console.Write("Digite o valor (entre -1 e 1): ");
                    val = double.Parse(Console.ReadLine());
                    if (val >= -1 && val <= 1)
                        Console.WriteLine($"arccos({val}) = {Math.Acos(val) * 180 / Math.PI:F2}°");
                    else
                        Console.WriteLine("Erro: Valor fora do domínio (-1 a 1)");
                    break;
                
                case 0:
                    break;
                
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (op != 0) Pausa();

        } while (op != 0);
    }

    static void MenuLogaritmos()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("--- LOGARITMOS ---");
            Console.WriteLine("1. Logaritmo Natural (ln)");
            Console.WriteLine("2. Logaritmo Base 10 (log10)");
            Console.WriteLine("3. Logaritmo em qualquer base");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Digite o número: ");
                    double a = double.Parse(Console.ReadLine());
                    if (a <= 0)
                        Console.WriteLine("Erro: Logaritmo de número não positivo!");
                    else
                        Console.WriteLine($"ln({a}) = {Math.Log(a):F4}");
                    break;
                
                case 2:
                    Console.Write("Digite o número: ");
                    a = double.Parse(Console.ReadLine());
                    if (a <= 0)
                        Console.WriteLine("Erro: Logaritmo de número não positivo!");
                    else
                        Console.WriteLine($"log10({a}) = {Math.Log10(a):F4}");
                    break;
                
                case 3:
                    Console.Write("Digite o número: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Digite a base: ");
                    double baseLog = double.Parse(Console.ReadLine());
                    
                    if (a <= 0 || baseLog <= 0 || baseLog == 1)
                        Console.WriteLine("Erro: Parâmetros inválidos!");
                    else
                        Console.WriteLine($"log{baseLog}({a}) = {Math.Log(a, baseLog):F4}");
                    break;
                
                case 0:
                    break;
                
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (op != 0) Pausa();

        } while (op != 0);
    }

    static void MenuComplexos()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("--- NÚMEROS COMPLEXOS ---");
            Console.WriteLine("1. Adição (a + bi) + (c + di)");
            Console.WriteLine("2. Multiplicação");
            Console.WriteLine("3. Módulo");
            Console.WriteLine("4. Forma Polar");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Parte real do primeiro: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária do primeiro: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Parte real do segundo: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária do segundo: ");
                    double d = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Resultado: ({a} + {b}i) + ({c} + {d}i) = {a + c} + {b + d}i");
                    break;
                
                case 2:
                    Console.Write("Parte real do primeiro: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária do primeiro: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Parte real do segundo: ");
                    c = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária do segundo: ");
                    d = double.Parse(Console.ReadLine());
                    
                    double real = a * c - b * d;
                    double imag = a * d + b * c;
                    Console.WriteLine($"Resultado: ({a} + {b}i) × ({c} + {d}i) = {real} + {imag}i");
                    break;
                
                case 3:
                    Console.Write("Parte real: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária: ");
                    b = double.Parse(Console.ReadLine());
                    
                    double modulo = Math.Sqrt(a * a + b * b);
                    Console.WriteLine($"Módulo de {a} + {b}i = {modulo:F4}");
                    break;
                
                case 4:
                    Console.Write("Parte real: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Parte imaginária: ");
                    b = double.Parse(Console.ReadLine());
                    
                    modulo = Math.Sqrt(a * a + b * b);
                    double fase = Math.Atan2(b, a) * 180 / Math.PI;
                    Console.WriteLine($"Forma polar: {modulo:F4} ∠ {fase:F2}°");
                    break;
                
                case 0:
                    break;
                
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (op != 0) Pausa();

        } while (op != 0);
    }

    static void Pausa()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}