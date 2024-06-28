int anterior = 1;
int atual = 1;
List<int> fibonacci = new List<int>();
fibonacci.Add(anterior);
fibonacci.Add(atual);

for (int i =0; i <5; i++)
{
    int futuro = anterior + atual;
    anterior = atual;
    atual = futuro;
    
    fibonacci.Add(futuro);    
}