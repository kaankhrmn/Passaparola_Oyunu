using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soruno = 0, doğru = 0, yanlis = 0;
        int sayacD = 0;
        int sayacY = 0;

        private void txtCevap_TextChanged(object sender, EventArgs e)
        {
        //    if (string.IsNullOrEmpty(txtCevap.Text))
        //    {
        //        linkLabel1.Enabled = false;
        //    }
        //    else { linkLabel1.Enabled = true; }
        }

        private void txtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                switch (soruno)
                {
                    
                    case 1:
                        if (txtCevap.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 2:
                        if (txtCevap.Text == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 3:
                        if (txtCevap.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 4:
                        if (txtCevap.Text == "day")
                        {
                            buttonD.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 5:
                        if (txtCevap.Text == "eşek")
                        {
                            buttonE.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 6:
                        if (txtCevap.Text == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 7:
                        if (txtCevap.Text == "gri")
                        {
                            buttonG.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 8:
                        if (txtCevap.Text == "hatay")
                        {
                            buttonH.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 9:
                        if (txtCevap.Text == "ışık")
                        {
                            buttonI.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 10:
                        if (txtCevap.Text == "ingilizce")
                        {
                            buttonİ.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 11:
                        if (txtCevap.Text == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 12:
                        if (txtCevap.Text == "kahramanmaraş")
                        {
                            buttonK.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 13:
                        if (txtCevap.Text == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 14:
                        if (txtCevap.Text == "muz")
                        {
                            buttonM.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 15:
                        if (txtCevap.Text == "nar")
                        {
                            buttonN.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 16:
                        if (txtCevap.Text == "orange")
                        {
                            buttonO.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 17:
                        if (txtCevap.Text == "pasaport")
                        {
                            buttonP.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 18:
                        if (txtCevap.Text == "rize")
                        {
                            buttonR.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 19:
                        if (txtCevap.Text == "sarı")
                        {
                            buttonS.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 20:
                        if (txtCevap.Text == "trabzon")
                        {
                            buttonT.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 21:
                        if (txtCevap.Text == "uludağ")
                        {
                            buttonU.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 22:
                        if (txtCevap.Text == "vişne")
                        {
                            buttonV.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 23:
                        if (txtCevap.Text == "yellow")
                        {
                            buttonY.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {

                            buttonY.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                    case 24:
                        if (txtCevap.Text == "zürafa")
                        {
                            buttonZ.BackColor = Color.Green;
                            sayacD++;
                            lblDogru.Text = sayacD.ToString();
                            txtCevap.Clear();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            sayacY++;
                            lblYanlis.Text = sayacY.ToString();
                            txtCevap.Clear();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text= "Sonraki";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                buttonA.BackColor = Color.Yellow;
                btnHarf.Text = buttonA.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                buttonB.BackColor = Color.Yellow;
                btnHarf.Text = buttonB.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                buttonC.BackColor = Color.Yellow;
                btnHarf.Text = buttonC.Text;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "İngilizce gün ne demek?";
                buttonD.BackColor = Color.Yellow;
                btnHarf.Text = buttonD.Text;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Nasrettin hocanın bindiği hayvan?";
                buttonE.BackColor = Color.Yellow;
                btnHarf.Text = buttonE.Text;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                buttonF.BackColor = Color.Yellow;
                btnHarf.Text = buttonF.Text;

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Beyaz ve siyahın karışımı oluşan renk";
                buttonG.BackColor = Color.Yellow;
                btnHarf.Text = buttonG.Text;

            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Bu bölgeye özel soslu dürüm";
                buttonH.BackColor = Color.Yellow;
                btnHarf.Text = buttonH.Text;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Güneş ne yayar?";
                buttonI.BackColor = Color.Yellow;
                btnHarf.Text = buttonI.Text;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Dünya dili olarak kabul edilen dil?";
                buttonİ.BackColor = Color.Yellow;
                btnHarf.Text = buttonİ.Text;

            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                buttonJ.BackColor = Color.Yellow;
                btnHarf.Text = buttonJ.Text;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Dondurmasıyla ünlü ilimiz?";
                buttonK.BackColor = Color.Yellow;
                btnHarf.Text = buttonK.Text;

            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Kırmızı çiçek?";
                buttonL.BackColor = Color.Yellow;
                btnHarf.Text = buttonL.Text;

            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Maymunların en sevdiği meyve";
                buttonM.BackColor = Color.Yellow;
                btnHarf.Text = buttonM.Text;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Çarşıdan aldın bir tane eve geldin bin tane?";
                buttonN.BackColor = Color.Yellow;
                btnHarf.Text = buttonN.Text;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Turuncunun ingilizcesi?";
                buttonO.BackColor = Color.Yellow;
                btnHarf.Text = buttonO.Text;

            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Yurt dışına çıkmak için gerekli belge?";
                buttonP.BackColor = Color.Yellow;
                btnHarf.Text = buttonP.Text;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Çayıyla meşhur il?";
                buttonR.BackColor = Color.Yellow;
                btnHarf.Text = buttonR.Text;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Yellowun Türkçesi?";
                buttonS.BackColor = Color.Yellow;
                btnHarf.Text = buttonS.Text;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "61 plakaya sahip il?";
                buttonT.BackColor = Color.Yellow;
                btnHarf.Text = buttonT.Text;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Bursa da bir dağ?";
                buttonU.BackColor = Color.Yellow;
                btnHarf.Text = buttonU.Text;

            }
            if (soruno == 22)
            {
                richTextBox1.Text = "kana kırmızı renk veren meyve?";
                buttonV.BackColor = Color.Yellow;
                btnHarf.Text = buttonV.Text;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Sarının ingilizcesi?";
                buttonY.BackColor = Color.Yellow;
                btnHarf.Text = buttonY.Text;

            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Boynu uzun bir hayvan?";
                buttonZ.BackColor = Color.Yellow;
                btnHarf.Text = buttonZ.Text;
                linkLabel1.Text = "son soruya ulaştınız.";
            }

        }
    }
}
