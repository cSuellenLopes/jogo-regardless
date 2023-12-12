# JOGO REGARDLESS

## SOBRE O JOGO:

Bem-vindo ao "REGARDLESS" - uma aventura interativa cheia de desafios, escolhas cruciais e desfechos surpreendentes. Neste jogo, você será confrontado com situações únicas enquanto navega por diferentes personagens e enfrenta desafios específicos para cada um deles.

### História:

O "REGARDLESS" leva você a um mundo repleto de mistérios e decisões difíceis. O destino de personagens como Bruno e Omar está em suas mãos, e cada escolha que você faz moldará a narrativa de maneiras inesperadas.


## LIGUAGEM DE PROGRAMAÇÃO UTILIZADA PARA SEU DESENVOLVIMENTO:
C Sharp

## SOBRE O CÓDIGO:

### Classe Abstrata: Inicio.

A classe Inicio é declarada como abstrata, o que significa que não pode ser instanciada diretamente. Ela serve como uma base para outras classes que devem implementar o método abstrato Start.


**Atributos:**

nome (string): Variável para armazenar o nome do usuário.

gameName (string): Variável que contém o nome do jogo ("REGARDLESS").

EnterIntroduction (string): Variável para armazenar a entrada do usuário na introdução do jogo.

**Métodos:**

**Start (abstract):** Método abstrato que deve ser implementado por classes derivadas. Serve como o ponto de partida para a página inicial do jogo.

**Who:** Método responsável por identificar o usuário. Solicita o nome do usuário e exibe uma representação visual.

**Introduction:** Método que exibe uma introdução gráfica e textual ao jogo. O usuário é incentivado a pressionar Enter para prosseguir.

**Welcome:** Método que exibe uma mensagem de boas-vindas ao usuário, incluindo o nome do jogo e o nome do usuário.


**Observações:**

O código contém gráficos ASCII artísticos que representam visualmente o nome do jogo e algumas imagens relacionadas ao tema.

Há um uso extenso de mensagens de console para interagir com o usuário.

O código utiliza um loop while (true) para garantir que certas partes se repitam até que as condições específicas sejam atendidas.


### Classe: Home (Herda de Inicio)
A classe Home herda da classe abstrata Inicio e implementa o método abstrato Start. Esta classe representa a página inicial do jogo.


**Atributos:**

Selecionador (string): Variável para armazenar o nome do personagem escolhido pelo usuário.

upperSelecionador (string): Variável para armazenar o nome do personagem em letras maiúsculas.

Voltar (string): Variável para armazenar a entrada do usuário sobre voltar à página inicial.

upperVoltar (string): Variável para armazenar a entrada do usuário em letras maiúsculas.

options (int): Variável para armazenar a opção escolhida pelo usuário no menu.

encerrarLoop (bool): Variável booleana que controla o loop principal do método abstrato Start.


**Métodos:**

Start (override): Método sobrescrito da classe base Inicio. Exibe o menu da página inicial, permite ao usuário fazer escolhas e responde de acordo com a opção escolhida.

**Herança:** A classe Home herda da classe abstrata Inicio, o que significa que ela deve implementar o método abstrato Start.

**Menu Inicial:** Exibe opções para o usuário escolher: Regras, Iniciar e Informações.

**Switch de Opções:** Um switch é usado para lidar com as opções escolhidas pelo usuário, fornecendo informações sobre regras, iniciando o jogo ou exibindo informações.

**Validação de Entrada:** Realiza a validação das entradas do usuário para garantir escolhas válidas.

**Repetição do Loop:** Utiliza um loop para permitir que o usuário volte à página inicial após visualizar regras ou informações.


**Observações:** 

O código inclui mensagens claras para orientar o usuário e informar sobre regras e personagens disponíveis.

Há uma validação de entrada para garantir que o usuário faça escolhas válidas.


## Classe Abstrata: gamePlay
A classe abstrata gamePlay fornece a estrutura básica para o desenvolvimento de diferentes níveis do jogo "REGARDLESS". Contém atributos essenciais e métodos abstratos que devem ser implementados por suas classes derivadas.


