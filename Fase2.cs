﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitico
{
    public partial class Fase2 : Form
    {
        private int vida = 5;
        private const int vidaMaxima = 5;
        private int vidaCshar = 5;

        public Fase2()
        {
            InitializeComponent();
        }

        private void Fase2_Load(object sender, EventArgs e)
        {
            btn_ajuda.Click += SelecionarOpcao;
            btn_block.Click += SelecionarOpcao;
            btn_denunciar.Click += SelecionarOpcao;
            btn_xingar.Click += SelecionarOpcao;
            btn_ignorar.Click += SelecionarOpcao;

            AtualizarCoracoes();
            AtualizarCoracoesAdversario();
        }

        private void SelecionarOpcao(object sender, EventArgs e)
        {
            Button botao = sender as Button;



            if (botao == btn_ajuda)
            {

                vida++;
                if (vida > vidaMaxima) vida = vidaMaxima; 
            }
            else if (botao == btn_denunciar)
            {

                vidaCshar--;
                if (vidaCshar < 0) vidaCshar = 0; 
                MessageBox.Show("Você denunciou! O adversário perdeu um coração.");
            }
            else if (botao == btn_block)
            {
        
                vidaCshar--;
                vida--;
                if (vida < 0) vida = 0;
                if (vidaCshar < 0) vidaCshar = 0;
            }
            else if (botao == btn_xingar || botao == btn_ignorar)
            {

                vida--;
                if (vida < 0) vida = 0;
            }


            AtualizarCoracoes();
            AtualizarCoracoesAdversario();
            VerificarGameOver();
        }

        private void AtualizarCoracoes()
        {
         
            VidaPitico1.Visible = vida >= 1;
            VidaPitico2.Visible = vida >= 2;
            VidaPitico3.Visible = vida >= 3;
            VidaPitico4.Visible = vida >= 4;
            VidaPitico5.Visible = vida >= 5;

            labelVida.Text = $"Vida: {vida}";
        }

        private void AtualizarCoracoesAdversario()
        {
         
            VidaCshar1.Visible = vidaCshar >= 1;
            VidaCshar2.Visible = vidaCshar >= 2;
            VidaCshar3.Visible = vidaCshar >= 3;
            VidaCshar4.Visible = vidaCshar >= 4;
            VidaCshar5.Visible = vidaCshar >= 5;

            labelVidaCshar.Text = $"Vida Adversário: {vidaCshar}";
        }

        private void VerificarGameOver()
        {
            if (vida <= 0)
            {
                MessageBox.Show("Game Over! Pitico perdeu.");
                btn_recomeçar.Visible = true;
                btn_continuarfase.Visible = true;
                game_over.Visible = true;
                cshar_1.Visible = false;
                pitico_1.Visible = false;
                textBox1.Visible = false;
                lbl_pergunta.Visible = false;
                VidaPitico1.Visible = false;
                VidaPitico2.Visible = false;
                VidaPitico3.Visible = false;
                VidaPitico4.Visible = false;
                VidaPitico5.Visible = false;
                VidaCshar1.Visible = false;
                VidaCshar2.Visible = false;
                VidaCshar3.Visible = false;
                VidaCshar4.Visible = false;
                VidaCshar5.Visible = false;
                btn_ajuda.Visible = false;
                btn_block.Visible = false;
                btn_denunciar.Visible = false;
                btn_xingar.Visible = false;
                btn_ignorar.Visible = false;
                prosseguir1.Visible = false;
                prosseguir2.Visible = false;
                prosseguir3.Visible = false;
                prosseguir4.Visible = false;
                prosseguir5.Visible = false;
                btn_cont.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (vidaCshar <= 0)
            {
                MessageBox.Show("Game Over! O adversário perdeu.");
        
            }
       
    }



    private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_block_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Toma essa! Aquela baranga finalmente foi bloqueada" +
                ", \n fazendo com que Pitico pudesse ter pelo menos um pequeno descanso e paz. Cshar -1 coração ";
            prosseguir1.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;    

        }

        private void prosseguir1_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cria fake news sobre pitico, dizendo que ele não toma banho! -1 coração do pitico. ";
            btn_cont.Visible = true;
            prosseguir1.Visible = false;
        }

        private void btn_xingar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Reação: Cshar -1 Coração. Ele espalha por todo lugar que o pitico o atacou primeiro, dando um ataque de -1 coração" +
                "\n do pitico ";
            prosseguir2.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir2_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Por mais satisfatório que isso possa parecer," +
                " \n ainda é crime! Pitico deve levar suas questões contra seus inimigos para o Tribunal e não usando agressão.  ";
            btn_cont.Visible = true;
            prosseguir2.Visible = false;
        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico pede ajuda da multidão à sua volta, e os cidadãos lhe dão motivação! +1 coração.";
            prosseguir3.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir3_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar fica irritado e começa a juntar bots para ficar mais forte.";
            btn_cont.Visible = true;
            prosseguir3.Visible = false;
        }

        private void btn_ignorar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico resolveu não bloquear seu assediador, seus dias se passaram de forma extremamente estressante," +
                " \n até chegar ao ponto de simplesmente não sentir mais vontade ou felicidade compartilhando as coisas que gosta," +
                " \n sequer se comunicando com pessoas ao seu redor, ficando apenas cabisbaixo em seu quarto. Tão deprimente. .";
            prosseguir4.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir4_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar continua xingando pitico, mandando mensagens de como ele é feio!-1 coração para pitico";
            btn_cont.Visible = true;
            prosseguir4.Visible = false;
        }

        private void btn_denunciar_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Pitico resolve denunciar o perfil do seu hater, diminuindo o alcance de seu perfil.";
            prosseguir5.Visible = true;
            btn_ajuda.Visible = false;
            btn_block.Visible = false;
            btn_denunciar.Visible = false;
            btn_xingar.Visible = false;
            btn_ignorar.Visible = false;
        }

        private void prosseguir5_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "Cshar -1 coração. Ele gasta esse turno criando uma conta nova!";
            btn_cont.Visible = true;
            prosseguir5.Visible = false;
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            lbl_pergunta.Text = "O que o pitico fará? ";
            btn_cont.Visible = false;
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vida = 5;
            vidaCshar = 5;

            // Atualiza a interface gráfica para refletir a nova vida
            AtualizarCoracoes();
            AtualizarCoracoesAdversario();

            game_over.Visible = false;
            btn_recomeçar.Visible = false;
            btn_continuarfase.Visible = false;
            cshar_1.Visible = true;
            pitico_1.Visible = true;
            textBox1.Visible = true;
            lbl_pergunta.Visible = true;
            lbl_pergunta.Text = "O que o pitico fará?";
            VidaPitico1.Visible = true;
            VidaPitico2.Visible = true;
            VidaPitico3.Visible = true;
            VidaPitico4.Visible = true;
            VidaPitico5.Visible = true;
            VidaCshar1.Visible = true;
            VidaCshar2.Visible = true;
            VidaCshar3.Visible = true;
            VidaCshar4.Visible = true;
            VidaCshar5.Visible = true;
            btn_ajuda.Visible = true;
            btn_block.Visible = true;
            btn_denunciar.Visible = true;
            btn_xingar.Visible = true;
            btn_ignorar.Visible = true;
            pictureBox1.Visible = true;
        }
    }
}


