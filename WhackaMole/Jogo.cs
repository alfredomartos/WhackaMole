using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WhackaMole
{
    public partial class Jogo : Form
    {
        Random rnd = new Random(); // nova classe para gerar posiçao aleatoria da toupeira
        int posicao = 0; //variavel da posiçao
        int score = 0; //variavel dos pontos
        int falhancos = 0; // vezes que falhou
        bool acertar = false; //quando o jogador acerta, fica true
        bool tmp = false;
        SoundPlayer musica = new SoundPlayer(Properties.Resources.Theme_song); //musica tema


        public Jogo()
        {
            InitializeComponent();
            musica.Play(); //musica começar
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            saudacao.Visible = true; 
            Mole.Visible = false;
            if (tempo.Interval > 500) 
            {
                saudacao.Visible = false; //depois de 400 milisegundos a imagem desaparece
                Mole.Visible=true; //a imagem aparece
                tempo.Stop(); //timer pára
                tmp = true;
            }
        }
        private void acertouMole(object sender, EventArgs e)
        {
            if (tmp == true) timer1.Start(); //a imagem inicial desaparece e a mole do jogo aparece
            score++; // aumenta a pontuaçao +1

            Mole.Image = Properties.Resources.deadmole;

            acertar = true; // outptut que acertou

            Mole.Enabled = false; // nao permite carregar novamente na picturebox da toupeira
        }

        private void moverMole(object sender, EventArgs e)
        {
           

            if (acertar == false) // output que falhou
            {
                falhancos++; // aumenta o numero de falhanços +1
            }

            lblpancadas.Text = "Pancadas: " + score; // vezes que acertou
            lblfalhancos.Text = "Falhanços: " + Convert.ToString(falhancos-1); // // vezes que falhou

            if (score >= 10) // se chegar as 10 pancadas, acaba o jogo
            {
                timer1.Stop(); // o timer para
                musica.Stop(); //musica para
                Mole.Enabled = false; // // nao permite carregar novamente na picturebox da toupeira
                MessageBox.Show("Parabéns! Espancaste as toupeiras!");
                this.Close();
                
            }
            else if (falhancos > 5 )
            {
                timer1.Stop(); // o timer para
                musica.Stop(); //musica para
                Mole.Enabled = false; // nao permite carregar novamente na picturebox da toupeira
                MessageBox.Show("Perdeste Nabo!");
                this.Close();
            }

            moveMole(); // faz a funçao de mover a toupeira 
        }

        private void moveMole()
        {
            acertar = false; //output que falhou
            Mole.Image = Properties.Resources.mole; // muda a imagem da toupeira 
            Mole.Enabled = true; // permite nos carregar na picture box 

            posicao = rnd.Next(1, 7); // gerar posiçao aleatoria de 1 a 7


            switch (posicao)
            {
                case 1:
                    Mole.Left = 464;
                    Mole.Top = 251;
                    break;

                case 2:
                    Mole.Left = 258;
                    Mole.Top = 216;
                    break;

                case 3:
                    Mole.Left = 41;
                    Mole.Top = 243;
                    break;

                case 4:
                    Mole.Left = 67;
                    Mole.Top = 324;
                    break;

                case 5:
                    Mole.Left = 261;
                    Mole.Top = 369;
                    break;

                case 6:
                    Mole.Left = 445;
                    Mole.Top = 322;
                    break;

                default:
                    break;
            }
        }
    }
}