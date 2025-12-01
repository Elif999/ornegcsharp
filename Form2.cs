using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp29
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i=1;i<=10;i++)
            {
                int sonuç = i * sayi;
                listBox1.Items.Add(sayi+"*"+i+"="+sonuç);
            }
        }
    }
}
/*yapay zeka;
 Tabii ki! Verdiğiniz kod parçası, bir Windows Forms uygulamasında bir butona tıklandığında kullanıcının 
 girdiği bir sayının çarpanlarını (1 ile 10 arasındaki sayılarla çarpılmış hali) listeleyen
 bir işlevi yerine getiriyor. Şimdi kodun mantığını adım adım açıklayayım.

Kodun Tamamı
private void button1_Click(object sender, EventArgs e)
{
    int sayi = Convert.ToInt32(textBox1.Text);
    for(int i = 1; i <= 10; i++)
    {
        int sonuç = i * sayi;
        listBox1.Items.Add(sonuç);
    }
}
Adım Adım Açıklama
Kullanıcı Girdisini Alma:
int sayi = Convert.ToInt32(textBox1.Text);
Bu satır, textBox1 adlı metin kutusundan kullanıcıdan alınan değeri alır 
ve int türüne dönüştürerek sayi değişkenine atar.
Kullanıcı, bu metin kutusuna bir sayı girmelidir.
Döngü ile Çarpma İşlemi:
for(int i = 1; i <= 10; i++)
{
    int sonuç = i * sayi;
    listBox1.Items.Add(sonuç);
}
for döngüsü, i değişkenini 1'den başlatır ve 10'a kadar (10 dahil) devam eder.
Her döngü adımında, i değeri ile sayi çarpılır ve bu çarpım sonucu sonuç değişkenine atanır.
listBox1.Items.Add(sonuç); ifadesi, sonuç değerini listBox1 adlı liste kutusuna ekler.

Örnek
Örneğin, kullanıcı "textBox1'e" 5 sayısını girerse:
İlk döngü adımında (i = 1): sonuç = 1 * 5 = 5 (5 eklenir)
İkinci döngü adımında (i = 2): sonuç = 2 * 5 = 10 (10 eklenir)
Üçüncü döngü adımında (i = 3): sonuç = 3 * 5 = 15 (15 eklenir)
Dördüncü döngü adımında (i = 4): sonuç = 4 * 5 = 20 (20 eklenir)
Beşinci döngü adımında (i = 5): sonuç = 5 * 5 = 25 (25 eklenir)
Altıncı döngü adımında (i = 6): sonuç = 6 * 5 = 30 (30 eklenir)
Yedinci döngü adımında (i = 7): sonuç = 7 * 5 = 35 (35 eklenir)
Sekizinci döngü adımında (i = 8): sonuç = 8 * 5 = 40 (40 eklenir)
Dokuzuncu döngü adımında (i = 9): sonuç = 9 * 5 = 45 (45 eklenir)
Onuncu döngü adımında (i = 10): sonuç = 10 * 5 = 50 (50 eklenir)
Sonuç olarak, listBox1'de 5, 10, 15, 20, 25, 30, 35, 40, 45 ve 50 sayıları görünecektir.

Özet
Bu kod, kullanıcıdan alınan bir sayıyı (örneğin 5) 1 ile 10 arasındaki sayılarla çarpar ve sonuçları listBox1'e ekler.
Kullanıcı, button1 butonuna tıkladığında bu işlem gerçekleşir.
Bu, çarpanları listelemek için basit ve etkili bir yöntemdir. 
Eğer daha fazla açıklama veya örnek isterseniz, lütfen belirtin!

*/