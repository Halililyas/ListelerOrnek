using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolcu_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcu futbolcu = new Futbolcu();
            while (true)
            {
                Console.WriteLine("----------PROGRAMA HOŞGELDİNİZ----------");
                Console.WriteLine("1-)Futbolcu Ekle\n2-)Futbolcu Sil\n3-)Futbolcu Güncelle\n4-)Futbolcu Görüntüle");
                int sec = Convert.ToInt16(Console.ReadLine());
                if (sec==1)
                {
                    futbolcu.FutbolcuEkle();
                    
                }
                else if (sec==2)
                {
                    futbolcu.FutbolcuSil();
                }
                else if (sec==3)
                {
                    futbolcu.FutbolcuGüncelle();
                }
                else if (sec==4)
                {
                    futbolcu.FutbolcuListe();
                }
                else
                {
                    Console.WriteLine("hatalı işlem ");
                }
                Console.ReadLine();
            }
        }
    }
}
