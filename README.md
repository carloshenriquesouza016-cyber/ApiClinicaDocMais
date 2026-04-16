# 🏥 DocMais - Sistema de Gestão para Clínica Médica

## 📌 Descrição
O **DocMais** é um sistema desenvolvido para gerenciar o funcionamento de uma clínica médica, permitindo o controle de pacientes, médicos, agendamentos e atendimentos em tempo real.

O objetivo do projeto é simular um ambiente real de clínica, organizando desde o cadastro até a finalização da consulta.

---

## ⚙️ Funcionalidades

### 👤 Gestão de Pacientes
- Cadastro de pacientes  
- Listagem de pacientes  
- Busca por paciente (CPF ou nome)  
- Edição de dados  
- Exclusão de paciente  

**Dados armazenados:**
- Nome  
- CPF  
- Telefone  
- Email  
- Data de nascimento  
- Endereço  
- Prioridade  

---

### 👨‍⚕️ Gestão de Médicos
- Cadastro de médicos  
- Listagem de médicos  
- Busca de médico  
- Edição de médico  
- Exclusão de médico  

**Dados armazenados:**
- Nome  
- Especialidade *(opcional)*  

---

### 📅 Agendamentos
- Criação de agendamentos  
- Listagem de consultas  
- Busca de agendamentos  
- Edição de agendamentos  
- Cancelamento de consultas  

**Regras do sistema:**
- Todo agendamento inicia com status **Agendado**  
- Não é permitido agendar datas passadas  
- Evita conflito de horários para o mesmo médico  

**Status possíveis:**
- Agendado  
- Cancelado  
- Concluído  

---

### 📢 Sistema de Chamada
- Listagem de pacientes em espera  
- Chamada do próximo paciente  
- Atualização do status da chamada  
- Finalização do atendimento  

**Status possíveis:**
- Aguardando  
- Chamado  
- Atendido  

---

## 🔄 Fluxo do Sistema

1. Paciente é cadastrado  
2. Médico é cadastrado  
3. Consulta é agendada  
4. Paciente entra na fila de atendimento  
5. Paciente é chamado  
6. Atendimento é realizado  
7. Consulta é finalizada  

---

## 🧠 Tecnologias Utilizadas
- C#  
- ASP.NET Core Web API  
- Programação Orientada a Objetos (POO)  

---

## 🚀 Melhorias Futuras
- Implementação de banco de dados  
- Sistema de autenticação (login)  
- Relatórios de atendimento  
- Controle de usuários  
- Integração com frontend  

---

## 📄 Objetivo do Projeto
Este projeto foi desenvolvido com fins educacionais, com o objetivo de praticar conceitos de desenvolvimento backend, organização de código e construção de APIs REST.

---

## Carlos Henrique
###carloshenriquesouza016gmail.com
