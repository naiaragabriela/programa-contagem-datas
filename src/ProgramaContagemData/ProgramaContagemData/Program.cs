int data1, data2, dias;
dias = 0;


int DataInicial()
{
    Console.WriteLine("Informe o primeiro ano");
    return int.Parse(Console.ReadLine());
}
int DataFinal()
{
    Console.WriteLine("Informe o segundo ano");
    return int.Parse(Console.ReadLine());
}

data1 = DataInicial();
data2 = DataFinal();




if (data2 > data1)

{
    for (int ano = data1; ano <= data2; ano++)
    {
        dias = (data2 - data1 + 1) * 365;

        if (data1 % 4 == 0 && dias % 100 != 0)
        {
            dias += 1;
        }
    }

    Console.WriteLine($"A quantidade de dias entre o ano de {data1} até o ano de {data2} é: {dias} dias");
}



if (data2 < data1)
{
    Console.WriteLine("Não é possível ter uma quantidade de dias negativos");
}
if (data2 == data1)
{
    Console.WriteLine("A quantidade de dias durante as datas é zero");
}










