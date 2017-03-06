namespace WebForLink.Domain.Entities
{
    public class Usuario
    {
        protected Usuario()
        {
        }
        public Usuario(string login)
        {
            Login = login;
        }
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public void SetLogin(string login) { Login = login; }
        public void SetSenha(string senha) { Senha = senha; }
    }
}
