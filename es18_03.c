#include <stdio.h>
#include <string.h>

int cifra(char carattere)
 {
  if (carattere=='0') return 1;
  if (carattere=='1') return 1;
  if (carattere=='2') return 1;
  if (carattere=='3') return 1;
  if (carattere=='4') return 1;
  if (carattere=='5') return 1;
  if (carattere=='6') return 1;
  if (carattere=='7') return 1;
  if (carattere=='8') return 1;
  if (carattere=='9') return 1;
  return 0;
 } 

int main(char s[]){
    printf("inserisci data: \n")

      int i = 0;
      int barrette = 0;
      int numCifre;

      if(s == NULL) 
            return 0;
      if(strlen(s) != 10)
            return 0;

        cifra();
     for(i=0; s[i] != '\0'; i++)
     {
         if(stringa[i] < '0' || stringa[i] > '9')
            {
	            return 0;
            }
           if(s[i] == '/')
            {
                 if(i != 2 && i != 5)
                       return 0; 
            }       
     }
      if(numCifre != 8 || barrette != 2)
          return 0;
}