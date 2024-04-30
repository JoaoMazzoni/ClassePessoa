using ClassePessoa;

Pessoa p1 = new Pessoa();

Console.WriteLine();

p1.setNome(Console.ReadLine()); //Console.ReadLine vai na referência, ou seja, está lendo a string digitada pelo usuário.
Console.WriteLine(p1.getNome());

p1.setIdade(int.Parse(Console.ReadLine())); //Método retornando o valor para o objeto 
Console.WriteLine(p1.getIdade());

Pessoa p2 = new Pessoa("Felipe", 39); //Inserindo valor sem o "set"
Console.WriteLine(p2.getNome(), p2.getIdade()); //Acessando os atributos e pegando os valores que já foram inseridos neles.