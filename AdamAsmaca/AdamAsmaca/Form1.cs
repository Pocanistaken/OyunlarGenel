using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        /*
        Bu kısımda bazı objeleri tanımlıyorum tekrardan erişip kullanabilmek için
         */
        List<char> harfListesi = new List<char>();
        string randomKelime = null;
        int hataSayaci = 0;
        


        public Form1()
        {
            InitializeComponent();
            // Oyunu başlatma fonksiyonunu contractor içerisinde çağırıyorum.
            Start_Game();


            // Burada otomatik bir şekilde butonları aynı event içerisine ekliyorum tek tek her buton için
            // Click eventi oluşturmaktansa bu şekilde yapmak daha mantıklı.
            buttonQ.Click += Button_Click;
            for (int i = 0; i <= 30; i++)
            {
                this.Controls["button" + i].Click += Button_Click;
            }
        }




        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text; // Tüm butonların click eventi bağladığımız event fonksiyonumuzdan tıkladığımız butonun adını çekiyorum.
                clickedButton.Enabled = false; // Tıklanılan denenen butonun bir daha tıklanmaması için butonu devre dışı bırakıyorum.


                string kelime = buttonText.ToLower(); // Seçilen
                char c = kelime[0]; // Stringi chara dönüştürüyorum.

                Checker(c); // Checker fonksiyonunu çağırıyorum.



            }
        }   

        private void Start_Game()
        {
            string[] kelimeler = {  "istanbul",  "manisa", "gaziantep", "elazığ", "kars", "izmir"};
            Random random = new Random(); // Random objesini oluşturuyorum
            randomKelime = kelimeler[random.Next(kelimeler.Length)]; // Burada random objesini oluşturduğum nesnedeki Next methodu ile string dizisinden random şehir seçiyor.

            string yazi = null; // Burada yazi değişkenini labeli değiştirmek için oluşturdum


            for (int i = 0; i < randomKelime.Length; i++)
            {
                harfListesi.Add('_'); // Liste için.
                yazi += "_ "; // Label için

            }

            kelimeLabel.Text = yazi;

        }


        private void Checker(char c)
        {


            if (randomKelime.Contains(c)) // Eğer random oluşan kelime fonksiyonun parametresindeki harfi içeriyorsa
            {


                for (int i = 0; i < randomKelime.Length; i++) // Burada döngü oluşturuyorum sebebi örneğin birden fazla aynı harf olabilir hepsini tespit edebilmek için.
                {
                    if (randomKelime[i].Equals(c))
                    {
                        harfListesi[i] = c;

                        kelimeLabel.Text = "";


                    }
                }

            }
            else
            {
                hataSayaci++;
                kalanHakLabel.Text = "Kalan hak = " + (11 - hataSayaci);

                // Burada resim gösterme kısmında otomasyon denedim fakat hiçbir kod çalışmadı
                // Çalışmadığı için klasik yöntem olarak tek tek kontrol ekledim.

                if (hataSayaci == 0)
                {
                    pictureBox1.Image = Properties.Resources._0;
                }

                if (hataSayaci == 1)
                {
                    pictureBox1.Image = Properties.Resources._1;
                }

                if (hataSayaci == 2)
                {
                    pictureBox1.Image = Properties.Resources._2;

                }

                if (hataSayaci == 3)
                {
                    pictureBox1.Image = Properties.Resources._3;

                }

                if (hataSayaci == 4)
                {
                    pictureBox1.Image = Properties.Resources._4;

                }

                if (hataSayaci == 5)
                {
                    pictureBox1.Image = Properties.Resources._5;

                }

                if (hataSayaci == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;

                }

                if (hataSayaci == 7)
                {
                    pictureBox1.Image = Properties.Resources._7;

                }

                if (hataSayaci == 8)
                {
                    pictureBox1.Image = Properties.Resources._8;

                }
                if (hataSayaci == 9)
                {
                    pictureBox1.Image = Properties.Resources._9;

                }

                if (hataSayaci == 10)
                {
                    pictureBox1.Image = Properties.Resources._10;

                }

                if (hataSayaci == 11)
                {
                    pictureBox1.Image = Properties.Resources._11;
                    MessageBox.Show("Oyun bitti!");
                    Application.Exit();


                }


            }

            string yazi = null;
            for(int i = 0; i< harfListesi.Count; i++)
            {
                yazi += harfListesi[i] + " ";


            }
            kelimeLabel.Text = yazi;


            // Burada harflistesindeki listede eğer _ yoksa oyunu kullanıcı kazanıyor çünkü başka açılacak kelime kalmadığı için.
            if (!harfListesi.Contains('_'))
            {
                MessageBox.Show("Oyunu kazandın!");
                Application.Exit();


            }
        }
    }
}
