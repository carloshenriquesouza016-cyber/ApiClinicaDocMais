
        namespace ClinicaDocMais.Models
        {
        
            public class AgendamentoModel
        {
            // PACIENTE //
            public string? nomePaciente { get; set; }
            public string? cpfPaciente { get; set; }
            public string? telefonePaciente { get; set; }

            // MEDICO //
            public string? nomeMedico { get; set; }
            public string? crmMedico { get; set; }
            public string? especialidadeMedico { get; set; }

            // ATENDIMENTO //
            public DateTime dataHoraAgendamento { get; set; }

            // AGENDAMENTO //
            public bool pacientePresente { get; set; } 
            public bool medicoPresente { get; set; }
      }
    }


