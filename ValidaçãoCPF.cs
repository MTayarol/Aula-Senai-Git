static bool ValidarCPF(string cpf)
{
    cpf = cpf.Replace(".", "").Replace("-", "");

    if (cpf.Length != 11)
        return false;

    return cpf.All(char.IsDigit);
}