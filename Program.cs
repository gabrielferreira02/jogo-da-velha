namespace JogoDaVelhaConsole;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======= PEDRA PAPEL E TESOURA =======");
        Console.WriteLine("1 - Pedra\n2 - Papel\n3 - Tesoura");
        Mao player1;
        Mao player2;
        int player1Count = 0;
        int player2Count = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Rodada {i} ---------");
            player1 = LerJogada(1);
            player2 = LerJogada(2);
            Console.WriteLine("Resultado da rodada ----------");
            Console.WriteLine($"Jogador 1: {player1}");
            Console.WriteLine($"Jogador 2: {player2}");

            var winner = Jogo.Jogar(player1, player2);
            Console.WriteLine($"Vencedor: {winner}");
            ValidateResult(ref player1Count, ref player2Count, winner);
        }

        Console.WriteLine("Resultado Final --------");
        Console.WriteLine($"Jogador 1 ({player1Count} x {player2Count}) Jogador 2");
    }

    private static void ValidateResult(ref int player1, ref int player2, Resultado winner)
    {
        if (winner == Resultado.PLAYER_1)
        {
            player1++;
            return;
        }

        if (winner == Resultado.PLAYER_2)
        {
            player2++;
            return;
        }

    }

    private static Mao LerJogada(int i)
    {
        Console.WriteLine($"Jogador {i}: ");
        while (true)
        {
            var tecla = Console.ReadKey(intercept: true);

            if (char.IsDigit(tecla.KeyChar))
            {
                int jogada = int.Parse(tecla.KeyChar.ToString());
                if (jogada >= 1 && jogada <= 3) return (Mao)jogada;
            }

            Console.WriteLine("Jogada inválida, tente novamente!");

        }

    }
}

