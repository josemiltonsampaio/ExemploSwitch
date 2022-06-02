public static class Program
{
    public enum Direcao
    {
        Cima,
        Baixo,
        Direita,
        Esquerda
    }

    public enum Orientacao
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    public static void Main()
    {
        var direcao = Direcao.Esquerda;
        Console.WriteLine($"Direção: {direcao}");
        Console.WriteLine($"Ponto cardeal {ParaOrientacao_Instrucao(direcao)}");
        Console.WriteLine($"Desconto para abc: {Desconto("abc")}");
    }

    public static Orientacao ParaOrientacao_Instrucao(Direcao direcao)
    {
        switch (direcao)
        {
            case Direcao.Cima:
                return Orientacao.Norte;
            case Direcao.Baixo:
                return Orientacao.Sul;
            case Direcao.Direita:
                return Orientacao.Leste;
            case Direcao.Esquerda:
                return Orientacao.Oeste;
            default:
                throw new ArgumentOutOfRangeException(nameof(direcao), $"Valor não esperado: {direcao}");
        }
    }

    public static Orientacao ParaOrientacao_Expressao(Direcao direcao) => direcao switch
    {
        Direcao.Cima => Orientacao.Norte,
        Direcao.Direita => Orientacao.Leste,
        Direcao.Baixo => Orientacao.Sul,
        Direcao.Esquerda => Orientacao.Oeste,
        _ => throw new ArgumentOutOfRangeException(nameof(direcao), $"Valor não esperado: {direcao}"),
    };

    public static int Desconto(string cargo)
    {
        return cargo switch
        {
            "administrativo" => 10,
            "gerencia" => 20,
            "diretoria" => 30,
            _ => 0
        };
    }
}
