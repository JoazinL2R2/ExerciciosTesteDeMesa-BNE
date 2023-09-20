#include <stdio.h>
#include <math.h>

int main(void) {
  float VF;
  float VP;
  float juros;
  int periodo;
  float v1;
  float rendimento;
  int i;
  VF = 7390.61;
  juros = 0.0125;
  periodo = 7;
  i = 1;
  while(i < periodo)
    {
      v1 = powf(1+juros,i);
      VP = VF / v1;
      printf("\n%0.2f",VP);
      i++;
    }
}
