namespace backend.Entities // Certifique-se de que o namespace corresponda ao seu projeto
{
    public class Cadastro
{
    public int Id { get; set; }
    public string NomeCadastro { get; set; }
    public string Nickname { get; set; } // Verifique se essa propriedade existe
    public string EmailCadastro { get; set; } // Verifique se essa propriedade existe
    public string SenhaCadastro { get; set; } // Verifique se essa propriedade existe
    public string TelCadastro { get; set; } 

    public ICollection<RegistroDePartida> RegistroDePartidas { get; set; } // Relacionamento
}   

}

