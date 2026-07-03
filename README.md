# Atividades de Programação em C#

Coleção de exercícios práticos desenvolvidos em C# (.NET), cobrindo conceitos fundamentais de lógica de programação, estruturas condicionais, laços de repetição, funções e manipulação de dados.

O projeto conta com um menu principal (`Program.cs`) que permite escolher e executar cada atividade individualmente.

## 📋 Índice de Atividades

| # | Atividade | Conceitos Abordados |
|---|-----------|----------------------|
| 1 | [Verificador de Número Positivo, Negativo ou Zero](#1-verificador-de-número-positivo-negativo-ou-zero) | Estruturas condicionais (`if`/`else if`/`else`) |
| 2 | [Calculadora de Média com Aprovação](#2-calculadora-de-média-com-aprovação) | Operações aritméticas, condicionais |
| 3 | [Tabuada com Laço de Repetição](#3-tabuada-com-laço-de-repetição) | Laço `for` |
| 4 | [Contador de Números Pares e Ímpares](#4-contador-de-números-pares-e-ímpares) | Laço `for`, operador módulo |
| 5 | [Calculadora de Fatorial com Validação](#5-calculadora-de-fatorial-com-validação) | Laço `for`, validação de entrada |
| 6 | [Sequência de Fibonacci](#6-sequência-de-fibonacci) | Laço `for`, variáveis acumuladoras |
| 7 | [Sistema de Login com Tentativas](#7-sistema-de-login-com-tentativas) | Validação de credenciais, `Thread.Sleep` |
| 8 | [Calculadora de Potência Sem Operador Nativo](#8-calculadora-de-potência-sem-operador-nativo) | Funções (métodos), laços |
| 9 | [Validador de Número Primo](#9-validador-de-número-primo) | Laço `for`, `Math.Sqrt` |
| 10 | [Menu de Operações com Laço Repetitivo](#10-menu-de-operações-com-laço-repetitivo) | Laço `do-while`, `switch` |
| 11 | [Conversor de Temperatura Completo](#11-conversor-de-temperatura-completo) | `switch`, fórmulas matemáticas |

## 🗂️ Estrutura do Projeto

```
📁 Projeto
├── Program.cs         # Menu principal e ponto de entrada
├── Atividade_1.cs      # Verificador de número
├── Atividade_2.cs      # Calculadora de média
├── Atividade_3.cs       # Tabuada
├── Atividade_4.cs       # Contador pares/ímpares
├── Atividade_5.cs       # Calculadora de fatorial
├── Atividade_6.cs       # Sequência de Fibonacci
├── Atividade_7.cs       # Sistema de login
├── Atividade_8.cs       # Calculadora de potência
├── Atividade_9.cs       # Validador de primo
├── Atividade_10.cs      # Menu de operações
└── Atividade_11.cs      # Conversor de temperatura
```

Todas as classes de atividades pertencem ao namespace `atividades` e expõem um método estático público, chamado a partir do `switch` em `Program.cs`.

## ▶️ Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone o repositório e navegue até a pasta do projeto.
3. Execute o comando:
   ```bash
   dotnet run
   ```
4. No menu exibido, digite o número da atividade desejada (1 a 11) e siga as instruções no console.

## 📖 Descrição das Atividades

### 1. Verificador de Número Positivo, Negativo ou Zero
Lê um número inteiro digitado pelo usuário e informa se ele é positivo, negativo ou igual a zero.

### 2. Calculadora de Média com Aprovação
Solicita três notas, calcula a média aritmética e informa se o aluno está aprovado (média ≥ 7) ou reprovado.

### 3. Tabuada com Laço de Repetição
Solicita um número e exibe sua tabuada de multiplicação de 1 a 10 usando um laço `for`.

### 4. Contador de Números Pares e Ímpares
Solicita uma quantidade de números a serem digitados e conta quantos são pares e quantos são ímpares.

### 5. Calculadora de Fatorial com Validação
Calcula o fatorial de um número inteiro não negativo, validando a entrada antes do cálculo.

### 6. Sequência de Fibonacci
Gera e exibe os N primeiros termos da sequência de Fibonacci, sendo N informado pelo usuário.

### 7. Sistema de Login com Tentativas
Simula um processo de autenticação, comparando usuário e senha digitados com credenciais fixas, incluindo um pequeno atraso para simular validação.

### 8. Calculadora de Potência Sem Operador Nativo
Calcula a potência de um número (base elevada a um expoente) sem usar o operador `Math.Pow` ou similar, implementando a lógica manualmente via laço `for`, incluindo suporte a expoentes negativos.

### 9. Validador de Número Primo
Verifica se um número inteiro é primo, testando divisores até a raiz quadrada do número para otimizar o processo.

### 10. Menu de Operações com Laço Repetitivo
Exibe um menu interativo (soma, subtração, multiplicação e divisão) que se repete até o usuário optar por sair, tratando também o caso de divisão por zero.

### 11. Conversor de Temperatura Completo
Converte temperaturas entre Celsius, Fahrenheit e Kelvin, oferecendo as seis combinações possíveis de conversão.

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET**

## ✍️ Autor

Desenvolvido por Vinícius Costa como exercício de fixação de lógica de programação em C#.
