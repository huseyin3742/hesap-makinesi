namespace hesap_makinesi
{
    public partial class HESAPMAKÝNESÝ : Form
    {
        private char _islem;
        private bool _ekranTEMÝZLENECEKMÝ;
        private int _ilksayi;
        public HESAPMAKÝNESÝ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }

            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void sayý1Button_Click(object sender, EventArgs e)
        {

            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void sayý2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void sayý4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void sayý5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void sayý6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void sayý7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void sayý8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void sayý9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void sayý0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMÝZLENECEKMÝ)
            {
                ekranlabel.Text = "";
                _ekranTEMÝZLENECEKMÝ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTEMÝZLENECEKMÝ = true;
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
            _ekranTEMÝZLENECEKMÝ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTEMÝZLENECEKMÝ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTEMÝZLENECEKMÝ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
