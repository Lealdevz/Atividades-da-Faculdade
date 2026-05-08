import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class ScientificCalculatorTest {

    // setup que eu ja consigo instanciar o objeto antes de realizar o teste, vou mostrar no terceiro teste
    private ScientificCalculator calculadoraInstanciada;

    @BeforeEach
    void setup() {
        calculadoraInstanciada = new ScientificCalculator();
    }

    // ------------------------------------------------------------------------------------------- //

    @Test
    void deveSomarDoisNumeros() {
        double numero1 = 10;
        double numero2 = 20;
        ScientificCalculator calculadora = new ScientificCalculator();

        assertEquals(30, calculadora.add(numero1, numero2));
    }

    @Test
    void deveSubtrairDoisNumeros() {
        // setup
        ScientificCalculator calculadora = new ScientificCalculator();
        double numero1 = 30;
        double numero2 = 10;

        // execution
        double resultado = calculadora.subtract(numero1, numero2);

        // assertion
        assertEquals(20, resultado);
    }

    @Test
    void deveSomarDoisNumerosComObjetoInstanciado() {
        double numero1 = 20;
        double numero2 = 30;

        assertEquals(50, calculadoraInstanciada.add(numero1, numero2));
    }

    @Test
    void deveCalcularRaizDeUmNumeroPositivo() {
        double numero1 = 100;

        assertEquals(10, calculadoraInstanciada.squareRoot(numero1));
    }

    @Test
    void deveLancarExcecaoQuandoRaizQuadradaNegativa() {
        double numero1 = -100;

        assertThrows(IllegalArgumentException.class, () -> {
            calculadoraInstanciada.squareRoot(numero1);
        });
    }

    @Test
    void deveLancarExcecaoQuandoTentarDividirPorZero() {
        double numero1 = 100;
        double numero2 = 0;

        assertThrows(IllegalArgumentException.class, () -> {
            calculadoraInstanciada.divide(numero1, numero2);
        });
    }

    @Test
    void deveCalcularLogNumerosPositivos() {
        assertEquals(Math.log(100), calculadoraInstanciada.log(100));
        assertEquals(Math.log(1000), calculadoraInstanciada.log(1000));
    }

    @Test
    void deveCalcularSenoNumerosPositivos() {
        assertEquals(1, calculadoraInstanciada.sin(90), 0.0001);
        assertEquals(0, calculadoraInstanciada.sin(180), 0.0001);
    }
}
