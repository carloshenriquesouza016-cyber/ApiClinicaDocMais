namespace ClinicaDocMais.Models
{
    public class PacienteModel
    {
        public string? cpf { get; set; }
        public string? nome { get; set; }
        public string? telefone { get; set; }
        public string? dataNascimento { get; set; }
        public string? endereco { get; set; }
        public string? prioridade { get; set; }
        public string? email { get; set; }
        public string crm { get; internal set; }


        public PacienteModel(string? cpf, string? nome, string? dataNascimento)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            
        }
    }
}