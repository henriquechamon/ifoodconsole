using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        public string email = "henrique@email.com";
        public string pass = "123";
        public string user = "Henrique";
        
        static void Main(string[] args)
        {
            string street = "Cândido Gonçalves";
            string number = "2003";
            string city = "Belo Horizonte";

        //CÓDIGO
        Login:
            Console.Clear();
            Console.Title = "Ifood - Console Application";
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine(".__  _____                 .___\r\n|__|/ ____\\____   ____   __| _/\r\n|  \\   __\\/  _ \\ /  _ \\ / __ | \r\n|  ||  | (  <_> |  <_> ) /_/ | \r\n|__||__|  \\____/ \\____/\\____ | \r\n                            \\/ ");
            Console.BackgroundColor= ConsoleColor.Black;
            Console.Write("E-mail:");
            string email2 = Console.ReadLine();
            Console.Write("Senha:");
            string pass2 = Console.ReadLine();
            if (email2 == email & pass2 == pass)
            {
                Console.Clear();
                Console.WriteLine($"Olá, {this.user}! O Ifood está preparando o sistema para você...");
                Thread.Sleep(1000);
                Console.WriteLine("Carregando...");
                Thread.Sleep(1000);
                Console.WriteLine("Se conectando aos datacenters de henriquechamon.com...");
                Thread.Sleep(2000);
                Console.WriteLine("Pronto!");
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\\______   \\ ____   _______/  |______   __ ______________    _____/  |_  ____   ______\r\n |       _// __ \\ /  ___/\\   __\\__  \\ |  |  \\_  __ \\__  \\  /    \\   __\\/ __ \\ /  ___/\r\n |    |   \\  ___/ \\___ \\  |  |  / __ \\|  |  /|  | \\// __ \\|   |  \\  | \\  ___/ \\___ \\ \r\n |____|_  /\\___  >____  > |__| (____  /____/ |__|  (____  /___|  /__|  \\___  >____  >\r\n        \\/     \\/     \\/            \\/                  \\/     \\/          \\/     \\/ ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Selecione qual restaurante deseja faze pedido:");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Mc Donald´s");
                Console.WriteLine("2. Giraffas");
                int escolha = int.Parse(Console.ReadLine());
                Thread.Sleep(2000);
                //MC DONALDS
                if (escolha == 1)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("   _____  _________   ________                       .__       .___      \r\n  /     \\ \\_   ___ \\  \\______ \\   ____   ____ _____  |  |    __| _/______\r\n /  \\ /  \\/    \\  \\/   |    |  \\ /  _ \\ /    \\\\__  \\ |  |   / __ |/  ___/\r\n/    Y    \\     \\____  |    `   (  <_> )   |  \\/ __ \\|  |__/ /_/ |\\___ \\ \r\n\\____|__  /\\______  / /_______  /\\____/|___|  (____  /____/\\____ /____  >\r\n        \\/        \\/          \\/            \\/     \\/           \\/    \\/ ");
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine("Seja bem vindo(a) ao Mc Donalds! Escolha o que fazer:");
                    Console.WriteLine("1. Realizar pedido");
                    Console.WriteLine("2. Voltar ao início do sistema");
                    int escolhamcdonalds = int.Parse(Console.ReadLine());
                    if (escolhamcdonalds == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Cardápio:");
                        Console.WriteLine("1. McChicken + Milk Shake");
                        Console.WriteLine("2. BigMac + Coca-cola");
                        Console.WriteLine("3. McLancheFeliz + Nuggets");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        int escolhacardapio = int.Parse(Console.ReadLine());
                        if (escolhacardapio == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"O Seu McChicken + MilkShake chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;

                        }
                        if (escolhacardapio == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"O Seu BigMac + CocaCola chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;
                        }
                        if (escolhacardapio == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"O Seu McLancheFeliz + Nugget´s chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;
                        }

                    }
                    if (escolhamcdonalds == 2)
                    {
                        Console.Clear();
                        goto Login;

                    }

                }
                //GIRAFFAS
                if (escolha == 2)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("  ________.__               _____  _____              ._.\r\n /  _____/|__|___________ _/ ____\\/ ____\\____    _____| |\r\n/   \\  ___|  \\_  __ \\__  \\\\   __\\\\   __\\\\__  \\  /  ___/ |\r\n\\    \\_\\  \\  ||  | \\// __ \\|  |   |  |   / __ \\_\\___ \\ \\|\r\n \\______  /__||__|  (____  /__|   |__|  (____  /____  >__\r\n        \\/               \\/                  \\/     \\/ \\/");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine("Seja bem vindo(a) ao Giraffas! Escolha o que fazer:");
                    Console.WriteLine("1. Realizar pedido");
                    Console.WriteLine("2. Voltar ao início do sistema");
                    int escolhagiraffas = int.Parse(Console.ReadLine());
                    if (escolhagiraffas == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Cardápio:");
                        Console.WriteLine("1. Prato feito com frango empanado");
                        Console.WriteLine("2. Bifé de quadril");
                        Console.WriteLine("3. Parmegianas");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        int escolhacardapio2 = int.Parse(Console.ReadLine());
                        if (escolhacardapio2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"O Seu Prato feito com frango empanado chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;
                        }
                        if (escolhacardapio2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"O Seu Bifé de quadril empanado chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;
                        }
                        if (escolhacardapio2 == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Insira suas informações abaixo:");
                            Console.Write("Rua:");
                            string rua = Console.ReadLine();
                            Console.Write("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.Write("Bairro:");
                            string bairro = Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("________                               .__                      \r\n\\_____  \\  __ _______    ______ ____   |  | _____               \r\n /  / \\  \\|  |  \\__  \\  /  ___// __ \\  |  | \\__  \\              \r\n/   \\_/.  \\  |  // __ \\_\\___ \\\\  ___/  |  |__/ __ \\_            \r\n\\_____\\ \\_/____/(____  /____  >\\___  > |____(____  / /\\  /\\  /\\ \r\n       \\__>          \\/     \\/     \\/            \\/  \\/  \\/  \\/ ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Estamos enviando suas informações para nossa central mais próxima de {cidade}...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("__________           .___.__    .___         _____      .__  __        ._.\r\n\\______   \\ ____   __| _/|__| __| _/____   _/ ____\\____ |__|/  |_  ____| |\r\n |     ___// __ \\ / __ | |  |/ __ |/  _ \\  \\   __\\/ __ \\|  \\   __\\/  _ \\ |\r\n |    |   \\  ___// /_/ | |  / /_/ (  <_> )  |  | \\  ___/|  ||  | (  <_> )|\r\n |____|    \\___  >____ | |__\\____ |\\____/   |__|  \\___  >__||__|  \\____/__\r\n               \\/     \\/         \\/                   \\/                \\/");
                            Thread.Sleep(4000);
                            Console.WriteLine($"A sua Parmegiana empanado chegará em breve em {rua} no bairro {bairro}!");
                            Thread.Sleep(3000);
                            goto Login;
                        }

                    }
                    if (escolhagiraffas == 2)
                    {
                        Console.Clear();
                        goto Login;

                    }

                }


            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("Usuário ou senha inválido, tente acessar o código!");
            }


        }
    }
    }
