#include <stdio.h>

int main(void) {
  int a;
  int i[5];
  a = 2;

while(a<6)
  {
    i[a]=10*a;
    printf("\n %d",i[a]);
    a++;
  }
}
