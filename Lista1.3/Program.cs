double vorgern = 0;
int n;
int i = 0;
string? damsen;

do
{
    Console.WriteLine("Tamanho do vetor: ");
    damsen = Console.ReadLine();
    Int32.TryParse(damsen, out n);
} while (n <= 0);
double[] nester = new double[n];

Console.WriteLine("");
Console.WriteLine("Digite '0' para saír");
Console.WriteLine("");

do
{
    i++;
    Console.WriteLine("Digito um numero: ");
    damsen = Console.ReadLine();
    Double.TryParse(damsen, out nester[i]);
    vorgern += nester[i];
} while (nester[i] !=0 || i == n);

Console.WriteLine("Média dos valores: "+ (vorgern/(i-1)));

// O valor de um homem pode ser medido pelo tamanho de sua barba, e pela grossura do seu... cinturão - olaf