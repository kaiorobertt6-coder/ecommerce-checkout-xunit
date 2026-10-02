# Ecommerce Checkout — xUnit

## Métodos Criados

A classe `PedidoService` possui três métodos:

### 1. GerarCodigoRastreio

```csharp
GerarCodigoRastreio(string regiao, int numeroPedido)
```

Retorna o código de rastreio com a região em letras maiúsculas e o número do pedido preenchido com zeros à esquerda, totalizando 4 dígitos.

**Exemplo:**

```text
Entrada: "sudeste", 42
Saída: "SUDESTE-0042"
```

### 2. CalcularPontosFidelidade

```csharp
CalcularPontosFidelidade(int valorTotal)
```

Calcula os pontos de fidelidade do cliente. A cada R$ 10,00 em compras, são concedidos 2 pontos.

**Exemplo:**

```text
Entrada: 150
Saída: 30 pontos
```

### 3. TemDireitoAFreteGratis

```csharp
TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
```

Verifica se o cliente possui direito ao frete grátis.

O frete é gratuito quando o valor da compra é maior ou igual a R$ 200,00 **ou** quando o cliente é VIP.

**Exemplos:**

```text
R$ 150 + cliente VIP → true
R$ 150 + cliente não VIP → false
```

## Cobertura dos Testes

Os testes unitários estão implementados na classe `PedidoServiceTests` utilizando o framework **xUnit** e o atributo `[Fact]`.

Foram criados **4 testes**, cobrindo todos os métodos implementados:

| # | Método                     | Cenário                          | Assert utilizado |
| - | -------------------------- | -------------------------------- | ---------------- |
| 1 | `GerarCodigoRastreio`      | Verifica `SUDESTE-0042`          | `Assert.Equal`   |
| 2 | `CalcularPontosFidelidade` | Verifica 30 pontos para R$ 150   | `Assert.Equal`   |
| 3 | `TemDireitoAFreteGratis`   | Cliente VIP abaixo de R$ 200     | `Assert.True`    |
| 4 | `TemDireitoAFreteGratis`   | Cliente não VIP abaixo de R$ 200 | `Assert.False`   |

Dessa forma, os três métodos da classe `PedidoService` possuem testes unitários correspondentes, incluindo os retornos dos tipos:

* `string`
* `int`
* `bool`

## Como Executar os Testes

Com o terminal aberto na pasta raiz da solução, execute:

```bash
dotnet test
```

O comando irá compilar os projetos e executar todos os testes unitários.

A suíte deve apresentar **4 testes aprovados e 0 testes com falha**.

## Autor

**Kaio Moreira**

Projeto acadêmico desenvolvido para a disciplina de **Garantia e Qualidade de Software**.
