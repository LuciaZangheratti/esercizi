# include <stdio.h>
# include <math.h>

int main()
{
   double somma= 0;
   int num;
do
 {
    printf("scrivi il numero\n")
    scanf("%d",& num);
if(num =>0)
{
    radice=sqrt(num);
    somma=somma+radice;
    printf("la somma delle radiciè:%f",somma);
}
else

printf("calcolo impossibile perchè non si può fare la radice di un numero negativo");

 } while(num => 0);
}

