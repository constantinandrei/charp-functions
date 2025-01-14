﻿//// See https://aka.ms/new-console-template for more information
//using System;


////In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
////Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:


////void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
////Potete prendere quella fatta in classe questa mattina

//void StampaArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i]);
//        if (i < array.Length - 1)
//            Console.Write(" - ");
        
//    }

//    Console.WriteLine();
//}

////int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

//int Quadrato(int numero)
//{
//    return numero * numero;
//}

////int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
////Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] arrayToSquare = new int[array.Length];
//    for (int i = 0; i < array.Length; i++)
//        arrayToSquare[i] = Quadrato(array[i]);
//    return arrayToSquare;
//}

////int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

//int sommaElementiArray(int[] array)
//{
//    int somma = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        somma += array[i];
//    }

//    return somma;
//}

////Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:

//int[] givenArray = { 2, 6, 7, 5, 3, 9 };

////Stampare l’array di numeri fornito a video
//Console.WriteLine("Stampa array di numeri");
//StampaArray(givenArray);

////Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
////(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Console.WriteLine("Stampa array di numeri al quadrato");
//StampaArray(ElevaArrayAlQuadrato(givenArray));
//Console.WriteLine("Stampa array di numeri");
//StampaArray(givenArray);

////Stampare la somma di tutti i numeri

//Console.WriteLine("Somma numeri: ");
//Console.WriteLine(sommaElementiArray(givenArray));
////Stampare la somma di tutti i numeri elevati al quadrati

//Console.WriteLine("Somma numeri elevati al quadrato: ");
//Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(givenArray)));

////BONUS: Convertire le funzioni appena dichiarate in funzioni generiche,
////ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
////ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
////A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire,
////e dopo di che questi vengono inseriti a mano dall’utente esternamente.
////Rieseguire il programma con l’input preso esternamente dall’utente.
//Console.WriteLine();
//Console.WriteLine();


//Console.WriteLine("Quanti numeri deve contenere l'array?");
//int arrayLength = Convert.ToInt32(Console.ReadLine());

//int[] userArray = new int[arrayLength];

//for (int i = 0; i < userArray.Length; i++)
//{
//    Console.WriteLine($"Inserire il numero {i + 1} di {arrayLength}");
//    userArray[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine();
//Console.WriteLine("Stampa array di numeri");
//StampaArray(userArray);
//Console.WriteLine("Stampa array di numeri al quadrato");
//StampaArray(ElevaArrayAlQuadrato(userArray));
//Console.WriteLine("Somma numeri: ");
//Console.WriteLine(sommaElementiArray(userArray));
//Console.WriteLine("Somma numeri elevati al quadrato: ");
//Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(userArray)));


// Bonus 

//// Fattoriale di un numero

//// Iterativo

//int Fattoriale(int numero)
//{
//    if (numero < 0)
//        return 0;
//    int result = 1;
//    for (int i = 1; i <= numero; i++)
//    {
//        result *= i;
//    }
//    return result;
//}


//Console.WriteLine("fattoriale con metodo interativo");
//Console.WriteLine(Fattoriale(3));
//Console.WriteLine();

//// Ricorsivo

//Console.WriteLine("fattoriale con metodo ricorsivo");

//int FattorialeRicorsivo(int numero)
//{
//    if (numero == 0)
//    {
//        return 1;
//    }

//    return numero * FattorialeRicorsivo(numero - 1);
//}


//Console.WriteLine(FattorialeRicorsivo(4));

//Console.WriteLine();
////Seguenza di Fibonacci

//// Interativo

//int Fibonacci(int numero)
//{
//    if (numero == 0)
//        return numero;
//    int fibonacciFirst = 0;
//    int fibonacciSecond = 1;
//    for (int i = 0; i < numero - 1; i++)
//    {
//        int temporalStore = fibonacciSecond;
//        fibonacciSecond = fibonacciFirst + fibonacciSecond;
//        fibonacciFirst = temporalStore;
//    }

//    return fibonacciSecond;
//}

//Console.WriteLine("Fibonacci iterativo");
//Console.WriteLine(Fibonacci(10));

//Console.WriteLine();

// Cifrario di Cesare

string Crypting(string phrase, int key)
{
    // declare the alphabet
    string alphabeth = "abcdefghijklmnopkrstuvwxyz";

    // declare the variable used to store the final cripted message
    string cripted = "";

    // loop throught the messahe
    for (int i = 0; i < phrase.Length; i++)
    {

        // the space will not be considered
        if (phrase[i].Equals(" "))
            continue;
        else
        {
            // find the position of the char in the alphabet
            int charIndex = alphabeth.IndexOf(phrase[i]);

            // replace in the new message with the crypted position
            // using modulo of the exact length of the alphabet to start from zero if the char is in the final positions
            cripted += alphabeth[(charIndex + key) % alphabeth.Length];

        }
    }

    return cripted;
}

string Decrypting(string phrase, int key)
{
    // declare the alphabet
    string alphabeth = "abcdefghijklmnopkrstuvwxyz";

    // declare the variable used to store the final cripted message
    string decripted = "";

    // loop throught the messahe
    for (int i = 0; i < phrase.Length; i++)
    {

        // the space will not be considered
        if (phrase[i].Equals(" "))
            continue;
        else
        {
            // find the position of the char in the alphabet
            int charIndex = alphabeth.IndexOf(phrase[i]);
            // replace in the new message with the crypted position
            int newPosition = charIndex - key;
            // if negative position of new charIndex then sutract from the alphabeth length to get the right value
            if (newPosition < 0)
                newPosition = alphabeth.Length + newPosition;
            decripted += alphabeth[newPosition];

        }
    }

    return decripted;
}

// ask to user if decript or encript

Console.WriteLine("Per criptare una frase inserire la lettera c, per decriptare inserire la lettera d (c / d)");
string userChoise = Console.ReadLine();
// ask the message
Console.WriteLine("Inserire il messaggio");
string message = Console.ReadLine();

Console.WriteLine("Inserire la chiave");
int key = Convert.ToInt32(Console.ReadLine());
Console.Write("Il messaggio finale è: ");
if (userChoise.Equals("c"))
    Console.WriteLine(Crypting(message, key));
else if (userChoise.Equals("d"))
    Console.WriteLine(Decrypting(message, key));