**Atributos:**

EnterLevelAssigned (string): Armazena a entrada do usuário para prosseguir para o nível atribuído.

EnterScenario (string): Armazena a entrada do usuário para prosseguir na leitura do cenário.

Start (string): Armazena a entrada do usuário para iniciar o nível.


**Métodos Abstratos:**

LevelAssigned(): Método abstrato que deve ser implementado pelas classes derivadas para definir a lógica específica do nível atribuído.

ShowDescription(): Método abstrato que deve ser implementado para exibir a descrição do cenário e desafio do nível.

StartLevel(): Método abstrato que deve ser implementado para iniciar a lógica do nível e interação com o usuário.


### Classe: Bruno (Herda de gamePlay)

A classe Bruno representa um dos níveis do jogo e herda da classe abstrata gamePlay. Contém atributos específicos para o nível "BRUNO" e implementa os métodos abstratos para personalizar a lógica do jogo.


**Atributos:**

KeyWord (string): Armazena a palavra-chave fornecida pelo usuário.

upperKeyWord (string): Armazena a versão em letras maiúsculas da palavra-chave.

secondKeyWord (string): Segunda tentativa de palavra-chave fornecida pelo usuário.

secKeyWord (string): Armazena a versão em letras maiúsculas da segunda palavra-chave.

upperSelecionador (string): Armazena o nome do personagem em letras maiúsculas.

secondTry (string): Entrada do usuário para uma segunda tentativa.

nextLevelB (string): Opção do usuário para avançar para o próximo desafio ou reiniciar após uma tentativa falha.

nextLevelB1 (string): Opção do usuário após salvar o personagem Bruno.

nextLevelB2 (string): Opção do usuário após salvar o personagem Bruno com a palavra-chave "CURA".


**Métodos:**

LevelAssigned(): Implementação do método abstrato LevelAssigned específico para o personagem Bruno. Exibe a introdução do desafio e inicia a primeira parte.

ShowDescription(): Implementação do método abstrato ShowDescription que apresenta o cenário e o desafio do nível.

StartLevel(): Implementação do método abstrato StartLevel que inicia a lógica específica do nível, incluindo a resolução do caça-palavras e suas consequências.

**Observações:**

Há interação significativa com o usuário por meio de mensagens de console.

A lógica do jogo envolve escolhas do usuário, validação de entrada e múltiplos desfechos com base nas decisões tomadas.


### Classe: Omar (Herda de gamePlay)
A classe Omar representa um dos níveis do jogo e herda da classe abstrata gamePlay. Ela contém atributos específicos para o nível "OMAR" e implementa os métodos abstratos para personalizar a lógica do jogo.


**Atributos:**

EnterDescription (string): Armazena a entrada do usuário para prosseguir com a descrição do sofrimento de Omar.

KeyWord (string): Armazena a palavra-chave fornecida pelo usuário.

secKeyWord (string): Armazena a segunda tentativa de palavra-chave fornecida pelo usuário.

upperKeyWord (string): Armazena a versão em letras maiúsculas da palavra-chave.

upperSelecionador (string): Armazena o nome do personagem em letras maiúsculas.

next (string): Representa um Enter para prosseguir com a descrição do sofrimento de Omar.

nextLevel (string): Opção do usuário para avançar para o próximo desafio ou reiniciar após uma tentativa falha.

nextLevel2 (string): Opção do usuário após salvar o personagem Omar.


**Métodos:**

LevelAssigned(): Implementação do método abstrato LevelAssigned específico para o personagem Omar. Exibe a introdução do desafio e inicia a primeira parte.

ShowDescription(): Implementação do método abstrato ShowDescription que apresenta o cenário e o desafio do nível.

StartLevel(): Implementação do método abstrato StartLevel que inicia a lógica específica do nível, incluindo a resolução do enigma e suas consequências.


**Observações:**

