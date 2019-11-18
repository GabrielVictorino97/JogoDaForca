using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    class Perguntas : Form1
    {

        public String[] perguntas { get; set; }
        public String[] dicas { get; set; }

        public void EscolhePerguntas()
        {
            this.perguntas = new String[25];
            this.dicas = new String[25];


            #region perguntasEdicas

            perguntas[0] = "biblioteca";
            dicas[0] = "Acredite se quiser, tem na sua escola";

            perguntas[1] = "estrada";
            dicas[1] = "Passa carros";

            perguntas[2] = "aviao";
            dicas[2] = "Não é um passaro nem o super homem";

            perguntas[3] = "bandeira";
            dicas[3] = "Quem fez do japão tava com preguiça";

            perguntas[4] = "bigode";
            dicas[4] = "Nem todo homem tem, mas algumas meninas tem";

            perguntas[5] = "bola";
            dicas[5] = "Chutar";

            perguntas[6] = "dentista";
            dicas[6] = "Usa a maquininha do capeta";

            perguntas[7] = "fazenda";
            dicas[7] = "Tem animais";

            perguntas[8] = "galinha";
            dicas[8] = "Ave mas não voa";

            perguntas[9] = "gato";
            dicas[9] = "Cachorro é melhor";

            perguntas[10] = "laranja";
            dicas[10] = "Fruta ";

            perguntas[11] = "mapa";
            dicas[11] = "Define o caminho";

            perguntas[12] = "martelo";
            dicas[12] = "Thor";

            perguntas[13] = "nariz";
            dicas[13] = "Serve para sentir cheiros";

            perguntas[14] = "ovo";
            dicas[14] = "quem nasceu primeiro?";

            perguntas[15] = "palhaço";
            dicas[15] = "Amigo que não ajuda no trabalho";

            perguntas[16] = "pirata";
            dicas[16] = "jack sparrow";

            perguntas[17] = "palmeiras";
            dicas[17] = "Não tem mundial";

            perguntas[18] = "heroi";
            dicas[18] = "Salva as pessoas";

            perguntas[19] = "mulher";
            dicas[19] = "Sempre tem razão";

            perguntas[20] = "paraguai";
            dicas[20] = "Falsificado";

            perguntas[21] = "jogos";
            dicas[21] = "Sai mais estressado do que quando começou";

            perguntas[22] = "computador";
            dicas[22] = "Melhor invenção da tecnologia";

            perguntas[23] = "internet";
            dicas[23] = "Ninguém vive sem";

            perguntas[24] = "animal";
            dicas[24] = "Pode ser de estimação";
            #endregion


        }

    }
}
