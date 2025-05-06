# 📚 Sistema de Reservas de Salas de Estudo

Este é um sistema de console em C# desenvolvido como trabalho prático para a disciplina de Programação Orientada a Objetos. O objetivo é permitir o registro de reservas de salas de estudo, com base em uma configuração de datas e horários válidos.

---

## ✅ Funcionalidades

- Configuração de datas e horários permitidos para reserva.
- Registro de reservas com:
  - Data e hora
  - Capacidade da sala (entre 1 e 39)
  - Descrição da sala
- Validação automática dos dados inseridos.
- Exibição de mensagens de erro e sucesso.
- Uso de Programação Orientada a Objetos (POO): Abstração, Encapsulamento e Separação de Responsabilidades.

---

## 🧱 Estrutura do Projeto

SistemaReservaSalas/
│
├── Modelos/
│   ├── ConfiguracaoReserva.cs   # Define a configuração válida de datas e horários
│   └── Reserva.cs               # Representa uma reserva e contém validações
│
└── Program.cs                   # Ponto de entrada da aplicação


---

## 🧠 Conceitos Aplicados

- **Encapsulamento:** Atributos privados com acesso controlado por métodos.
- **Abstração:** Divisão clara entre a lógica de configuração e de reserva.
- **Validações:** Centralizadas nas classes com mensagens amigáveis ao usuário.
- **Reuso de código:** Uso da mesma instância de configuração para várias reservas.

---

## 💻 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/bolivia00/SistemaReservaSalas.git
