using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Week2
{
    public static class GestioneAgenda
    {
        public static List<Task> tasks = new List<Task>();

        public static void VisualizzaTask()
        {
            StampaTaskDiUnaLista(tasks);
        }
        public static void StampaTaskDiUnaLista(List<Task> listaTasks)
        {
            //controllo se la lista generica dei task è piena (all'inizio sarà vuota)
            if (listaTasks.Count == 0)
            {
                Console.WriteLine("Lista Vuota");
            }
            {
                Console.WriteLine("Descrizione\t\tDataScadenza\t\tLivelloPriorità\t\t");
                foreach (var item in listaTasks) //(cerco TASK tasks in listaTasks)
                {
                    Console.WriteLine($"{item.Descrizione}\t\t{item.DataScadenza}\t\t{item.Importanza}\t\t");
                }
            }
        }

        public static void CaricaDatiProva()
        {
            Task primoTask = new Task()
            {
                Descrizione = "Fare spesa",
                DataScadenza = new DateTime(2021, 10, 22),
                Importanza = (LivelloPriorità)1,

            };

            tasks.Add(primoTask);
            //ApriFile(); TODO: da concludere e sistemare.

        }

        public static void AggiungiTask()
        //Un nuovo task può essere aggiunto solo se la sua data di scadenza è posteriore alla data di inserimento del task.
        {
            Task taskNew = new Task();

            taskNew.DataScadenza = InserisciDataScadenza();

            // PARTE OPZIONALE : CONTROLLO SU DESCRIZIONE
            //bool choice = true;
            //do
            //{
            //    Console.WriteLine("Inserisci descrizione del task: ");
            //    string descrizione = Console.ReadLine();
            //    foreach (var item in tasks) //(cerco TASK tasks in listaTasks)
            //    {
            //        if (item.Descrizione != descrizione)
            //        {
            //            taskNew.Descrizione = descrizione;
            //            choice = false;
            //        }
            //    }
            //} while (choice);


            Console.WriteLine("Inserire Descrizione task: ");
            taskNew.Descrizione = Console.ReadLine();
                      

            taskNew.Importanza = InserireImportanza();
            tasks.Add(taskNew);
            Console.WriteLine("Nuovo Task aggiunto correttamente");
            VisualizzaTask();
        }
        public static void FiltraTask()
        {
            LivelloPriorità priorità = InserireImportanza();
            List<Task> tasksFiltrati = new List<Task>();
            foreach (var item in tasks)
            {
                if (item.Importanza == priorità)
                {
                    tasksFiltrati.Add(item);
                }

            }
            StampaTaskDiUnaLista(tasksFiltrati);


        }
        public static void EliminaTask()
        {
            //posso decidere di eliminare un task secondo la data di scadenza (ad esempio elimino i task del xxxx,xx,xx delle ore xx:xx)
            //creo una funzione di CercaTask
            DateTime dataNew;
            Console.WriteLine("I tasks presenti nell'Agenda sono: ");
            VisualizzaTask();
            do
            {
                Console.WriteLine("Inserire la Data di Scadenza e Ora del task che si intende eliminare: ");
            } while (!(DateTime.TryParse(Console.ReadLine(), out dataNew)));

            Task taskTrovato = CercaTask(dataNew);
            if (taskTrovato == null)
            {
                Console.WriteLine("Task non trovato");
            }
            else
            {
                tasks.Remove(taskTrovato);
                Console.WriteLine("Task eliminato");

            }


        }
        private static DateTime InserisciDataScadenza()
        {
            DateTime data;

            do
            {
                Console.WriteLine("Inserisci Data di Scadenza del task: ");
            } while (!(DateTime.TryParse(Console.ReadLine(), out data) && data >= DateTime.Now));
            return data;   //NELLA CONSOLE INSERISCI: 30/10/2021 09:20

        }
        private static LivelloPriorità InserireImportanza()
        {
            Console.WriteLine("Inserisci Livello di Priorità del task");
            Console.WriteLine($"{(int)LivelloPriorità.Alto} per il livello di priorità {LivelloPriorità.Alto}");
            Console.WriteLine($"{(int)LivelloPriorità.Medio} per il livello di priorità {LivelloPriorità.Medio}");
            Console.WriteLine($"{(int)LivelloPriorità.Basso} per il livello di priorità {LivelloPriorità.Basso}");
            int importanza;
            do
            {
                Console.WriteLine("Fai la tua scelta: ");
            } while (!(int.TryParse(Console.ReadLine(), out importanza) && importanza >= 1 && importanza <= 3));

            return (LivelloPriorità)importanza;  //se ho scelto 1 mi rende ALTO che è associato all'1.
        }
        public static Task CercaTask(DateTime data)
        {
            foreach (var item in tasks)
            {
                if (item.DataScadenza == data)
                {
                    return item;
                }
            }
            return null;




        }
        public static void MemorizzaTasks()
        {
            string path = @"C:\Users\Alessia\Desktop\ESERCITAZIONE WEEK2\Esercitazione_Week2\Esercitazione_Week2\FileTasks.txt";
            using (StreamWriter sw1 = new StreamWriter(path, true))
                foreach (var item in tasks)
                {
                    sw1.WriteLine($"Descrizione: {item.Descrizione}\t\tData Scadenza: {item.DataScadenza}\t\tLivello di Priorità: {item.Importanza}\t\t");
                }

        }

        //public static void ApriFile()
        //{
        //    string path = @"C:\Users\Alessia\Desktop\ESERCITAZIONE WEEK2\Esercitazione_Week2\Esercitazione_Week2\FileTasks.txt";

        //    using (StreamReader sr1 = new StreamReader(path))
        //    {
        //        string contenutoFile = sr1.ReadToEnd();
        //        var array = contenutoFile.Split("\t\t");
        //        LivelloPriorità level = (LivelloPriorità)Enum.Parse(typeof(LivelloPriorità), "Alto");

        //    }
        //}




    }

    }

           
    

