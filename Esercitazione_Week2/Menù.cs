using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Week2
{
    //L’utente può:
    //1.Visualizzare i tasks;
    //2.Aggiungere un nuovo task;
    //3.Eliminare un task esistente;
    //4.Filtrare i tasks per importanza (ovvero per livello di priorità);
    //Un nuovo task può essere aggiunto solo se la sua data di scadenza è posteriore alla data di inserimento del task.
    //Al termine delle operazioni, i task dovranno essere salvati su un file txt.
    public static class Menù
    {
        public static void Start()
            
        {
         
            Console.WriteLine("Benvenuto nella tua area di Gestione Agenda!\n");
            GestioneAgenda.CaricaDatiProva();
            //OPZIONALE: Lettura da File, da sostituire a CaricaDatiProva.
            //lettura e conversione in un enum "TipoEnum"
            //(TipoEnum)Enum.Parse(typeof(TipoEnum), "stringa da convertire");
           

            bool continua = true;
            do
            {
                Console.WriteLine("\n------Menù-----\n");
                Console.WriteLine("Premi 1 per visualizzare i tasks");
                Console.WriteLine("Premi 2 per aggiungere un task");
                Console.WriteLine("Premi 3 per eliminare un task esistente");
                Console.WriteLine("Premi 4 per filtrare i tasks per importanza");
                Console.WriteLine("Premi 0 per uscire");
                int choice;
                do
                {
                    Console.WriteLine("Fai la tua scelta tra le possibili opzioni");
                } while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 4));
                switch (choice)
                {
                    case 1: 
                        GestioneAgenda.VisualizzaTask();
                     break;
                    case 2:
                        GestioneAgenda.AggiungiTask();
                        break;
                    case 3:
                        GestioneAgenda.EliminaTask();
                        break;
                    case 4:
                        GestioneAgenda.FiltraTask();
                        break;
                   case 0:
                        Console.WriteLine("Arrivederci");                        
                        GestioneAgenda.MemorizzaTasks();
                        continua = false;
                        break;
                }
                               
            } while (continua); //(oppure continua==true)


            //lettura e conversione in un enum "TipoEnum"
            //(TipoEnum)Enum.Parse(typeof(TipoEnum), "stringa da convertire");
        }
    }
}
