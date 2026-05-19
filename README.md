# NanoVR: Laboratório de Microeletrônica no Metaverso

**Nome Completo:** Isaac Martins de Oliveira Braga e Sousa

## Apresentando o Seu Projeto
O "NanoVR" é uma simulação de um laboratório de microeletrônica (Cleanroom). O ambiente virtual é composto por piso antiestático, bancadas de inspeção e iluminação intensa característica de instalações de fabricação de semicondutores. O ponto central do projeto é um holograma 3D ampliado de um transistor CMOS que permite a interação do usuário para visualização do seu chaveamento lógico e mudança de estado no canal de condução.

## Contexto e Objetivos
O projeto está inserido nos contextos de educação e simulação industrial dentro do Metaverso. O principal objetivo é criar uma ferramenta imersiva para auxiliar estudantes de engenharia a visualizarem e interagirem com modelos tridimensionais de layouts VLSI. Isso resolve o problema de engajamento e a dificuldade de abstração espacial ao estudar dispositivos em escala nanométrica durante as aulas teóricas tradicionais.

## Processo de Criação e Dificuldades
O desenvolvimento seguiu uma abordagem de arquitetura "Top-Down", iniciando pelo planejamento da cena e hierarquia de GameObjects (Management, Player, Environment e Interactables), seguido pela elaboração da lógica do script C# (SimulacaoCMOS.cs) focado no uso do XR Interaction Toolkit. 

**Dificuldades (Limitação de Hardware):**
O maior desafio enfrentado no processo foi a limitação de hardware. A falta de memória RAM suficiente na máquina atual inviabilizou a execução fluida do Unity Editor para a renderização, testes práticos em tempo real e o processo de build do projeto, especialmente ao rodar o sistema simultaneamente com outros servidores e compiladores de desenvolvimento. Como solução para essa barreira técnica, o projeto foi documentado e entregue com foco integral na arquitetura de software, estruturação conceitual da cena e na lógica de programação da interação.