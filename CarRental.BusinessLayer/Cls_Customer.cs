using CarRental.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BusinessLayer
{
    public class Cls_Customer
    {
        public int ID { get; set; }
        public string Tc { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string EhliyetTürü { get; set; }
        public int EhliyetNo { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Notlar { get; set; }
        public  bool Insert(int DrivingLicenceTypeID)
        {
        	try
			{
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("[Sp_Customer_Insert]", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TC", Tc);
                sqlCommand.Parameters.AddWithValue("@Isim", Isim);
                sqlCommand.Parameters.AddWithValue("@Soyisim", Soyisim);
                sqlCommand.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                sqlCommand.Parameters.AddWithValue("@EhliyetTürü", EhliyetTürü);
                sqlCommand.Parameters.AddWithValue("@EhliyetNo", EhliyetNo);
                sqlCommand.Parameters.AddWithValue("@Telefon", Telefon);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@Adres", Adres);
                sqlCommand.Parameters.AddWithValue("@Notlar", Notlar);
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
        public bool Update(int DrivingLicenceTypeID)
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("[Sp_Customer_Update]", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TC", Tc);
                sqlCommand.Parameters.AddWithValue("@Isim", Isim);
                sqlCommand.Parameters.AddWithValue("@Soyisim", Soyisim);
                sqlCommand.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                sqlCommand.Parameters.AddWithValue("@EhliyetTürü", EhliyetTürü);
                sqlCommand.Parameters.AddWithValue("@EhliyetNo", EhliyetNo);
                sqlCommand.Parameters.AddWithValue("@Telefon", Telefon);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@Adres", Adres);
                sqlCommand.Parameters.AddWithValue("@Notlar", Notlar);
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
        public bool Delete(int DrivingLicenceTypeID)
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("[Sp_Customer_Delete]", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TC", Tc);
                sqlCommand.Parameters.AddWithValue("@Isim", Isim);
                sqlCommand.Parameters.AddWithValue("@Soyisim", Soyisim);
                sqlCommand.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                sqlCommand.Parameters.AddWithValue("@EhliyetTürü", EhliyetTürü);
                sqlCommand.Parameters.AddWithValue("@EhliyetNo", EhliyetNo);
                sqlCommand.Parameters.AddWithValue("@Telefon", Telefon);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@Adres", Adres);
                sqlCommand.Parameters.AddWithValue("@Notlar", Notlar);
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

        public SqlDataReader CustomerListele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID,TC,Isim,Soyisim,DoğumTarihi,EhliyetTürü,EhliyetNo,Telefon,Email,Adres,Notlar from Customers", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Listele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select DrivingLicenceType from DrivingLicenceType", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        
        public SqlDataReader Listele_Arama(string TC)
        {
            int CustomerID = 0;
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select * from Customers where TC like '" + TC + "%'", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@TC", TC);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            return sqlDataReader;

        }
        public static int IDVer(string EhliyetTürü)
        {
            int DrivingLicenceTypeID = 0;
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID from Customers where EhliyetTürü=@EhliyetTürü", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@EhliyetTürü", EhliyetTürü);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                DrivingLicenceTypeID = Convert.ToInt32(sqlDataReader["ID"]);
            }
            // sqlConnection.Close ();

            return DrivingLicenceTypeID;
        }

    }
}
