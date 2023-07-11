
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2021-2022 BAHAR DÖNEMİ
**
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string birler, onlar, yüzler, binler, onbinler; //string ifadeler için veri tanımlaması
        private void button1_Click(object sender, EventArgs e)
        {
            double  sayi = Convert.ToDouble(textBox1.Text);  
            
          
            
                    int sayi_int = Convert.ToInt32(sayi); //kullanıcıdan sayı alınır.

            int kontrol_tl = 0;  //kontrol_tl yi sıfıra eşitle
            if(sayi_int==0) //sayi_int sıfıra eşitse kontrol_tl yi 1 e eşitle
            {
                kontrol_tl = 1;
            }

            string virgul = ","; //virgül tanımlıyoruz
            bool result2 = textBox1.Text.Contains(virgul);
            

            string onlar_Kurus = ""; //onlar kuruş için boş string değeri tanımlama

            string birler_Kurus = ""; //birler kuruş için boş string değeri tanımlama

            if (result2) //sayıda eğer virgül varsa
            {
                string girlen_sayi_Str = ""; //girilen sayi için boş string tannımlanır.
                girlen_sayi_Str = textBox1.Text; //texboxdaki text bu değere atanır. 
                string kurus = "";  //string kuruş için bpş string değeri açılır. 
                kurus = girlen_sayi_Str.Split(',').Last(); //split last fonksiyonu ile virgülle ayrılan değerin sonu kurus değişkenine atanur. 
                label1.Text = kurus; //kuruş değişkeni label1 e atanır. 
                int kurus_int; //kurus_int olarak int değişkeni tanımanır. 
                kurus_int = Convert.ToInt32(kurus); //kullanıcıdan input alınır. 
                if (kurus.Length == 1) //kuruş uzunluğu 1 ise
                {
                    kurus_int = kurus_int * 10; //kurus_int i 10 ile çarp
                }
                int fazlakurus; 
                if (kurus_int >= 100)   //kuruş kısmına 100 ve üzeri yazılırsa
                {
                    fazlakurus = kurus_int / 100; //TL kısmına atılacak kısım
                    kurus_int = kurus_int % 100;  //kalan kuruş değeri için
                    sayi_int = sayi_int + fazlakurus;  //tl ile kuruş kısmından artan tl değeri toplanıp sayı_int e aktarılıyor.
                }

                int  onlar_kurus, biler_kurus; //int olarak onlar_kurus ve biler_kurus olarak değerler tanımlanır. 


                sayi = kurus_int % 100;  //kurus_int ifadesinin 100 e göre modu alınarak sayi değişkenine atanır. 

                onlar_kurus = kurus_int / 10; //kurus_int ifadesi 10 a bölünerek onlar_kurus ifadesine atanır. 

                kurus_int = kurus_int % 10; //kurus_int ifadesinin 10 a göre modu alınarak kurus_int ifadesine atanır. 
                 

                biler_kurus = kurus_int; //kurus_int ifadesi biler_kurus ifadesine atanır. 

                
               

                switch (onlar_kurus) //kuruşun 2. basamağı için switch case ifadesi açılır. 

                {

                    case 1: onlar_Kurus = " On "; break;  //onlar_kurus 1 e eşitse onlar_Kurus'a on değeri atanır.

                    case 2: onlar_Kurus = " Yirmi "; break;   //onlar_kurus 2 ye eşitse onlar_Kurus'a yirmi değeri atanır.

                    case 3: onlar_Kurus = " Otuz "; break;  //onlar_kurus 3 e eşitse onlar_Kurus'a otuz değeri atanır.

                    case 4: onlar_Kurus = " Kırk "; break;  //onlar_kurus 4 e eşitse onlar_Kurus'a kırk değeri atanır.

                    case 5: onlar_Kurus = "Elli"; break;  //onlar_kurus 5 e eşitse onlar_Kurus'a elli değeri atanır.

                    case 6: onlar_Kurus = "Altmış"; break;  //onlar_kurus 6 ya eşitse onlar_Kurus'a altmış değeri atanır.

                    case 7: onlar_Kurus = "Yetmiş"; break;   //onlar_kurus 7 ye eşitse onlar_Kurus'a yetmiş değeri atanır.

                    case 8: onlar_Kurus = "Seksen"; break;   //onlar_kurus 8 e eşitse onlar_Kurus'a seksen değeri atanır.

                    case 9: onlar_Kurus = "Doksan"; break;  //onlar_kurus 9 a eşitse onlar_Kurus'a doksan değeri atanır.

                }

                switch (biler_kurus)  //biler_kurus eşitliği için switch case açılır.

                {

                    case 1: birler_Kurus = " Bir "; break;  //biler_kurus 1 e eşitse birler_Kurus a bir değeri atanır. 

                    case 2: birler_Kurus = " İki "; break;   //biler_kurus 2 ye eşitse birler_Kurus a iki değeri atanır. 

                    case 3: birler_Kurus = " Üç "; break;  //biler_kurus 3 e eşitse birler_Kurus a üç değeri atanır. 

                    case 4: birler_Kurus = " Dört "; break;  //biler_kurus 4 e eşitse birler_Kurus a dört değeri atanır. 

                    case 5: birler_Kurus = " Beş "; break;  //biler_kurus 5 e eşitse birler_Kurus a beş değeri atanır. 

                    case 6: birler_Kurus = " Altı "; break;  //biler_kurus 6 ya eşitse birler_Kurus a altı değeri atanır. 

                    case 7: birler_Kurus = " Yedi "; break;  //biler_kurus 7 ye eşitse birler_Kurus a yedi değeri atanır. 

                    case 8: birler_Kurus = " Sekiz "; break;  //biler_kurus 8 e eşitse birler_Kurus a sekiz değeri atanır. 

                    case 9: birler_Kurus = " Dokuz "; break;  //biler_kurus 9 a eşitse birler_Kurus a dokuz değeri atanır. 

                }
            }

            else if (result2 == false)
            {
                birler_Kurus = " sıfır ";
                onlar_Kurus = "";
                
            }

            if (sayi_int >= 0 && sayi_int <= 99999) {   //sayi_int değer aralığı tanımlanır
                      switch (sayi_int / 10000) {  //5. basamak için işlem yapılır. bölümdeki sayı yazı olarak tanımlanır. 

                          case 9: onbinler = "doksan  "; //9 e eşitse doksan 
                              break;
                          case 8: onbinler = "seksen  ";  //sekize eşitse  seksen 
                              break;
                          case 7: onbinler = "yetmiş  "; //yediye eşitse yedi
                              break;
                          case 6: onbinler = "altmış ";  //altıya eşitse altmış
                              break;
                          case 5: onbinler = "elli  ";  //beşe eşitse elli 
                              break;
                          case 4: onbinler = "kırk  ";  //dörde eşitse kırk
                              break;
                          case 3: onbinler="otuz  ";   //üçe eşitse otuz
                              break;
                          case 2: onbinler = "yirmi  ";  //ikiye eşitse yirmi
                              break;
                          case 1:
                              onbinler = "on  ";//bire eşitse on bin şeklinde yazı ile yazılır. 
                              break;
                          case 0: onbinler = ""; //sıfıra eşitse boş string değeri yazdırır.
                              break;


                      }
        

                      switch ((sayi_int % 10000) / 1000) //4. basamak değeri için işlem yapılır. sayi_int 10000 e göre modu alınıp kalan sayı 1000 e bölünür.
                      {
                          case 9:
                              binler = "dokuz bin "; //dokuza eşitse dokuz bin
                              break;
                          case 8:
                              binler = "sekiz bin "; //sekize eşitse sekiz bin
                              break;
                          case 7:
                             binler = "yedi bin "; //yediye eşitse yedi bin
                              break;
                          case 6: 
                              binler = "altı bin "; //altıya eşitse altı bin
                              break;
                          case 5:
                              binler = "beş bin ";  //beşe eşitse beş bin
                              break;
                          case 4:
                              binler = "dört bin "; //dörde eşitse dört bin
                              break;
                          case 3:
                              binler = "üç bin ";  //üçe eşitse üç bin
                              break;
                          case 2:
                              binler = "iki bin "; //ikiye eşitse iki bin
                              break;
                          case 1:
                                binler = "bir bin "; //bire eşitse bir bin olarak yazılır. 

                              break;
                        
                    case 0: binler = " ";
                              break;
                      }

                      switch ((sayi_int % 1000) / 100) //sayının 3. basmağı için işlem yapıyoruz. sayi_int in 1000 e göre modunu alıp 100 e bölüyoruz.
                      {
                          case 9:
                              yüzler = "dokuz yüz "; //dokuza eşitse dokuz yüz
                              break;
                          case 8:
                              yüzler = "sekiz yüz "; //sekize eşitse sekiz yüz
                              break;
                          case 7:
                              yüzler = "yedi yüz "; //yediye eşitse yedi yüz
                              break;
                          case 6:
                              yüzler = "altı yüz "; //altıya eşitse altı yüz
                              break;
                          case 5:
                              yüzler = "beş yüz "; //beşe eşitse beş yüz
                              break;
                          case 4:
                              yüzler = "dört yüz"; //dörde eşitse dört yüz
                              break;
                          case 3:
                              yüzler= "üç yüz"; //üçe eşitse üç yüz
                              break;
                          case 2:
                              yüzler = "iki yüz"; //ikiye eşitse iki yüz
                              break;
                          case 1:
                              yüzler = "yüz"; //bire eşitse yüz yazdırıyoruz.
                              break;
                          case 0:
                              yüzler = "";
                              break;
                      }

                      switch ((sayi_int % 100) / 10) //sayının 2. basamağı için işlem yapıyoruz. sayi_intin 100 e göre modunu alıp 10 a bölüyoruz.
                      {
                          case 9:
                              onlar = "doksan "; //dokuza eşitse doksan 
                              break;
                          case 8:
                              onlar = "seksen "; //sekize eşitse seksen 
                              break;
                          case 7:
                              onlar = "yetmiş "; //yediye eşitse yetmiş 
                              break;
                          case 6:
                              onlar = "altmış "; //altıya eşitse altmış 
                              break;
                          case 5:
                              onlar = "elli "; //beşe eşitse elli 
                              break;
                          case 4:
                              onlar = "kırk "; //dörde eşitse kırk
                              break;
                          case 3:
                              onlar = "otuz "; //üçe eşitse otuz
                              break;
                          case 2:
                              onlar = "yirmi "; //ikiye eşitse yirmi
                              break;
                          case 1:
                              onlar = "on "; //bire eşitse on a eşitliyoruz.
                              break;
                          case 0:
                              onlar = "";
                              break;
                      }

                if (onlar_Kurus== "Elli" || onlar_Kurus== "Altmış"||onlar_Kurus=="Yetmiş" || onlar_Kurus=="Seksen" ||onlar_Kurus=="Doksan")
                {
                    switch ((sayi_int % 10) - 1)  //ilk basamak için sayi_int in 10 a göre modunu alıyoruz
                    {
                        case 9:
                            birler = "dokuz "; //dokuza eşitse dokuz
                            break;
                        case 8:
                            birler = "sekiz "; //sekize eşitse sekiz
                            break;
                        case 7:
                            birler = "yedi "; //yediye eşitse yedi
                            break;
                        case 6:
                            birler = "altı "; //altıya eşitse altı
                            break;
                        case 5:
                            birler = "beş "; //beşe eşitse beş
                            break;
                        case 4:
                            birler = "dört "; //dörde eşitse dört
                            break;
                        case 3:
                            birler = "üç "; //üçe eşitse üç
                            break;
                        case 2:
                            birler = "iki "; //ikiye eşitse iki
                            break;
                        case 1:
                            birler = "bir "; //bire eşitse bir yazdırıyoruz.
                            break;
                        case 0:
                            birler = "";
                            break;
                    }
                }
                else
                {
                    switch ((sayi_int % 10))  //ilk basamak için sayi_int in 10 a göre modunu alıyoruz
                    {
                        case 9:
                            birler = "dokuz "; //dokuza eşitse dokuz
                            break;
                        case 8:
                            birler = "sekiz "; //sekize eşitse sekiz
                            break;
                        case 7:
                            birler = "yedi "; //yediye eşitse yedi
                            break;
                        case 6:
                            birler = "altı "; //altıya eşitse altı
                            break;
                        case 5:
                            birler = "beş "; //beşe eşitse beş
                            break;
                        case 4:
                            birler = "dört "; //dörde eşitse dört
                            break;
                        case 3:
                            birler = "üç "; //üçe eşitse üç
                            break;
                        case 2:
                            birler = "iki "; //ikiye eşitse iki
                            break;
                        case 1:
                            birler = "bir "; //bire eşitse bir yazdırıyoruz.
                            break;
                        case 0:


                            birler = "";
                            break;
                    }
                }
                     
                          }

                  else
                  {
                      MessageBox.Show("EN FAZLA BEŞ BASAMAKLI DEĞER GİREBİLİRSİNİZ!!!"); //girilen değer 5 basamaktan büyükse messagebox ile uyarı mesajı alıyoruz.
                  }
            


            if (sayi_int > 9999) //sayı_int 5 basamaklıysa
            {

                if (kontrol_tl == 1) 
                {
                    label1.Text =  onlar_Kurus + birler_Kurus + " kuruş"; 

                }
                label1.Text = onbinler+ binler + yüzler + onlar + birler + "TL" + onlar_Kurus + birler_Kurus + " kuruş"; //kuruş ifadeleri ile beraber 5 basamağa kadar yazdırır
            }
            else if (sayi_int <= 9999 && sayi_int > 999) //sayı_int 4 basamaklıysa
            {
                if (kontrol_tl == 1)
                  {
                    label1.Text =  onlar_Kurus + birler_Kurus + " kuruş";

                }
                label1.Text = binler + yüzler + onlar + birler + "TL" + onlar_Kurus + birler_Kurus + " kuruş";  //kuruş ifadeleri ile beraber 4. basamağa kadar yazdırır.
            }
            else if (sayi_int <= 999 && sayi_int > 99) //sayı_int 3 basamaklıysa
            {

                if (kontrol_tl == 1)
                {
                    label1.Text =  onlar_Kurus + birler_Kurus + " kuruş";

                }
                else
                label1.Text = yüzler + onlar + birler + "TL" + onlar_Kurus + birler_Kurus + " kuruş"; //kuruş ifadeleri ile beraber 3. basamağa kadar yazdırır.
            }
            else if (sayi_int <= 99 && sayi_int > 9) //sayı_int iki basamaklıysa
            {

                if (kontrol_tl == 1)
                {
                    label1.Text =  onlar_Kurus + birler_Kurus + " kuruş";

                }
                else
                    label1.Text = onlar + birler + "TL" + onlar_Kurus + birler_Kurus + " kuruş"; //kuruş ifadeleri ile beraber 2. basamağa kadar yazdırır.
            }
            else //sayı_int bir basamaklıysa
            {

                if (kontrol_tl == 1)
                {
                    label1.Text =  onlar_Kurus + birler_Kurus + " kuruş";

                }
                else
                    label1.Text = birler + "TL" +  onlar_Kurus + birler_Kurus + " kuruş"; //kuruş ifadeleri ile beraber 1. basamağa kadar yazdırır.
            }
            if(sayi_int>=0 && sayi_int < 1)
            {
                label1.Text="sıfır TL"+ onlar_Kurus + birler_Kurus + " kuruş";
            }
           

        }               

    }


}
    