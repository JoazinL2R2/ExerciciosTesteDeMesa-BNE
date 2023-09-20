#include <stdio.h>

int main(void) {
  int a;
  int b;
  int v[5];
  a = 7;
  b = a - 6;
  while(b<a)
    {
      v[b] = b + a;
      printf("\n%d", v[b]);
      b = b + 2;
    }
}
