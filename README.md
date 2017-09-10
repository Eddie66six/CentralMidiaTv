# CentralMidiaTv

Skip to content
This repository

    Pull requests
    Issues
    Marketplace
    Explore

    @Eddie66six

0
0

    0

Eddie66six/CentralMidiaTv
Code
Issues 0
Pull requests 0
Projects 0
Wiki
Settings
CentralMidiaTv/Ler.txt
ec0f1e5 2 minutes ago
guilherme rodrigues souza Add project files.
33 lines (31 sloc) 1.65 KB
Start:
--configuracao e teste
1-Restaurar os pacotes
	ctrl + shift + b
2-Gerar o banco
	acessar 2-servico -> web.config procurar por connectionString e alterar .\SQLEXPRESS pelo banco local do pc
	acessar a janela package manager console do visual studio (caso nao encontre a janela acesse
	->view->other windows->package manager console
	selecionar o projeto 2-servico\centralmidiatv.servico\centralmidiatv.servico e executar o comando Update-Database

--caminho para implementacao
1-Caso ja exista as interfaces 4-dominio
	implementar a assinatura do metodo na pasta repositorio caso precise acessar o banco e implementar o metodo em
	-> 2-aplicacao->data
	implementar a assinatura do metodo na pasta aplicacao caso precise e implementar o metodo em
	-> 2-aplicacao->aplicacao
	criar um web api controller class v2.1 em -> 2-servico->controller
2-Caso nao exista interfaces 4-dominio
	criar a imterface no dominio-> seguir o passo anterior
	acessar 3-aplicacao->data->ioc e adicionar as referenciar ex:
	registro.Register<IFuncionarioRepositorio, FuncionarioRepositorio>();
    registro.Register<IFuncionarioAplicacao, FuncionarioAplicacao>();
3-Caso crie uma entidade
	criar no dominio seguindo o padrao das pastas
	criar o map em -> 3-aplicacao->data->map
	adicionar a referecia da entidade em 3-aplicacao->data-> Contexto
	ex: public DbSet<Dominio.Funcionario.Entidade.Funcionario> Funcionario { get; set; }
	e adicionar o map no mesmo arquivo no metodo OnModelCreating
	ex: modelBuilder.Configurations.Add(new Map.FuncionarioMap());
	executar o comando Update-Database
	caso a alteracao no banco altere alguma coluna que ja contenha dados use
	executar o comando Update-Database -Force
	

    © 2017 GitHub, Inc.
    Terms
    Privacy
    Security
    Status
    Help

    Contact GitHub
    API
    Training
    Shop
    Blog
    About

