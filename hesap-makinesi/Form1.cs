namespace hesap_makinesi
{
    public partial class HESAPMAK�NES� : Form
    {
        private char _islem;
        private bool _ekranTEM�ZLENECEKM�;
        private int _ilksayi;
        public HESAPMAK�NES�()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }

            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void say�1Button_Click(object sender, EventArgs e)
        {

            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void say�2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void say�4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void say�5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void say�6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void say�7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void say�8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void say�9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void say�0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEM�ZLENECEKM�)
            {
                ekranlabel.Text = "";
                _ekranTEM�ZLENECEKM� = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTEM�ZLENECEKM� = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTEM�ZLENECEKM� = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTEM�ZLENECEKM� = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTEM�ZLENECEKM� = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
