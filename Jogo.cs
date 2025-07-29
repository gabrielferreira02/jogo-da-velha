namespace JogoDaVelhaConsole;

public static class Jogo
{
    public static Resultado Jogar(Mao player1, Mao player2)
    {
        return (player1, player2) switch
        {
            (Mao.PEDRA, Mao.PAPEL) => Resultado.PLAYER_2,
            (Mao.PEDRA, Mao.TESOURA) => Resultado.PLAYER_1,
            (Mao.PAPEL, Mao.PEDRA) => Resultado.PLAYER_1,
            (Mao.PAPEL, Mao.TESOURA) => Resultado.PLAYER_2,
            (Mao.TESOURA, Mao.PAPEL) => Resultado.PLAYER_1,
            (Mao.TESOURA, Mao.PEDRA) => Resultado.PLAYER_2,
            _ => Resultado.EMPATE,
        };
    }
}
