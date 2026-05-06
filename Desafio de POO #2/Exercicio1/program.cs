using P2__Desafio_1;

//Diretor diretor = new Diretor("Thiago", 30, 32650.20, 40);
//Gerente gerente = new Gerente("Mario", 25, 15000.00, 1120.35);

/*Console.WriteLine("O salario do Diretor é de {0:C2}",diretor.GetSalario());
diretor.AumentarSalario(20);
Console.WriteLine("O salario do Diretor é de {0:C2}", diretor.GetSalario());
Console.WriteLine("O salario com a bonificao é de {0:C2}", diretor.CalcularSalario());
Console.WriteLine("----------------------------");

Console.WriteLine("O salario do Gerente é de {0:C2}", gerente.GetSalario());
gerente.AumentarSalario(20);
Console.WriteLine("O salario do Gerente é de {0:C2}", gerente.GetSalario());
Console.WriteLine("O salario com a bonificao é de {0:C2}", gerente.CalcularSalario());
Console.WriteLine("----------------------------");*/

List<Funcionario> baseFuncionarios = new List<Funcionario>()
{
 new Diretor("Thiago", 30, 32650.20, 40),
 new Gerente("Mario", 25, 15000.00, 1120.35),
 new FuncionarioRegular("Gustavo",20,1105.50)
};



foreach(Funcionario clt in baseFuncionarios)
{
    if (clt is Diretor)
    {
        Diretor diretor = (Diretor)clt;
        Console.WriteLine($"O nome do diretor é {diretor.GetNome()}");
        Console.WriteLine("O salario do Diretor é de {0:C2}", diretor.GetSalario());
        diretor.AumentarSalario(20);
        Console.WriteLine("O salario do Diretor com aumento é de {0:C2}", diretor.GetSalario());
        Console.WriteLine("O salario com a bonificao é de {0:C2}", diretor.CalcularSalario());
        Console.WriteLine("-------------");
    }
    else if (clt is Gerente)
    {
        Gerente gerente = (Gerente)clt;
        Console.WriteLine($"O nome do gerente é {gerente.GetNome()}");
        Console.WriteLine("O salario do Gerente é de {0:C2}", gerente.GetSalario());
        gerente.AumentarSalario(20);
        Console.WriteLine("O salario do Gerente com aumento é de {0:C2}", gerente.GetSalario());
        Console.WriteLine("O salario com a bonificao é de {0:C2}", gerente.CalcularSalario());
        Console.WriteLine("-----------------------------------------");

    }
    else if (clt is FuncionarioRegular) 
    {
        FuncionarioRegular funcionarioRegular = (FuncionarioRegular)clt;
        Console.WriteLine($"O nome do funcionario é {funcionarioRegular.GetNome()}");
        Console.WriteLine("O salario do funcionario regular é de {0:C2}", funcionarioRegular.GetSalario());
    }
}