A lógica do jogo envolve uma charada e a escolha de sequências corretas para Omar encontrar a saída do labirinto subaquático.

Há múltiplos desfechos com base nas decisões do jogador, incluindo a possibilidade de salvar ou falhar no desafio.

O código implementa verificações de entrada para garantir a validade das escolhas do jogador.


## Classe: JogoProgram
A classe JogoProgram contém o método Main, que serve como ponto de entrada do programa. Este método instancia objetos das classes Home, Bruno, e Omar para representar diferentes partes do jogo e coordenar a execução geral.


**Métodos:**

Main (static void): Método principal que inicia a execução do jogo.


**Instanciação de objetos:**

Cria uma instância da classe Home chamada home01.

Chama os métodos Who, Introduction, Welcome, e Start da instância home01 para identificar o usuário, apresentar a introdução, dar as boas-vindas e iniciar a página inicial do jogo.


**Instanciação de objetos para os personagens Bruno e Omar:**

Cria uma instância da classe Bruno chamada character01.

Atribui o nome do personagem selecionado pelo usuário à propriedade upperSelecionador de character01.

Chama os métodos LevelAssigned, ShowDescription, e StartLevel de character01 para representar a execução do desafio do personagem Bruno.

Cria uma instância da classe Omar chamada character02.

Atribui o nome do personagem selecionado pelo usuário à propriedade upperSelecionador de character02.

Chama os métodos LevelAssigned, ShowDescription, e StartLevel de character02 para representar a execução do desafio do personagem Omar.


**Condições de progressão:**

Verifica se o jogador escolheu uma opção de progressão no desafio do personagem Bruno (character01).

Se sim, atribui "OMAR" a upperSelecionador de character02 e executa os desafios do personagem Omar.

Se o jogador escolher continuar, exibe uma mensagem informando que não há mais desafios.

Se não, verifica se o jogador escolheu uma opção de progressão no desafio do personagem Omar (character02).

Se sim, atribui "BRUNO" a upperSelecionador de character01 e executa os desafios do personagem Bruno.

Se o jogador escolher continuar, exibe uma mensagem informando que não há mais desafios.


**Observações:**

O código utiliza uma estrutura sequencial para a execução dos desafios dos personagens Bruno e Omar, verificando as opções de progressão do jogador.

A lógica condicional determina o fluxo do jogo com base nas escolhas feitas pelo jogador em cada desafio.

Não há um loop de repetição infinito, indicando que o jogo termina após a execução dos desafios propostos.



### Requisitos Funcionais

1 - Iniciar o Jogo

2 - Identificar o Usuário

3 - Apresentar Introdução

4	- Dar Boas-Vindas

5 - Exibir Página Inicial do Jogo

6 - Permitir Escolha de Personagem

7 - Exibir Descrição do Cenário	gamePlay

8 - Iniciar Lógica do Nível	gamePlay 

9 - Apresentar Desafios Específicos para Bruno

10 - Apresentar Desafios Específicos para Omar

11 - Realizar Validação de Entrada	Home, Bruno, Omar	Vários Métodos

12 - Permitir Progressão entre Desafios	JogoProgram	Condições de Progressão

13 - Apresentar Múltiplos Desfechos	Bruno e Omar

### Requisitos Não Funcionais:

1 - Interface Atrativa

2 - Compreensibilidade nas Interações

3 - Experiência Imediata

4 - Validação Robusta

5 - Boas Práticas de Programação

6 - Caminhos Divergentes

7 - Finalização Adequada

### Situação atual do jogo:

Em desenvolvimento.


### Referências e Créditos:

**Criadora:** Suellen Lopes

**Desenvolvedora:** Suellen Lopes

"Regardless" foi baseado no tipo de jogo do filme "Escolha ou Morra", do diretor Toby Meakins, e na ideia de desafios mortais e instigantes da franquia "Jogos Mortais".

**Artes em ASCII:**

1 - https://www.asciiart.eu/

2 - https://ascii-art.botecodigital.dev.br/

3 - https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
