# Exercício 4

Crie uma classe chamada `ServicoFabrica<T>` que possui um método chamado `NovaInstancia()`. Quando este método é chamado, ele cria um objeto do tipo `T` (invocando o construtor padrão, sem parâmetros) e retorna este objeto. Um detalhe importante é que apenas classes que implementam a interface `IServico` (que também deve ser definida por você) devem ser aceitas na parametrização do tipo. Esta interface possui o método `void Executar()`, que deve ser implementado pelas classes que implementam esta interface.
