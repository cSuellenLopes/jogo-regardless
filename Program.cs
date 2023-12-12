using System;
namespace HelloWold
{

    public abstract class Inicio
    {

        public string nome;                            // Variaveis 
        public string gameName = "REGARDLESS";         // da Classe
        public string EnterIntroduction;


        public abstract void Start();   // Metodo Abstrato (O Pontapé para a Pagina Inicial)




        public void Who()
        {              // Metodo para a identificação do usuario.



            while (true)
            {
                Console.WriteLine(" _________________________ ");
                Console.WriteLine("|<><><>     |  |    <><><>|");
                Console.WriteLine("|<>         |  |        <>|");
                Console.WriteLine("|           |  |          |");
                Console.WriteLine("|  (______ <\\-/> ______)  |");
                Console.WriteLine("|  /_.-=-.\\| \" |/.-=-._\\  |");
                Console.WriteLine("|   /_    \\(o_o)/    _\\   |");
                Console.WriteLine("|    /_  /\\/ ^ \\/\\  _\\    |");
                Console.WriteLine("|      \\/ | / \\ | \\/      |");
                Console.WriteLine("|_______ /((( )))\\ _______|");
                Console.WriteLine("|      __\\ \\___/ /__      |");
                Console.WriteLine("|--- (((---'   '---))) ---|");
                Console.WriteLine("|           |  |          |");
                Console.WriteLine("|           |  |          |");
                Console.WriteLine(":           |  |          :");
                Console.WriteLine(" \\<>        |  |       <>/ ");
                Console.WriteLine("  \\<>       |  |      <>/  ");
                Console.WriteLine("   \\<>      |  |     <>/   ");
                Console.WriteLine("    `\\<    |  |   <>/'    ");
                Console.WriteLine("      `\\<  |  |  <>/'     ");
                Console.WriteLine("        `\\<|  |<>/'       ");
                Console.WriteLine("          `-.  .-`         ");
                Console.WriteLine("            '--'           ");

                Console.WriteLine("");


                Console.WriteLine("  _____  ______ _____          _____  _____  _      ______  _____ _____ ");
                Console.WriteLine(" |  __ \\|  ____/ ____|   /\\   |  __ \\|  __ \\| |    |  ____|/ ____/ ____|");
                Console.WriteLine(" | |__) | |__ | |  __   /  \\  | |__) | |  | | |    | |__  | (___| (___  ");
                Console.WriteLine(" |  _  /|  __|| | |_ | / /\\ \\ |  _  /| |  | | |    |  __|  \\___ \\___ \\ ");
                Console.WriteLine(" | | \\ \\| |___| |__| |/ ____ \\| | \\ \\| |__| | |____| |____ ____) |___) |");
                Console.WriteLine(" |_|  \\_\\______\\_____/_/    \\_\\_|  \\_\\_____/|______|______|_____/_____/ ");
            

            Console.WriteLine("");

                Console.WriteLine("INFORME SEU NOME:");
                nome = Console.ReadLine();

                Console.WriteLine("");


                Console.Clear();

                if (nome == "")
                {
                    Who();
                }

                else {break;}

            }

        }

        public void Introduction()
        {


            Console.WriteLine("                                  {} {}                                 ");
            Console.WriteLine("                         !  !  ! II II !  !  !                         ");
            Console.WriteLine("                      !  I__I__I_II II_I__I__I  !                      ");
            Console.WriteLine("                      I_/|__|__|_|| ||_|__|__|\\_I                      ");
            Console.WriteLine("                   ! /|_/|  |  | || || |  |  |\\_\\ !                   ");
            Console.WriteLine("       .--.        I//|  |  |  | || || |  |  |  |\\\\I        .--.       ");
            Console.WriteLine("      /-   \\    ! /|/ |  |  |  | || || |  |  |  | \\|\\ !    /=   \\      ");
            Console.WriteLine("      \\=__ /    I//|  |  |  |  | || || |  |  |  |  |\\\\I    \\-__ /      ");
            Console.WriteLine("       }  {  ! /|/ |  |  |  |  | || || |  |  |  |  | \\|\\ !  }  {       ");
            Console.WriteLine("      {____} I//|  |  |  |  |  | || || |  |  |  |  |  |\\\\I {____}      ");
            Console.WriteLine("_!__!__|= |=/|/ |  |  |  |  |  | || || |  |  |  |  |  | \\|=|  |__!__!_");
            Console.WriteLine("_I__I__|  ||/|__|__|__|__|__|__|_|| ||_|__|__|__|__|__|__|\\||- |__I__I_");
            Console.WriteLine("-|--|--|- ||-|--|--|--|--|--|--|-|| ||-|--|--|--|--|--|--|-||= |--|--|-");
            Console.WriteLine(" |  |  |  || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||  |  |  | ");
            Console.WriteLine(" |  |  |= || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  | ");
            Console.WriteLine(" |  |  |- || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  | ");
            Console.WriteLine(" |  |  |- || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||- |  |  | ");
            Console.WriteLine("_|__|__|  ||_|__|__|__|__|__|__|_|| ||_|__|__|__|__|__|__|_||  |__|__|_");
            Console.WriteLine("-|--|--|= ||-|--|--|--|--|--|--|-|| ||-|--|--|--|--|--|--|-||- |--|--|-");
            Console.WriteLine("-|--|--|| |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  |    ");
            Console.WriteLine("~~~~~~~~~~~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~");


            Console.WriteLine("");
            Console.WriteLine("INTRODUÇÃO AO JOGO.");
            Console.WriteLine();
            Console.WriteLine("QUANDO SE É PERGUNTADO - VOCÊ O SALVARIA? JAMAIS “DEPENDE” DEVE SER A RESPOSTA.");
            Console.WriteLine();
            Console.WriteLine("ESTE JOGO SE TRATA DISTO - POR QUE EU PRECISO TE DAR UM MOTIVO PARA SALVAR ALGUÉM!?");
            Console.WriteLine();
            Console.WriteLine("NESTE JOGO VOCÊ ESCOLHERÁ E TERÁ QUE SALVAR UMA PESSOA ALEATÓRIA.");
            Console.WriteLine();
            Console.WriteLine("ESSA PESSOA PODE SER O MÉDICO QUE ACHARÁ A CURA PARA O ALZHEIMER OU UM TERRORISTA - QUEM SABERÁ!?");
            Console.WriteLine();
            Console.WriteLine("NÃO HAVERÁ MOTIVOS - CONTUDO HAVERÁ CONSEQUÊNCIAS - MAS ELAS DIRÃO MAIS SOBRE A PESSOA DO QUE SOBRE VOCÊ.");
            Console.WriteLine();
            Console.WriteLine("PARA AJUDÁ-LO(A): EM TODAS AS CHARADAS - A PALAVRA-CHAVE SERÁ UMA PISTA DE QUEM ESSA PESSOA É OU SERÁ.");
            Console.WriteLine();
            Console.WriteLine("CHATGPT AVISA: ESTE JOGO NÃO FOI CRIADO PARA INCITAR ATITUDES VIOLENTAS OU PARA DEFENDER CRIMINOSOS.");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("PRESSIONE ENTER E SERÁ GUIADO(A) PARA A PAGINA INICIAL:");
                EnterIntroduction = Console.ReadLine();

                if (EnterIntroduction == "") { break; }
                else { Console.Clear(); Introduction(); break; }
            }
        }

        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("                           ####                    ");
            Console.WriteLine("                          ####                    ");
            Console.WriteLine("                          ####                    ");
            Console.WriteLine("          ####            ####            ##      ");
            Console.WriteLine("          ####                          ######    ");
            Console.WriteLine("            ####      ############    ######      ");
            Console.WriteLine("                  ##################    ##        ");
            Console.WriteLine("                ######################            ");
            Console.WriteLine("                ########################          ");
            Console.WriteLine("              ##########################          ");
            Console.WriteLine("              ############################        ");
            Console.WriteLine("    ######    ############################  ######");
            Console.WriteLine("    ######    ############################  ######");
            Console.WriteLine("              ############################        ");
            Console.WriteLine("              ############################        ");
            Console.WriteLine("              ##########################          ");
            Console.WriteLine("                ######################            ");
            Console.WriteLine("                  ##################              ");
            Console.WriteLine("            ####    ##############    ####        ");
            Console.WriteLine("          ######                        ####      ");
            Console.WriteLine("          ####                            ##      ");
            Console.WriteLine("                          ####                    ");
            Console.WriteLine("                          ####                    ");
            Console.WriteLine("                          ####                    ");
            Console.WriteLine("");

