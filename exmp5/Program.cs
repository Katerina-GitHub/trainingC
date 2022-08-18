int a = 2;
int b = 5;
int c = 15;
int d = 8;
int e = 1;

int min = a;
if (a < min) min = a;
if (b < min) min = b;
if (c < min) min = c;
if (d < min) min = d;
if (e < min) min = e;

Console.WriteLine("min is " + min);