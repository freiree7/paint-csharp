/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 22 / 05 / 2024
* Autores do Projeto: Felipe Freire Rodrigues de Oliveira
*                    
*
* Turma: 3°H
* Atividade Proposta em aula
 * Observação: < colocar se houver>
 * 
 * 
 * ******************************************************************/

using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace inicioProjeto
{
    public partial class Form1 : Form
    {
        int[,] pontos = new int[5, 5];
        int x, y, c = 0;
        int z = 1;
        string id = "";
        Color cor = new Color();

        string estiloLinhaAtual = "Normal";
        int espessura = 1;
        int raio = 0;
        int raioCirculo = 0;
        int raioCirculoMenor = 0;
        int largura, altura;
        string figuraGeometrica = "";
        string caminhoArquivo = $@"E:\arquivo.dat";
        string arquivos = "";
        int r;
        int g;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

       

        public Color Cor(int r, int g, int b)
        {
            Color cor = new Color();
            cor = Color.FromArgb(r, g, b);

            return cor;
        }


        public void Ponto(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1 + 1, y1);

        }


        public void Reta(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            Ponto(e, x0, y0, x1, y1, caneta);
        }




        public void CirculoElipse(PaintEventArgs e, int Xc, int Yc, int Rx, int Ry, int Ti, int Tf, Pen caneta)
        {

            int inicio = 0;
            int completa = 360;



            for (int i = Ti; i <= completa; i++)
            {
                double x1 = Xc + Ry * Math.Cos(inicio * (Math.PI / 180));
                double y1 = Yc + Rx * Math.Sin(inicio * (Math.PI / 180));


                int x = (int)x1;
                int y = (int)y1;

                double x2 = Xc + Ry * Math.Cos(i * Math.PI / 180);
                double y2 = Yc + Rx * Math.Sin(i * Math.PI / 180);

                Ponto(e, x, y, (int)x2, (int)y2, caneta);

                inicio = i;
            }
        }

        public void Retangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            e.Graphics.DrawRectangle(caneta, x0, y0, x1, y1);
        }

        public void Triangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, Pen caneta)
        {
            Reta(e, x0, y0, x1, y1, caneta);
            Reta(e, x1, y1, x2, y2, caneta);
            Reta(e, x2, y2, x0, y0, caneta);
        }

        public void Prisma(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, int x3, int y3, Pen caneta)
        {
            Reta(e, x0, y0, x1, y1, caneta);
            Reta(e, x1, y1, x2, y2, caneta);
            Reta(e, x2, y2, x3, y3, caneta);
            Reta(e, x3, y3, x0, y0, caneta);
        }

        public void Quadrilatero(PaintEventArgs e, int x0, int y0, int largura, int altura, Pen caneta)
        {
            e.Graphics.DrawRectangle(caneta, x0, y0, largura, altura);
        }

        public void Pentagono(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, Pen caneta)
        {
            Reta(e, x0, y0, x1, y1, caneta);
            Reta(e, x1, y1, x2, y2, caneta);
            Reta(e, x2, y2, x3, y3, caneta);
            Reta(e, x3, y3, x4, y4, caneta);
            Reta(e, x4, y4, x0, y0, caneta);

        }


        private void reta_Click(object sender, EventArgs e)
        {
            z++;
            id = "reta";
            figuraGeometrica = "reta";
        }

        private void quadrilatero_Click(object sender, EventArgs e)
        {
            z++;
            id = "quadrilatero";
            figuraGeometrica = "quadrilatero";
        }

        private void circulo_Click(object sender, EventArgs e)
        {
            z++;
            id = "circulo";
            figuraGeometrica = "circulo";
        }

        private void pentagono_Click(object sender, EventArgs e)
        {
            z++;
            id = "pentagono";
            figuraGeometrica = "pentagono";
        }

        private void triangulo_Click(object sender, EventArgs e)
        {
            z++;
            id = "triangulo";
            figuraGeometrica = "triangulo";
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            z++;
            id = "elipse";
            figuraGeometrica = "elipse";
        }
        private void prisma_Click(object sender, EventArgs e)
        {
            z++;
            id = "prisma";
            figuraGeometrica = "prisma";
        }


        private void Espessura_SelectedIndexChanged(object sender, EventArgs e)
        {

            espessura = int.Parse(Espessura.SelectedItem.ToString());
        }

        private void estilhoLinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            estiloLinhaAtual = estilhoLinha.SelectedItem.ToString();
        }



        private void atualizaCor()
        {
            corRecente.BackColor = cor;
        }

        



        public Pen canetinha(Color cor, int espessura)
        {
            Pen caneta = new Pen(cor, espessura);
            if (estiloLinhaAtual == "Tracejada")
            {
                float[] estilo = { 5, 2 };
                caneta.DashPattern = estilo;
            }
            if (estiloLinhaAtual == "Pontilhada")
            {
                float[] estilo = { 1, 2 };
                caneta.DashPattern = estilo;
            }
            if (estiloLinhaAtual == "TraçoPonto")
            {
                float[] estilo = { 5, 2, 1, 2 };
                caneta.DashPattern = estilo;
            }
            if (estiloLinhaAtual == "TraçoDoisPontos")
            {
                float[] estilo = { 4, 2, 1, 2, 1, 2 };
                caneta.DashPattern = estilo;
            }
            return caneta;
        }


        

        private void preto_Click(object sender, EventArgs e)
        {
            cor = preto.BackColor;
            atualizaCor();
        }
        private void vermelho_Click(object sender, EventArgs e)
        {
            cor = vermelho.BackColor;
            atualizaCor();
        }
        private void verde_Click(object sender, EventArgs e)
        {
            cor = verde.BackColor;
            atualizaCor();
        }

        private void branco_Click(object sender, EventArgs e)
        {
            cor = branco.BackColor;
            atualizaCor();
        }

        private void cinza_Click(object sender, EventArgs e)
        {
            cor = cinza.BackColor;
            atualizaCor();
        }

        private void cinzaClaro_Click(object sender, EventArgs e)
        {
            cor = cinzaClaro.BackColor;
            atualizaCor();
        }

        private void vermelhoEscuro_Click(object sender, EventArgs e)
        {
            cor = vermelhoEscuro.BackColor;
            atualizaCor();

        }

        private void marrom_Click(object sender, EventArgs e)
        {
            cor = marrom.BackColor;
            atualizaCor();
        }

        private void rosa_Click(object sender, EventArgs e)
        {
            cor = rosa.BackColor;
            atualizaCor();
        }

        private void laranja_Click(object sender, EventArgs e)
        {
            cor = laranja.BackColor;
            atualizaCor();
        }

        private void amareloEscuro_Click(object sender, EventArgs e)
        {
            cor = amareloEscuro.BackColor;
            atualizaCor();
        }

        private void amarelo_Click(object sender, EventArgs e)
        {
            cor = amarelo.BackColor;
            atualizaCor();
        }

        private void amareloClaro_Click(object sender, EventArgs e)
        {
            cor = amareloClaro.BackColor;
            atualizaCor();
        }

        private void verdeClaro_Click(object sender, EventArgs e)
        {
            cor = verdeClaro.BackColor;
            atualizaCor();
        }

        private void azul_Click(object sender, EventArgs e)
        {
            cor = azul.BackColor;
            atualizaCor();
        }

        private void azulClaro_Click(object sender, EventArgs e)
        {
            cor = azulClaro.BackColor;
            atualizaCor();
        }

        private void azulEscuro_Click(object sender, EventArgs e)
        {
            cor = azulEscuro.BackColor;
            atualizaCor();
        }

        private void azulCinza_Click(object sender, EventArgs e)
        {
            cor = azulCinza.BackColor;
            atualizaCor();
        }

        private void roxo_Click(object sender, EventArgs e)
        {
            cor = roxo.BackColor;
            atualizaCor();
        }

        private void roxoClaro_Click(object sender, EventArgs e)
        {
            cor = roxoClaro.BackColor;
            atualizaCor();
        }




        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (id == "reta")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    c++;
                }
                else if (c == 1)
                {
                    pontos[0, 1] = e.X;
                    pontos[1, 1] = e.Y;
                    c = 0;
                    Invalidate();
                }
            }

            else if (id == "triangulo")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    c++;
                }
                else if (c == 1)
                {
                    pontos[0, 1] = e.X;
                    pontos[1, 1] = e.Y;
                    c++;
                }
                else if (c == 2)
                {
                    pontos[0, 2] = e.X;
                    pontos[1, 2] = e.Y;
                    Invalidate();
                    c = 0;
                }
            }

            else if (id == "pentagono")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    c++;
                }
                else if (c == 1)
                {
                    pontos[0, 1] = e.X;
                    pontos[1, 1] = e.Y;
                    c++;
                }
                else if (c == 2)
                {
                    pontos[0, 2] = e.X;
                    pontos[1, 2] = e.Y;
                    c++;
                }
                else if (c == 3)
                {
                    pontos[0, 3] = e.X;
                    pontos[1, 3] = e.Y;
                    c++;
                }
                else if (c == 4)
                {
                    pontos[0, 4] = e.X;
                    pontos[1, 4] = e.Y;
                    c = 0;
                    Invalidate();
                }
            }

            else if (id == "prisma")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    c++;
                }
                else if (c == 1)
                {
                    pontos[0, 1] = e.X;
                    pontos[1, 1] = e.Y;
                    c++;
                }
                else if (c == 2)
                {
                    pontos[0, 2] = e.X;
                    pontos[1, 2] = e.Y;
                    c++;
                }
                else if (c == 3)
                {
                    pontos[0, 3] = e.X;
                    pontos[1, 3] = e.Y;
                    c = 0;
                    Invalidate();
                }
            }

            else if (id == "circulo")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Digite o raio do círculo:", "Raio do Círculo");
                    if (int.TryParse(input, out int raioC))

                        raio = raioC;


                    c = 0;
                    Invalidate();
                }
            }

            else if (id == "elipse")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    c = 0;
                    string raioMaior = Microsoft.VisualBasic.Interaction.InputBox("Digite o raio do eixo maior da elipse:", "Raio do Eixo Maior", "100");
                    string raioMenor = Microsoft.VisualBasic.Interaction.InputBox("Digite o raio do eixo menor da elipse:", "Raio do Eixo Menor", "50");
                    if (int.TryParse(raioMaior, out int raio1) && int.TryParse(raioMenor, out int raio2))
                    {
                        raioCirculo = raio1;
                        raioCirculoMenor = raio2;
                    }
                    c = 0;
                    Invalidate();

                }
            }

            else if (id == "quadrilatero")
            {
                if (c == 0)
                {
                    pontos[0, 0] = e.X;
                    pontos[1, 0] = e.Y;
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Largura:", "Largura do Quadrilátero");
                    if (int.TryParse(input, out int larguraX))
                    {
                        largura = larguraX;
                    }

                    input = Microsoft.VisualBasic.Interaction.InputBox("Altura:", "Altura do Quadrilátero");
                    if (int.TryParse(input, out int alturaX))
                    {
                        altura = alturaX;
                    }

                    c = 0;
                    Invalidate();
                }
            }
        }


        


      

        private void Form1_Load(object sender, EventArgs e)
        {
            cor = preto.BackColor;
        }





        



     
       


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
             
            if (z > 1)
            {
                switch (id)
                {
                    case "reta":
                        Reta(e, pontos[0, 0], pontos[1, 0], pontos[0, 1], pontos[1, 1], canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Ponto Inicial: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Ponto Final: (" + pontos[0, 1] + "," + pontos[1, 1] + "), Cor: (" + cor.R +"," + cor.G + " ," + cor.B + ") , Estilo linha: " + estiloLinhaAtual + ", Espessura: " + espessura;
                        break;

                    case "triangulo":
                        Triangulo(e, pontos[0, 0], pontos[1, 0], pontos[0, 1], pontos[1, 1], pontos[0, 2], pontos[1, 2], canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Ponto 1: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Ponto 2: (" + pontos[0, 1] + "," + pontos[1, 1] + "), Ponto 3: (" + pontos[0, 2] + "," + pontos[1, 2] + "),  Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;

                    case "pentagono":
                        Pentagono(e, pontos[0, 0], pontos[1, 0], pontos[0, 1], pontos[1, 1], pontos[0, 2], pontos[1, 2], pontos[0, 3], pontos[1, 3], pontos[0, 4], pontos[1, 4], canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Ponto 1: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Ponto 2: (" + pontos[0, 1] + "," + pontos[1, 1] + "), Ponto 3: (" + pontos[0, 2] + "," + pontos[1, 2] + "), Ponto 4: (" + pontos[0, 3] + "," + pontos[1, 3] + "), Ponto 5: (" + pontos[0, 4] + "," + pontos[1, 4] + "), Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;

                    case "circulo":


                        CirculoElipse(e, pontos[0, 0], pontos[1, 0], raio, raio, 0, 360, canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Centro: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Raio: " + raio + ",  Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;


                    case "elipse":


                        CirculoElipse(e, pontos[0, 0], pontos[1, 0], raioCirculoMenor, raioCirculo, 0, 360, canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Centro: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Raio Menor: " + raioCirculoMenor + ", Raio Maior: " + raioCirculo + ",  Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;



                    case "quadrilatero":
                        Quadrilatero(e, pontos[0, 0], pontos[1, 0], largura, altura, canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Ponto Inicial: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Largura: " + largura + ", Altura: " + altura + ",  Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;

                    case "prisma":
                        Prisma(e, pontos[0, 0], pontos[1, 0], pontos[0, 1], pontos[1, 1], pontos[0, 2], pontos[1, 2], pontos[0, 3], pontos[1, 3], canetinha(cor, espessura));
                        arquivos += Environment.NewLine + "Forma: " + figuraGeometrica + ", Ponto 1: (" + pontos[0, 0] + "," + pontos[1, 0] + "), Ponto 2: (" + pontos[0, 1] + "," + pontos[1, 1] + "), Ponto 3: (" + pontos[0, 2] + "," + pontos[1, 2] + "), Ponto 4: (" + pontos[0, 3] + "," + pontos[1, 3] + "),  Cor: (" + cor.R + "," + cor.G + " ," + cor.B + ") , Espessura: " + espessura;
                        break;

                    default:
                        
                        break;
                }




            }

        }

        private void gravarTxt_Click(object sender, EventArgs e)
        {
            if (z > 1) 
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\rbrto\OneDrive\Área de Trabalho\Wagneeer\projetoFelipe\projetoFelipe\dados.dat", true))
                {
                    
                    writer.WriteLine(arquivos);
                }

               
                arquivos = "";
            }

            MessageBox.Show("Informações gravadas com sucesso");
        }

    }
}
