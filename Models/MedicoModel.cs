namespace clinicaDocMais.Models
{
    public class MedicoModel
    {
        public string? nome { get; set; }
        public string? crm { get; set; }
        public string? endereco { get; set; }
        public string? telefone { get; set; }
        public string? dataNascimento { get; set; }
        public string? especialidade { get; set; }


        public MedicoModel(string? nome, string? crm, string? endereco, string? telefone, string? dataNascimento, string? especialidade)
        {
            this.nome = nome;
            this.crm = crm;
            this.endereco = endereco;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.especialidade = especialidade;
        }


    }
}