string parolaMin = "", parolaMaiusc = "";
string s, sFinale = "";
char c1, c2;

Console.WriteLine("Inserisci la parola in maiuscolo da convertire in minuscolo");
parolaMaiusc = Console.ReadLine();
Console.WriteLine("inserisci la striga iniziale"); // chiede la stringa iniziale a cui sostutuire il carattere
s = Console.ReadLine();

for (int i = 0; i < parolaMaiusc.Length; i++) //ciclo che scorre la stringa carattere per carattere
{
    char c = parolaMaiusc[i]; //estrae il singolo carattere alla posizione attuale (i)
    Console.WriteLine("inserisci il carattere da sostituire"); // chiede il carattere da sostituire
    c1 = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("inserisci il nuovo carattere"); // chiede il carattere da immettere
    c2 = Convert.ToChar(Console.ReadLine());

    if (c >= 'A' && c <= 'Z') //verifica se il carattere è una lettera maiuscola controllando la tabella ASCII
        for (int i = 0; i < s.Length; i++) // scorre tutte i caratteri della stringhe principale
        {
            if (s[i] == c1) // controlla se il carattere attuale nella posizione 'i' corrisponde a quello da sostituire
            {
                parolaMin += (char)(c + 32); //converte in minuscolo aggiungendo 32 (distanza ASCII) e lo aggiunge al risultato
                sFinale = sFinale + c2; // se corrisponde aggiunge il nuovo carattere alla stringa finale
            }
            else //se il carattere non è una lettera maiuscola (è un numero, simbolo, o già minuscolo)
    else
                    {
                        parolaMin = parolaMin + c; //lo aggiunge alla stringa finale lasciandolo inalterato
                        sFinale = sFinale + s[i]; // altrimenti mantiene il carattere originale e lo aggiunge alla stringa finale
                    }
        }

    Console.WriteLine("la parola in minuscolo è: " + parolaMin);
    Console.WriteLine("la stringa finale modificata è: " + sFinale); // stampa la stringa finale aggiornata