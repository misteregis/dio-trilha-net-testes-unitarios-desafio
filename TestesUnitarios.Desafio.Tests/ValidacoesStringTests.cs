using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    [Theory]
    [InlineData("Matrix", 6)]
    [InlineData("", 0)]
    [InlineData("Hello", 5)]
    [InlineData("12345", 5)]
    public void DeveRetornarQuantidadeCaracteresDaPalavra(string texto, int resultadoEsperado)
    {
        // Arrange / Act
        var resultado = ValidacoesString.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData("Esse é um texto qualquer", "qualquer", true)]
    [InlineData("Outro texto de exemplo", "inexistente", false)]
    public void DeveConterAPalavraNoTexto(string texto, string textoProcurado, bool resultadoEsperado)
    {
        // Arrange / Act
        var resultado = ValidacoesString.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData("Esse é um texto qualquer", "teste", false)]
    [InlineData("Outro texto para teste", "teste", true)]
    [InlineData("Este é um test", "teste", false)]
    public void NaoDeveConterAPalavraTesteNoTexto(string texto, string textoProcurado, bool resultadoEsperado)
    {
        // Arrange / Act
        var resultado = ValidacoesString.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData("Começo, meio e fim do texto procurado", "procurado", true)]
    [InlineData("Outro exemplo de texto", "exemplo", false)]
    [InlineData("Um caso especial de teste", "teste", true)]
    public void TextoDeveTerminarComAPalavra(string texto, string textoProcurado, bool resultadoEsperado)
    {
        // Arrange / Act
        var resultado = ValidacoesString.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
