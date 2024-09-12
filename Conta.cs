public class Conta
{
    public string nome;
    public int numero;
    public int senha; 
    public int saldo;

    public Conta(string nomeDousuario, int numeroDaconta, int senhaDaconta, int saldoDaconta)
    {
        nome = nomeDousuario;
        numero = numeroDaconta;
        senha = senhaDaconta;
        saldo = saldoDaconta; 
    }
}
