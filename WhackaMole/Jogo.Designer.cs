namespace WhackaMole
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblpancadas = new System.Windows.Forms.Label();
            this.lblfalhancos = new System.Windows.Forms.Label();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saudacao = new System.Windows.Forms.PictureBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saudacao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpancadas
            // 
            this.lblpancadas.AutoSize = true;
            this.lblpancadas.BackColor = System.Drawing.Color.Transparent;
            this.lblpancadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpancadas.Location = new System.Drawing.Point(771, 23);
            this.lblpancadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpancadas.Name = "lblpancadas";
            this.lblpancadas.Size = new System.Drawing.Size(84, 17);
            this.lblpancadas.TabIndex = 0;
            this.lblpancadas.Text = "Pancadas:";
            // 
            // lblfalhancos
            // 
            this.lblfalhancos.AutoSize = true;
            this.lblfalhancos.BackColor = System.Drawing.Color.Transparent;
            this.lblfalhancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfalhancos.Location = new System.Drawing.Point(771, 52);
            this.lblfalhancos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfalhancos.Name = "lblfalhancos";
            this.lblfalhancos.Size = new System.Drawing.Size(87, 17);
            this.lblfalhancos.TabIndex = 1;
            this.lblfalhancos.Text = "Falhancos:";
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.Color.Transparent;
            this.Mole.Image = global::WhackaMole.Properties.Resources.mole;
            this.Mole.Location = new System.Drawing.Point(593, 396);
            this.Mole.Margin = new System.Windows.Forms.Padding(4);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(213, 158);
            this.Mole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mole.TabIndex = 2;
            this.Mole.TabStop = false;
            this.Mole.Visible = false;
            this.Mole.Click += new System.EventHandler(this.acertouMole);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.moverMole);
            // 
            // saudacao
            // 
            this.saudacao.BackColor = System.Drawing.Color.Transparent;
            this.saudacao.BackgroundImage = global::WhackaMole.Properties.Resources.mole_inicio;
            this.saudacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saudacao.Location = new System.Drawing.Point(-8, 103);
            this.saudacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saudacao.Name = "saudacao";
            this.saudacao.Size = new System.Drawing.Size(396, 303);
            this.saudacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saudacao.TabIndex = 3;
            this.saudacao.TabStop = false;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 2000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhackaMole.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 689);
            this.Controls.Add(this.saudacao);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.lblfalhancos);
            this.Controls.Add(this.lblpancadas);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jogo";
            this.Text = "Whack a Mole";
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saudacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpancadas;
        private System.Windows.Forms.Label lblfalhancos;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox saudacao;
        private System.Windows.Forms.Timer tempo;
    }
}

