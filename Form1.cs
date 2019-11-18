using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jogo_da_Forca
{
    public partial class Form1 : Form
    {
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        private int cont = 0;
       


        public Form1()
        {

            InitializeComponent();
            

        }
       
        //perguntas realizadas comentadas para puxar dados da classe
    /*  public void EscolhePerguntas()
      {
          perguntas = new String[25];
          dicas = new String[25];


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
      */
    private void IniciaJogo()
        {
            Perguntas pe = new Perguntas();
            pe.EscolhePerguntas();
            Random r = new Random();
            pospalavra = r.Next(0, 25);
            palavra = pe.perguntas[pospalavra];
            tela = "";
            
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }

            txtPalavra.Text = tela;
            lbDica.Text = pe.dicas[pospalavra];
            tentativas = 5;
            lbTrestantes.Text = tentativas.ToString();
           // lbTotalTentativas.Text = tentativas.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnForca.Visible = true;
            btnStart.Visible = false;
            this.IniciaJogo();
            txtLetrasDigitadas.Text = "";
            

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

           
                Boolean encontrouLetra = false;
                Char letra;
                string txt = "";
                
            if (txtLetrasDigitadas.Text.Length <= 0)
            {
                txtLetrasDigitadas.Text = txtLetrasDigitadas.Text + txtLetra.Text;
            }
            else
            {
                txtLetrasDigitadas.Text = txtLetrasDigitadas.Text +" , "+ txtLetra.Text;
            }
          

            try
            {
                letra = Convert.ToChar(txtLetra.Text);
            }
            catch
            {
                MessageBox.Show("Digite uma letra válida");
                return;

            }
          

                for (int i = 0; i < palavra.Length; i++)
                {
                    
                    if (palavra[i] == letra)
                    {
                        encontrouLetra = true;
                       
                        txt = txt + txtLetra.Text;
               }
                else
                    {
                        txt = txt + tela[i];
                    }
                }
                tela = txt;
                txtPalavra.Text = tela;
                txtLetra.Clear();

            if (encontrouLetra == false) { 

                cont++;
                tentativas--;
                lbTrestantes.Text = tentativas.ToString();
                pbCabeça.Visible = true;
                

            }
            if (cont == 2)
            {
                pbCorpo.Visible = true;
            }
                

       

            if (txtPalavra.Text.IndexOf('#') == -1)
            {
                pnForca.Visible = false;
                MessageBox.Show("Você Ganhooooou!!");
                btnStart.Visible = true;
            }
            if (tentativas <= 0)
            {
                MessageBox.Show("Você Perdeu!!");
                pnForca.Visible = false;
                btnStart.Visible = true;
                

            }
        }
    }
}
