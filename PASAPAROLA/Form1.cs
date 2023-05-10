using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASAPAROLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {

                    case 1:
                        if (bunifuMetroTextbox1.Text=="Adana"||bunifuMetroTextbox1.Text=="adana")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                           5
                            
                        }
                        else
                        {
                            button6.BackColor=Color.Red;
                            yanlıs++;
                            label3.Text=yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                            
                        }

                        break;
                    case 2:
                        if (bunifuMetroTextbox1.Text == "Bist" || bunifuMetroTextbox1.Text == "bist")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 3:
                        if (bunifuMetroTextbox1.Text == "Cömert" || bunifuMetroTextbox1.Text == "cömert")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";

                        }
                        break;
                        case 4:
                        if (bunifuMetroTextbox1.Text == "Dolar" || bunifuMetroTextbox1.Text == "dolar")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 5:
                        if (bunifuMetroTextbox1.Text == "Esir" || bunifuMetroTextbox1.Text == "esir")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 6:
                        if (bunifuMetroTextbox1.Text == "Fevri" || bunifuMetroTextbox1.Text == "fevri")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 7:
                        if (bunifuMetroTextbox1.Text == "Gümüş" || bunifuMetroTextbox1.Text == "gümüş")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 8:
                        if (bunifuMetroTextbox1.Text == "Horlamak" || bunifuMetroTextbox1.Text == "Horlamak")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 9:
                        if (bunifuMetroTextbox1.Text == "Iğdır" || bunifuMetroTextbox1.Text == "ığdır")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 10:
                        if (bunifuMetroTextbox1.Text == "İlkkan" || bunifuMetroTextbox1.Text == "ilkkan")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 11:
                        if (bunifuMetroTextbox1.Text == "Jerry" || bunifuMetroTextbox1.Text == "jerry")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 12:
                        if (bunifuMetroTextbox1.Text == "Kolera" || bunifuMetroTextbox1.Text == "kolera")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 13:
                        if (bunifuMetroTextbox1.Text == "Leyla" || bunifuMetroTextbox1.Text == "leyla")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 14:
                        if (bunifuMetroTextbox1.Text == "Mona Lisa" || bunifuMetroTextbox1.Text == "mona lisa" || bunifuMetroTextbox1.Text == "Mona lisa")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 15:
                        if (bunifuMetroTextbox1.Text == "Nil " || bunifuMetroTextbox1.Text == "nil")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 16:
                        if (bunifuMetroTextbox1.Text == "Ortodoks" || bunifuMetroTextbox1.Text == "ortodoks")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 17:
                        if (bunifuMetroTextbox1.Text == "Püre" || bunifuMetroTextbox1.Text == "Püre")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 18:
                        if (bunifuMetroTextbox1.Text == "Rusya" || bunifuMetroTextbox1.Text == "rusya")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 19:
                        if (bunifuMetroTextbox1.Text == "Sığ" || bunifuMetroTextbox1.Text == "sığ")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 20:
                        if (bunifuMetroTextbox1.Text == "Tolunay Ören" || bunifuMetroTextbox1.Text == "tolunay ören" || bunifuMetroTextbox1.Text == "Tolunay ören")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 21:
                        if (bunifuMetroTextbox1.Text == "Uhud" || bunifuMetroTextbox1.Text == "uhud")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 22:
                        if (bunifuMetroTextbox1.Text == "Venedik" || bunifuMetroTextbox1.Text == "venedik")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 23:
                        if (bunifuMetroTextbox1.Text == "Yusuf Has Hacip" || bunifuMetroTextbox1.Text == "Yusuf has hacip")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                        }
                        break;
                        case 24:
                        if (bunifuMetroTextbox1.Text == "Zaman Makinesi" || bunifuMetroTextbox1.Text == "zaman makinesi" || bunifuMetroTextbox1.Text == "Zaman makinesi")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            bunifuMetroTextbox1.Text = "";
                            MessageBox.Show("Tebrikler son soruyu doğru cevapladınız doğru :"+label2.Text+"yanlış :"+label3.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                            bunifuMetroTextbox1.Text = "";
                            MessageBox.Show("Son soruya ulaştınız :" + label2.Text + "yanlış :" + label3.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;



                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            linkLabel1.Text = "SONRAKİ";
            soruno++;
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizde pamuğu ile ünlü olan insanlarının güneşe ateş açtığı şehrimizin ismi nedir ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İstanbul borsasına kısaltma olarak ne denir?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {

                richTextBox1.Text = "Hesabı ödeyen , parayı önemsemeyen insana ne denir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {

                richTextBox1.Text = "Sürekli yükselen bozdurdukça çoğalan şeye ne denir?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {

                richTextBox1.Text = "Savaş sırasında ele geçirilen askerlere ne isim verilir?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {

                richTextBox1.Text = "Tartışma esnasında karşıdaki insan aceleci davranmasına ne denir?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {

                richTextBox1.Text = "Ag elementinin türkçe karşılığı nedir?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {

                richTextBox1.Text = "Uyurken yapılan ve diğer insanları rahatsız eden eyleme ne isim verilir?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {

                richTextBox1.Text = "En doğuda yer alan ilimizin ismi nedir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {

                richTextBox1.Text = "Gibi dizinde üç yakın arkadaştan kel olan oyuncunun ismi nedir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {

                richTextBox1.Text = "Bir kedi ve farenin kavgalarını anlatan ünlü çizgifilm de farenin ismi nedir?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {

                richTextBox1.Text = "Sagopa kajmer ile bir dönem ilişkileri olan ünlü kadın rap sanatçısının lakabı nedir?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {

                richTextBox1.Text = "Başrollerini Ali Atay ve Ezgi Asaroğlunun paylaştığı türk dizisinde Ezgi Asaroğlunun canlandırdığı karakterin ismi nedir?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {

                richTextBox1.Text = "Leonardo da Vinci ' ye ait olan ünlü tablonun ismi nedir?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {

                richTextBox1.Text = "Mısırdan geçen ve zamanında kutsal sayılan nehirin ismi nedir?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {

                richTextBox1.Text = "Bir hristiyan mezhebine verilen isim nedir?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {

                richTextBox1.Text = "Bebeklere verilen özel yiyeceğe verilen isim?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {

                richTextBox1.Text = "Alaskayı Amerikaya satan ülke nedir?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {

                richTextBox1.Text = "Balıklama atlamanın tehlikeli olduğu deniz seviyesine ne ad verilir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {

                richTextBox1.Text = "Burnu ile fazladan yer kaplayan Sinan Engin ile yakın arkadaş twitch yayıncısın ismi nedir?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {

                richTextBox1.Text = "Okçuların yerlerini terkettiği ünlü savaşın ismi nedir?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {

                richTextBox1.Text = "İçinde sandallar ile seyahat edilebilen şehrin ismi nedir?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {

                richTextBox1.Text = "Türk edebiyatı için önemli eserlerden biri olan 'Kutadgu Bilig' eserinin yazarı kimdir?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {

                richTextBox1.Text = "İleri bir tarihe gitmek için kullanılan hayali alate ne isim verilir?";
                button24.BackColor = Color.Yellow;
            }
        }
    }
}
