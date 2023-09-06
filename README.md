# Repo : csharp-typesystem-snacks
Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
BONUS:
Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire. Una volta la scelta il programma esegue il snack corrispondente.

# Snack 1 problems encountered and solutions
- I was unable to check if the user input was a number. Using TryParse i solved this problem. Solution founded here: https://stackoverflow.com/questions/14304591/check-if-user-input-is-a-number
- double.TryParse() try to convert the type to double and assign the value to a variabile but with the default configuration don't recognize commas and dots. I solved this problems adding this two parameters NumberStyles.Any, CultureInfo.InvariantCulture. Solution founded here https://stackoverflow.com/questions/11560465/parse-strings-to-double-with-comma-and-point
