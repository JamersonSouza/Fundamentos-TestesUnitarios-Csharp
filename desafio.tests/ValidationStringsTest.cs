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
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "a";
        var resultadoEsperado = 0;

        // Act
        var resultado = _validations.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         _validations.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(true);
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
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(true);
    }

    //TODO: Corrigir a anotação [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "teste";

        // Act
        var resultado = _validations.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}