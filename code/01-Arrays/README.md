# Arrays

Um array é uma variável/contêiner que pode armazenar vários valores. Uma coleção de sequencial de tamanho fixo de elementos do mesmo tipo. Um array é usado para armazenar uma coleção de dados mas geralmente é mais util pensar em um array como uma coleção de variáveis do mesmo tipo armazenadas em locais de memória contíguos (situado ao lado, ou que está muito próximo).

A maioria das estruturas de dados faz uso de arrays para implementar seus algoritmos.

Termos importantes para entender o conceito de array:

- Elemento - Cada item armazenado em um array é chamado de elemento.
- Índice - Cada localização de um elemento em uma matriz possui um índice numérico, que é usado para identificar o elemento

## Declarando Arrays

Para declarar um array em C#, você pode usar a seguinte sintaxe:

```c#
datatype[] arrayName;
```

O "datatype" é usado para especificar o tipo de elemento no array. Os cochetes "[]" especificam a classificação de um array e a classificação especifica o tamanho do array. Já o "arrayName" especifica o nome do array.

Por exemplo:

```C#
double[] balance;
```

## Inicializando um Array

Declarar um array não o inicializa na memória. Quando a variável de um array é inicializada, você pode atribuir valores a esse array.

Array é um tipo de referencia, então você precisa usar a palabra "new" para criar uma instancia.

Por exemplo:

```C#
double[] balance = new double[10];
```

## Atribuindo valores a um Array

É possivel atribuir valores a elementos individuais do array usando o número do índice.

Por exemplo:

```C#
double[] balance = new double[10];
balance[0] = 4500.0;
```

Também é possível atribuir valores ao array no momento da declaração.

Por exemplo:

```C#
double[] balance = { 2340.0, 4523.69, 3421.0};
```

É possível também criar e inicializar um array.

Por exemplo:

```C#
int [] marks = new int[5]  { 99,  98, 92, 97, 95};
```

É possível omitir o tamanho do array.

Por exemplo:

```C#
int [] marks = new int[]  { 99,  98, 92, 97, 95};
```

Assim como copiar uma variável de um array para outra variável de array de destino. Nesse caso, o destino e a origem apontam para o mesmo local de memória.

Por exemplo:

```C#
int [] marks = new int[]  { 99,  98, 92, 97, 95};
int[] score = marks;
```

Quando se cria um array, o compilador C# inicializa implicitamente cada elemento da matriz com um valor padrão, dependendo do tipo de array. Por exemplo, para um array int todos os elementos são inicializados com 0.

## Acessando elementos do Array

Um elemento é acessado pela indexação do nome do array. Isso é feito colocando o índice do elemento entre cochetes após o nome do array.

[Por exemplo:](https://github.com/romulodeoliveira/Data-Structure/blob/main/code/01-Arrays/Exemple01/Program.cs)

```C#
double salary = balance[9];
```

<div align="center">

![source code](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img01.png)

</div>

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img02.png)

</div>

---

# Arrays C#

Outros conceitos importantes relacionados a array que devem ser claros para um programador C#:

---

## C# - Arrays Multidimensionais

C# permite arrays multidimensionais. Esses também são chamados de arrays retangulares. O exemplo a seguir representa uma forma de declarar um array bidimensional de string:

```C#
string [,] names;
```

Ou um array tridimensional de variáveis `int` como:

```C#
int [ , , ] m;
```

### Arrays Bidimensionais

A forma mais simples de um array multidimensional é um array bidimensional. Um array bidimensional é uma lista de arrays unidimensionais.

Um array bidimensional pode ser considerado uma tabela que possui x números de linhas e y números de colunas.

Dessa forma, cada elemento é identificado por um nome de elemento `exemplo[a, b]` onde `exemplo` é o nome da matriz e `a` e `b` são os subscritos que identificam exclusivamente cada elemento do array.

### Inicializando e Acessando Arrays Bidimensionais

Arrays multidimensionais podem ser inicializadas especificando valores (como também podem ser inicializados sem especificar tais valores) entre colchetes para cada linha e um elemento pode ser acessado usando os índices de linha e coluna. Podemos observar nos dois exemplos a seguir:

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img03.png)

</div>

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img04.png)

</div>

E abaixo o resultado do código:

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img05.png)

</div>

---

## C# - Arrays Irregulares

Arrays irregulares (ou [denteada](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/jagged-arrays), ou ainda Jagged) são arrays de arrays. Uma matriz cujo os elementos são outras matrizes.

Os arrays irregulares podem ser inicializados da seguinte forma:

```c#
string[][] frutas = new string[3][];
```

Mas antes de usá-los, devemos sempre inicializá-los. E isso fazemos da seguinte forma:

```c#
frutas[0] = new string[6];
frutas[1] = new string[4];
frutas[2] = new string[2];
```

Também é possível usar os inicializadores para preencher os elementos matriz com valores. Nesse caso não é necessário informar o tamanho da matriz:

```c#
frutas[0] = new string[] { "Maçã", "Banana", "Laranja", "Abacaxi", "Morango", "Uva" };
frutas[1] = new string[] { "Manga", "Limão", "Pera", "Melancia" };
frutas[2] = new string[] { "Kiwi", "Cereja" };
```

