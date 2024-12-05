namespace ApiComBanco.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int BookId  { get; set; }

        public Book Book { get; set; }
    }
}
