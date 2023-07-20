using KelimeOgren.Data;
using KelimeOgren.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace KelimeOgren
{
    public partial class FormKelimeEkrani : Form
    {
        public FormKelimeEkrani()
        {
            InitializeComponent();
        }

        List<Word> wordList = new List<Word>();
        Word kelime = new Word();
        int length;
        int kelimeSayisi = 0;
        int kalanSure = 90;
        int kalanHak = 3;
        bool start = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            GetWords();
            lblKalanSure.Text= kalanSure.ToString();
            lblKalanHak.Text= kalanHak.ToString();
        }

        private void tbxEn_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (kelime.ingilizce.ToLower() == tbxEn.Text.ToLower())
            {
                kelimeSayisi++;
                kelime = GetWordById(CreateId());
                tbxEn.Text = null;
                tbxTr.Text = kelime.turkce;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lblKalanSure.Text = kalanSure.ToString();
            if (kalanSure <= 0)
            {
                timer1.Stop();
                MessageBox.Show($"Doðru Cevap Sayýsý : {kelimeSayisi}");
                Clear();
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            if (kalanHak > 0)
            {
                kalanHak--;
                lblMessage.Text = $"{kelime.ingilizce}";

                kelime = GetWordById(CreateId());
                tbxTr.Text = kelime.turkce.ToLower();
                lblKalanHak.Text = $"Kalan Hakkýnýz : {kalanHak}";
            }
            else
            {
                lblMessage.Text = "Pas Hakkýnýz Bulunmamaktadýr!";
            }

        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                timer1.Start();
                start = true;
                btnBitir.Text = "Bitir";
                kelime = GetWordById(CreateId());
                tbxTr.Text = kelime.turkce.ToLower();
                lblKalanHak.Text = $"Kalan Hakkýnýz : {kalanHak}";
            }
            else
            {
                Clear();
                timer1.Stop();
            }
        }


        public void GetWords()
        {
            using (var context = new wordContext())
            {
                var words = context.sozluk.ToList();
                foreach (var word in words)
                {
                    wordList.Add(word);
                }
                length = words.Count;
            }
        }

        public Word GetWordById(int id)
        {
            return wordList.Where(w => w.id == id).First();
        }

        public int CreateId()
        {
            Random random = new Random();
            return random.Next(1, length + 1);
        }

        public void Clear()
        {
            start = false;
            btnBitir.Text = "Baþla";
            kelimeSayisi = 0;
            kalanHak = 3;
            tbxEn.Text = null;
            tbxTr.Text = null;
            kalanSure = 90;
            lblKalanSure.Text = kalanSure.ToString();
            lblKalanHak.Text = $"Kalan Hakkýnýz : {kalanHak}";

        }
    }
}