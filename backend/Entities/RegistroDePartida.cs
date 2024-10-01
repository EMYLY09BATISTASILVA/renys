namespace backend.Entities // Certifique-se de que o namespace corresponda ao seu projeto
{
    public class RegistroDePartida
    {
        public int Id { get; set; }
        public int CadastroId { get; set; }
        public int QntPartida { get; set; }
        public int QntVitoria { get; set; }
        public int QntDerrota { get; set; }
        public int QntEmpate { get; set; }
        
        public Cadastro Cadastro { get; set; } // Relacionamento
    }
}
