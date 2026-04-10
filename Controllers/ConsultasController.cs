using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        //Método Http que retorne os pacientes atenditos hoje (nome)

        [HttpGet("atendidosHoje")]
        public List<string> pacientesAtendidosHoje()
        {
            //Lógica para retornar os nomes dos pacientes (pelo menos 3)
            List<string> pacientes = new List<string>
            {
                "Felipe Firmino",
                "Robson Silva",
                "Carlos Henrique"
           };
            return pacientes;
        }
    }
}
       