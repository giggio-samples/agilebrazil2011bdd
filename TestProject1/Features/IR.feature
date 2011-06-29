#language: pt-br

@web
Funcionalidade: Cálculo do IR
	Enquanto contrinbuinte
	Eu gostaria de saber o valor do IR
	Para que eu possa planejar melhor minhas finanças
	
Cenário: Desempregado
	Dado um contribuinte que ganha 0.00 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 0.00 reais
	
Cenário: Isento no limite
	Dado um contribuinte que ganha 1499.15 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 0.00 reais

Cenário: Primeira faixa
	Dado um contribuinte que ganha 2000 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 37.57 reais
	
Cenário: Segunda faixa
	Dado um contribuinte que ganha 2500 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 94.06 reais

Cenário: Terceira faixa
	Dado um contribuinte que ganha 3000 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 169.38 reais

Cenário: Quarta faixa
	Dado um contribuinte que ganha 4000 reais por mês
	Quando ele solicita o cálculo do IR
	Então ele deve confirmar que vai pagar 407.22 reais
