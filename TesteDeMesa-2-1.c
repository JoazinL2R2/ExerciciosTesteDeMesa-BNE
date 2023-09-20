#include <stdio.h>
#include <math.h>

int main(void) {
  float ValorPresente;
  float TaxaJuros;
  int PeriodoMes;
  float ValorFinal;
  float valor;
  
  ValorPresente = 1.000;
  TaxaJuros = 5.30 / 100;
  PeriodoMes = 10;
  
  valor = ValorPresente * (1 + TaxaJuros);
  ValorFinal = pow(valor, PeriodoMes); 

  printf(" R$ %0.5f", ValorFinal);
}
