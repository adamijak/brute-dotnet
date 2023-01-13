#include <unistd.h>
int main (void) {
   return execl ("out", "", NULL);
}
