Sql
## Base di dati

**Big Data**
Una grande quantita di dati omogenei o eterogenei 

**Data Lake**
Una massa informa di informazioni non strutturate 

**Risorsa Informazione** 

**Sistema Informativo** e una combinazione di risorse umane e materiali o procedure organizzate per la raccolta l'archiviazione elaborazione e scambio infomazioni necessaria all' attività operative.

**Sistema** e un sistema che evidenzia il fatto che esiste un insieme organizzativo di elelmenti.

**Sistema Informatico** 
Indica l'insieme degli strumenti informatic impiegati per il trasferimento autmatico delle informazioni al fine di agrvolare le funzioni del sistema informativo.

## DataBase

Sistemi per la gestione di base dati (SGBD) o Data Base Management
System (DBMS)
•
una base di dati è una collezione di dati atti a rappresentare le informazioni
che interessano un sistema informativo
•
un SGBD è un sistema software in grado di gestire (costruire, modificare,
utilizzare, …) una base dati
•
Sistemi di recupero delle informazioni (SRI) o Information Retrieval
System (IRS)

Un DB è costituito da una grande quantità di dati, organizzati in
insiemi omogenei in correlazione tra loro
i dati sono memorizzati e gestiti in memoria permanente (disco)
i dati sono condivisi fra più utenti e fra più applicazioni per ridurre la
ridondanza e la possibilità di inconsistenze.

## In un DB esiste:
una parte sostanzialmente invariante nel tempo, detto schema della base di
dati , che descrive le caratteristiche dei
una parte variabile nel tempo, detta istanza o stato del DB, costituita dai valori
effettivi dei dati

**accezione generica, metodologica**
insieme organizzato di dati utilizzati per il supporto allo svolgimento delle
attività di un ente (azienda, ufficio, persona)

**accezione specifica, metodologica e tecnologica**
insieme di dati gestito da un DBMS

