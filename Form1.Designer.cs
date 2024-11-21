namespace inicioProjeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reta = new System.Windows.Forms.Button();
            this.quadrilatero = new System.Windows.Forms.Button();
            this.circulo = new System.Windows.Forms.Button();
            this.triangulo = new System.Windows.Forms.Button();
            this.pentagono = new System.Windows.Forms.Button();
            this.prisma = new System.Windows.Forms.Button();
            this.Espessura = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.estilhoLinha = new System.Windows.Forms.ComboBox();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.gravarTxt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roxoClaro = new System.Windows.Forms.Button();
            this.azulCinza = new System.Windows.Forms.Button();
            this.azulClaro = new System.Windows.Forms.Button();
            this.rosa = new System.Windows.Forms.Button();
            this.amareloEscuro = new System.Windows.Forms.Button();
            this.marrom = new System.Windows.Forms.Button();
            this.cinzaClaro = new System.Windows.Forms.Button();
            this.verdeClaro = new System.Windows.Forms.Button();
            this.amareloClaro = new System.Windows.Forms.Button();
            this.roxo = new System.Windows.Forms.Button();
            this.azulEscuro = new System.Windows.Forms.Button();
            this.amarelo = new System.Windows.Forms.Button();
            this.azul = new System.Windows.Forms.Button();
            this.laranja = new System.Windows.Forms.Button();
            this.vermelhoEscuro = new System.Windows.Forms.Button();
            this.cinza = new System.Windows.Forms.Button();
            this.branco = new System.Windows.Forms.Button();
            this.preto = new System.Windows.Forms.Button();
            this.vermelho = new System.Windows.Forms.Button();
            this.corRecente = new System.Windows.Forms.Button();
            this.verde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reta
            // 
            this.reta.BackColor = System.Drawing.Color.White;
            this.reta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reta.Image = ((System.Drawing.Image)(resources.GetObject("reta.Image")));
            this.reta.Location = new System.Drawing.Point(189, 36);
            this.reta.Name = "reta";
            this.reta.Size = new System.Drawing.Size(29, 28);
            this.reta.TabIndex = 1;
            this.reta.UseVisualStyleBackColor = false;
            this.reta.Click += new System.EventHandler(this.reta_Click);
            // 
            // quadrilatero
            // 
            this.quadrilatero.BackColor = System.Drawing.Color.White;
            this.quadrilatero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quadrilatero.Image = ((System.Drawing.Image)(resources.GetObject("quadrilatero.Image")));
            this.quadrilatero.Location = new System.Drawing.Point(154, 36);
            this.quadrilatero.Name = "quadrilatero";
            this.quadrilatero.Size = new System.Drawing.Size(29, 28);
            this.quadrilatero.TabIndex = 2;
            this.quadrilatero.UseVisualStyleBackColor = false;
            this.quadrilatero.Click += new System.EventHandler(this.quadrilatero_Click);
            // 
            // circulo
            // 
            this.circulo.BackColor = System.Drawing.Color.White;
            this.circulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.circulo.Location = new System.Drawing.Point(259, 36);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(29, 28);
            this.circulo.TabIndex = 3;
            this.circulo.Text = "○";
            this.circulo.UseVisualStyleBackColor = false;
            this.circulo.Click += new System.EventHandler(this.circulo_Click);
            // 
            // triangulo
            // 
            this.triangulo.BackColor = System.Drawing.Color.White;
            this.triangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.triangulo.Image = ((System.Drawing.Image)(resources.GetObject("triangulo.Image")));
            this.triangulo.Location = new System.Drawing.Point(119, 36);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(29, 28);
            this.triangulo.TabIndex = 4;
            this.triangulo.UseVisualStyleBackColor = false;
            this.triangulo.Click += new System.EventHandler(this.triangulo_Click);
            // 
            // pentagono
            // 
            this.pentagono.BackColor = System.Drawing.Color.White;
            this.pentagono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pentagono.Image = ((System.Drawing.Image)(resources.GetObject("pentagono.Image")));
            this.pentagono.Location = new System.Drawing.Point(84, 36);
            this.pentagono.Name = "pentagono";
            this.pentagono.Size = new System.Drawing.Size(29, 28);
            this.pentagono.TabIndex = 5;
            this.pentagono.UseVisualStyleBackColor = false;
            this.pentagono.Click += new System.EventHandler(this.pentagono_Click);
            // 
            // prisma
            // 
            this.prisma.BackColor = System.Drawing.Color.White;
            this.prisma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prisma.Image = ((System.Drawing.Image)(resources.GetObject("prisma.Image")));
            this.prisma.Location = new System.Drawing.Point(224, 36);
            this.prisma.Name = "prisma";
            this.prisma.Size = new System.Drawing.Size(29, 28);
            this.prisma.TabIndex = 6;
            this.prisma.UseVisualStyleBackColor = false;
            this.prisma.Click += new System.EventHandler(this.prisma_Click);
            // 
            // Espessura
            // 
            this.Espessura.FormattingEnabled = true;
            this.Espessura.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "8"});
            this.Espessura.Location = new System.Drawing.Point(577, 77);
            this.Espessura.Name = "Espessura";
            this.Espessura.Size = new System.Drawing.Size(56, 21);
            this.Espessura.TabIndex = 8;
            this.Espessura.Text = "1";
            this.Espessura.SelectedIndexChanged += new System.EventHandler(this.Espessura_SelectedIndexChanged);
            // 
            // estilhoLinha
            // 
            this.estilhoLinha.FormattingEnabled = true;
            this.estilhoLinha.Items.AddRange(new object[] {
            "Normal",
            "Tracejada",
            "Pontilhada",
            "TraçoDoisPontos",
            "TraçoPonto"});
            this.estilhoLinha.Location = new System.Drawing.Point(334, 36);
            this.estilhoLinha.Name = "estilhoLinha";
            this.estilhoLinha.Size = new System.Drawing.Size(121, 21);
            this.estilhoLinha.TabIndex = 28;
            this.estilhoLinha.Text = "Normal";
            this.estilhoLinha.SelectedIndexChanged += new System.EventHandler(this.estilhoLinha_SelectedIndexChanged);
            // 
            // btn_elipse
            // 
            this.btn_elipse.BackColor = System.Drawing.Color.White;
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_elipse.Image")));
            this.btn_elipse.Location = new System.Drawing.Point(49, 36);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(29, 28);
            this.btn_elipse.TabIndex = 29;
            this.btn_elipse.UseVisualStyleBackColor = false;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // gravarTxt
            // 
            this.gravarTxt.BackColor = System.Drawing.Color.White;
            this.gravarTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gravarTxt.BackgroundImage")));
            this.gravarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gravarTxt.Location = new System.Drawing.Point(716, 6);
            this.gravarTxt.Name = "gravarTxt";
            this.gravarTxt.Size = new System.Drawing.Size(65, 59);
            this.gravarTxt.TabIndex = 31;
            this.gravarTxt.UseVisualStyleBackColor = false;
            this.gravarTxt.Click += new System.EventHandler(this.gravarTxt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roxoClaro);
            this.panel1.Controls.Add(this.azulCinza);
            this.panel1.Controls.Add(this.azulClaro);
            this.panel1.Controls.Add(this.rosa);
            this.panel1.Controls.Add(this.amareloEscuro);
            this.panel1.Controls.Add(this.marrom);
            this.panel1.Controls.Add(this.cinzaClaro);
            this.panel1.Controls.Add(this.verdeClaro);
            this.panel1.Controls.Add(this.amareloClaro);
            this.panel1.Controls.Add(this.roxo);
            this.panel1.Controls.Add(this.azulEscuro);
            this.panel1.Controls.Add(this.amarelo);
            this.panel1.Controls.Add(this.azul);
            this.panel1.Controls.Add(this.laranja);
            this.panel1.Controls.Add(this.vermelhoEscuro);
            this.panel1.Controls.Add(this.cinza);
            this.panel1.Controls.Add(this.branco);
            this.panel1.Controls.Add(this.preto);
            this.panel1.Controls.Add(this.vermelho);
            this.panel1.Controls.Add(this.corRecente);
            this.panel1.Controls.Add(this.verde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gravarTxt);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Espessura);
            this.panel1.Controls.Add(this.estilhoLinha);
            this.panel1.Controls.Add(this.btn_elipse);
            this.panel1.Controls.Add(this.circulo);
            this.panel1.Controls.Add(this.prisma);
            this.panel1.Controls.Add(this.triangulo);
            this.panel1.Controls.Add(this.reta);
            this.panel1.Controls.Add(this.quadrilatero);
            this.panel1.Controls.Add(this.pentagono);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1929, 108);
            this.panel1.TabIndex = 32;
            // 
            // roxoClaro
            // 
            this.roxoClaro.BackColor = System.Drawing.Color.Plum;
            this.roxoClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roxoClaro.Location = new System.Drawing.Point(1214, 59);
            this.roxoClaro.Name = "roxoClaro";
            this.roxoClaro.Size = new System.Drawing.Size(26, 28);
            this.roxoClaro.TabIndex = 56;
            this.roxoClaro.UseVisualStyleBackColor = false;
            this.roxoClaro.Click += new System.EventHandler(this.roxoClaro_Click);
            // 
            // azulCinza
            // 
            this.azulCinza.BackColor = System.Drawing.Color.SteelBlue;
            this.azulCinza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azulCinza.Location = new System.Drawing.Point(1182, 59);
            this.azulCinza.Name = "azulCinza";
            this.azulCinza.Size = new System.Drawing.Size(26, 28);
            this.azulCinza.TabIndex = 55;
            this.azulCinza.UseVisualStyleBackColor = false;
            this.azulCinza.Click += new System.EventHandler(this.azulCinza_Click);
            // 
            // azulClaro
            // 
            this.azulClaro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.azulClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azulClaro.Location = new System.Drawing.Point(1150, 60);
            this.azulClaro.Name = "azulClaro";
            this.azulClaro.Size = new System.Drawing.Size(26, 28);
            this.azulClaro.TabIndex = 54;
            this.azulClaro.UseVisualStyleBackColor = false;
            this.azulClaro.Click += new System.EventHandler(this.azulClaro_Click);
            // 
            // rosa
            // 
            this.rosa.BackColor = System.Drawing.Color.Pink;
            this.rosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rosa.Location = new System.Drawing.Point(1022, 60);
            this.rosa.Name = "rosa";
            this.rosa.Size = new System.Drawing.Size(26, 28);
            this.rosa.TabIndex = 53;
            this.rosa.UseVisualStyleBackColor = false;
            this.rosa.Click += new System.EventHandler(this.rosa_Click);
            // 
            // amareloEscuro
            // 
            this.amareloEscuro.BackColor = System.Drawing.Color.Gold;
            this.amareloEscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amareloEscuro.Location = new System.Drawing.Point(1054, 60);
            this.amareloEscuro.Name = "amareloEscuro";
            this.amareloEscuro.Size = new System.Drawing.Size(26, 28);
            this.amareloEscuro.TabIndex = 52;
            this.amareloEscuro.UseVisualStyleBackColor = false;
            this.amareloEscuro.Click += new System.EventHandler(this.amareloEscuro_Click);
            // 
            // marrom
            // 
            this.marrom.BackColor = System.Drawing.Color.Brown;
            this.marrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marrom.Location = new System.Drawing.Point(990, 60);
            this.marrom.Name = "marrom";
            this.marrom.Size = new System.Drawing.Size(26, 28);
            this.marrom.TabIndex = 51;
            this.marrom.UseVisualStyleBackColor = false;
            this.marrom.Click += new System.EventHandler(this.marrom_Click);
            // 
            // cinzaClaro
            // 
            this.cinzaClaro.BackColor = System.Drawing.Color.Gray;
            this.cinzaClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinzaClaro.Location = new System.Drawing.Point(958, 60);
            this.cinzaClaro.Name = "cinzaClaro";
            this.cinzaClaro.Size = new System.Drawing.Size(26, 28);
            this.cinzaClaro.TabIndex = 50;
            this.cinzaClaro.UseVisualStyleBackColor = false;
            this.cinzaClaro.Click += new System.EventHandler(this.cinzaClaro_Click);
            // 
            // verdeClaro
            // 
            this.verdeClaro.BackColor = System.Drawing.Color.Lime;
            this.verdeClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verdeClaro.Location = new System.Drawing.Point(1118, 60);
            this.verdeClaro.Name = "verdeClaro";
            this.verdeClaro.Size = new System.Drawing.Size(26, 28);
            this.verdeClaro.TabIndex = 49;
            this.verdeClaro.UseVisualStyleBackColor = false;
            this.verdeClaro.Click += new System.EventHandler(this.verdeClaro_Click);
            // 
            // amareloClaro
            // 
            this.amareloClaro.BackColor = System.Drawing.Color.LightYellow;
            this.amareloClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amareloClaro.Location = new System.Drawing.Point(1086, 60);
            this.amareloClaro.Name = "amareloClaro";
            this.amareloClaro.Size = new System.Drawing.Size(26, 28);
            this.amareloClaro.TabIndex = 48;
            this.amareloClaro.UseVisualStyleBackColor = false;
            this.amareloClaro.Click += new System.EventHandler(this.amareloClaro_Click);
            // 
            // roxo
            // 
            this.roxo.BackColor = System.Drawing.Color.MediumOrchid;
            this.roxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roxo.Location = new System.Drawing.Point(1214, 13);
            this.roxo.Name = "roxo";
            this.roxo.Size = new System.Drawing.Size(26, 28);
            this.roxo.TabIndex = 47;
            this.roxo.UseVisualStyleBackColor = false;
            this.roxo.Click += new System.EventHandler(this.roxo_Click);
            // 
            // azulEscuro
            // 
            this.azulEscuro.BackColor = System.Drawing.Color.DarkBlue;
            this.azulEscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azulEscuro.Location = new System.Drawing.Point(1182, 13);
            this.azulEscuro.Name = "azulEscuro";
            this.azulEscuro.Size = new System.Drawing.Size(26, 28);
            this.azulEscuro.TabIndex = 46;
            this.azulEscuro.UseVisualStyleBackColor = false;
            this.azulEscuro.Click += new System.EventHandler(this.azulEscuro_Click);
            // 
            // amarelo
            // 
            this.amarelo.BackColor = System.Drawing.Color.Yellow;
            this.amarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amarelo.Location = new System.Drawing.Point(1086, 14);
            this.amarelo.Name = "amarelo";
            this.amarelo.Size = new System.Drawing.Size(26, 28);
            this.amarelo.TabIndex = 45;
            this.amarelo.UseVisualStyleBackColor = false;
            this.amarelo.Click += new System.EventHandler(this.amarelo_Click);
            // 
            // azul
            // 
            this.azul.BackColor = System.Drawing.Color.DodgerBlue;
            this.azul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azul.Location = new System.Drawing.Point(1150, 13);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(26, 28);
            this.azul.TabIndex = 44;
            this.azul.UseVisualStyleBackColor = false;
            this.azul.Click += new System.EventHandler(this.azul_Click);
            // 
            // laranja
            // 
            this.laranja.BackColor = System.Drawing.Color.DarkOrange;
            this.laranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laranja.Location = new System.Drawing.Point(1054, 14);
            this.laranja.Name = "laranja";
            this.laranja.Size = new System.Drawing.Size(26, 28);
            this.laranja.TabIndex = 43;
            this.laranja.UseVisualStyleBackColor = false;
            this.laranja.Click += new System.EventHandler(this.laranja_Click);
            // 
            // vermelhoEscuro
            // 
            this.vermelhoEscuro.BackColor = System.Drawing.Color.DarkRed;
            this.vermelhoEscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vermelhoEscuro.Location = new System.Drawing.Point(990, 14);
            this.vermelhoEscuro.Name = "vermelhoEscuro";
            this.vermelhoEscuro.Size = new System.Drawing.Size(26, 28);
            this.vermelhoEscuro.TabIndex = 42;
            this.vermelhoEscuro.UseVisualStyleBackColor = false;
            this.vermelhoEscuro.Click += new System.EventHandler(this.vermelhoEscuro_Click);
            // 
            // cinza
            // 
            this.cinza.BackColor = System.Drawing.Color.DimGray;
            this.cinza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinza.Location = new System.Drawing.Point(958, 14);
            this.cinza.Name = "cinza";
            this.cinza.Size = new System.Drawing.Size(26, 28);
            this.cinza.TabIndex = 41;
            this.cinza.UseVisualStyleBackColor = false;
            this.cinza.Click += new System.EventHandler(this.cinza_Click);
            // 
            // branco
            // 
            this.branco.BackColor = System.Drawing.Color.White;
            this.branco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branco.Location = new System.Drawing.Point(926, 60);
            this.branco.Name = "branco";
            this.branco.Size = new System.Drawing.Size(26, 28);
            this.branco.TabIndex = 40;
            this.branco.UseVisualStyleBackColor = false;
            this.branco.Click += new System.EventHandler(this.branco_Click);
            // 
            // preto
            // 
            this.preto.BackColor = System.Drawing.Color.Black;
            this.preto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preto.Location = new System.Drawing.Point(926, 14);
            this.preto.Name = "preto";
            this.preto.Size = new System.Drawing.Size(26, 28);
            this.preto.TabIndex = 39;
            this.preto.UseVisualStyleBackColor = false;
            this.preto.Click += new System.EventHandler(this.preto_Click);
            // 
            // vermelho
            // 
            this.vermelho.BackColor = System.Drawing.Color.Red;
            this.vermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vermelho.Location = new System.Drawing.Point(1022, 14);
            this.vermelho.Name = "vermelho";
            this.vermelho.Size = new System.Drawing.Size(26, 28);
            this.vermelho.TabIndex = 38;
            this.vermelho.UseVisualStyleBackColor = false;
            this.vermelho.Click += new System.EventHandler(this.vermelho_Click);
            // 
            // corRecente
            // 
            this.corRecente.BackColor = System.Drawing.Color.Black;
            this.corRecente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.corRecente.ForeColor = System.Drawing.Color.Transparent;
            this.corRecente.Location = new System.Drawing.Point(841, 12);
            this.corRecente.Name = "corRecente";
            this.corRecente.Size = new System.Drawing.Size(63, 59);
            this.corRecente.TabIndex = 37;
            this.corRecente.UseVisualStyleBackColor = false;
            // 
            // verde
            // 
            this.verde.BackColor = System.Drawing.Color.Green;
            this.verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verde.Location = new System.Drawing.Point(1118, 14);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(26, 28);
            this.verde.TabIndex = 36;
            this.verde.UseVisualStyleBackColor = false;
            this.verde.Click += new System.EventHandler(this.verde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Contorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Gravar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1289, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(577, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 65);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 20);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button reta;
        private System.Windows.Forms.Button quadrilatero;
        private System.Windows.Forms.Button circulo;
        private System.Windows.Forms.Button triangulo;
        private System.Windows.Forms.Button pentagono;
        private System.Windows.Forms.Button prisma;
        private System.Windows.Forms.ComboBox Espessura;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox estilhoLinha;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button gravarTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verde;
        private System.Windows.Forms.Button corRecente;
        private System.Windows.Forms.Button vermelho;
        private System.Windows.Forms.Button preto;
        private System.Windows.Forms.Button roxoClaro;
        private System.Windows.Forms.Button azulCinza;
        private System.Windows.Forms.Button azulClaro;
        private System.Windows.Forms.Button rosa;
        private System.Windows.Forms.Button amareloEscuro;
        private System.Windows.Forms.Button marrom;
        private System.Windows.Forms.Button cinzaClaro;
        private System.Windows.Forms.Button verdeClaro;
        private System.Windows.Forms.Button amareloClaro;
        private System.Windows.Forms.Button roxo;
        private System.Windows.Forms.Button azulEscuro;
        private System.Windows.Forms.Button amarelo;
        private System.Windows.Forms.Button azul;
        private System.Windows.Forms.Button laranja;
        private System.Windows.Forms.Button vermelhoEscuro;
        private System.Windows.Forms.Button cinza;
        private System.Windows.Forms.Button branco;
    }
}

