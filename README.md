# 🎭 Polimorfismo em C# - Sistema de Descontos

Este repositório contém um projeto prático de estudo em **C#** focado em demonstrar o pilar do **Polimorfismo** na Programação Orientada a Objetos (POO).

## 🚀 Sobre o Projeto
O código simula um sistema de cálculo de descontos em folha de pagamento (Vale Alimentação e Vale Transporte) para diferentes tipos de funcionários de uma empresa. O objetivo é mostrar como o mesmo comando pode ter comportamentos diferentes dependendo de qual funcionário está sendo processado.

## 🧠 Conceitos de POO Aplicados
Este projeto explora os seguintes conceitos:

* **Polimorfismo de Sobrescrita:** A capacidade de um método com o mesmo nome executar lógicas diferentes.
* **Palavra-chave `virtual`:** Utilizada no método `valeAlimentacao` da classe base `Desconto` para permitir que classes filhas modifiquem o seu comportamento.
* **Palavra-chave `override`:** Utilizada na classe filha `Gerente` para reescrever a regra do Vale Alimentação (alterando a taxa de 10% para 20%), enquanto outras classes (como `Estagiario`) mantêm a regra padrão.
* **Instanciação Polimórfica:** No arquivo principal, objetos específicos (`Estagiario`, `Gerente`, `Atendente`) são instanciados e tratados através de uma referência da sua classe base (`Desconto`), acionando os métodos corretos automaticamente.

## 🛠️ Tecnologias Utilizadas
* C#
* .NET Console App

## 💻 Como Executar
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone este repositório no seu computador:
   ```bash
   git clone [https://github.com/NatBaracho/polimorfismo.git](https://github.com/NatBaracho/polimorfismo.git)
