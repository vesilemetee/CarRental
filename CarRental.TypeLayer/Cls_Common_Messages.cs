using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.TypeLayer
{
    public class Cls_Common_Messages
    {
        public static string CRUD_Message(string TabloAdi, bool basarilimi, string CRUD)
        {
            string answer = "";
            if (basarilimi == true)
            {
                if (CRUD == "insert")
                {
                    answer = TabloAdi + " tablosuna başarıyla kaydedildi.";
                }
                else if (CRUD == "update")
                {
                    answer = TabloAdi + " tablosuna başarıyla güncellendi.";
                }
                else if (CRUD == "delete")
                {
                    answer = TabloAdi + " tablosuna başarıyla silindi.";
                }
                else
                {
                    answer = TabloAdi + " tablosu CRUD işlemi yapılırken yanlış parametre";
                }
            }
            else
            {
                if (CRUD == "insert")
                {
                    answer = TabloAdi + " tablosuna kaydedilmedi.HATA!!!";
                }
                else if (CRUD == "update")
                {
                    answer = TabloAdi + " tablosuna güncellenemedi.HATA!!!";
                }
                else if (CRUD == "delete")
                {
                    answer = TabloAdi + " tablosuna silinemedi.HATA!!!";
                }
                else
                {
                    answer = TabloAdi + " tablosu CRUD işlemi yapılırken yanlış parametre HATA!!!";
                }
            }
            return answer;
        }
    }
}
