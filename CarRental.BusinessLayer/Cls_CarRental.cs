using CarRental.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace CarRental.BusinessLayer
{
    public class Cls_CarRental
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public int Yıl { get; set; }
        public string Yakıt { get; set; }
        public string Vites { get; set; }
        public int Km { get; set; }
        public string Renk { get; set; }
        public string Tc { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string EhliyetTürü { get; set; }
        public int EhliyetNo { get; set; }
        public string Telefon { get; set; }
        public DateTime AlışTarihi  { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KiraÜcreti { get; set; }
        public int ToplamGün { get; set; }
        public int ToplamÜcret { get; set; }
        public string Durum { get; set; }

        public bool Insert()
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("Sp_Rental_Insert", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Marka", Marka);
                sqlCommand.Parameters.AddWithValue("@Model", Model);
                sqlCommand.Parameters.AddWithValue("@Plaka", Plaka);
                sqlCommand.Parameters.AddWithValue("@Yıl", Yıl);
                sqlCommand.Parameters.AddWithValue("@Yakıt", Yakıt);
                sqlCommand.Parameters.AddWithValue("@Vites", Vites);
                sqlCommand.Parameters.AddWithValue("@Km", Km);
                sqlCommand.Parameters.AddWithValue("@Renk", Renk);
                sqlCommand.Parameters.AddWithValue("@Durum", Durum);
                sqlCommand.Parameters.AddWithValue("@TC", Tc);
                sqlCommand.Parameters.AddWithValue("@Isim", Isim);
                sqlCommand.Parameters.AddWithValue("@Soyisim", Soyisim);
                sqlCommand.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                sqlCommand.Parameters.AddWithValue("@EhliyetTürü", EhliyetTürü);
                sqlCommand.Parameters.AddWithValue("@EhliyetNo", EhliyetNo);
                sqlCommand.Parameters.AddWithValue("@Telefon", Telefon);
                sqlCommand.Parameters.AddWithValue("@AlışTarihi", AlışTarihi);
                sqlCommand.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                sqlCommand.Parameters.AddWithValue("@KiraÜcreti", KiraÜcreti);
                sqlCommand.Parameters.AddWithValue("@ToplamGün", ToplamGün);
                sqlCommand.Parameters.AddWithValue("@ToplamÜcret", ToplamÜcret);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {

                return false;
            }
        }

      
        public SqlDataReader Brand_Listele(string Marka)
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select * from Cars where Marka like '" + Marka + "%'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Marka", Marka);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Brand_Listele1()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select DISTINCT Marka,Model,Plaka,Yıl,Yakıt,Vites,Km,Renk,Ücret,Durum from Cars", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Customer_Listele(string TC)
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select * from Customers where TC like '" + TC + "%'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TC", TC);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Customer_Listele1()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select TC,Isim,Soyisim,DoğumTarihi,EhliyetTürü,EhliyetNo,Telefon,Email,Adres,Notlar from Customers", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

    }
}
