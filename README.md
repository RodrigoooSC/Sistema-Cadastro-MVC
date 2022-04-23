
# Sistema de Cadastro - MVC 🗃
Fala pessoal, tudo bem?🖖🏽 Esse projeto foi desenvolvido durante as aulas da faculdade no módulo - PROGRAMAÇÃO PARA WEB EM AMBIENTE PROPRIETÁRIO.

## # Sobre o projeto 📚

> O MVC é um padrão de arquitetura de software que visa realizar a separação dos elementos de um software
> em FrontEnd (visão do usuário – tela) e do BackEnd (processamento do núcleo ou motor da aplicação).
> Este modelo facilita tanto o desenvolvimento quanto a manutenção do software, pois separa a regra do
> negócio da interface com o usuário.

> O ASP.NET MVC é um framework para desenvolvimento de aplicações web no qual somos capazes de utilizar a linguagem de
> programação C#. A partir de seu uso é possível criar desde pequenos sites estáticos até grandes portais de e-commerce e
> outros projetos complexos.
        
Este projeto visa a criação de uma aplicação que receberá dados inseridos por um usuário diretamente no navegador
por meio de digitação em campos de um formulário, permitindo a inclusão, alteração, listagem e exclusão desses dados em um banco de dados.

Para o desenvolvimento do projeto foi utilizado o SDK do .NET (<a href="https://dotnet.microsoft.com/en-us/download/dotnet/5.0" target="_blank">5.0.404</a>),
o framework  web Bootstrap(<a href="https://getbootstrap.com/docs/4.3/getting-started/introduction/" 
target="_blank">v4.3.x</a>), para personalização da tabela foi utilizado o plug-in da biblioteca JavaScript jQuery <a href="https://datatables.net/" 
target="_blank">DataTables</a> e o banco de dados foi desenvolvido utilizando o <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads" 
target="_blank">SQL Server 2019</a>.

<div class="center">
  <img src="wwwroot/img//gif/Cadastro-MVC.gif">
</div>

## # Tecnologias utilizadas ⚙
<div>
 <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" />
 <img src="https://img.shields.io/badge/CSS-239120?&style=for-the-badge&logo=css3&logoColor=white" />
 <img src="https://img.shields.io/badge/JavaScript-323330?style=for-the-badge&logo=javascript&logoColor=F7DF1E" />
 <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
 <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
 <img src="https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white" />   
 <img src="https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
 <img src="https://img.shields.io/badge/Git-E34F26?style=for-the-badge&logo=git&logoColor=white" /> 
  <img src="https://img.shields.io/badge/Visual_Studio_Code-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white" />
</div>

## # Executando o projeto 🚀
- Clone o repositório:
```bash
https://github.com/RodrigoooSC/Sistema-Cadastro-MVC.git
```
- Crie o banco de dados, a tabela e os campos:
```sql
CREATE DATABASE cadastro_mvc;

USE cadastro_mvc;

CREATE TABLE tb_pessoa(

PessoaID int primary key not null identity(1,1),
PessoaNome varchar(50),
PessoaEmail varchar(30),
PessoaTelefone varchar(11)
);
```
- Caso seja necessário entre na pasta Sistema-Cadastro-MVC/Models/PessoaModel.cs e altera a constante de conexão do banco de dados:
```c#
readonly string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=cadastro_mvc;Integrated Security=True";
```
- Abra um terminal na pasta raiz e execute o projeto:
```bash
dotnet run
```
