using CarRental.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BusinessLayer
{
    public class Cls_Rental
    {

        public SqlDataReader Rental_Listele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID,Marka,Model,Plaka,Yıl,Yakıt,Vites,Km,Renk,TC,Isim,Soyisim,DoğumTarihi,EhliyetTürü,EhliyetNo,Telefon,AlışTarihi,TeslimTarihi,KiraÜcreti,ToplamGün,ToplamÜcret,Durum from CarRentall", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

    }
}
