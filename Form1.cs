using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace SzukajDrogi
{
    public partial class Form1 : Form
    {
                
        int iiX, iiY;
        public List<Kafel> Kafle { get; set; }
        public List<Kafel> KafleZnalezionejSciezki { get; set; }
        int liczbakafli { get; set; }
        Kafel Cel { get; set; }
        Kafel Start { get; set; } 
        int NajkrotszaDroga { get; set; }
        string NajkrotszaSciezka { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Events  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kafel4_Load(object sender, EventArgs e)
        {

        }

        private void kafel3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BudujMape();
        }

        private void kafel1_Load(object sender, EventArgs e)
        {

        }


        private void pMapa_Paint(object sender, PaintEventArgs e)
        {

        }




        private void pMapa_Click(object sender, EventArgs e)
        {
            bool test = true;
            Kafel kafel = (Kafel)sender;
            int wart = kafel.Wartosc;
        }

        #endregion

        #region Function
        public void PokazPolozenie(object sender, EventArgs e)
        {
            Kafel tmp = (Kafel)sender;
            SetColorKafli(Color.LightGray);
            lblX.Text = tmp.X.ToString();
            lblY.Text = tmp.Y.ToString();
            lblWartosc.Text = tmp.Wartosc.ToString();
            tmp.BackColor = Color.Yellow; 
            this.Cel = tmp;

        }

        /// <summary>
        /// Ustawiam kolor kafli 
        /// </summary>
        /// <param name="kolor"></param>
        private void SetColorKafli(Color kolor)
        {
            foreach (Kafel tmp in Kafle)
            {
                tmp.BackColor = kolor;
            }
        }

        /// <summary>
        /// szukam okreśłonego kafla
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Kafel ZnajdzKafel(int x, int y)
        {
            return Kafle.Find(tmp => tmp.X == x && tmp.Y == y);        
        }

        /// <summary>
        /// Wywołanie szukania drogi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSzukajDrogi_Click(object sender, EventArgs e)
        {
            SzukajDrogi(); 
        }

        /// <summary>
        /// Funkcja wyszukiwania najkrótszej drogi
        /// </summary>
        /// <param name="start"></param>
        /// <param name="cel"></param>
        /// <param name="odwiedzone"></param>
        /// <param name="droga"></param>
        /// <param name="SciezkaKafli"></param>
        /// <returns></returns>
        public int DrogadoKafla_1(Kafel start, Kafel cel, List<Kafel> odwiedzone, int droga, string SciezkaKafli)
        {
            string lsStart, lsTmpKafel;
            int sciezka; 
            lsStart = start.Name;
            string SciezkaOdwiedzona = SciezkaKafli;          

            List<Kafel> SciezkaOdwiedzone = new List<Kafel>();

            foreach (Kafel odwiedzony in odwiedzone)
            {
                SciezkaOdwiedzone.Add(odwiedzony);
            }

            sciezka = droga; 
            foreach (Kafel tmp in start.sasiedzi)
            {
                lsTmpKafel = tmp.Name; 
                if (start.Equals(this.Start))
                {
                    droga = 0;
                    SciezkaKafli = "[00]";
                    SciezkaOdwiedzone = new List<Kafel>();
                 }
                if (!SciezkaOdwiedzone.Contains(tmp))
                {
                    //lbxLog.Items.Add($"Kafel[{ tmp.X}; { tmp.Y} Wartosc {tmp.Wartosc} ]");
                    if (tmp.Name ==Cel.Name)
                    {
                        //KafleDroga.Add(tmp);
                        droga = sciezka + tmp.Wartosc;
                        if (SciezkaOdwiedzona == "")
                        {
                            SciezkaOdwiedzona = SciezkaKafli + tmp.Name;
                        }
                        else
                        {
                            SciezkaOdwiedzona = SciezkaKafli + "|" + tmp.Name;
                        }
                        // lbxLog.Items.Add($"Zbadana sciezka {SciezkaOdwiedzona} o długości {droga} ");
                        if (NajkrotszaDroga == -1)
                        {
                            NajkrotszaDroga = droga;
                            NajkrotszaSciezka = SciezkaOdwiedzona;
                            KafleZnalezionejSciezki.Clear(); 
                        }
                        else
                        {
                            if (NajkrotszaDroga > droga)
                            {
                                NajkrotszaDroga = droga;
                                NajkrotszaSciezka = SciezkaOdwiedzona;
                                KafleZnalezionejSciezki.Clear();
                            }
                        }                                 

                    }
                    else
                    {
                        
                        SciezkaOdwiedzone.Add(start);
                        droga = sciezka + tmp.Wartosc;
                        if (NajkrotszaDroga > 0 && droga > NajkrotszaDroga) return droga;
                        if (SciezkaOdwiedzona == "")
                        {
                            SciezkaOdwiedzona = SciezkaKafli + tmp.Name;
                        }
                        else
                        {
                            SciezkaOdwiedzona = SciezkaKafli + "|" + tmp.Name;
                        }

                        // SciezkaOdwiedzona = SciezkaKafli + tmp.Name;
                        droga = DrogadoKafla_1(tmp, Cel, SciezkaOdwiedzone, droga, SciezkaOdwiedzona);
                    }
                }
            }
            return droga;        
        }

        /// <summary>
        /// Buduje Mape o wymiarach określonych przez użytkownika w oknie
        /// </summary>
        private void BudujMape()
        {
            Kafel sasiad;
            Kafle = new List<Kafel>();
            iiX = (int)nX.Value;
            iiY = (int)nY.Value;

            pMapa.Width = (int)(iiX * 30);
            pMapa.Height = (int)(iiY * 30);
            pMapa.SuspendLayout();
            pMapa.Controls.Clear();
            for (int i = 0; i < iiY; i++)
            {
                for (int j = 0; j < iiX; j++)
                {
                    System.Threading.Thread.Sleep(1);
                    Random rnd = new Random();
                    Kafel kafel = new Kafel();
                    kafel.Wartosc = rnd.Next(10) + 1;
                    kafel.BackColor = Color.LightGray;
                    kafel.Y = i;
                    kafel.X = j;
                    kafel.Name = $"[{j}{i}]";
                    kafel.Click += new EventHandler(PokazPolozenie);

                    sasiad = ZnajdzKafel(j - 1, i);
                    if (sasiad != null)
                    {
                        kafel.NowySasiad(sasiad);
                        sasiad.NowySasiad(kafel);
                    }

                    sasiad = ZnajdzKafel(j, i - 1);
                    if (sasiad != null)
                    {
                        kafel.NowySasiad(sasiad);
                        sasiad.NowySasiad(kafel);
                    }
                    pMapa.Controls.Add(kafel);
                    Kafle.Add(kafel);

                }
            }
            pMapa.ResumeLayout();
            pMapa.Refresh();
            pMapa.Visible = true;
        }

        /// <summary>
        /// Przygotowanie danych i uruchomienie funkcji wyszukiwania najkrótszej drogi 
        /// </summary>
        private void SzukajDrogi()
        {
            int droga = 0;
            KafleZnalezionejSciezki = new List<Kafel>();
            string sciezkakafli = "[00]";
            NajkrotszaDroga = -1;
            NajkrotszaSciezka = "";
            liczbakafli = 0;

            //zmieniam kolor kafli
            SetColorKafli(Color.LightSeaGreen);

            if (this.Cel == null)
            {
                MessageBox.Show("Wskaż cel podróży !!!");
            }
            else
            {
                lbxLog.Items.Clear();
                List<Kafel> Odwiedzone = new List<Kafel>();
                this.Start = Kafle[0];
                droga = DrogadoKafla_1(this.Start, Cel, Odwiedzone, droga, sciezkakafli);
                lbxLog.Items.Add($"Znaleziono najkrotszą drogę: {NajkrotszaDroga} {NajkrotszaSciezka}");
                string[] kafle = NajkrotszaSciezka.Split('|');
                foreach (string tmp in kafle)
                {
                    Kafel KafelSciezki = Kafle.Find(x => x.Name == tmp);
                    if (KafelSciezki != null) KafelSciezki.BackColor = Color.Red;
                }
            }
        }

        #endregion

    }
}
