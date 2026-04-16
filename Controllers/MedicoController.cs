using clinicaDocMais.Models;
using ClinicaDocMais.Models;
using ClinicaDocMais.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Runtime.CompilerServices;

namespace clinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {

        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();

        public MedicoModel? Medico { get; private set; }

        [HttpPost("cadastroMedico")]
        public string cadastrarMedico([FromBody] MedicoModel medico)
        {

            listaMedicos.Add(medico);
            return $"Dr. {medico.nome}cadastrodo com sucesso";
        }
        //listar os medicos
        [HttpGet("listaMedico")]
        public List<MedicoModel> listarMedicos()

        {
            return listaMedicos;
        }
        //editar medico

        [HttpPut("editarMedico/{crm}")]
        public string editarMedico([FromBody] MedicoModel medicoEditado, string crm)
        {
            MedicoService medico = new MedicoService();
            medico.editarMedico(medicoEditado, crm);

            if (medico == null)
            {
                return "Médico não encontrado";
            }
            else
            {
                return $"Médico de CRM Nº {crm} editado com sucesso";
            }
        }
    
        
        //excluir medico
        [HttpDelete("deletarMedico/{crm}")]
        public string deletarMedico(string crm)
        {
            foreach (var medico in listaMedicos)
            {
                if (medico.crm == crm)
                {
                    listaMedicos.Remove(medico);
                    return $"medico com crm {crm} removido com sucesso";
                }
            }
            return "medico nao encotrado.";
        }

        [HttpGet("buscaMedico/{crm}")]
        public MedicoModel? BuscarMedico(string crm)
        {
            foreach (var medico in listaMedicos)
            {
                if (medico.crm != crm)
                {
                    continue;
                }
                return Medico;
            }
            return null;
        }
    }
}