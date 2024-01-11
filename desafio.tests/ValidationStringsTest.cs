using desafio.console.services;
namespace desafio.tests;

public class ValidationStringsTest
{
    private ValidationStrings _validations;

    public ValidationStringsTest()
    {
        _validations = new ValidationStrings();    
    }
      [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {

        // Arrange
        var texto = "matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validations.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
         bool result = _validations.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validations.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validations.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}