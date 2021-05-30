using System;
using GameTOP.LIB;

namespace GameTOP
{
class JogoFODA
{
    private Jogador Jogador;

    public JogoFODA(Jogador jogador)
    {
        Jogador = jogador;
    }
    public void IniciarJogo()
    {
        Jogador.Chuta();
        Jogador.Passa();
    }

}

}