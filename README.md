# Sistema de Hospedagem

Um sistema console simples para gerenciamento de hospedagem desenvolvido em C# .NET 9.0.

## Funcionalidades

- **Cadastro de Hóspedes**: Registre pessoas com nome e sobrenome
- **Cadastro de Suítes**: Crie suítes com diferentes tipos (Simples, Luxo, Premium), capacidade e valor da diária
- **Reservas**: Reserve quartos associando hóspedes às suítes disponíveis
- **Listagem de Reservas**: Visualize todas as reservas realizadas
- **Desconto Automático**: Desconto de 10% para reservas de 10 dias ou mais

## Estrutura do Projeto

```
Hospedagem/
├── Models/
│   ├── Pessoa.cs          # Modelo para hóspedes
│   ├── Suite.cs           # Modelo para suítes
│   └── Reserva.cs         # Modelo para reservas
├── Services/
│   ├── HospedeService.cs  # Serviços relacionados a hóspedes
│   ├── SuiteService.cs    # Serviços relacionados a suítes
│   └── ReservaService.cs  # Serviços relacionados a reservas
└── Program.cs             # Programa principal
```

## Como Usar

1. Clone o repositório
2. Navegue até o diretório do projeto
3. Execute o projeto:
   ```bash
   dotnet run
   ```

## Menu Principal

1. **Cadastrar Hóspede** - Adicione novos hóspedes ao sistema
2. **Cadastrar Suíte** - Registre novas suítes disponíveis
3. **Reservar Quarto** - Crie uma nova reserva
4. **Listar Reservas** - Visualize todas as reservas
5. **Fechar Programa** - Encerra a aplicação

## Regras de Negócio

- Não é possível cadastrar hóspedes em uma reserva sem ter uma suíte associada
- O número de hóspedes não pode exceder a capacidade da suíte
- Reservas de 10 dias ou mais recebem desconto de 10%
- Cada entidade possui um ID único gerado automaticamente

## Tecnologias

- C# .NET 9.0
- Console Application

## Requisitos

- .NET 9.0 SDK

---

*Sistema desenvolvido para gerenciamento básico de hospedagem com interface de console.*
