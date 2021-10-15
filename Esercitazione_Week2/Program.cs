using System;

//RISPOSTA PARTE TEORICA:
//DOMANDA 1:
//Di fianco a ogni riga di codice, scrivere se si tratta di inizializzazione, dichiarazione, assegnazione
//a) string nome = “Mario”; DICHIARAZIONE E INIZIALIZZAZIONE
//b) int i; DICHIARAZIONE
//c) isInt = true; ASSEGNAZIONE
//DOMANDA 2
//Quale tipo può essere null?
//a) Valore
//b) Riferimento IL RIFERIMENTO PUò ESSERE NULL.
//DOMANDA 3
//Dato il seguente metodo
//public int FaiQualcosa(string[] ilMioArray)
//{
//}
//Qual’è il modo corretto per chiamare il metodo?
//a) int i = FaiQualcosa(arrayDiInteri);
//b) string parola = FaiQualcosa(arrayDiStringhe); 
//c) int i = FaiQualcosa(arrayDiStringhe); RISPOSTA C, RENDE UN INTERO E HA IN INGRESSO UN ARRAY DI STRINGHE
//d) string parola = FaiQualcosa(arrayDiInteri); 
//DOMANDA 4
//Quali dei seguenti codici è un esempio di ricorsione?
//a) public int IlMioMetodo(int i)        A o C (sono uguali)
//{
//    //Condizione di stop
//    Tot = tot * IlMioSecondoMetodo(i++);
//}
//b) public int IlMioMetodo(int tot)
//{
//    for (int i = 0; i < tot; i++)
//    {
//        tot = tot * i;
//    }
//}
//c) public int IlMioMetodo(int i)
//{
//    //Condizione di stop
//    Tot = tot * IlMioMetodo(i++);
//}

//****************************************************************************
//Creare una Console Application che permetta di gestire i tasks di un utente.
//I tasks sono oggetti che possiedono:
//• una descrizione
//• una data di scadenza
//• un livello di priorità (Alto, Medio, Basso)


//L’utente può:
//1.Visualizzare i tasks;
//2.Aggiungere un nuovo task;
//3.Eliminare un task esistente;
//4.Filtrare i tasks per importanza (ovvero per livello di priorità);
//Un nuovo task può essere aggiunto solo se la sua data di scadenza è posteriore alla data di inserimento del task.
//Al termine delle operazioni, i task dovranno essere salvati su un file txt.
namespace Esercitazione_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
         Menù.Start();
         }
    }
}