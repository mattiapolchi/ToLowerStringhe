string parolaMin = "", parolaMaiusc = "";

Console.WriteLine("Inserisci la parola in maiuscolo da convertire in minuscolo");
parolaMaiusc = Console.ReadLine();

for (int i = 0; i < parolaMaiusc.Length; i++)
{
    char c = parolaMaiusc[i];
    if (c >= 'A' && c <= 'Z')
    {
        parolaMin += (char)(c + 32);
    }
    else
    {
        parolaMin = parolaMin + c;
    }
}
Console.WriteLine("la parola in minuscolo è: " + parolaMin);