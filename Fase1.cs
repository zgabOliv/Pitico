﻿using AxWMPLib;
using Pjt_Pitico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitico
{
    public partial class Fase1 : Form
    {
        public Fase1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }



        private void Fase1_Load(object sender, EventArgs e)
        {

            textBox_errado.Visible = false;
            textBox_acertou.Visible = false;
            if (Config.Ling == true)
            {
                textBoxperg1.Text = "Você recebe uma mensagem do seu banco dizendo que seu cartão foi clonado, o que você faz?";
                LetraAperg1.Text = "A. Ligo para o banco para confirmar";
                LetraBperg1.Text = "B. Entro em desespero";
                LetraCperg1.Text = "C. Passo as informações que eles pedirem";

                textBoxperg2.Text = "Você tem que escolher uma senha nova para seu e-mail, qual você escolhe?";
                LetraAperg2.Text = "A. A data do meu aniversário assim não esqueço!";
                LetraBperg2.Text = "B. Palavras com letras maiúsculas e minúsculas, números e caracteres especiais.";
                LetraCperg2.Text = "C. O nome da minha série favorita!";

                textBoxperg3.Text = "Qual mensagem não deveria ser compartilhada de forma nenhuma?";
                LetraAperg3.Text = "A. Fotos de gatinhos fofinhos :3";
                LetraBperg3.Text = "B. Uma notícia claramente sem fontes, cujo conteúdo e extremamente chamativo e sensacionalista.";
                LetraCperg3.Text = "Receitas de brownie";

                textBoxperg4.Text = "Agora como recompensa por ter respondido nossas últimas perguntas, você acaba de ganhar 100 mil reais! Deseja clicar no botão para aceitar?";
                LetraAperg4.Text = "A. Óbvio! São 100 mil reais, quem seria burro de não aceitar?";
                LetraBperg4.Text = "B. Não, não caio nessa de novo";

                lbl_parabéns.Text = "PARABÉNS, VOCÊ PASSOU DA FASE 1!!";
                button_tentardnv.Text = "COMEÇAR DE NOVO";

                textBox_acertou.Text = "Pype" + Environment.NewLine + Environment.NewLine + " COMO É POSSÍVEL?!?!?!?!?" + Environment.NewLine + "A próxima pergunta você não saberá!";
                textBox_errado.Text = "Pype" + Environment.NewLine + Environment.NewLine + "HAHAHAHAHA, VOCÊ FOI FISGADO!!";

                btn_póspergunta2.Text = "Prosseguir";
                btn_Póspergunta3.Text = "Prosseguir";
                BotaoCenario5.Text = "Prosseguir";
                BotaoCenario3.Text = "Prosseguir";
                BotaoCenario4.Text = "Prosseguir";

                
            }
            else
            {
                textBoxperg1.Text = "You receive a message from your bank saying your card has been cloned, what do you do?";
                LetraAperg1.Text = "A. Call the bank to confirm";
                LetraBperg1.Text = "B. Panic";
                LetraCperg1.Text = "C. Provide the information they ask for";

                textBoxperg2.Text = "You need to choose a new password for your email, which one do you choose?";
                LetraAperg2.Text = "A. My birthday date, so I won't forget it!";
                LetraBperg2.Text = "B. Words with uppercase and lowercase letters, numbers, and special characters.";
                LetraCperg2.Text = "C. The name of my favorite series!";

                textBoxperg3.Text = "Which message should never be shared?";
                LetraAperg3.Text = "A. Cute kitty photos :3";
                LetraBperg3.Text = "B. A clearly source-less news story with extremely catchy and sensational content.";
                LetraCperg3.Text = "Brownie recipes";

                textBoxperg4.Text = "Now as a reward for answering our last questions, you just won 100 thousand reais! Do you want to click the button to accept?";
                LetraAperg4.Text = "A. Of course! It's 100 thousand reais, who would be dumb not to accept?";
                LetraBperg4.Text = "B. No, I won't fall for this again";

                lbl_parabéns.Text = "CONGRATULATIONS, YOU PASSED STAGE 1!!";
                button_tentardnv.Text = "START OVER";

                textBox_acertou.Text = "Pype" + Environment.NewLine + " HOW IS IT POSSIBLE?!?!?!?!?" + Environment.NewLine + "You won't know the next question!";
                textBox_errado.Text = "Pype" + Environment.NewLine + Environment.NewLine + "HAHAHAHAHA, YOU'VE BEEN HOOKED!!";

                btn_póspergunta2.Text = "Proceed";
                btn_Póspergunta3.Text = "Proceed";
                BotaoCenario3.Text = "Proceed";
                BotaoCenario4.Text = "Proceed";
                BotaoCenario5.Text = "Proceed";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(LetraAperg1.CanSelect)
            {
                BotaoCenario3.Visible = true;
                Cenario3.Visible = true;
                LetraAperg1.Visible = false;
                LetraBperg1.Visible = false;
                LetraCperg1.Visible = false;
                textBoxperg1.Visible = false;
   
         

        }
    }

        private void LetraCperg1_Click(object sender, EventArgs e)
        {
            if (LetraCperg1.CanSelect)
            {
                button_tentardnv.Visible = true;
                BackgroundImage = Properties.Resources.erroPergunta1;
                LetraAperg1.Visible = false;
                LetraBperg1.Visible = false;
                LetraCperg1.Visible = false;
                textBoxperg1.Visible = false;
                erroPergunta1.Visible = true;
                textBox_errado.Visible = true;
                button_tentardnv.BringToFront();
            }
        }

        private void LetraBperg1_Click(object sender, EventArgs e)
        {
            if (LetraBperg1.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg1.Visible = false;
                LetraBperg1.Visible = false;
                LetraCperg1.Visible = false;
                textBoxperg1.Visible = false;
                erroPergunta1.Visible = true;
                textBox_errado.Visible = true;
                button_tentardnv.BringToFront();
            }
        }

        private void BotaoCenario3_Click(object sender, EventArgs e)
        {
            if(BotaoCenario3.CanSelect)
            {
                BotaoCenario4.Visible = true;
                Cenario4.Visible = true;
       
                Cenario3.Visible = false;
            BotaoCenario3.Visible = false;
            }
        }

        private void BotaoCenario4_Click(object sender, EventArgs e)
        {
            if (BotaoCenario4.CanSelect)
            {
                BotaoCenario5.Visible = true;
                Cenario5.Visible = true;
   
                Cenario4.Visible = false;
                BotaoCenario4.Visible = false;
            }
        }
    

        private void BotaoCenario5_Click(object sender, EventArgs e)
        {
            if (BotaoCenario5.CanSelect)
            {
                LetraAperg2.Visible = true;
                LetraBperg2.Visible = true;
                LetraCperg2.Visible = true;
                textBoxperg2.Visible = true;
                Cenario6perg2.Visible = true;

                BotaoCenario5.Visible = false;
                Cenario5.Visible = false;
            }
        }

        private void LetraAperg2_Click(object sender, EventArgs e)
        {
            if (LetraAperg2.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg2.Visible = false;
                LetraBperg2.Visible = false;
                LetraCperg2.Visible = false;
                textBoxperg2.Visible = false;
                Cenario6perg2.Visible = false;
                erroPerg2.Visible = true;
            }
        }
    

        private void LetraCperg2_Click(object sender, EventArgs e)
        {
            if (LetraCperg2.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg2.Visible = false;
                LetraBperg2.Visible = false;
                LetraCperg2.Visible = false;
                textBoxperg2.Visible = false;
                Cenario6perg2.Visible = false;
                erroPerg2.Visible = true;
            }
        }
        private void LetraBperg2_Click(object sender, EventArgs e)
        {
            if (LetraBperg2.CanSelect)
            {
                cenario_original.Visible = true;
                LetraAperg2.Visible = false;
                LetraBperg2.Visible = false;
                LetraCperg2.Visible = false;
                textBoxperg2.Visible = false;
                Cenario6perg2.Visible = false;
                btn_Póspergunta3.Visible = true;
                textBox_acertou.Visible = true;

            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            if (LetraAperg3.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg3.Visible = false;
                LetraBperg3.Visible = false;
                LetraCperg3.Visible = false;
                textBoxperg3.Visible = false;
                Cenario7perg3.Visible = false;
                erroperg3.Visible = true;
                btn_póspergunta2.Visible = false;
            }
        }

        private void LetraBperg3_Click(object sender, EventArgs e)
        {
            if (LetraBperg3.CanSelect)
            {
                LetraAperg4.Visible = true;
                LetraBperg4.Visible = true;
                Cenario8perg4.Visible = true;
                textBoxperg4.Visible = true;

                LetraAperg3.Visible = false;
                LetraBperg3.Visible = false;
                LetraCperg3.Visible = false;
                textBoxperg3.Visible = false;
                Cenario7perg3.Visible = false;
                btn_póspergunta2.Visible = false;
        
            }
        }

        private void LetraCperg3_Click(object sender, EventArgs e)
        {
            if (LetraCperg3.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg3.Visible = false;
                LetraBperg3.Visible = false;
                LetraCperg3.Visible = false;
                textBoxperg3.Visible = false;
                Cenario7perg3.Visible = false;
                erroperg3.Visible = true;
                btn_póspergunta2.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (LetraAperg4.CanSelect)
            {
                button_tentardnv.Visible = true;
                LetraAperg4.Visible = false;
                LetraBperg4.Visible = false;
                textBoxperg4.Visible = false;
                Cenario8perg4.Visible = false;
                erroperg4.Visible = true;
                btn_Póspergunta3.Visible = false;
                btn_póspergunta2.Visible = false;
            }
        }

        private void LetraBperg4_Click(object sender, EventArgs e)
        {
            if (LetraBperg4.CanSelect)
            {
                prosseguir_fase2.Visible = true;
                button_tentardnv.Visible = true;
                lbl_parabéns.Visible = true;
                Cenario9.Visible = true;
                LetraAperg4.Visible = false;
                LetraBperg4.Visible = false;
                textBoxperg4.Visible = false;
                Cenario8perg4.Visible = false;
               btn_póspergunta2.Visible = false;
                btn_Póspergunta3.Visible = false;
            }
        }
        private void SetSpecificControlsInvisible()
        {
            // Lista de controles específicos que devem ser invisíveis
            List<Control> controlsToHide = new List<Control>()
    {
        Cenario3,
      Cenario4,
      Cenario5,
      Cenario6perg2,
      Cenario7perg3,
      Cenario8perg4,
      Cenario9,
      BotaoCenario3,
      BotaoCenario4,
      BotaoCenario5,
      erroPerg2,
      erroperg3,
      erroperg4,
      erroPergunta1,
      lbl_parabéns,
      LetraAperg2,
      LetraBperg2,
      LetraCperg2,
          LetraAperg3,
      LetraBperg3,
      LetraCperg3,
      LetraAperg4,
      LetraBperg4,
      textBoxperg2,
      textBoxperg3,
      textBoxperg4,



    };

            // Itera sobre todos os controles no formulário
            foreach (Control control in this.Controls)
            {
                // Se o controle estiver na lista, define a propriedade Visible como false
                if (controlsToHide.Contains(control))
                {
                    control.Visible = false;
                }
            }
        }

        private void button_tentardnv_Click(object sender, EventArgs e)
        {
            LetraAperg1.Visible = true;
            LetraBperg1.Visible = true;
            LetraCperg1.Visible = true;
            textBoxperg1.Visible = true;
            BackgroundImage = Properties.Resources.cenario1;
            button_tentardnv.Visible = false;
            prosseguir_fase2.Visible = false;
            SetSpecificControlsInvisible();
            textBox_errado.Visible = false;
        }

        private void prosseguir_fase2_Click(object sender, EventArgs e)
        {
            string videoName = "fase1_end";
            if (prosseguir_fase2.CanSelect)
                {
                button_tentardnv.Visible = false;
                axWindowsMediaPlayer1.Visible = true;
                    byte[] video = null;

                    switch (videoName)
                    {
                        case "fase1_end":
                            video = Pitico.Properties.Resources.fase1_end;
                            break;
                        default:
                            MessageBox.Show("Vídeo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Gere um nome de arquivo temporário único
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.mp4");

                    // Escreva o vídeo dos recursos para o arquivo temporário
                    using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(video, 0, video.Length);
                    }

                    axWindowsMediaPlayer1.URL = tempFilePath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
        }



        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
                {
                    // Verifique se o estado é 'MediaEnded'
                    if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
                    {
                        // Vídeo terminou, abra o próximo formulário
                        Form proximoFormulario = new Fase2();
                        proximoFormulario.Show();
                        this.Close();
                    }
        }

        private void Cenario9_Click(object sender, EventArgs e)
        {

        }

        private void Cenario8perg4_Click(object sender, EventArgs e)
        {

        }

        private void Cenario7perg3_Click(object sender, EventArgs e)
        {

        }

        private void erroPerg2_Click(object sender, EventArgs e)
        {

        }

        private void Cenario6perg2_Click(object sender, EventArgs e)
        {

        }

        private void Cenario5_Click(object sender, EventArgs e)
        {

        }

        private void Cenario4_Click(object sender, EventArgs e)
        {

        }

        private void Cenario3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reaçao_pitico_Click(object sender, EventArgs e)
        {

        }

        private void btn_póspergunta2_Click(object sender, EventArgs e)
        {

            }
        

        private void btn_Póspergunta3_Click(object sender, EventArgs e)
        {
            cenario_original.Visible = false;
            LetraAperg3.Visible = true;
            LetraBperg3.Visible = true;
            LetraCperg3.Visible = true;
            textBoxperg3.Visible = true;
            Cenario7perg3.Visible = true;
            btn_Póspergunta3.Visible = false;
            btn_póspergunta2.Visible = false;
            textBox_acertou.Visible = false;
            textBox_errado.Visible = false;
        }

        private void cenario_original_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
