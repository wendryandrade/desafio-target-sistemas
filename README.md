# Desafio Técnico 

## Desenvolvedor de Sistemas Jr - Target Sistemas  

**Wendrya Andrade Oliveira**

Este repositório contém as soluções dos 5 exercícios propostos no processo seletivo para a vaga de Desenvolvedor de Sistemas Jr na Target Sistemas.  

Cada exercício está implementado como um projeto de console C# separado (.NET 8), com foco em clareza, boas práticas e funcionalidade.

---

## 📋 Exercícios

### ✅ Exercício 1 – Cálculo de soma utilizando repetição `while`
Calcula a soma dos números de 1 até 13 utilizando `while`.

**Resposta:** 91

---

### ✅ Exercício 2 – Verifica se número pertence à sequência de Fibonacci
Recebe um número digitado pelo usuário e verifica se ele pertence à sequência de Fibonacci.  
Mostra a sequência até o número informado e trata entradas inválidas.

📥 Entrada via console

**Resposta:**  
O programa verifica se o número pertence à sequência de Fibonacci e exibe o resultado no console.

---

### ✅ Exercício 3 – Análise de Faturamento Mensal
Lê o arquivo `dados.json` contendo o faturamento diário do mês e calcula:
- Menor valor
- Maior valor
- Média mensal (ignorando dias com valor 0)
- Número de dias acima da média

📄 **Arquivo externo:** `dados.json`  
📝 Leitura feita com `System.Text.Json`

**Resposta:**  
- Menor faturamento: R$ 373,78  
- Maior faturamento: R$ 48.924,24  
- Média mensal: R$ 20.865,37  
- Dias com faturamento acima da média: 10

---

### ✅ Exercício 4 – Percentual de Representação por Estado
Calcula e exibe o percentual de representação de cada estado no faturamento total de acordo com os dados fornecidos.

**Resposta:**  
- Total: R$ 180.759,98  
- SP: 37,53%  
- RJ: 20,29%  
- MG: 16,17%  
- ES: 15,03%  
- Outros: 10,98%

---

### ✅ Exercício 5 – Inversão de String
Recebe uma palavra ou frase digitada pelo usuário e imprime o texto original e o texto invertido.  
Não utiliza funções prontas como `Reverse()`.
 
📥 Entrada via console

**Resposta:**  
O programa percorre a string de trás pra frente e monta manualmente a versão invertida, exibindo o original e o resultado final no console.

---

## ▶️ Como executar

- Abra os projetos individualmente no Visual Studio 2022 ou superior e compile
- No Exercício 3, verifique se o arquivo `dados.json` está presente no diretório bin/Debug/net8.0 ou se está com a propriedade "Copiar para o diretório de saída" ativada.

---

## ✔️ Observações

- Código escrito com foco em clareza, lógica e legibilidade
- Comentários explicativos incluídos
- Sem uso de métodos avançados ou prontos (conforme solicitado)
- Projetos separados para facilitar navegação e testes