**Nella nostra accezione i database sono:**
un supporto digitale in cui i dati sono immagazzinati
un software che permetta il recupero dei dati
una rete che permetta un’accessibilita` condivisa ai dati


**Definizione** : Un DBMS è un sistema centralizzato o distribuito che
offre opportuni linguaggi per:
definire lo schema di una basi di dati (lo schema va definito prima di creare
dati),
scegliere le strutture dati per la memorizzazione dei dati,
memorizzare i dati rispettando i vincoli definiti nello schema;
recuperare e modificare i dati interattivamente (linguaggio di interrogazione o
query language) o da programmi.

## I DBMS offrono dei linguaggi 
per la definizione dello schema del DB
l’uso della base di dati ( accesso ai dati, inserimento, modifica, cancellazione)

I DBMS garantiscono una gestione efficiente del DB

le operazioni devono essere eseguite utilizzando un insieme di risorse ( tempo
e spazio) che siano accettabili per gli utenti.

I DBMS garantiscono l’affidabilità dell DB

i dati sono protetti da errori dovuti a malfunzionamenti e interferenze.

I DBMS garantiscono la privatezza del DB

i dati sono protetti dall’accesso e dall’uso da parte di utenti non autorizzati.


## CARATTERISTICHE DEI DATI GESTITI DAI DBMS
Sono organizzati in insiemi omogenei, fra i quali sono definite delle
relazioni. La struttura dei dati e le relazioni sono descritte nello schema
usando i meccanismi di astrazione del modello dei dati del DBMS;

Sono molti, in assoluto e rispetto ai metadati, e non possono essere gestiti
in memoria temporanea;

Sono accessibili mediante transazioni, unità di lavoro atomiche che non
possono avere effetti parziali;

Sono protetti sia da accesso da parte di utenti non autorizzati, sia da
corruzione dovuta a malfunzionamenti hardware e software;

Sono utilizzabili contemporaneamente da utenti diversi.

## I DATABASE SONO GRANDI
dimensioni (molto) maggiori della memoria centrale dei sistemi di calcolo
utilizzati

il limite deve essere solo quello fisico dei dispositivi

hanno un tempo di vita indipendente dalle singole esecuzioni dei programmi
che le utilizzano

## I DATABASE SONO CONDIVISI

Ogni organizzazione (specie se grande) è divisa in settori o comunque svolge
diverse attività

Ciascun settore/attività ha un (sotto)sistema informativo (non
necessariamente disgiunto)

## I DBMS GARANTISCONO PRIVATEZZA

Si possono definire meccanismi di autorizzazione

l'utente A è autorizzato a leggere tutti i dati e a modificare quelli sul ricevimento

l'utente B è autorizzato a leggere X e a modificare Y

## I DBMS GARANTISCONO AFFIDABILITA

Affidabilità (per le basi di dati):

resistenza a malfunzionamenti hardware e software

Una base di dati è una risorsa pregiata e quindi deve essere conservata a lungo
termine

## I DBMS DEVONO ESSERE EFFICIENTI

Cercano di utilizzare al meglio le risorse di spazio di memoria (principale e
secondaria) e tempo (di esecuzione e di risposta)

I DBMS, con tante funzioni, rischiano l'inefficienza e per questo ci sono grandi
investimenti e competizione

L’efficienza è anche il risultato della qualità delle applicazioni

## I DBMS DEVONO ESSERE EFFICACI

Cercano di rendere produttive le attività dei loro utilizzatori, offrendo
funzionalità articolate, potenti e flessibili:

il corso è in buona parte dedicato ad illustrare come i DBMS perseguono
l'efficacia

## ARCHITETTURA STANDARD II
livello logico
descrizione dell’intera base di dati nel modello logico
“principale” del DBMS

livello interno (o fisico)
rappresentazione dello schema logico per
mezzo di strutture fisiche di memorizzazione (es.: files)

livello esterno
descrizione di parte della base di dati in un modello
logico (“viste” parziali, derivate, anche in modelli diversi)


## INDIPENDENZA DEI DATI

L’approccio con tre livelli di descrizione dei dati è stato proposto come
un modo per garantire le proprietà di indipendenza logica e fisica dei
dati, che sono fra gli obiettivi più importanti dei DBMS

l’accesso avviene solo tramite il livello esterno (che può coincidere
con il livello logico)

due forme:
indipendenza fisica
indipendenza logica
## INDIPENDENZA FISICA

il livello logico e quello esterno sono indipendenti da quello fisico

una relazione è utilizzata nello stesso modo qualunque sia la sua realizzazione
fisica

la realizzazione fisica può cambiare senza che debbano essere modificati i
programmi

i programmi applicativi non devono essere modificati in seguito a modifiche
dell’organizzazione fisica dei dati.

## INDIPENDENZA LOGICA

il livello esterno è indipendente da quello logico

aggiunte o modifiche alle viste non richiedono modifiche al livello
logico

modifiche allo schema logico che lascino inalterato lo schema esterno
sono trasparenti

i programmi applicativi non devono essere modificati in seguito a
modifiche dello schema logico.

## LINGUAGGI PER DATABASE

Un altro contributo all’efficacia: disponibilità di vari linguaggi e
interfacce

linguaggi testuali interattivi SQL

comandi (SQL) immersi in un linguaggio ospite (Pascal, Java, C ...)

comandi (SQL) immersi in un linguaggio ad hoc, con anche altre funzionalità
(p.es. per grafici o stampe strutturate)

con interfacce amichevoli (senza linguaggio testuale)

## Modelli

Un modello di dati e’ un insieme di concetti utilizzati per organizzare i dati e descriverne la struttura in modo che essa risulti comprensibile a un
elaboratore


## MODELLI INFORMATICI
Sono modelli simbolici rappresentazione formale delle idee e conoscenze
relative ad un fenomeno
Si hanno diverse categorie di modelli informatici che differiscono per i tipi di fatti che si considerano, ossia per i diversi livelli di astrazione a cui si opera

**modelli concettuali** sono considerati solo i fatti relativi alla realtà
senza alcun riferimento agli strumenti informatici che dovranno usare il
modello

**modelli logici** sono considerati anche fatti relativi agli strumenti
informatici il modello è adeguato alle caratteristiche del DBMS, in
modo che possa essere da questo interpretato

**modelli fisici** sono considerate le strutture fisiche usate dal
calcolatore per rappresentare i dati

## MODELLI CONCETTUALI

Permettono di rappresentare i dati in modo
indipendente da ogni sistema

cercano di descrivere i concetti del mondo reale

sono utilizzati nelle fasi preliminari di progettazione

Il più diffuso è il modello Entity Relationship modello  **ER**

![alt text](image.png)


## LA CONOSCENZA CONCRETA

La conoscenza concreta riguarda i fatti specifici che si vogliono
rappresentare

Si suppone che la realtà consista di entità che hanno alcune
proprietà

Si suppone inoltre che le entità omogenee siano raggruppabili in
collezioni e che siano connesse fra di loro da associazioni che
evolvano nel tempo

CONOSCENZA CONCRETA:
## ENTITA’ e PROPRIETA’
Le entità sono ciò che esiste e di cui interessa rappresentare alcuni fatti
o proprietà

Ad esempio sono entità i libri la “Divina Commedia” o il “
gli utenti “ e “ di una biblioteca in esame

Le proprietà costituiscono i fatti che interessano soltanto perché
descrivono caratteristiche di determinate entità

## TIPI DI ENTITA’

Un tipo entità è una descrizione astratta di ciò che accomuna un
insieme di entità omogenee (della stessa natura), esistenti o possibili

Un tipo non è una specifica collezione di entità, ma descrive la
struttura di tutte le entità “ va pensato come una collezione
infinita di entità possibili

Il tipo persona descrive non solo tutte le persone che esistono, ma anche
quelle che esisteranno o che potrebbero esistere

Ad un tipo sono associate le **proprietà delle entità** che appartengono a
tale tipo, nonché le caratteristiche di tali proprietà

Il tipo utente ha le proprietà cognome e recapito, intendendo con questo che
ogni utente ha un cognome e un recapito, ma con un valore in generale diverso da quello di tutti gli 

Nell’esame di una realtà, tra tutte le possibili proprietà di entità omogenee, con il processo di astrazione che porta a definire il loro tipo si isolano solo quelle che sono interessanti per il fine che ci si prefigge

Ad esempio, per gli utenti della biblioteca si ritengono interessanti il cognome e il recapito, ma non il colore degli occhi o dei capelli


## CONOSCENZA CONCRETA:
CARATTERISTICHE DELLE PROPRIETA’
Ogni proprietà ha un nome, detto anche attributo e un dominio cioè
l’insieme dei possibili valori che può assumere

Ogni proprietà è una coppia ( valore di un certo tipo)

Ogni proprietà può essere classificata come segue

atomica/strutturata

unione semplice

univoca /multivalore

totale (obbligatoria)/parziale

costante/variabile

calcolata/non calcolata

## CARATTERISTICHE DELLE PROPRIETA’

Una proprietà è atomica se il suo valore non è scomponibile
(es
il cognome di una persona) altrimenti e’ detta strutturata (es la residenza
è scomponibile in indirizzo, CAP,)

Una proprietà è di tipo unione se il suo valore può essere di tipi diversi
(es la proprietà titolare di un corso può essere un professore associato o un professore ordinario) altrimenti è detta semplice

Una proprietà è univoca se il suo valore è unico

(es
cognome di un utente ha un unico valore) altrimenti è detta multivalore
(es
la proprietà “recapiti telefonici” di una persona è multivalore se si ammette
che alcune persone possano essere raggiunte attraverso più numeri telefonici)

Una proprietà è totale  se ogni entità dell’universo del
discorso ha per essa un valore specificato, altrimenti è detta parziale

(es
si può considerare il cognome di un utente una proprietà totale ed il suo
recapito telefonico una proprietà parziale)

Una proprietà è costante se il suo valore non cambia nel tempo, altrimenti
è detta variabile
(es
data di nascita è una costante, l’indirizzo è variabile)

Una proprietà è calcolata se il suo valore può essere determinato a
partire dal valore di altre proprietà, altrimenti è detta non calcolata
(es l’età può essere calcolata dalla data di nascita)


Le entità dello stesso tipo possono essere raggruppate in collezioni che
chiameremo classi
DEFINIZIONE.
Una classe è un insieme variabile nel tempo di entità
omogenee (dello stesso tipo).
Esempio. La classe dei libri è l’insieme dei libri che la biblioteca possiede ad un
certo istante.
Una classe ha due aspetti:

uno intensionale , invariante nel tempo

uno estensionale , variabile nel tempo
L’aspetto intensionale riguarda il tipo degli elementi, mentre l’aspetto
estensionale riguarda l’insieme dei suoi elementi.
Come accade in generale per gli
insiemi , gli elementi di una classe possono essere dati in due
modi: elencandoli in modo esplicito (ad esempio, gli elementi della classe delle persone sono
Mario, Giorgio ecc.), oppure caratterizzandoli mediante una condizione sui valori delle loro
proprietà (ad esempio, i minorenni sono tutte le persone con età inferiore a 18 anni).

## DDL
DDL consente di creare e modificare la struttura di un database, comprese le tabelle, le colonne e le relazioni tra le tabelle. Permette poi di creare e modificare gli indici, che possono migliorare le prestazioni delle query su un database. Inoltre, i comandi DDL possono essere utilizzati per impostare vincoli sui dati memorizzati nel database, garantendo l'integrità e la coerenza dei dati.

## DML
Data Manipulation Language (DML) è un sottoinsieme di SQL (Structured Query Language) utilizzato per gestire e manipolare i dati in un database relazionale. DML comandi vengono utilizzati per inserire, aggiornare, cancellare e recuperare dati da un database.

## QL
Query language (QL) - permette di interrogare il database, cioè di leggere i dati. Device Media Control Language (DMCL) - permette di controllare i supporti (memorie di massa) dove vengono memorizzati i dati.

## Transazione

E un blocco di istruzioni che viene eseguito nella sua totalità e non viene mai eseguito parzialmente

**Dump** Copie di backup  del database sottoforma di insert per ricostruirlo
## DIFFERENZA TRA NVARCHAR E CHAR
NVARCHAR USANO TUTTI I DIZIONARI CONOSCIUTI
VARCHAR USANO IL DIZIONARIO DELLA LINGUA CHE STAI USANDO 