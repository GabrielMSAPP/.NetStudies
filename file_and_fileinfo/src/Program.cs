using static System.Console;

WriteLine("Informe o nome do arquivo: ");
var nome = ReadLine();
nome = VerificarNomeArquivo(nome);

var path = Path.Combine(Environment.CurrentDirectory,$"{nome}.txt" );

CriarArquivo(path);

WriteLine("Digite enter para finalizar.");
ReadLine();



// metodos
static string VerificarNomeArquivo(string nome)
{
    foreach ( var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");
    }
    catch 
    {
        WriteLine("O nome do arquivo é inválido. ");
    }
    
}