/*
Exercicio: Crie um cadastro de uma biblioteca.
Leia os seguintes dados:
Título
Subtitulo
Autor
Editora
Número de páginas
Data de publicação
Idioma
Após receber os dados, limpe o console e exiba os dados na tela.
*/

Console.WriteLine("Bem vindo ao sistema de cadastro");
Console.WriteLine("Informe o titulo:");
string titulo = Console.ReadLine();
Console.WriteLine("Informe o subtitulo:");
string subtitulo = Console.ReadLine();
Console.WriteLine("Informe o autor:");
string autor = Console.ReadLine();
Console.WriteLine("Informe a editora:");
string editora = Console.ReadLine();
Console.WriteLine("Informe o total de paginas:");
int paginas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a data de publicação:");
string data = Console.ReadLine();
Console.WriteLine("Informe o idioma:");
string idioma = Console.ReadLine();



Console.WriteLine($"Titulo: {titulo}\nSubtitulo: {subtitulo}\nAutor: {autor}\nEditora: {editora}\nTotal de Paginas: {paginas}\nData de Publicação:{data}\nIdioma: {idioma}");

Console.Clear();