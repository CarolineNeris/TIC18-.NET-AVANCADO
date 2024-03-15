# Classe ContaBancaria ---> 'Teu Dinheiro Minhas Regras'

Crie uma classe `ContaBancaria` que possui um saldo como field e os métodos `Sacar(double)`, `Depositar(double)` e `Transferir(double, ContaBancaria)`. Crie também duas exceções: `ValorInvalidoException` e `SaldoInsuficienteException`.

A exceção `ValorInvalidoException` deve ser lançada se o valor utilizado nas operações de depósito, saque ou transferência for igual ou inferior a 0. Já a exceção `SaldoInsuficienteException` deve ser lançada se o valor de um saque ou transferência for superior ao saldo disponível.

No construtor de `ValorInvalidoException`, é necessário fornecer uma mensagem de erro e o valor inválido utilizado. No construtor de `SaldoInsuficienteException`, é necessário fornecer uma mensagem de erro e também o saldo disponível.

Crie uma classe que instancia duas contas e tenta realizar operações de depósito, saque e transferência. Faça transações corretas e também transações que geram exceção. Quando a transação gerar exceção, faça um catch da mesma, imprima a mensagem de erro e o valor inválido utilizado (para `ValorInvalidoException`) ou o saldo disponível (para `SaldoInsuficienteException`).
