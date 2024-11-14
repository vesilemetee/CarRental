using CarRental.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.BusinessLayer
{
    public class Cls_Car
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public int Yıl { get; set; }
        public string Yakıt { get; set; }
        public string Vites { get; set; }
        public int Km { get; set; }
        public string Renk { get; set; }
        public decimal Ücret { get; set; }
        public string Fotograf { get; set; }
        public bool Insert(int FullTypeID, int GearTypeID)
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("[Sp_Car_Insert]", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Marka", Marka);
                sqlCommand.Parameters.AddWithValue("@Model", Model);
                sqlCommand.Parameters.AddWithValue("@Plaka", Plaka);
                sqlCommand.Parameters.AddWithValue("@Yıl", Yıl);
                sqlCommand.Parameters.AddWithValue("@Yakıt", Yakıt);
                sqlCommand.Parameters.AddWithValue("@Vites", Vites);
                sqlCommand.Parameters.AddWithValue("@Km", Km);
                sqlCommand.Parameters.AddWithValue("@Renk", Renk);
                sqlCommand.Parameters.AddWithValue("@Ücret", Ücret);
                sqlCommand.Parameters.AddWithValue("@Fotograf", Fotograf);
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
        public bool Update(int FullTypeID, int GearTypeID)
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("Sp_Car_Update", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", ID);
                sqlCommand.Parameters.AddWithValue("@Marka", Marka);
                sqlCommand.Parameters.AddWithValue("@Model", Model);
                sqlCommand.Parameters.AddWithValue("@Plaka", Plaka);
                sqlCommand.Parameters.AddWithValue("@Yıl", Yıl);
                sqlCommand.Parameters.AddWithValue("@Yakıt", Yakıt);
                sqlCommand.Parameters.AddWithValue("@Vites", Vites);
                sqlCommand.Parameters.AddWithValue("@Km", Km);
                sqlCommand.Parameters.AddWithValue("@Renk", Renk);
                sqlCommand.Parameters.AddWithValue("@Ücret", Ücret);
                sqlCommand.Parameters.AddWithValue("@Fotograf", Fotograf);
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
        public bool Delete(int FullTypeID, int GearTypeID)
        {
            try
            {
                SqlConnection sqlConnection = Cls_Connection.baglanti;
                SqlCommand sqlCommand = new SqlCommand("Sp_Car_Delete", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", ID);
                sqlCommand.Parameters.AddWithValue("@Marka", Marka);
                sqlCommand.Parameters.AddWithValue("@Model", Model);
                sqlCommand.Parameters.AddWithValue("@Plaka", Plaka);
                sqlCommand.Parameters.AddWithValue("@Yıl", Yıl);
                sqlCommand.Parameters.AddWithValue("@Yakıt", Yakıt);
                sqlCommand.Parameters.AddWithValue("@Vites", Vites);
                sqlCommand.Parameters.AddWithValue("@Km", Km);
                sqlCommand.Parameters.AddWithValue("@Renk", Renk);
                sqlCommand.Parameters.AddWithValue("@Ücret", Ücret);
                sqlCommand.Parameters.AddWithValue("@Fotograf", Fotograf);
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
        public SqlDataReader Fuel_Listele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select FullType from FullType", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Gear_Listele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select GearType from GearType", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public static int Full_IDVer(string FullType)
        {
            int FullTypeID = 0;
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID from FullType where FullType=@FullType", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@FullType", FullType);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                FullTypeID = Convert.ToInt32(sqlDataReader["ID"]);
            }
            // sqlConnection.Close ();

            return FullTypeID;
        }

        public static int Gear_IDVer(string GearType)
        {
            int GearTypeID = 0;
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID from GearType where GearType=@GearType", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@GearType", GearType);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                GearTypeID = Convert.ToInt32(sqlDataReader["ID"]);
            }
            // sqlConnection.Close ();

            return GearTypeID;
        }

        public SqlDataReader CarListele()
        {
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select ID,Marka,Model,Plaka,Yıl,Yakıt,Vites,Km,Renk,Ücret,Fotograf from Cars", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }
        public SqlDataReader Listele_Arama(string Marka)
        {
            int BrandID = 0;
            SqlConnection sqlConnection = Cls_Connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("select * from Cars where Marka like '" + Marka + "%'", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Marka", Marka);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            return sqlDataReader;

        }

    }
}
