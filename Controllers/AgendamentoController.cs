using clinicaDocMais.Models;
using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class AgendamentoController : ControllerBase
    {
        public static List<AgendamentoModel> listaDeAgendamento = new List<AgendamentoModel>();

        [HttpPost("agendarconsulta")]
        public async Task<IActionResult> AgendarConsulta([FromBody] PacienteModel pacienteAgendado, MedicoModel medicoAgendado, DateTime dataHoraAgendada)
        {
            try
            {
                AgendamentoModel agendamentoAtual = new AgendamentoModel();
                agendamentoAtual.nomePaciente = pacienteAgendado.nome;
                agendamentoAtual.nomeMedico = medicoAgendado.nome;
                agendamentoAtual.telefonePaciente = pacienteAgendado.telefone;
                agendamentoAtual.cpfPaciente = pacienteAgendado.nome;
                agendamentoAtual.crmMedico = medicoAgendado.crm;
                agendamentoAtual.especialidadeMedico = medicoAgendado.especialidade;
                agendamentoAtual.dataHoraAgendamento = dataHoraAgendada;
                listaDeAgendamento.Add(agendamentoAtual);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro Inesperado: " + ex.Message);
            }
        }
    }
}
    

