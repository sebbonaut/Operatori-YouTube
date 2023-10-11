using Operatori;

Razlomak[] razlomci = new Razlomak[3];
razlomci[0] = new Razlomak(-4, 6);
razlomci[1] = new Razlomak(-1, 3);
//razlomci[2] = razlomci[0] + razlomci[1];
//razlomci[2] = razlomci[0] / razlomci[0];
razlomci[1] += razlomci[0];
razlomci[1] += (Razlomak)2;
razlomci[2] = new Razlomak(-2, 3);
Console.WriteLine(razlomci[2].Brojnik + "/"
    + razlomci[2].Nazivnik);
//Console.WriteLine(2 + razlomci[2]);
razlomci[0] = new Razlomak(5,3);
if (razlomci[0])
    Console.WriteLine("Istina");
else if (!razlomci[0])
    Console.WriteLine("Laz");
else
    Console.WriteLine("Nesto drugo");
Console.WriteLine(razlomci[0].ToString());

razlomci[0] = new Razlomak(-2, 6);
//razlomci[1] = razlomci[0];
razlomci[1] = new Razlomak(-2, 6);
if (razlomci[0].Equals(razlomci[1]))
    Console.WriteLine("Isti su!");
else
    Console.WriteLine("Nisu isti!");

int a = 2, b = 3;
if ((a++) == 2 || (b++) == 3) //short-circuit
    Console.WriteLine("ok");
Console.WriteLine($"{a}, {b}");