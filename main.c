#include <unistd.h>
int main (void) {
   return execl ("app", "", NULL);
}
