using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAL : IDataMappercs<Category, Int32>
    {
        SqlCommand _command;
        public CategoryDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public int Insert(Category item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "INSERT INTO Categories(CategoryName,Description) values(@name,@desc)";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@name", item.CategoryName);
            _command.Parameters.AddWithValue("@desc", item.Description);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                affectedRows = _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Ekleme başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public int Update(Category item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "UPDATE Categories SET CategoryName=@name, Description=@desc WHERE CategoryId=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@name", item.CategoryName);
            _command.Parameters.AddWithValue("@desc", item.Description);
            _command.Parameters.AddWithValue("@id", item.CategoryID);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                affectedRows = _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Güncelleme başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public int Delete(Category item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }
            _command.CommandText = "DELETE FROM Categories WHERE CategoryId=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.CategoryID);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Silme Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public List<Category> GetAll()
        {
            List<Category> catList = new List<Category>();
            _command.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";
            _command.Parameters.Clear();

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                SqlDataReader reader = _command.ExecuteReader();
                //ExecuteNoneQuery => insert, update, delete işlemlerinde etkilenen satır sayısını döndürür.
                //ExecuteScalar => Select sorgusu sonucunun tek bir hücre veri döndürür.
                //ExecuteReader => select sorgusu sonucu birden fazla veriyi döndürür.

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();
                        cat.CategoryID = (int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader.IsDBNull(2) ? default(string) : reader[2].ToString();
                        //---------------|          NULL ise->         değilse->

                        catList.Add(cat);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return catList;
        }
        public Category Get(int id)
        {
            Category cat = null;

            _command.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", id);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cat = new Category();
                        cat.CategoryID = (int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader[2] != DBNull.Value ? (string)reader[2] : default(string);
                        //----------------|           KOŞU          |      true ise     |   false ise
                      
                        //Ternary if(Tek satırda if kontrolü) => Tek bir koşul için, o koşula ait var ya da yok, uyuyor ya da uymuyor gibi sadece iki farklı yolu varsa, aynı zamanad 2 yol içindeki tek satırlık bir kod yazacaksam bu yapıyı kullanıyorum. Koşul geçerliyse ? işaretinden : işaretine kadar geçerli kodu çalıştırır. Koşul geçerli değilse : den sonraki kodu çalıştırır.
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return cat;
        }
    }
}
