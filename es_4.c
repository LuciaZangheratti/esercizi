#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

int Ricerca(int array[], int x)
{
    int numero;
    printf("inserisci il numero da ricercare");
    scanf("%d", numero);
    for (int i = 0; i < x; i++)
    {
        if (array[i] == numero)
            return i + 1;
    }
    return -1;
}

void Visualizza(int array[], int x)
{
    for (int i = 0; i < x; i++)
    {
        printf("%d", array[i]);
    }
}

void Modifica(int array[], int x)
{
    int numero, posizione;
    printf("inserisci l'elemento da modificare, fino a %d", x);
    scanf("%d", posizione);
    array[posizione] = numero;
}

void Inserisci(int array[], int x)
{
    int numero;
    printf("inserisci il numero che vuoi inserire: ");
    scanf("%d", numero);
    array[x] = numero;
    printf("numero messo in %d", x);
    x++;
}

void Elimina(array[], int x)
{
    int posizione;
    printf("inserisci l'elemento che vuoi eliminare fino a %d", x);
    scanf("%d", posizione);
    for (int i = posizione; i < x - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[x] = 0;
}

int main(int argc, char *argv[])
{
    int numeri[SHRT_MAX];
    int scelta, risp, x = 0;

    do
    {
        printf("inserisci i numeri, mettere -1 per andare avanti");
        scanf("%d", scelta);
        if (scelta != 1)
        {
            numeri[x] = scelta;
            x++;
        }
    } while (scelta != -1);

    do
    {
        printf("premere 1 per mostrare il contenuto dell'array\n");
        printf("premere 2 per inserire un elemento\n")
        printf("premere 3 per modificare un elemento\n"
        printf("premere 4 per eliminare un elemento\n");
        printf("premere 5 per ricercare un elemento\n"):
        printf("premere 0 per terminare\n");
        scanf("%d", scelta) ;
    }
    if (scelta == 1)
        Ricerca(numeri[], x);
    else if (scelta == 2)
        Inserisci(numeri[], x);
    else if (scelta == 3)
        Modifica(numeri[], x);
    else if (scelta == 4)
        Elimina(numeri[], x);
    else if (scelta == 5)
    {
        risp=Ricerca(numeril],x);
        if (risp != -1)
            printf("In numero si trova in posizione %d", risp);
    }
}
while (scelta != 0)
    ;
return 0;
}