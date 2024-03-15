//Criar um vetor
int[] vetor = new int[100];
Random aleatorio = new Random();

//Preencher o vetor aleatório
for(int i = 0; i < vetor.Length; i++) {
    vetor[i] = aleatorio.Next(100);
}

for(int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + " ");
}

//Ordernar o vetor
Array.Sort(vetor);

Console.WriteLine("\n");

//Imprimir o vetor
for(int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + " ");
}

