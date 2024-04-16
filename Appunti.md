# Definizioni
### Diagramma UML:
 Universal Modeling Language
### Diagramma ER:
 Entity Relationship
### SqlDataReader 
fa parte di adonet

### stored procedure
Un metodo che permette di effettuare operazioni tramite parametri e permette il QL e il DML e le temporary table
###  ORM:
 Object Relational Mapping, serve per effettuare una corrispondeza diretta con quelli che sono gli oggeti presenti sul database e le classi.
 ### foreign key
 indica un vincolo di integrità referenziale 
### EF:
 Entity Framework
### Contesto:
 funzionalita di EF che permette di usare LINQ
### DTO:
 Data Transfer Object, è un pattern per il trasferimento dati
### Hash table:
 ogni singolo elemento ha un identificativo univoco che lo caratterizza (array associativo). Una volta inserito il valore non può più essere modificato va eliminato e reinserito.L'hash table non ha il controllo sul tipo, posso inserire come tipo o come chiave qualsiasi tipo di dato (int, float, double, string)
### Dictionary:
 è come l'hash table ma tipizzato, va specificato sia il tipo di chiave che il tipo di valore, quindi se il tipo di dato specificato è un tipo string il valore deve essere per forza una stringa altrimenti mi da errore. Nel voler scorrere tutta la "lista" contenente chiave/valore si usa DisctionaryEntry ma è di tipo generico. Se so che tipo di dato inserisco devo usare il comando KeyValuePair specificando il valore e dandomi quindi la possibilità di scorrere tutto.
## Sia le Hash table che i Dictionary
 _sono entrambi usualmente utilizzati come contenitori di impostazioni_

## DBContext:
  Effettua la connessione con il database.E' una connessione diretta con i nostri model e il DB. E' quell'insieme di funzionalità che ci permette di rispettare tutti i vincoli tipici della tabella del nostro DBMS e di tutte le possibili relazioni e ci permetterà tramite la sintassi LINQ di recuperare le informazioni e riversarlo.
## Scaffold
 sarebbero i contenitori

# Entity Framework
## Passaggi
- sqlDataClient
- entityframework core
- entityframeworktools
- entityframeworkcoresqlserver
- passare il comando, nella console, su strumenti gestione Nuget la seguente stringa, andando a cambiare se necessario il nome del server e il DB. Scaffold-DbContext "Server=ACADEMY2024-10\SQLEXPRESS;Database=acc_lez07_otm_carta;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

### ICollection: 
è una interfaccia che si specializza quando la si utilizza. 

### Incapsulamento:
 la capacità di una classe di nascondere le proprietà,parzialmente o totalmente, senza farle vedere all'esterno se non tramite dei metodi.

### Singleton:
 è un processo attraverso il quale creo una istanza di un oggetto e non può essere re-istanziato.

### Static: 
è un attributo di classe, prima dell'esecuzione del programma si caricano tutti gli attributi static e si allocheranno alla memoria.

### Polimorfismo:
 si può effettuare solo in una situazione di ereditarietà, e si può avere in 3 situazioni, in caso di interfaccia, in caso di classe astratta o di classe non astratta. Risolve il problema principale dei contenitori omogenei, rendendo quindi possibile la non omogeneita. E' la capacità di una variabile di prendere il tipo del figlio.

 ### Classe Object:
 E la classe padre di tutte, quella dal quale ereditano tutti gli "Oggetti".

 # WPF: Windows Presentetion Foundation.
 E' un set di funzionalità, che serve principalmente per App standalone.E' una libreria di classi del Framework .NET proprietarie Microsoft per lo sviluppo dell'interfaccia grafica delle applicazioni in ambienti Windows.
### WEBServer:
tramite un browser ci permette di analizzare/interagire con una interfaccia.

## DAB:
https://bitbucket.org/braintechinnovations/workspace/repositories/

### Xml: è il padre del HTML
XML: Xpansible Markup Language
### XAML

### Interfaccia: //TODO

### Creazione applicazione WPF:
- Creo la cartella Models
- Aggiungo i pacchetti nuGet
- Scaffolding
- Creo una cartella IDAL
- Imprecazioni varie

## HTML
!Doctype: serve a settare il dizionario di tutto ciò che viene dopo.
html è stateless.
## Gallerie JavaScript:
- D3 Gallery
- Three JS
### Principali TAG 
I tag sono elementi strutturali e di contenuto.
```HTML
<!DOCTYPE html>
<html>
    <head>
        <title>Titolo della pagina</title>
    </head>
    <body>
        <!-- Questo è un commento -->
        <h1>Titolo1</h1>
        <h2>Titolo2</h2>
        <h3>Titolo3</h3>
        <!--Fino ad h6-->
        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
          
        </p>
        <script>
            var a = 5
        </script>
        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.

        </p>
    </body>
</html>
```













