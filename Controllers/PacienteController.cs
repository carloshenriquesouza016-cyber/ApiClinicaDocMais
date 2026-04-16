using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : Controller
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();

        // cadastrarPaciente //

        [HttpGet("listarPaciente")]
        public string casa()
        {
            return "casa";
        }

        [HttpGet("nomePaciente")]
        public string paciente()
        {
            string nome = "Giovanni";
            return "Paciente: " + nome;
        }

        [HttpGet("listaPacientes")]
        public List<string> listaNome()
        {
            List<string> listaPacientes = new List<string>();
            listaPacientes = ["Giovanni", "Carlos", "Pedro"];
            return listaPacientes;
        }


        [HttpGet("buscaPaciente /{id}")]
        public PacienteModel? buscarPacientes(string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf == id) ;
                {
                    return paciente;
                }
            }

            return null;
        }

        [HttpGet("editarPaciente/{id}")]
        public string editarPaciente([FromBody] PacienteModel pacienteEditado, string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf == id)
                {
                    paciente.cpf = pacienteEditado.cpf;
                    paciente.nome = pacienteEditado.nome;
                    paciente.telefone = pacienteEditado.telefone;
                    paciente.email = pacienteEditado.email;
                    paciente.dataNascimento = pacienteEditado.dataNascimento;
                    paciente.endereco = pacienteEditado.endereco;
                    return $"Paciente {paciente.nome}, cpf anterior: {id} editado com sucesso";

                }
            }
            return "Paciente não encontrado.";
        }
        [HttpDelete("deletarPaciente/{id}")]
        public string deletarPaciente(string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf == id)
                {
                    listaPaciente.Remove(paciente);
                    return $"Paciente com CPF {id} removido com sucesso!";
                }
            }

            return "Paciente não encontrado.";
        }                                              
    }
}