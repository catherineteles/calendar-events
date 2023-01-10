# Projeto Calendário de eventos

Nesse projeto foi implementado um sistema que usa os tipos avançados do C# para construir um calendário de eventos.
Com este projeto, foi importante manipular tipos avançados do C# em um contexto real de datas, muito comum no dia a dia de uma pessoa desenvolvedora.


# Orientações

<details>
  <summary><strong>‼️ Para rodar o projeto</strong></summary><br />

  1. Clone o repositório.

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-calendar-events.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-calendar-events`

  2. Instale as dependências.
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Inicie o projeto `dotnet run`.

  
</details>


<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do projeto `src/<project>` ou de testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contenha `TestMethod1`.

  