string parolaMin = "", parolaMaiusc = ""; 

Console.WriteLine("Inserisci la parola in maiuscolo da convertire in minuscolo"); 
parolaMaiusc = Console.ReadLine(); 

for (int i = 0; i < parolaMaiusc.Length; i++) //ciclo che scorre la stringa carattere per carattere
{
    char c = parolaMaiusc[i]; //estrae il singolo carattere alla posizione attuale (i)

    if (c >= 'A' && c <= 'Z') //verifica se il carattere è una lettera maiuscola controllando la tabella ASCII
    {
        parolaMin += (char)(c + 32); //converte in minuscolo aggiungendo 32 (distanza ASCII) e lo aggiunge al risultato
    }
    else //se il carattere non è una lettera maiuscola (è un numero, simbolo, o già minuscolo)
    {
        parolaMin = parolaMin + c; //lo aggiunge alla stringa finale lasciandolo inalterato
    }
}

Console.WriteLine("la parola in minuscolo è: " + parolaMin); 