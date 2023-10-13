using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Manav_PROJE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList meyve = new ArrayList();

            ArrayList meyvekg = new ArrayList();

            ArrayList sebze = new ArrayList();

            ArrayList sebzekg = new ArrayList();

            meyve.Add("Elma");
            meyve.Add("Armut");
            meyve.Add("Karpuz");

            meyvekg.Add(0);
            meyvekg.Add(0);
            meyvekg.Add(0);

            sebze.Add("Ispanak");
            sebze.Add("Mısır");
            sebze.Add("Patlıcan");

            sebzekg.Add(0);
            sebzekg.Add(0);
            sebzekg.Add(0);

      

            while (true)
            {
                Console.WriteLine("Hoşgeldiniz\nHal için  1\nManav için 2");
            string secim=Console.ReadLine();


                if (secim == "1")
                {
                  
                    Console.WriteLine("Meyve mi sebze mi istersiniz\nMeyve için 1\nSebze için 2");
                    string urunSecim = Console.ReadLine();

                
                        if (urunSecim == "Meyve")
                        {
                            while (true)
                            {
                                Console.WriteLine("Meyveler:\n\nElma\nArmut\nKarpuz\n\nLütfen seçim yapmak istediğiniz meyvenin numarasını giriniz");
                            string meyveSecim = Console.ReadLine();

                                                    
                                if (meyveSecim == "Elma" || meyveSecim == "Armut" || meyveSecim == "Karpuz")
                                {
                                    try
                                    {
                                        Console.WriteLine("Kaç kg istersiniz");
                                        int meyveSayisi = Convert.ToInt32(Console.ReadLine());

                                        int index = meyve.IndexOf(meyveSecim);
                                        Console.WriteLine(index);

                                    int aaa = Convert.ToInt32(meyvekg[index]);
                                    aaa += meyveSayisi;

                                    meyvekg[index] = aaa;

                                }
                                    catch (Exception) { Console.WriteLine("Lütfen rakam giriniz");  }


                                DON:
                                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n Meyve seçimi için 1\nÇıkış yapmak için2");
                                    string cikis = Console.ReadLine();
                                    if (cikis == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Eklemek istediğiniz meyveyi seçiniz");
                                        string meyveEkleme = Console.ReadLine();
                                        
                                            if (meyveEkleme == "Elma" || meyveEkleme == "Armut" || meyveEkleme == "Karpuz")
                                            {
                                                try
                                                {
                                                    int index2 = meyve.IndexOf(meyveEkleme);
                                                    Console.WriteLine(index2);


                                                    Console.WriteLine("Eklemek istediğiniz kiloyu seçin");
                                                    int meyvekgEkleme = Convert.ToInt32(Console.ReadLine());

                                                    int aaa = Convert.ToInt32(meyvekg[index2]);

                                                    aaa += meyvekgEkleme;

                                                    meyvekg[index2] = aaa;
                                                }catch(Exception) { Console.WriteLine("Lütfen rakam giriniz"); }

                                                goto DON;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lütfen geçerli meyve giriniz");
                                                
                                            }
                                        }
                                    }
                                    else if (cikis == "2") { break; }
                                    else { goto DON; };

                                }
                                else
                                {
                                    Console.WriteLine("Lütfen elimizde bulunan meyvelerden bir tanesini seçiniz");
                                }
                            }
                        }

                        else if (urunSecim == "Sebze")
                        {

                            while (true)
                            {
                                Console.WriteLine("Sebzeler:\n\nIspanak\nMısır\nPatlıcan\n\nLütfen seçim yapmak istediğiniz sebzenin numarasını giriniz");
                                string sebzeSecim = Console.ReadLine();


                                if (sebzeSecim == "Ispanak" || sebzeSecim == "Mısır" || sebzeSecim == "Patlıcan")
                                {
                                    try
                                    {
                                        Console.WriteLine("Kaç kg istersiniz");
                                        int sebzeSayısı = Convert.ToInt32(Console.ReadLine());

                                        int index = sebze.IndexOf(sebzeSecim);
                                        Console.WriteLine(index);

                                        sebzekg.Insert(index, sebzeSayısı);

                                    }
                                    catch (Exception) { Console.WriteLine("Lütfen rakam giriniz"); }


                                DON:
                                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n Sebze seçimi için 1\nÇıkış yapmak için2");
                                    string cikis = Console.ReadLine();
                                    if (cikis == "1")
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Eklemek istediğiniz Sebzeyi seçiniz");
                                            string sebzeEkleme = Console.ReadLine();

                                            if (sebzeEkleme == "Ispanak" || sebzeEkleme == "Mısır" || sebzeEkleme == "Patlıcan")
                                            {
                                                try
                                                {
                                                    int index2 = sebze.IndexOf(sebzeEkleme);
                                                    Console.WriteLine(index2);


                                                    Console.WriteLine("Eklemek istediğiniz kiloyu seçin");
                                                    int sebzekgEkleme = Convert.ToInt32(Console.ReadLine());

                                                    int aaa = Convert.ToInt32(sebzekg[index2]);

                                                    aaa += sebzekgEkleme;

                                                    sebzekg[index2] = aaa;
                                                }
                                                catch (Exception) { Console.WriteLine("Lütfen rakam giriniz"); }

                                                goto DON;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lütfen geçerli Sebze giriniz");

                                            }
                                        }
                                    }
                                    else if (cikis == "2") { break; }
                                    else { goto DON; };

                                }
                                else
                                {
                                    Console.WriteLine("Lütfen elimizde bulunan sebzelerden bir tanesini seçiniz");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen meyve veya sebze seçiniz");
                        }
                    
                }
                
                else if (secim == "2")
                    {

                    DON:
                        Console.WriteLine("Hoşgeldiniz\nMeyve mi Sebze mi istersiniz");
                        string manavSecim = Console.ReadLine();

                        if (manavSecim == "Meyve")
                        {


                            Console.WriteLine("Lütfen istediğiniz meyveyi seçiniz\nElma,Armut,Karpuz");
                            string meyveSecim = Console.ReadLine();

                            int index = meyve.IndexOf(meyveSecim);
                            Console.WriteLine(index);

                            int aaa = Convert.ToInt32(meyvekg[index]);

                            if (aaa > 0)
                            {

                                Console.WriteLine("Kaç kg istersiniz");
                                int meyveSayisi = Convert.ToInt32(Console.ReadLine());
                             
                                aaa -= meyveSayisi;

                                meyvekg[index] = aaa;
                            }
                            else { Console.WriteLine("Yetersiz stok");  goto DON; }

                        }else if (manavSecim == "Sebze")
                    {
                        Console.WriteLine("Lütfen istediğiniz sebzeyi seçiniz\nElma,Armut,Karpuz");
                        string sebzeSecim = Console.ReadLine();

                        int index = sebze.IndexOf(sebzeSecim);
                        Console.WriteLine(index);

                        int aaa = Convert.ToInt32(sebzekg[index]);

                        if (aaa > 0)
                        {

                            Console.WriteLine("Kaç kg istersiniz");
                            int sebzeSayisi = Convert.ToInt32(Console.ReadLine());

                            aaa -= sebzeSayisi;

                            sebzekg[index] = aaa;
                        }
                        else { Console.WriteLine("Yetersiz stok"); goto DON; }


                    }
                    else { Console.WriteLine("Lütfen meyve veya sebze seçiniz");goto DON; }

                    }
                               
                else
                {
                    Console.WriteLine("Lütfen 1 veya 2 yi seçiniz");

                }
                DON2:
                for (int i = 0; i < meyve.Count; i++)
            {
                Console.WriteLine(meyve[i]);
            }
                for (int i = 0; i < meyvekg.Count; i++)
                {
                    Console.WriteLine(meyvekg[i]);
                }
                for (int i = 0; i < sebze.Count; i++)
                {
                    Console.WriteLine(sebze[i]);
                }
                for (int i = 0; i < sebzekg.Count; i++)
                {
                    Console.WriteLine(sebzekg[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
