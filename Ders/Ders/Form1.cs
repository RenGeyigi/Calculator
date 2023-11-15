using System.Drawing.Text;

namespace Ders
{
    public partial class Form1 : Form
    {
        private char _islem; // alt çizgi her yerde geçerli olduğunu tanımlama adına konur
        private bool _ekrantemzilenecekmi;
        private int _ilksayı;

        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemzilenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemzilenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0 ";
        }

        private void toplaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemzilenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }
        private void cikartButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemzilenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void carpButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemzilenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void bolButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemzilenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(EkranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayı + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayı - ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayı / ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayı * ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            EkranLabel.Text = Convert.ToString(sonuc);
        }



        private void silButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }
    }
}