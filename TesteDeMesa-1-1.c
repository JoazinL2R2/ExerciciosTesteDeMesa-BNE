#include <stdio.h>

int main(void) {
  int a;
  int b;
  int c;
  int cont;
  cont = 0;
  int i[4];
  a = 10;
  b = 20;
  c = ((a+b) / 2);
  c = c - 40;
  
  for (int j = 0; j < 4; j++) {
    i[j] = 0;
  }

  while(cont <= 3) {
    if(cont == 3) { 
      i[3] = a + b + c;
      printf("\n %d", i[3]);
    }
    else {
      printf("\n NaN");
    }
    cont++;
  }
}