            Console.WriteLine(nome + ", BEM-VINDO(A) AO JOGO: " + gameName + "!"); 

            Console.WriteLine("");


        }
    }

    public class Home : Inicio
    {

        public string Selecionador;       // Variavel para capturar o Personagem, do qual o usuario deseja jogar.
        public string upperSelecionador; // Variavel utilizada pada receber o valor da variavel Selecionador e converter tudo para Maiuscula. 

        public string Voltar;
        public string upperVoltar;

        public int options;

        public bool encerrarLoop = true; // Principal Loop do Metodo Abstrato Start.



        public override void Start()
        {

            Console.WriteLine("AGORA VOCÊ ESTÁ NA PAGINA INICIAL");

            Console.WriteLine("");

            Console.WriteLine("1 - REGRAS");
            Console.WriteLine("2 - INICIAR");
            Console.WriteLine("3 - INFORMAÇÕES");

            Console.WriteLine("");

            while (encerrarLoop == true)
            {

                options = 0;

                Console.WriteLine(nome + ", ESCOLHA UMA DAS OPÇÕES ACIMA COM O NÚMERO CORRESPONDENTE:");
                options = Int32.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (options < 1 || options > 3)
                {
                    Console.Clear();

                    Welcome();

                    Start(); break;
                } // Para se a opção for inválida, ficar repetindo o Start como se fosse uma atualização de página.

                else { encerrarLoop = false; }




                switch (options)

                {
                    case 1:
                        Console.WriteLine("OPÇÃO SELECIONADA: REGRAS");

                        Console.WriteLine("");

                        Console.WriteLine("REGRA 1 - SIGA AS INSTRUÇÕES CORRETAMENTE.");

                        Console.WriteLine("");
                        Console.WriteLine("FIM DAS REGRAS!");
                        Console.WriteLine("");

                        while (true)
                        {

                            Console.WriteLine(nome + ", DESEJA VOLTAR PARA A PÁGINA INICIAL? DIGITE SIM OU NÃO.");
                            Voltar = Console.ReadLine();
                            
                            upperVoltar = Voltar.ToUpper();

                            if (upperVoltar == "SIM")
                            {
                                Console.Clear();
                                Start(); encerrarLoop = true; // Reinicia o metodo Start chamando o Loop do While.
                                break;
                            } 

                            else if (upperVoltar == "NÃO" || upperVoltar == "NAO")
                            {

                                Console.Clear();
                                Console.WriteLine("");

                                Console.WriteLine("NÃO HÁ MAIS NADA."); 
                                Console.WriteLine("");
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("POR FAVOR, DIGITE SIM OU NÃO.");
                            } 

                             Console.WriteLine("");

                            }
                               break;



                    case 2:
                        Console.WriteLine("OPÇÃO SELECIONADA: INICIAR");

                        Console.WriteLine("");

                        Console.WriteLine("PERSONAGENS DISPONIVEIS PARA JOGAR:");

                        Console.WriteLine("");

                        Console.WriteLine("• BRUNO"); Console.WriteLine("• OMAR");

                        Console.WriteLine("");

                        while (true)
                        {
                            Console.Write("ESCOLHA UMA DAS OPÇÕES ACIMA COM O NOME CORRESPONDENTE DO PERSONAGEM: ");
                            Selecionador = Console.ReadLine();

                            upperSelecionador = Selecionador.ToUpper(); if (upperSelecionador != "BRUNO" && upperSelecionador != "OMAR")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("ERRO NA ESCRITA OU ESSE PERSONAGEM NÃO EXISTE! TENTE NOVAMENTE. "); Console.WriteLine("");
                            }
                            else { break; }
                        }

                        Console.WriteLine(""); 
                        
                        break;


                    case 3:
                        Console.WriteLine("OPÇÃO SELECIONADA: INFORMAÇÕES");
                        Console.WriteLine("");
                        Console.WriteLine("INFORMAÇÃO 1 - EM TODO PERSONAGEM APARECERÁ UMA ILUSTRAÇÃO DO QUE SE TRATARÁ O DESAFIO.");
                        Console.WriteLine("");
                        Console.WriteLine("FIM DAS INFORMAÇÕES!");
                        Console.WriteLine("");

                        while (true)
                        {

                            Console.WriteLine(nome + ", DESEJA VOLTAR PARA A PÁGINA INICIAL? DIGITE SIM OU NÃO.");
                            Voltar = Console.ReadLine();

                            upperVoltar = Voltar.ToUpper();

                            if (upperVoltar == "SIM")
                            {
                                Console.Clear();
                                Start(); encerrarLoop = true;
                                break;
                            }

                            else if (upperVoltar == "NÃO" || upperVoltar == "NAO")
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("NÃO HÁ MAIS NADA.");
                                Console.WriteLine("");
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("ERRO! POR FAVOR, DIGITE SIM OU NÃO.");
                                Console.WriteLine("");
                            }
                            }
                             break;
                         
                            } 

                            } // Fechamento do encerrarLoop.

                            }
                            
                            }


    public abstract class gamePlay
    {
        public string EnterLevelAssigned;
        public string EnterScenario;
        public string Start;

        public abstract void LevelAssigned();
        public abstract void ShowDescription();
        public abstract void StartLevel();


    }

    public class Bruno : gamePlay
    {

       

        public string KeyWord;
        public string upperKeyWord;

        public string secondKeyWord;
        public string secKeyWord; // É o ToUpper da variavel secondKeyWord.
       
        public string upperSelecionador;
        public string secondTry;

        public string nextLevelB;
        public string nextLevelB1;
        public string nextLevelB2;


        public override void LevelAssigned()
        {

            if (upperSelecionador == "BRUNO")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("PERSONAGEM SELECIONADO: BRUNO ");
                Console.WriteLine("");
                Console.WriteLine("BEM-VINDO AO DESAFIO: LIGHTING!");

                Console.WriteLine("");

                Console.WriteLine("              .-*--,.   .-.");
                Console.WriteLine("          .--. ./OOOOOOOOO\\.'OOO`9~-.");
                Console.WriteLine("        .`OOOOOO.OOM.OLSONOOOOO@@OOOOOO\\");
                Console.WriteLine("       /OOOO@@@OO@@@OO@@@OOO@@@@@@@@OOOO`.");
                Console.WriteLine("       |OO@@@WWWW@@@@OOWWW@WWWW@@@@@@@OOOO).");
                Console.WriteLine("     .-'OO@@@@WW@@@W@WWWWWWWWOOWW@@@@@OOOOOO}");
                Console.WriteLine("    /OOO@@O@@@@W@@@@@OOWWWWWOOWOO@@@OOO@@@OO|");
                Console.WriteLine("   lOOO@@@OO@@@WWWWWWW\\OWWWO\\WWWOOOOOO@@@O.'");
                Console.WriteLine("    \\OOO@@@OOO@@@@@@OOW\\     \\WWWW@@@@@@@O'.");
                Console.WriteLine("     `,OO@@@OOOOOOOOOOWW\\     \\WWWW@@@@@@OOO)");
                Console.WriteLine("      \\,O@@@@@OOOOOOWWWWW\\     \\WW@@@@@OOOO.'");
                Console.WriteLine("        `c~8@@@@WWW@@W\\       \\WOO|\\UO-~'");
                Console.WriteLine("             (OWWWWWW@/\\W\\    _\\WO)");
                Console.WriteLine("               `-''     \\   \\WW=*'");
                Console.WriteLine("                         __\\   \\");
                Console.WriteLine("                         \\      \\");
                Console.WriteLine("                          \\    __\\");
                Console.WriteLine("                           \\  \\");
                Console.WriteLine("                            \\ \\");
                Console.WriteLine("                             \\ \\");
                Console.WriteLine("                              \\\\");
                Console.WriteLine("                               \\\\");
                Console.WriteLine("                                \\");
                Console.WriteLine("                                 \\");
                Console.WriteLine("");

                while (true)
                {
                    Console.WriteLine("PRESSIONE ENTER PARA INICIAR A DESCRIÇÃO DO DESAFIO LIGHTING:");
                    EnterLevelAssigned = Console.ReadLine();
                    if (EnterLevelAssigned != "") { LevelAssigned(); break; }
                    else { break; }

                }
            }


        }


        public override void ShowDescription()
        {

            switch (EnterLevelAssigned)
            {
                case "":
                    Console.Clear();

                    Console.WriteLine("");
                    Console.WriteLine("CENÁRIO:");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("BRUNO - VOCÊ ESTÁ NUM AQUÁRIO - SOBRE UM TANQUE DE ACRÍLICO (DE APROXIMADAMENTE 25 MIL LITROS) COM 30 ENGUIAS-ELÉTRICAS!");
                    Console.WriteLine("");
                    Console.WriteLine("QUE GERAM DESCARGAS ELÉTRICAS (DE APROXIMADAMENTE 200 VOLTS)");
                    Console.WriteLine("");
                    Console.WriteLine("E ESTÁ (DE JOELHOS) PRESO - POR CORRENTES - Á UMA PLATAFORMA AUTOMÁTICA.");
                    Console.WriteLine("");
                    Console.WriteLine("— SOCORRO! POR FAVOR! ME TIRA DAQUI!");
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("PRESSIONE ENTER PARA LER O DESAFIO:");
                        EnterScenario = Console.ReadLine();

                        if (EnterScenario == "") { Console.Clear(); break; }
                        else
                        {
                            Console.Clear();
                            ShowDescription();
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("DESAFIO:");
                    Console.WriteLine("");
                    Console.WriteLine("(O DESAFIO) PARA AJUDÁ-LO CONSISTE QUE - POR ATRAVÉS DE UMA CHARADA.");
                    Console.WriteLine("");
                    Console.WriteLine("O JOGADOR ACHE A PALAVRA-CHAVE QUE ESTÁ ESCRITA NO CAÇA-PALAVRAS (NO ENTORNO DO TANQUE)");
                    Console.WriteLine("");
                    Console.WriteLine("HÁ 12 PALAVRAS - CONTUDO O JOGADOR SÓ RECEBERÁ 2 TENTATIVAS PARA ACERTÁ-LA.");
                    Console.WriteLine("");
                    Console.WriteLine("E POR CADA ERRO - A PLATAFORMA (SOB VOCÊ) ABAIXARÁ E FECHARÁ O TANQUE POR (APROXIMADAMENTE 5 SEGUNDOS)");
                    Console.WriteLine("");
                    Console.WriteLine("PORTANTO - VOCÊ RECEBERÁ DAS ENGUIAS (APROXIMADAMENTE) 6000 VOLTS EM DESCARGA ELÉTRICA - POR 5 SEGUNDOS!");
                    Console.WriteLine("");
                    Console.WriteLine("— QUE!? NÃO! NÃO!");
                    Console.WriteLine("");
                    Console.WriteLine("SE O JOGADOR ACERTAR - A PLATAFORMA SE MANTERÁ NO TOPO ATÉ O ALVORECER.");
                    Console.WriteLine("");
                    Console.WriteLine("É QUANDO UM FUNCIONÁRIO O ENCONTRARÁ.");
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("PRESSIONE ENTER PARA INICIAR O DESAFIO:");
                        Start = Console.ReadLine();
                        if (Start != "")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ERRO! TENTE NOVAMENTE."); Console.WriteLine("");
                        }
                        else { break; }
                    }
                    break;


            }
        }

        public override void StartLevel()
        {
            switch (Start)
            {
                case "":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("CHARADA:");
                    Console.WriteLine("");
                    Console.WriteLine("NO CAMINHO DA EXISTÊNCIA, ATRAVESSO O VÉU SOMBRIO QUE DESVANECE DIANTE DA BUSCA INCANSÁVEL, ENTRELAÇANDO A SOLUÇÃO NOS MEANDROS TEMPORAIS.");
                    Console.WriteLine("");
                    Console.WriteLine("O QUE SOU EU?");
                    Console.WriteLine("");
                    Console.WriteLine("CAÇA-PALAVRAS:");
                    Console.WriteLine("");
                    Console.WriteLine("U  S  T  V  I  D  A  Q  R  U  V  P  W  Y");
                    Console.WriteLine("V  E  P  E  T  R  A  T  A  M  E  N  T  O");
                    Console.WriteLine("C  O  V  Q  T  U  P  S  N  T  E  M  P  O");

                    Console.WriteLine("D  O  E  N  Ç  A  T  U  P  S  W  Q  D  E");
                    Console.WriteLine("N  O  R  M  E  D  I  C  A  Ç  Ã  O  R  O");
                    Console.WriteLine("B  C  Q  V  T  J  K  G  L  N  S  O  N  O");

                    Console.WriteLine("U  S  T  Q  N  M  O  R  T  E  V  P  B  L");
                    Console.WriteLine("M  O  N  S  T  R  O  U  P  B  S  K  V  W");
                    Console.WriteLine("C  O  P  E  Y  K  J  U  K  A  C  U  R  A");

                    Console.WriteLine("N  Ã  P  Q  B  V  D  E  U  S  C  P  A  S");
                    Console.WriteLine("S  A  L  V  A  Ç  Ã  O  B  E  Q  K  W  Z");
                    Console.WriteLine("Z  O  N  P  Q  R  E  D  E  N  Ç  Ã  O  S");

                    Console.WriteLine("");

                    Console.WriteLine("QUAL É A PALAVRA-CHAVE?");
                    KeyWord = Console.ReadLine();
                    upperKeyWord = KeyWord.ToUpper();

                    if (upperKeyWord == "TRATAMENTO" || upperKeyWord == "VIDA" || upperKeyWord == "TEMPO" || upperKeyWord == "DOENÇA"
                    || upperKeyWord == "MEDICAÇÃO" || upperKeyWord == "SONO" || upperKeyWord == "MORTE" || upperKeyWord == "MONSTRO"
                    || upperKeyWord == "DEUS" || upperKeyWord == "SALVAÇÃO" || upperKeyWord == "REDENÇÃO")
                    {

                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("RESPOSTA ERRADA!");
                        Console.WriteLine("");
                        Console.WriteLine("— NÃO! NÃO!");

                        Console.WriteLine("");

                        Console.WriteLine("QUANDO A PLATAFORMA MERGULHOU BRUNO COM AS ENGUIAS - ELE SENTIU UM FORMIGAMENTO INTENSO - COMO SE MIL AGULHAS AFIADAS PERFURASSEM SUA PELE.");
                        Console.WriteLine("");
                        Console.WriteLine("QUANDO A DESCARGA ELÉTRICA AVANÇOU PARA OS NERVOS - ENVOLVENDO CADA FIBRA MUSCULAR EM CONTRAÇÕES DESCONTROLADAS.");
                        Console.WriteLine("");
                        Console.WriteLine("FOI QUANDO UMA DOR EXCRUCIANTE SE ESPALHOU PELO SEU CORPO - O FAZENDO ARQUEAR AS COSTAS (INVOLUNTARIAMENTE)");

                        Console.WriteLine("");

                        Console.WriteLine("OS 5 SEGUNDOS PARECIAM UMA ETERNIDADE E CADA PULSO ELÉTRICO MARCAVA UM TORMENTO INSUPORTÁVEL.");
                        Console.WriteLine("");
                        Console.WriteLine("ENQUANTO A VISÃO DE BRUNO OSCILAVA ENTRE FLASHES DE LUZ E ESCURIDÃO - UM ZUMBIDO ELÉTRICO ECOAVA EM SEUS OUVIDOS.");
                        Console.WriteLine("");
                        Console.WriteLine("CADA MÚSCULO - CADA CÉLULA PARECIA ESTAR À BEIRA DO COLAPSO.");

                        Console.WriteLine("");

                        Console.WriteLine("A QUEIMAÇÃO INTENSA TOMOU CONTA DE BRUNO - COMO SE SEU CORPO ESTIVESSE IMERSO EM CHAMAS INVISÍVEIS.");
                        Console.WriteLine("");
                        Console.WriteLine("ELE GRITOU - PORÉM O SOM FOI INIBIDO PELA ÁGUA.");
                        Console.WriteLine("");
                        Console.WriteLine("APÓS OS 5 SEGUNDOS - A PLATAFORMA SUBIU (AUTOMÁTICA)");

                        Console.WriteLine("");

                        Console.WriteLine("ENQUANTO A DOR PERSISTIA E BRUNO (ERRATICAMENTE) TENTAVA RESPIRAR.");
                        Console.WriteLine("");


                        while (true)
                        {
                            Console.WriteLine("PRESSIONE ENTER PARA TENTAR NOVAMENTE - ACERTAR A PALAVRA-CHAVE:");
                            secondTry = Console.ReadLine();

                            if (secondTry == "") { Console.Clear(); break; }
                            else
                            {
                                Console.WriteLine(""); Console.WriteLine("ERRO!"); Console.WriteLine("");
                            }
                        }

                        

                        switch (secondTry)
                        {
                            case "":
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("LEMBRE-SE: A PARTIR DE AGORA - SE VOCÊ ERRAR O BRUNO MORRERÁ.");

                                Console.WriteLine("");
                                Console.WriteLine("CHARADA:");
                                Console.WriteLine("");
                                Console.WriteLine("NO CAMINHO DA EXISTÊNCIA, ATRAVESSO O VÉU SOMBRIO QUE DESVANECE DIANTE DA BUSCA INCANSÁVEL, ENTRELAÇANDO A SOLUÇÃO NOS MEANDROS TEMPORAIS.");
                                Console.WriteLine("");
                                Console.WriteLine("O QUE SOU EU?");
                                Console.WriteLine("");
                                Console.WriteLine("CAÇA-PALAVRAS:");
                                Console.WriteLine("");
                                Console.WriteLine("U  S  T  V  I  D  A  Q  R  U  V  P  W  Y");
                                Console.WriteLine("V  E  P  E  T  R  A  T  A  M  E  N  T  O");
                                Console.WriteLine("C  O  V  Q  T  U  P  S  N  T  E  M  P  O");

                                Console.WriteLine("D  O  E  N  Ç  A  T  U  P  S  W  Q  D  E");
                                Console.WriteLine("N  O  R  M  E  D  I  C  A  Ç  Ã  O  R  O");
                                Console.WriteLine("B  C  Q  V  T  J  K  G  L  N  S  O  N  O");

                                Console.WriteLine("U  S  T  Q  N  M  O  R  T  E  V  P  B  L");
                                Console.WriteLine("M  O  N  S  T  R  O  U  P  B  S  K  V  W");
                                Console.WriteLine("C  O  P  E  Y  K  J  U  K  A  C  U  R  A");

                                Console.WriteLine("N  Ã  P  Q  B  V  D  E  U  S  C  P  A  S");
                                Console.WriteLine("S  A  L  V  A  Ç  Ã  O  B  E  Q  K  W  Z");
                                Console.WriteLine("Z  O  N  P  Q  R  E  D  E  N  Ç  Ã  O  S");

                                Console.WriteLine("");

                                Console.WriteLine("QUAL É A PALAVRA-CHAVE?");
                                secondKeyWord = Console.ReadLine();
                                secKeyWord = secondKeyWord.ToUpper();

                                if (secKeyWord == "TRATAMENTO" || secKeyWord == "VIDA" || secKeyWord == "TEMPO" || secKeyWord == "DOENÇA"
                                || secKeyWord == "MEDICAÇÃO" || secKeyWord == "SONO" || secKeyWord == "MORTE" || secKeyWord == "MONSTRO"
                                || secKeyWord == "DEUS" || secKeyWord == "SALVAÇÃO" || secKeyWord == "REDENÇÃO")
                                {

                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("VOCÊ MATOU BRUNO - O MÉDICO QUE ENCONTRARIA A CURA DO CÂNCER EM 2048 - ATRAVÉS DE TERAPIA GENÉTICA.");
                                    Console.WriteLine("");
                                    Console.WriteLine("COMO VOCÊ SE SENTE CONSIGO MESMO(A)?");
                                    Console.WriteLine("");
                                    Console.WriteLine("DESEJA:");
                                    Console.WriteLine("1 - IR PARA O PRÓXIMO DESAFIO");
                                    Console.WriteLine("2 - REINICIAR");
                                    Console.WriteLine("");

                                    while (true)
                                    {
                                        Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE:");
                                        nextLevelB = Console.ReadLine();

                                        if (nextLevelB == "2") { StartLevel(); break; }
                                        else if (nextLevelB == "1")
                                        {
                                            break;

                                        }

                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ERRO! POR FAVOR, SÓ É PERMITIDO 1 OU 2.");
                                            Console.WriteLine("");
                                        }
                                    }

                                }

                                else if (secKeyWord == "CURA")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("PARABÉNS! VOCÊ SALVOU BRUNO - O MÉDICO QUE ENCONTRARÁ A CURA DO CÂNCER EM 2048 - ATRAVÉS DE TERAPIA GENÉTICA.");
                                    Console.WriteLine();
                                    Console.WriteLine("COMO VOCÊ SE SENTE CONSIGO MESMO(A)?");
                                    Console.WriteLine("");
                                    Console.WriteLine("DESEJA:");
                                    Console.WriteLine("1 - IR PARA O PRÓXIMO DESAFIO");
                                    Console.WriteLine("2 - REINICIAR");
                                    Console.WriteLine("");

                                    while (true)
                                    {
                                        Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE:");
                                        nextLevelB1 = Console.ReadLine();

                                        if (nextLevelB1 == "2") { StartLevel(); break; }
                                        else if (nextLevelB1 == "1")
                                        {
                                            break;

                                        }

                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ERRO! POR FAVOR, SÓ É PERMITIDO 1 OU 2.");
                                            Console.WriteLine("");
                                        }
                                    }




                                }







                                break;
                        }
                    }
                    else if (upperKeyWord == "CURA")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("PARABÉNS! VOCÊ SALVOU BRUNO - O MÉDICO QUE ENCONTRARÁ A CURA DO CÂNCER EM 2048 - ATRAVÉS DE TERAPIA GENÉTICA.");
                        Console.WriteLine();
                        Console.WriteLine("COMO VOCÊ SE SENTE CONSIGO MESMO(A)?");
                        Console.WriteLine("");
                        Console.WriteLine("DESEJA:");
                        Console.WriteLine("1 - IR PARA O PRÓXIMO DESAFIO");
                        Console.WriteLine("2 - REINICIAR");
                        Console.WriteLine("");

                        while (true)
                        {
                            Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE:");
                            nextLevelB2 = Console.ReadLine();

                            if (nextLevelB2 == "2") { StartLevel(); break; }
                            else if (nextLevelB2 == "1")
                            {
                                break;

                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("ERRO! POR FAVOR, SÓ É PERMITIDO 1 OU 2.");
                                Console.WriteLine("");
                            }
                        }


                    }
                    else { StartLevel(); }
                    break;
            }


        }


    }

    public class Omar : gamePlay
    {

       

        public string EnterDescription;
      
        public string KeyWord;
        public string secKeyWord;
        public string upperKeyWord;

        public string upperSelecionador;

        public string next; // É um Enter para prosseguir com a descrição do sofrimento de Omar.

        public string nextLevel;
        public string nextLevel2;


        public override void LevelAssigned()
        {

            if (upperSelecionador == "OMAR")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("PERSONAGEM SELECIONADO: OMAR");
                Console.WriteLine("");
                Console.WriteLine("BEM-VINDO AO DESAFIO: WATER!");

                Console.WriteLine("");

                Console.WriteLine("            ##########                            ");
                Console.WriteLine("            ########################              ");
                Console.WriteLine("                ######################            ");
                Console.WriteLine("              ##########################          ");
                Console.WriteLine("            ##############################        ");
                Console.WriteLine("            ##############################        ");
                Console.WriteLine("          ##################################      ");
                Console.WriteLine("          ##################################      ");
                Console.WriteLine("          ############      ####                  ");
                Console.WriteLine("          ########        ####                    ");
                Console.WriteLine("          ########                                ");
                Console.WriteLine("          ######                                  ");
                Console.WriteLine("          ######                                  ");
                Console.WriteLine("          ######                                  ");
                Console.WriteLine("          ######                                  ");
                Console.WriteLine("        ##########                                ");
                Console.WriteLine("      ######  ######                              ");
                Console.WriteLine("      ####        ##                              ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                  ");

                Console.WriteLine("");

                while (true)
                {
                    Console.WriteLine("PRESSIONE ENTER PARA INICIAR O CENÁRIO DO DESAFIO WATER:");
                    EnterLevelAssigned = Console.ReadLine();
                    if (EnterLevelAssigned != "") { LevelAssigned(); break; }
                    else { break; }

                }
            }

        }

        public override void ShowDescription()
        {

            switch (EnterLevelAssigned)
            {
                case "":
                    Console.Clear();

                    Console.WriteLine("");

                    Console.WriteLine("CENÁRIO:");
                    Console.WriteLine();
                    Console.WriteLine("OMAR - VOCÊ ESTÁ NUM LABIRINTO SUBAQUÁTICO - ENQUANTO A SALA (INÍCIO) SE ENCHE (RAPIDAMENTE) COM ÁGUA!");
                    Console.WriteLine();
                    Console.WriteLine("— QUE MERDA É ESSA!? ME TIRA DAQUI!");
                    Console.WriteLine();
                    Console.WriteLine("O PERCURSO TEM 60 METROS E DURARÁ (APROXIMADAMENTE) 4 MINUTOS. PORTANTO PARA AJUDÁ-LO, VOCÊ TERÁ UM CILINDRO DE AR COMPRIMIDO.");
                    Console.WriteLine();
                    Console.WriteLine("COM (APROXIMADAMENTE) 10 LITROS + GÁS DE CIANETO DE HIDROGÊNIO.");
                    Console.WriteLine();
                    Console.WriteLine("O AR COMPRIMIDO O FARÁ RESPIRAR.");
                    Console.WriteLine();
                    Console.WriteLine("CONTUDO - O GÁS FARÁ VOCÊ EXPERIMENTAR: DIFICULDADE RESPIRATÓRIA, CONFUSÃO MENTAL E (POSSÍVEIS) CONVULSÕES.");
                    Console.WriteLine();
                    Console.WriteLine("— QUÊ!? EU VOU MORRER, SEU FILHO DA PUTA!");
                    Console.WriteLine();
                    Console.WriteLine("PORTANTO - RESPIRE COM MODERAÇÃO.");

                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("PRESSIONE ENTER PARA LER O DESAFIO:");
                        EnterScenario = Console.ReadLine();
                        if (EnterScenario == "") { Console.Clear(); break; }
                        else
                        {
                            Console.Clear();
                            ShowDescription();
                        }
                    }

                    Console.WriteLine("");

                    Console.WriteLine("DESAFIO:");
                    Console.WriteLine();
                    Console.WriteLine("(O DESAFIO) PARA AJUDÁ-LO CONSISTE QUE - POR ATRAVÉS DE UMA CHARADA.");
                    Console.WriteLine();
                    Console.WriteLine("O JOGADOR ACHE A SAÍDA (COM O ANIMAL CERTO) DO LABIRINTO.");
                    Console.WriteLine();
                    Console.WriteLine("SÓ O JOGADOR PODE ABRIR AS GRADES AUTOMÁTICAS - POR CADA ENCRUZILHADA.");
                    Console.WriteLine();
                    Console.WriteLine("— POR QUE ESTÁ FAZENDO ISSO? SEU MERDA!");
                    Console.WriteLine();
                    Console.WriteLine("APÓS VOCÊ CRUZAR A GRADE - ELA SE FECHARÁ AUTOMATICAMENTE E VOCÊ NÃO PODERÁ MAIS RETORNAR.");
                    Console.WriteLine();
                    Console.WriteLine("CASO O JOGADOR ENCONTRE A SAÍDA CERTA - ELA LEVARÁ VOCÊ PARA A PISCINA DE UMA CASA.");
                    Console.WriteLine();
                    Console.WriteLine("E UM MORADOR O ENCONTRARÁ.");
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("PRESSIONE ENTER PARA LER A DESCRIÇÃO DO DESAFIO:");
                        EnterDescription = Console.ReadLine();
                        if (EnterDescription != "")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ERRO! TENTE NOVAMENTE."); Console.WriteLine("");
                        }
                        else { break; }
                    }

                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("DESCRIÇÃO:");
                    Console.WriteLine("");
                    Console.WriteLine("OS ANIMAIS (DAS SAÍDAS) SÃO:");
                    Console.WriteLine();
                    Console.WriteLine("…⁠ᘛ⁠⁐̤⁠ᕐ⁠ᐷ – CAMALEÃO (DE JACKSON)");
                    Console.WriteLine();


                    Console.WriteLine("( .. )");
                    Console.WriteLine(" (()) - POLVO (MÍMICO)");

                    Console.WriteLine();
                    Console.WriteLine(" _ \\/ _");
                    Console.WriteLine("/o \\{}/ o\\");
                    Console.WriteLine("\\   ()   /");
                    Console.WriteLine(" > /\\ <  – BORBOLETA (FOLHA INDIANA)");
                    Console.WriteLine(" (o/\\/\\o)");
                    Console.WriteLine("  )    (");

                    Console.WriteLine();
                    Console.WriteLine(" ||  ||");
                    Console.WriteLine("  \\()//");
                    Console.WriteLine("//(__)\\ - ARANHA (CARANGUEIJO AMARELA)");
                    Console.WriteLine("||    ||");

                    Console.WriteLine();
                    Console.WriteLine("NO MAPA:");
                    Console.WriteLine();
                    Console.WriteLine("AS # REPRESENTAM GRADES AUTOMÁTICAS NO QUAL SÓ O JOGADOR PODE ABRIR.");
                    Console.WriteLine();
                    Console.WriteLine("OS X REPRESENTAM QUE NÃO HÁ SAÍDA.");
                    Console.WriteLine();
                    Console.WriteLine("FORMAS PARA GUIÁ-LO:");
                    Console.WriteLine();
                    Console.WriteLine("FRENTE - F");
                    Console.WriteLine("DIREITA - D");
                    Console.WriteLine("ESQUERDA - E");
                    Console.WriteLine("BAIXO - B");
                    Console.WriteLine();
                    Console.WriteLine("POR FAVOR - USE SÓ AS LETRAS CORRESPONDENTES!");
                    Console.WriteLine("");
                    Console.WriteLine("O LABIRINTO SERÁ COMO EM PACMAN - QUANDO ESCOLHIDA A DIREÇÃO, OMAR SEGUIRÁ ATÉ O FINAL DELA.");


                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("PRESSIONE ENTER PARA INICIAR O DESAFIO:");
                        Start = Console.ReadLine();
                        if (Start != "")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ERRO! TENTE NOVAMENTE."); Console.WriteLine("");
                        }
                        else { break; }
                    }
                    break;


            }
        }

        public override void StartLevel()
        {
            switch (Start)
            {
                case "":
                    Console.Clear();
                    Console.WriteLine("");

                    Console.WriteLine("CHARADA:");
                    Console.WriteLine();
                    Console.WriteLine("VAGUEIO PELAS SOMBRAS DA INCERTEZA, ALTERANDO CORES COMO UM ARTISTA ABSTRATO NA TELA DA AMBIGUIDADE.");
                    Console.WriteLine();
                    Console.WriteLine("QUEM SOU EU, PERDIDO NA DANÇA ENIGMÁTICA DAS IDENTIDADES?");

                    Console.WriteLine("");
                    Console.WriteLine("MAPA DO LABIRINTO:");
                    Console.WriteLine("");


                    Console.WriteLine(" ___________________________________  ");
                    Console.WriteLine("|C ____ |   | __ A| ___ ___ | |   | |");
                    Console.WriteLine("|#|   |X|_| |__ |#|_| __|____ | | | |");
                    Console.WriteLine("| | | |_________|_  |______ |___|_| |");
                    Console.WriteLine("| |_|     ________  |____ |   | ____|");
                    Console.WriteLine("| ____| |____ | |______ | |_| |____ |");
                    Console.WriteLine("|___|_|____ | | | ___ | |________ | |");
                    Console.WriteLine("|    _______| |P|__ | |______ | | | |");
                    Console.WriteLine("| | | ________|#| __|____ | | | __| |");
                    Console.WriteLine("|_| |__ |   | __|__ | ____| | |_| __|");
                    Console.WriteLine("|   |___| | |____ | |__ |   |_# B __|");
                    Console.WriteLine("| |_______|_______|___|___|___|___|_|");


                    Console.WriteLine("");

                    Console.WriteLine("QUAL É A SEQUÊNCIA CORRETA PARA OMAR ENCONTRAR A SAÍDA?");
                    KeyWord = Console.ReadLine();
                    upperKeyWord = KeyWord.ToUpper();

                    if (upperKeyWord == "FDFDFEFEBEF" || upperKeyWord == "F,D,F,D,F,E,F,E,B,E,F" || upperKeyWord == "FDFDFEFDFEF" || upperKeyWord == "F,D,F,D,F,E,F,D,F,E,F"
                    || upperKeyWord == "FDFDFEFDBDBDBD" || upperKeyWord == "F,D,F,D,F,E,F,D,B,D,B,D,B,D")
                    {

                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("RESPOSTA ERRADA!");

                        Console.WriteLine("");

                        Console.WriteLine("QUANDO OMAR PERCEBE QUE ESTÁ NA SAÍDA ERRADA - JÁ É TARDE DEMAIS.");
                        Console.WriteLine();

                        Console.WriteLine("O GÁS O ENVOLVE E CADA RESPIRAÇÃO É UM SUPLÍCIO (COMO SE O AR SE ESCAPASSE CRUELMENTE)");
                        Console.WriteLine();

                        Console.WriteLine("SUA MENTE É ENVOLVIDA POR UMA NÉVOA CONFUSA E SEUS PENSAMENTOS SE FRAGMENTAM ENQUANTO O GÁS AGE NOS PROCESSOS COGNITIVOS");
                        Console.WriteLine();

                        Console.WriteLine("QUANDO A REALIDADE É SUBSTITUÍDA POR UMA DISTORCIDA - CONVULSÕES VIOLENTAS AGITAM SEU CORPO SUBMERSO.");
                        Console.WriteLine();

                        Console.WriteLine("OS MÚSCULOS SE CONTORCEM EM RESPOSTA AO ATAQUE DO GÁS AO SISTEMA NERVOSO.");
                        Console.WriteLine();

                        Console.WriteLine("ENQUANTO O TEMPO AVANÇA - O CORAÇÃO DE OMAR (OUTRORA PULSANTE E FORTE) É GRADUALMENTE ENFRAQUECIDO PELA AÇÃO DO GÁS NO SISTEMA CARDIOVASCULAR.");
                        Console.WriteLine();

                        Console.WriteLine("EM DETERMINADO MOMENTO - A SINFONIA IRREGULAR DOS BATIMENTOS CARDÍACOS DE OMAR CULMINAM NUM SILÊNCIO DEVASTADOR.");
                        Console.WriteLine();

                        while (true)
                        {
                            Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR:");
                            next = Console.ReadLine();

                            if (next == "")
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("VOCÊ MATOU OMAR - UM CIVIL QUE INICIARIA (NO DIA 25 DE DEZEMBRO DE 2025) UM MASSACRE (COM ARMA DE FOGO) EM TORONTO.");
                                Console.WriteLine();
                                Console.WriteLine("COMO VOCÊ SE SENTE CONSIGO MESMO(A)?");
                                Console.WriteLine("");

                                Console.WriteLine("DESEJA:");
                                Console.WriteLine("1 - IR PARA O PRÓXIMO DESAFIO");
                                Console.WriteLine("2 - REINICIAR");
                                Console.WriteLine("");

                                while (true)
                                {
                                    Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE:");
                                    nextLevel2 = Console.ReadLine();

                                    if (nextLevel2 == "2") { StartLevel(); break; }
                                    else if (nextLevel2 == "1")
                                    {
                                        break;

                                    }

                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("ERRO! POR FAVOR, SÓ É PERMITIDO 1 OU 2.");
                                        Console.WriteLine("");
                                    }
                                }

                                break;
                            }
                            else { Console.Clear(); }
                        }

                    } // Fechamento do If principal.

                    else if (upperKeyWord == "FDBDFDBDFEFDF" || upperKeyWord == "F,D,B,D,F,D,B,D,F,E,F,D,F")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("PARABÉNS! VOCÊ SALVOU OMAR - UM CIVIL QUE INICIARÁ (NO DIA 25 DE DEZEMBRO DE 2025) UM MASSACRE (COM ARMA DE FOGO) EM TORONTO.");
                        Console.WriteLine();
                        Console.WriteLine("COMO VOCÊ SE SENTE CONSIGO MESMO(A)?");
                        Console.WriteLine();
                        Console.WriteLine("DESEJA:");
                        Console.WriteLine("1 - IR PARA O PRÓXIMO DESAFIO");
                        Console.WriteLine("2 - REINICIAR");
                        Console.WriteLine("");
                        while (true)
                        {
                            Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE:");
                            nextLevel = Console.ReadLine();

                            if (nextLevel == "2") { StartLevel(); break; }
                            else if (nextLevel == "1")
                            {
                                break;

                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("ERRO! POR FAVOR, SÓ É PERMITIDO 1 OU 2.");
                                Console.WriteLine("");
                            }
                        }








                    }

                    else { StartLevel(); }

                    break;
            }





        }


    }



    class JogoProgram
    {
        static void Main(string[] args)
        {


            Home home01 = new Home();

            home01.Who();
            home01.Introduction();

            home01.Welcome();

            home01.Start();

            Bruno character01 = new Bruno();

            character01.upperSelecionador = home01.upperSelecionador;

            character01.LevelAssigned();
            character01.ShowDescription();
            character01.StartLevel();

            Omar character02 = new Omar();

            character02.upperSelecionador = home01.upperSelecionador;

            character02.LevelAssigned();
            character02.ShowDescription();
            character02.StartLevel();

            if (character01.nextLevelB == "1" || character01.nextLevelB1 == "1" || character01.nextLevelB2 == "1")
            {
                character02.upperSelecionador = "OMAR";
                character02.LevelAssigned();
                character02.ShowDescription();
                character02.StartLevel();
                
                if (character02.nextLevel == "1" || character02.nextLevel2 == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("POR ENQUANTO NÃO HÁ MAIS DESAFIO");
                }

            }

            else if (character02.nextLevel == "1" || character02.nextLevel2 == "1")
            {
                character01.upperSelecionador = "BRUNO";
                character01.LevelAssigned();
                character01.ShowDescription();
                character01.StartLevel();
            }



        }
    }

}