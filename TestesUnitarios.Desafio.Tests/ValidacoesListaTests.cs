using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    [Theory]
    [InlineData(new[] { 5, -1, -8, 9 }, new[] { 5, 9 })]
    [InlineData(new[] { -3, -2, -1 }, new int[] { })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    public void DeveRemoverNumerosNegativosDeUmaLista(int[] entrada, int[] esperado)
    {
        // Act
        List<int> lista = new(entrada);
        List<int> resultadoEsperado = new(esperado);

        // Act
        var resultado = ValidacoesLista.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new[] { 5, -1, -8, 9 }, 9, true)]
    [InlineData(new[] { 5, -1, -8, 9 }, 10, false)]
    public void DeveVerificarSeContemNumeroNaLista(int[] entrada, int numero, bool resultadoEsperado)
    {
        // Arrange
        List<int> lista = new(entrada);

        // Act
        var resultado = ValidacoesLista.ListaContemDeterminadoNumero(lista, numero);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new[] { 5, -1, -8, 9 }, 10, false)]
    [InlineData(new[] { 1, 2, 3, 4 }, 10, false)]
    [InlineData(new[] { 10, 20, 30, 40 }, 10, true)]
    public void NaoDeveConterONumeroNaLista(int[] entrada, int numeroParaProcurar, bool resultadoEsperado)
    {
        // Arrange
        List<int> lista = new(entrada);

        // Act
        var resultado = ValidacoesLista.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new[] { 5, 7, 8, 9 }, new[] { 10, 14, 16, 18 })]
    [InlineData(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] entrada, int[] resultadoEsperado)
    {
        // Arrange
        List<int> lista = new(entrada);

        // Act
        var resultado = ValidacoesLista.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new[] { 5, -1, -8, 9 }, 9)]
    [InlineData(new[] { 0, 0, 0 }, 0)]
    public void DeveRetornarMaiorNumeroDaLista(int[] entrada, int resultadoEsperado)
    {
        // Arrange
        List<int> lista = new(entrada);

        // Act
        var resultado = ValidacoesLista.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new[] { 5, -1, -8, 9 }, -8)]
    [InlineData(new[] { 0, 0, 0 }, 0)]
    public void DeveRetornarMenorNumeroDaLista(int[] entrada, int resultadoEsperado)
    {
        // Arrange
        List<int> lista = new(entrada);

        // Act
        var resultado = ValidacoesLista.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
