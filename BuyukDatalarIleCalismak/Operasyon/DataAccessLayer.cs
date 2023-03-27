using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuyukDatalarIleCalismak.Operasyon
{
    public class DataAccessLayer : Base.Yardim
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            con = new SqlConnection("Server = DESKTOP-3J5F9CS\\SQLEXPRESS; Database = BuyukDatalarIleCalismak; Trusted_Connection = True;");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            else
                con.Open();
        }

        public int KayitEKLE(Entities.Kisi kisi)
        {
            int ReturnValue = 0;
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("KisiEkle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = kisi.Isim;
                cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = kisi.Soyisim;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = kisi.EmailAdres;
                cmd.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = kisi.Tel;
                cmd.Parameters.Add("@Resim", SqlDbType.VarBinary).Value = kisi.Resim;
                BaglantiAyarla();
                ReturnValue = cmd.ExecuteNonQuery();
                BaglantiAyarla();
            });
            return ReturnValue;
        }

        public SqlDataReader KisiDetayGetir(int id)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("select * from Kisiler where Id = @id", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KisilerListe()
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("select * from Kisiler", con);
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
    }
}
