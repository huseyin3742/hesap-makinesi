namespace hesap_makinesi
{
    public partial class HESAPMAKİNESİ : Form
    {
        private char _islem;
        private bool _ekranTEMİZLENECEKMİ;
        private int _ilksayi;
        public HESAPMAKİNESİ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }

            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void sayı1Button_Click(object sender, EventArgs e)
        {

            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void sayı2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void sayı4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void sayı5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void sayı6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void sayı7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void sayı8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void sayı9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void sayı0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTEMİZLENECEKMİ)
            {
                ekranlabel.Text = "";
                _ekranTEMİZLENECEKMİ = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTEMİZLENECEKMİ = true;
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
            _ekranTEMİZLENECEKMİ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTEMİZLENECEKMİ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTEMİZLENECEKMİ = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
