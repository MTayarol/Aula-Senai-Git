Departamento departamento = departamentos
    .FirstOrDefault(d => d.GetId() == idDepartamento);

if (departamento == null)
{
    Console.WriteLine("Departamento não encontrado.");
    return;
}