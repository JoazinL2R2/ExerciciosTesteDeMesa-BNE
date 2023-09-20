#include <stdio.h>
#include <math.h>

int main(void) {
  float Valor;
  float juros;
  int periodo;
  float v1;
  float rendimento;
  int i;
  printf("insira o Valor inicial do investimento em Reais(R$):\n");
  scanf("\n%f",&Valor);
  printf("informe o Juros mensal("%"):\n");
  scanf("\n%f",&juros);
  juros = juros /100;
  printf("Informe o periodo de investimento em meses:\n");
  scanf("%d",&periodo);
  i = 1;
  while(i <= periodo)
    {
      v1 = powf(1+juros,i);
      rendimento = Valor * v1;
      printf("\n%0.2f",rendimento);
      i++;
    }
}
