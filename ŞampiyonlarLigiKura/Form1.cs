using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞampiyonlarLigiKura
{
    public partial class Form1 : Form
    {
        //List ögesi verileri hafızada tutmaya yarar ve onları listeler.
        List<Takım> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takım yenitakim = null;

            takimlar = new List<Takım>();

            yenitakim= new Takım ("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Barcelona", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Paris Saint Germain", "Fransa");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Juventus", "İtalya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Inter", "İtalya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("RasenBallsport Leipzig", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Atalanta", "İtalya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Lazio", "İtalya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Sevilla", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Borussia Mönchengladbach", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Ajax Amsterdam", "Hollanda");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Porto", "Portekiz");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Stade Rennes", "Fransa");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Olimpik Marsilya", "Fransa");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Zenit", "Rusya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Brügge", "Belçika");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Red Bull Salzburg", "Avusturya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Skakhtar Donetsk", "Avusturya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("FK Krasnodar", "Rusya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Dynamo Kyiv", "Ukrayna");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Olimpiakos Pire", "Yunanistan");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("İstanbul Başakşehir", "Türkiye");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Lokomotif Moskova", "Rusya");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("FC Midtjylland", "Danimarka");
            takimlar.Add(yenitakim);

            yenitakim = new Takım("Ferencvarosi TC", "Macaristan");
            takimlar.Add(yenitakim);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear(); //aynı takımlar seçilmesin.
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rnd.Next(0, takimlar.Count / 4); //her torbaya 8 tane takım rastgele gidecek.

                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                //aynı ülke takımları aynı gruba düşmesin.
                bool ayniulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = AynıUlkedenTakimVarMi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takım);
                    if (ayniulkedentakimvar)
                    {
                        break;
                    }

                }
                if (!ayniulkedentakimvar) //eğer aynı ülkeden takım yoksa o zaman listboxlara ekle.
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takım);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takım);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takım);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takım);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takım);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takım);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takım);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takım);
                }
                else
                {
                    j--;
                }
            }
        }
                private bool AynıUlkedenTakimVarMi(ListBox grup, Takım takim)
                {
                    bool durum = false;
                    for (int i = 0; i < grup.Items.Count; i++)
                    {
                        Takım gruptakim = grup.Items[i] as Takım;
                        if (gruptakim.CountryName==takim.CountryName)
                {
                    durum = true;
                    break;
                }
                }
            return durum;
                }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> seçilentakimlar = new List<int>();
            for(int i=0;i<takimlar.Count;i++)
            {
                int seçilentakim = rnd.Next(0, takimlar.Count);
                if(seçilentakimlar.Contains(seçilentakim))
                {
                    i--;
                }
                else
                {
                    seçilentakimlar.Add(seçilentakim);
                }
            }
            for(int i=0;i<seçilentakimlar.Count;i++)
            {
                if(i<8)
                {
                    listBox1.Items.Add(takimlar[seçilentakimlar[i]]);
                }
                else if(i<16)
                {
                    listBox2.Items.Add(takimlar[seçilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    listBox3.Items.Add(takimlar[seçilentakimlar[i]]);
                }
                else 
                {
                    listBox4.Items.Add(takimlar[seçilentakimlar[i]]);
                }
            }
            torbalar.Add(listBox1);
            torbalar.Add(listBox2);
            torbalar.Add(listBox3);
            torbalar.Add(listBox4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }
    }
        }
 
