# APLICATIVO VOLTADO A CLÍNICA VETERINÁRIA
Projeto produzido pelo aluno João Victor dos Santos de Almeida na disciplina de Programação Orientada a Objetos no ano de 2019 - 1º Semestre do Curso de Ciência da Computação, da Universidade Tecnológica Federal do Paraná - UTFPR Medianeira e sob a orientação do professor Everton Coimbra de Araújo.

O aplicativo foi desenvolvido em C# utilizando o Visual Studio Community 2019 (v16.0.0) com o Framework ASP.NET Core 2.1.1, utilizando Razor Pages e padrão MVC. A persistência de dados foi feita com SQL Server, baseada no ORM (Mapeamento Objeto-Relacional) do Entity framework Core (v2.2.4)

# Instalação do Visual Studio Community
* Acesse https://visualstudio.microsoft.com/pt-br/vs/community/, selecione a plataforma utilizada (Windows ou MacOS) e clique em "Baixar o visual Studio"
* Instale normalmente, conforme as instruções que seguirem

# Instalação da Aplicação
* Vá para https://github.com/jvsa1102/ProjetoClinicaVeterinaria;
* Clique em "Clone or download" e "Download ZIP";
* Descompacte o arquivo baixado e abra a pasta;
* O arquivo principal é o "WebClinic.sln";

# Configuração e execução
* Com o Visual Studio Community e a aplicação baixados, Abra o arquivo "WebClinic.sln", que está na pasta "ProjetoClinicaVeterinaria"
* Basta clicar em "Iniciar" (ou F5 no teclado) para compilar e executar a aplicação.

# Conteúdo do repositório
O repositório contém as pastas:
* WebClinic: Pasta contendo todas subpastas referentes a solução;
  * Data: Onde localiza-se o contexto do banco de dados;
  * Migrations: Onde estão todas as migrações feitas;
  * Models: Onde todas as classes modelos de dados foram criados;
  * Pages: Possui todas as Views e seus respectivos Controllers para cada Model, com operações de CRUD e outras funcionalidades;
  * Properties: Configurações de json do projeto geradas via scaffolding;
  * wwwroot: Todas dependências de Bootstrap, CSS, Javascript e JSON necessárias para funcionamento do sistema;
  

# IMPORTANTE
* Não foram feitos testes da aplicação em um ambiente real, não havendo portando nenhuma garantia de sua estabilidade.

# Dúvidas ou Sugestões
* João Victor dos Santos de Almeida - joaovalmeida1102@gmail.com
