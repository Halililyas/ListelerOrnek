using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolcu_List
{
    internal class Futbolcu
    {
        List<Futbolcu> futbolcuList = new List<Futbolcu>();

        public int futbolcuİd { get; set; }
        public string futbolcuİsim { get; set; }
        public string futbolcuSoyisim { get; set; }
        public string futbolcuUlke { get; set; }
        public int futbolcuFormano { get; set; }
        public int futbolcuGolsayısı { get; set; }

        int İdOzellıgı = 0;

        public void FutbolcuEkle()
        {
            İdOzellıgı += 1;
            Futbolcu ft = new Futbolcu(); //nesne Oluşturulur 
            ft.futbolcuİd = İdOzellıgı;
            Console.WriteLine("Futbolcu İsmini Giriniz ");
            ft.futbolcuİsim = Console.ReadLine();
            Console.WriteLine("Futbolcu Soyisim Giriniz");
            ft.futbolcuSoyisim = Console.ReadLine();
            Console.WriteLine("Futbolcu nun  Ülkesi Giriniz");
            ft.futbolcuUlke = Console.ReadLine();
            Console.WriteLine("Futbolcu Forma No Girnizi");
            ft.futbolcuFormano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Futbolcu Gol Sayısını Giriniz :");
            ft.futbolcuGolsayısı = Convert.ToInt16(Console.ReadLine());

            futbolcuList.Add(ft); //Listeye Eklemek İçin Kullanılır add metodu kullanır
        }
        public void FutbolcuSil()
        {
            
            if (futbolcuList.Count==0)
            {
                Console.WriteLine("Silenecek Futbolcu yoktur ");
            }
            else
            {
                FutbolcuListe();
                Console.WriteLine("Silincek Futbolcu İd Giriniz : ");
                int Silİd = Convert.ToInt16(Console.ReadLine());
                foreach (var item in futbolcuList)
                {
                    if (item.futbolcuİd==Silİd)
                    {
                        futbolcuList.Remove(item);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Eşleşen Futbolcu Bulunamadı");
                    }
                }
               
            }
            

        }
        public void FutbolcuGüncelle()
        {
            if (futbolcuList.Count==0)
            {
                Console.WriteLine("Güncellenecek Futbolcu Yok");
            }
            else
            {
                Console.WriteLine("Güncellemek İstediğiniz Futbolcu İD Giriniz...");
                int SecİD = Convert.ToInt16(Console.ReadLine());
                foreach (var item in futbolcuList)
                {
                    FutbolcuListe();
                    if (item.futbolcuİd==SecİD)
                    {
                        Console.WriteLine("1-Forma Numarası\n2-Gol Sayısı");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim==1)
                        {
                            item.futbolcuFormano = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Futbolcu Forma no güncellendi ");
                        }
                        else if (secim==2)
                        {
                            item.futbolcuGolsayısı = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Futbolcu Gol Sayısı güncellendi ");
                        }
                        else
                        {
                            Console.WriteLine("Bir Hata oluştu Tekrar Giriniz");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seçilen Değerde İd Yok ");
                    }
                }
            }
        }
        public void FutbolcuListe()
        {
            if (futbolcuList.Count == 0)
            {
                Console.WriteLine("Listelencek Futbolcu Yoktur");
            }
            else
            {
                foreach (var item in futbolcuList)
                {
                    Console.WriteLine($"Futbolcu İd : {item.futbolcuİd}\nFutbolcu İsim : {item.futbolcuİsim}\nFutbolcu Soyisim : {item.futbolcuSoyisim}\n" +
                        $"Futbolcu Ülkesi : {item.futbolcuUlke}\nFutbolcu Formo No {item.futbolcuFormano}\nFutbolcu Gol Sayısı : {item.futbolcuGolsayısı} ");
               
                }
            }
        }

    }
}
