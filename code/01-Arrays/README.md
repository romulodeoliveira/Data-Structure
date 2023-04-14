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

:::center
![source code](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img01.png)
:::

:::center
![output](https://github.com/romulodeoliveira/Data-Structure/blob/main/img/01-Array/img02.png)
:::
