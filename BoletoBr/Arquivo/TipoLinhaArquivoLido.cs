﻿
namespace BoletoBr.Arquivo
{
    public enum TipoLinhaLido
    {
        HeaderDeArquivo = 1,
        HeaderDeLote = 10,
        Detalhe = 11,
        DetalheSegmentoW = 20,
        DetalheSegmentoE = 30,
        DetalheSegmentoT = 40,
        DetalheSegmentoU = 50,
        TraillerDeLote = 90,
        TraillerDeArquivo = 99,
    }

}
