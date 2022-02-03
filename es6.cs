#include <stdio.h>
int main (int argc, char*argv[])
{
    int a, b, c, nVolte= 0, sommaC=0
    double media;

    do
    {
        printf("inserisci a: \n");
        scanf("%d", & a);
        printf("inserisci b: \n");
        scanf("%d", & b);
    }while (a<b):
    do
    {
        printf("inserisci c: \n");
        scanf("%d", & c);
        if(c>a && c<b)
        {
            sommaC = sommaC + c;
            nVolte++;
        }

    }while(c>a && c<b);
    media = (double)c/ (double)nVolte;
    printf("Media è: %f", media);
}

}