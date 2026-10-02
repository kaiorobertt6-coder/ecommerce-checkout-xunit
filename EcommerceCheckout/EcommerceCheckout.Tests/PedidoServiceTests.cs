using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveRetornarMascaraExata()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        // Assert
        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveCalcularPontosCorretamente()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.CalcularPontosFidelidade(150);

        // Assert
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarTrue_ParaClienteVIPAbaixoDe200()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.TemDireitoAFreteGratis(150, true);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarFalse_ParaClienteNaoVIPAbaixoDe200()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.TemDireitoAFreteGratis(150, false);

        // Assert
        Assert.False(resultado);
    }
}