Também é possível inicializar a matriz mediante uma declaração como esta:

```c#
string[][] frutas = new string[3][]
{
    new string[] { "Maçã", "Banana", "Laranja", "Abacaxi", "Morango", "Uva" },
    new string[] { "Manga", "Limão", "Pera", "Melancia" },
    new string[] { "Kiwi", "Cereja" }
};
```

É possível ainda usar a seguinte forma abreviada. Observe que não é possível omitir o operador `new` da inicialização de elementos, porque não há nenhuma inicialização padrão para os elementos:

```c#
string[][] frutas =
{
    new string[] { "Maçã", "Banana", "Laranja", "Abacaxi", "Morango", "Uva" },
    new string[] { "Manga", "Limão", "Pera", "Melancia" },
    new string[] { "Kiwi", "Cereja" }
};
```

É possível acessar elementos de matrizes individuais como estes exemplos:

```c#
System.Console.WriteLine(frutas[1][0]); // Output: Manga
```

É possível misturar matrizes irregulares e multidimensionais. A seguir, há uma declaração e inicialização de uma matriz denteada unidimensional que contém três elementos de matriz bidimensional de tamanhos diferentes:

```c#
string[][,] frutas = new string[3][,]
{
    new string[,] { {"Maçã", "Banana", "Laranja"}, {"Abacaxi", "Morango", "Uva"}, {"Mamão", "Maracujá", "Tangerina"} },
    new string[,] { {"Manga", "Limão"}, {"Pera", "Melancia"}, {"Jaca", "Pitaya"} },
    new string[,] { {"Kiwi", "Cereja"}, {"Caqui", "Framboesa"} }
};
```

De forma similar ao que foi mostrado anteriormente, é possível acessar da seguinte forma:

```c#
System.Console.WriteLine(frutas[1][0, 0]); // Output: Manga
```

### Exemplo:

Este exemplo cria um array cujos elementos são arrays. Cada um dos elementos do array tem um tamanho diferente.

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img06.png)

</div>

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img07.png)

</div>

---

## C# - Passando Arrays como Argumentos de Função

Você pode passar uma matriz como um argumento de função em C#. O exemplo a seguir demonstra isso:

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img08.png)

</div>

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img09.png)

</div>

---

## C# - Passando Arrays como Argumentos de Função

Às vezes, ao declarar um método, não temos certeza do número de argumentos passados ​​como parâmetro. Arrays de parâmetros C# são úteis nesses momentos.

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img10.png)

</div>

<div align="center">

![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img11.png)

</div>

---

## C# - Classe Array

### Propriedades:

Estes são apenas alguns exemplos dos métodos disponíveis na classe Array. Existem outros métodos para trabalhar com arrays multidimensionais, realizar pesquisas, filtrar elementos, entre outros.

| Nome           | Descrição                                                                |
| -------------- | ------------------------------------------------------------------------ |
| Length         | Retorna o número total de elementos no array.                            |
| Rank           | Retorna a dimensão do array.                                             |
| IsFixedSize    | Indica se o array tem um tamanho fixo.                                   |
| IsReadOnly     | Indica se o array é somente leitura.                                     |
| IsSynchronized | Indica se o acesso ao array é sincronizado (thread-safe).                |
| SyncRoot       | Retorna um objeto que pode ser usado para sincronizar o acesso ao array. |

### Métodos:

Estes são apenas alguns exemplos de métodos da classe Array. Existem muitos outros métodos disponíveis para realizar operações de filtragem, projeção, agregação, entre outros.

| Nome                                 | Descrição                                                                                 |
| ------------------------------------ | ----------------------------------------------------------------------------------------- |
| GetValue(int index)                  | Retorna o valor do elemento no índice especificado.                                       |
| SetValue(object value, int index)    | Define o valor do elemento no índice especificado.                                        |
| Length                               | Retorna o número total de elementos no array.                                             |
| CopyTo(Array array, int index)       | Copia os elementos do array para outro array, a partir do índice especificado.            |
| Clone()                              | Cria uma cópia superficial do array.                                                      |
| Sort()                               | Ordena os elementos do array em ordem crescente.                                          |
| Reverse()                            | Inverte a ordem dos elementos no array.                                                   |
| IndexOf(object value)                | Retorna o índice da primeira ocorrência do valor especificado no array.                   |
| LastIndexOf(object value)            | Retorna o índice da última ocorrência do valor especificado no array.                     |
| Contains(object value)               | Verifica se o array contém o valor especificado.                                          |
| Clear()                              | Remove todos os elementos do array, definindo-os como o valor padrão do tipo de elemento. |
| Concat(Array array)                  | Concatena dois arrays.                                                                    |
| Copy(Array array, int index)         | Copia os elementos do array para outro array, a partir do índice especificado.            |
| GetLength(int dimension)             | Retorna o número de elementos em uma dimensão específica do array multidimensional.       |
| Resize(ref Array array, int newSize) | Redimensiona o array para o novo tamanho especificado.                                    |
