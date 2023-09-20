#include <stdio.h>
#include <math.h>

int main(void) 
{
  float Valor;
  float juros;
  int periodo;
  float v1;
  float rendimento;
  int i;
  float saque;
  char resposta;
  float Vdesejado;

  printf("Insira o Valor inicial do investimento em Reais(R$):\n");
  scanf("%f", &Valor);

  printf("Informe o Juros mensal('%%'):\n");
  scanf("%f", &juros);
  juros = juros / 100;

  printf("Informe o periodo de investimento em meses:\n");

  scanf("%d", &periodo);

  i = 1;
  while (i <= periodo) 
  {
    v1 = powf(1 + juros,i);
    rendimento = Valor * v1;
    printf("\n%0.2f",rendimento);

    printf("\nDeseja Efetuar um saque? (s/n)\n");
    scanf("%c",&resposta);

    while (resposta == 's') {
      printf("Insira o Valor Desejado:\n");
      scanf("%f", &Vdesejado);
      rendimento = rendimento - Vdesejado;

      printf("Deseja Efetuar outro saque? (s/n)\n");
      scanf("%c",&resposta);  
    }
    i++;
  }
}
