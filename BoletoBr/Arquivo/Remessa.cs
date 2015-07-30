﻿using BoletoBr.Enums;

namespace BoletoBr.Arquivo
{
    /// <summary>
    /// Contém informações que são pertinentes a um boleto, mas para geração da Remessa. Não são necessárias para Impressão do Boleto
    /// Autor: sidneiklein Data: 09/08/2013
    /// </summary>
    public class Remessa
    {
        public enum EnumTipoAmbiemte
        {
            Homologacao,
            Producao
        }
        //
        #region Atributos e Propriedades

        /// <summary>
        /// Variável que define se a Remessa é para Testes ou Produção
        /// </summary>
        public EnumTipoAmbiemte Ambiente { get; set; }

        /// <summary>
        /// Código de Ocorrência Utilizado na geração da Remessa.
        /// |Identificado no Banrisul        como "CODIGO OCORRENCIA" by sidneiklein|
        /// |Identificado no Banco do Brasil como "COMANDO"           by sidneiklein|
        /// </summary>
        public EnumCodigoOcorrenciaRemessa CodigoOcorrencia { get; set; }

        /// <summary>
        /// Tipo Documento Utilizado na geração da remessa. |Identificado no Banrisul by sidneiklein|
        /// Tipo Cobranca Utilizado na geração da remessa.  |Identificado no Sicredi by sidneiklein|
        /// </summary>
        public string TipoDocumento { get; set; }

        /// <summary>
        /// Número Sequencial do Arquivo (NSA) usado pela CAIXA para identificar o arquivo da remessa, é incrementado com 1 a cada header gerado.
        /// </summary>
        public int SequencialArquivo { get; set; }

        /// <summary>
        /// Número adotado e controlado pelo responsável pela geração magnética dos dados contidos no arquivo para
        /// identificar a seqüência de envio ou devolução do arquivo entre o Cedente e o Banco Cedente.
        /// Obs.: o número informado deve ser seqüencial crescente (anterior + 1).
        /// </summary>
        public int SequencialRemessa { get; set; }

        public Remessa(EnumTipoAmbiemte tipoAmbiente, EnumCodigoOcorrenciaRemessa codigoOcorrencia, string tipoDocumento)
        {
            Ambiente = tipoAmbiente;
            CodigoOcorrencia = codigoOcorrencia;
            TipoDocumento = tipoDocumento;
        }

        #endregion
    }
}
