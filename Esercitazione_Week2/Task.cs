using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Week2
{
    //I tasks sono oggetti che possiedono:
    //• una descrizione
    //• una data di scadenza
    //• un livello di priorità (Alto, Medio, Basso)
    public class Task
    {
        public string Descrizione { get; set; }
        public DateTime DataScadenza { get; set; }
        public LivelloPriorità Importanza { get; set; }

        //COSTRUTTORE -> Costruire oggetti task.
        public Task()
        {

        }

    }
    public enum LivelloPriorità
    {
        Alto = 1,
        Medio = 2,
        Basso = 3
    }
}
