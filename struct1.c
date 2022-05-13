#include <stdio.h>
#define DIM 5

typedef struct
{
    char nome[10];
    char ruolo[10];
    char squadra[10];
} calciatore_t;

int StampaMilan(calciatore_t calciatori[])
{
    for (int i = 0; i < DIM, i++)
    {
        printf(calciatori[i].squadra, "milan");
        printf(calciatori[i].nome, "nome");
    }
}

int StampaC(calciatore_t calciatori[])
{
    for (int i = 0; i < DIM, i++)
    {
        if (calciatori[i].nome == 'c')
            printf("%s", calciatori[i].nome);
    }
}

int main(int argc, char *argv[])
{
    calciatore_t calciatori[DIM];
    for (int i = 0; i < DIM; i++)
    {
        printf("inserisci nome");
        scanf("%s", calciatori[i].nome);

        printf("inserisci ruolo");
        scanf("%s", calciatori[i].ruolo);

        printf("inserisci squadra");
        scanf("%s", calciatori[i].squadra);
    }
    printf("calciatori del Milan");
    StampaMilan(calciatori[DIM]);

    printf("calciatori che iniziano per C");
    StampaC(calciatori[DIM]);
}
