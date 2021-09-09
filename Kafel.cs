using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzukajDrogi
{
    public partial class Kafel : UserControl
    {
        int _wartosc;
        int _X;
        int _Y;
        string _name;
        public List<Kafel> sasiedzi; 

        [Category ("Custom Properties")]
        public int Wartosc
        {
            get { return _wartosc; }
            set 
            {
                _wartosc = value;
                lblWartosc.Text = _wartosc.ToString();             
            }
        }

        public int X
        {
            get { return _X; }
            set { _X = value;  }
        }

        public int Y
        {
            get { return _Y; }
            set { _Y = value;  }
        }

        public string Name
        {
            get { return _name;  }
            set { _name = value;  }
        }

        public Kafel()
        {
            sasiedzi = new List<Kafel>();
            InitializeComponent();
        }

        private void lblWartosc_Click(object sender, EventArgs e)
        {
            Kafel kafelek = (Kafel)sender;
            int war = kafelek.Wartosc;
            kafelek.BackColor = Color.Yellow; 
        }

        public void NowySasiad(Kafel sasiad)
        {
            this.sasiedzi.Add(sasiad);        
        }
    }
}
