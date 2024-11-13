using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        // Kuşun düşme hızı (yer çekimi)
        int gravity = 15;

        // Boruların hızı
        int pipespeed = 6;

        // Skor
        int score = 0;

        public Form1()
        {
            InitializeComponent(); // Form bileşenlerini başlat
        }

        
        private void pictureBox2_Click(object sender, EventArgs e) { }

        
        private void pictureBox1_Click(object sender, EventArgs e) { }

        
        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Oyunu yeniden başlatan  metod
        public void startGame()
        {
            game_timer.Start(); // Oyun zamanlayıcısını başlat

            pic_bird.Top = 0; // Kuşu başlangıç konumuna getir

            pic_pipeup.Left = 800; // Üst borunun başlangıç konumunu ayarla

            pic_pipedown.Left = 950; // Alt borunun başlangıç konumunu ayarla

            score = 0; // Skoru sıfırla

            pipespeed = 6; // Boru hızını başlangıç değerine ayarla
        }

        // Zamanlayıcı her tick olduğunda çağrılır
        private void game_timer_Tick(object sender, EventArgs e)
        {
            pic_bird.Top = pic_bird.Top + gravity; // Kuşu yer çekimi etkisiyle aşağı indir

            pic_pipedown.Left = pic_pipedown.Left - pipespeed; // Alt boruyu sola hareket ettir

            pic_pipeup.Left = pic_pipeup.Left - pipespeed; // Üst boruyu sola hareket ettir

            lbl_score.Text = "score : " + score; // Skoru güncelle

            // Eğer alt boru ekranın sol kenarını geçerse
            if (pic_pipedown.Left < -180)
            {
                pic_pipedown.Left = 950; // Alt boruyu sağdan tekrar getir

                score++; // Skoru artır
            }

            // Eğer üst boru ekranın sol kenarını geçerse
            if (pic_pipeup.Left < -150)
            {
                pic_pipeup.Left = 800; // Üst boruyu sağdan tekrar getir
            }

            // Eğer kuş herhangi bir boruya, yere veya üst kenara çarparsa bitir
            if (pic_bird.Bounds.IntersectsWith(pic_pipedown.Bounds) || pic_bird.Bounds.IntersectsWith(pic_pipeup.Bounds) || pic_bird.Bounds.IntersectsWith(pic_ground.Bounds) || pic_bird.Top < -25)
            {
                Endgame(); // Oyunu bitir
            }

            void Endgame()
            {
                game_timer.Stop(); // Zamanlayıcıyı durdur

                lbl_score.Text = " Game over! Press Enter to try again. "; // Oyun bitti mesajını göster
            }

            // Skora bağlı olarak boru hızını artır
            if (score == 5)
            {
                pipespeed = 12; // 5 puanda boru hızını artır
            }

            if (score == 10)
            {
                pipespeed = 18; // 10 puanda boru hızını artır
            }

            if (score == 15)
            {
                pipespeed = 24; // 15 puanda boru hızını artır
            }

            if (score == 20)
            {
                pipespeed = 36; // 20 puanda boru hızını artır
            }
        }

        private void appointmentLabelEdit1_SelectedIndexChanged(object sender, EventArgs e) { } 

        private void label1_Click(object sender, EventArgs e) { } 

        // Kuşun aşağı hareket etmesini sağlayan olay
        private void bird_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Eğer Space tuşuna basıldıysa
            {
                gravity = -15; // Kuşun yukarı çıkmasını sağla (negatif yer çekimi)
            }
        }

        // Kuşun yukarı hareket etmesini sağlayan olay
        private void bird_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Eğer Space tuşuna basıldıysa
            {
                gravity = 9; // Kuşun aşağı düşmesini sağla (pozitif yer çekimi)
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) { } 

        // Form üzerinde Enter tuşuna basıldığında oyunu yeniden başlat
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startGame(); // Oyunu başlat
            }
        }
    }
}
