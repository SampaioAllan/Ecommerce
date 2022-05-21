namespace Ecommerce.Lib.Models
{
    public class Usuario
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        public Usuario(string nome, string email, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetSenha(senha);
        }
        private void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        private void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        private void SetSenha(string senha)
        {
            Senha = senha;
        }
        public string GetSenha()
        {
            return Senha;
        }
    }
}