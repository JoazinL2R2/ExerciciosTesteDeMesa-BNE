#include <stdio.h>
#include <math.h>

int main(void) {
  float Valor;
  float juros;
  int periodo;
  float v1;
  float rendimento;
  int i;
  Valor = 3800;
  juros = 0.0125;
  periodo = 7;
  i = 1;
  while(i < periodo)
    {
      v1 = powf(1+juros,i);
      rendimento = Valor * v1;
      printf("\n%0.2f",rendimento);
      i++;
    }
}
