// Faça um programa que receba o valor total da fatura, o percentual para o pagamento mínimo e a taxa de juros mensais. 

const double taxaIofMes = 0.0038;
const double taxaIofDia = 0.000082;



Console.WriteLine("--- ");

Console.Write("Valor total da fatura (R$)........: ");
decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

Console.Write("Pagamento mínimo (%)..............: ");
double percentualMinimo = Convert.ToDouble(Console.ReadLine()) / 100 ;

Console.Write("Taxa de juros mensais (%).........: ");
double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100 ;

decimal valorMinimo = valorTotal * Convert.ToDecimal(percentualMinimo);

decimal valorNaoPago = valorTotal - valorMinimo;
decimal valorJuros = valorNaoPago * Convert.ToDecimal(taxaJuros);
decimal valoriofMes = valorNaoPago * Convert.ToDecimal(taxaIofMes);
decimal valoriofDia = valorNaoPago * Convert.ToDecimal(taxaIofDia * 30);

decimal valorProximaFatura = valorNaoPago + valorJuros + valoriofMes + valoriofDia;
decimal custoRotativo = valorProximaFatura - valorNaoPago;

Console.WriteLine($"\nValor do pagamento mínimo.............: R$ {valorMinimo:C}");

Console.WriteLine($"Valor não pago..........................: R$ {valorNaoPago:C}");
Console.WriteLine($"Juros...................................: R$ {valorJuros:C}");
Console.WriteLine($"IOf mesnsal.............................: R$ {valoriofMes:C}");
Console.WriteLine($"IOf diário..............................: R$ {valoriofDia:C}");

Console.WriteLine($"\nValor a pagar na próxima fatura.......: R$ {valorProximaFatura:C}");
Console.WriteLine($"Custo do crédito rotativo ..............: R$ {custoRotativo:C}");


