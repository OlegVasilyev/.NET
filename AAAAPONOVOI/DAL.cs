using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.IO;
using System.ComponentModel;
using System.Data;
namespace AAAAPONOVOI
{
    class DAL
    {
        private string ConnectionString;
        public DAL()
        {
            this.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\Visual Studio 2015\Projects\AAAAPONOVOI\AAAAPONOVOI\Printer.mdf;Integrated Security=True";
        }
        public ArrayList needzapravka2(int id)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("Limit2", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public void OtpechatanoStrinichek(int id, int sum)
        {
            string cmdText = string.Format("UPDATE Printer SET [ОтпечатаноCтраниц] = @sum WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "sum",
                    Value = sum,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                    }
                }
                catch
                {
                }
            }
        }
        public bool DeleteToner(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("UPDATE Toner SET [Комментарий] = 'DELETE' WHERE [ID] = @Id", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
public BindingList<DbDataRecord> search(string nametable, string namecell, string parametr)
        {
            if (nametable == "Принтеров")
            {
                nametable = "Printer";
            }
            if (nametable == "Катриджей")
            {
                nametable = "Catrij";
            }
            if (nametable == "Тонеров")
            {
                nametable = "Toner";

            }
            if (nametable == "Локаций")
            {
                nametable = "PLocale";

            }
            if (nametable == "Деталей")
            {
                nametable = "Detal";

            }
            if (nametable == "Покупок")
            {
                nametable = "Shop";

            }
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM {nametable} WHERE [{namecell}] LIKE '%{parametr}%' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public bool DeleteDetal(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("DELETE FROM Detal WHERE [ID] = @ID", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool DeleteLocale(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("DELETE FROM PLocale WHERE [ID] = @ID", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
                return false;
            }
        }
        public bool DeletePrinter(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("UPDATE Printer SET [Комментарий] = 'DELETE' WHERE [ID] = @ID", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
                return false;
        }
        public bool DeleteShop(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("DELETE FROM Shop WHERE [ID] = @ID", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public BindingList<DbDataRecord> GetCatrij(string id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Catrij WHERE NOT [Комментарий] = 'DELETE' AND [Принтер№]='{id}' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public BindingList<DbDataRecord> GetDetal(string id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Detal WHERE [Катридж№]='{id}' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public BindingList<DbDataRecord> GetLocale(string id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM PLocale WHERE [Принтер№]='{id}' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public BindingList<DbDataRecord> GetPrinter()
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Printer WHERE NOT [Комментарий] = 'DELETE' Order By [ID]", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            list.Add(record);
                        }
                    }
                    connection.Dispose();
                }
                catch
                {
                }
            }
            return list;
        }
        public BindingList<DbDataRecord> GetShop(string id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Shop WHERE [Тонер№]='{id}' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public BindingList<DbDataRecord> GetToner(string id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Toner WHERE  NOT [Комментарий] = 'DELETE' AND [Катридж№]='{id}' ", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public ArrayList needzapravka()
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("Limit", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public bool DeleteCatrij(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("UPDATE Catrij SET [Комментарий] = 'DELETE' WHERE [ID] = @ID", new object[0]), connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveCatrij(string Model, string color, string type, string Status, string ot_str, string comment, string printID)
        {
            string cmdText = string.Format("INSERT INTO Catrij ( [Модель], [Цвет], [Вид], [Статус], [ОтпечатаноСтраниц], [Комментарий], [Принтер№] )VALUES (@Model, @Color, @Type, @Status, @OS, @Comment, @PrinterID)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Color",
                    Value = color,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Type",
                    Value = type,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Status",
                    Value = Status,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_str,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PrinterID",
                    Value = printID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveDetal(string bar, string drum, string photobar, string comment, string catrijID)
        {
            string cmdText = string.Format("INSERT INTO Detal ( [Барабан], [DRUM], [Фотобарабан], [Комментарий], [Катридж№] )VALUES (@Baraban, @DRUM, @PHOTOBARABAN, @Comment, @CatrijID)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Baraban",
                    Value = bar,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "DRUM",
                    Value = drum,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PHOTOBARABAN",
                    Value = photobar,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "CatrijID",
                    Value = catrijID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditCatrij(string id, string Model, string color, string type, string Status, string ot_str, string comment, string printID)
        {
            string cmdText = string.Format("UPDATE Catrij SET [Модель] = @Model, [Цвет] = @Color, [Вид] = @Type, [Статус] = @Status, [ОтпечатаноСтраниц] = @OS, [Комментарий] = @Comment, [Принтер№] = @PrinterID WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Color",
                    Value = color,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Type",
                    Value = type,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Status",
                    Value = Status,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_str,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PrinterID",
                    Value = printID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditDetal(string id, string bar, string drum, string photobar, string comment, string catrijID)
        {
            string cmdText = string.Format("UPDATE Detal SET [Барабан] = @Baraban, [DRUM]= @DRUM, [Фотобарабан] = @PHOTOBARABAN, [Комментарий] = @Comment, [Катридж№] = @CatrijID WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Baraban",
                    Value = bar,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "DRUM",
                    Value = drum,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PHOTOBARABAN",
                    Value = photobar,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "CatrijID",
                    Value = catrijID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditLocale(string id, string locale, string vladel, string comment, string prnterID)
        {
            string cmdText = string.Format("UPDATE PLocale SET [Расположение] = @Locale, [Владелец] = @Vladel, [Комментарий] = @Comment, [Принтер№] = @PrinterID WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Locale",
                    Value = locale,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Vladel",
                    Value = vladel,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PrinterID",
                    Value = prnterID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditPrinter(string id, string Model, string Status, string data, string ot_str, string comment)
        {
            string cmdText = string.Format("UPDATE Printer SET [Модель] = @Model, [Статус] = @Status, [Дата] = @Date, [ОтпечатаноCтраниц] = @OS, [Комментарий] = @Comment WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Status",
                    Value = Status,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Date",
                    Value = data,
                    SqlDbType = SqlDbType.Date
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_str,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditShop(string id, string name, string price, string date, string site, string comment, string tonerID)
        {
            string cmdText = string.Format("UPDATE Shop SET [Название] = @Name, [Цена] = @Price, [ДатаПокупки] = @Date, [АдресСайта] = @Site, [Комментарий] = @Comment, [Тонер№] = @TonerID WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Name",
                    Value = name,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Price",
                    Value = price,
                    SqlDbType = SqlDbType.Money
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Date",
                    Value = date,
                    SqlDbType = SqlDbType.Date
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Site",
                    Value = site,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "TonerID",
                    Value = tonerID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveEditToner(string id, string Model, string color, string ot_zap, string comment, string catrijID)
        {
            string cmdText = string.Format("UPDATE Toner SET [Модель] = @Model, [Цвет] = @Color, [КоличествоЗаправок] = @OS, [Комментарий] = @Comment, [Катридж№] = @CatrijID WHERE [ID] = @id", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Color",
                    Value = color,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_zap,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "CatrijID",
                    Value = catrijID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "id",
                    Value = id,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveInFileCatrij(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("Catrij.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Open), Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Catrij";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Модель\"; \"Цвет\"; \"Вид\"; \"Статус\"; \"ОтпечатаноСтраниц\"; \"Комментарий\"; \"Принтер№\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString() + "\";\"" + reader[5].ToString() + "\";\"" + reader[6].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveInFileDetal(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("Detal.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                writer = new StreamWriter(stream, Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Detal";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Барабан\"; \"DRUM\"; \"Фотобарабан\"; \"Комментарий\"; \"Катридж№\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString() + "\";\"" + reader[5].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveInFileLocale(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("Locale.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Open), Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Locale";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Расположение\"; \"Владелец\"; \"Комментарий\"; \"Принтер№\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveInFilePrinter(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("PrinterDB.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Open), Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Printer";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Модель\";\"Статус\";\"ОтпечатаноСтраниц\";\"Комментарий\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveInFileShop(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("Shop.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Open), Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Shop";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Название\"; \"Цена\"; \"Дата Покупки\"; \"Статус\"; \"Адрес Сайта\"; \"Комментарий\"; \"Тонер№\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString() + "\";\"" + reader[5].ToString() + "\";\"" + reader[6].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveInFileToner(string path)
        {
            StreamWriter writer;
            if (path == string.Empty)
            {
                writer = new StreamWriter(new FileStream("Toner.csv", FileMode.Create), Encoding.GetEncoding(0x4e3));
            }
            else
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Open), Encoding.GetEncoding(0x4e3));
            }
            string cmdText = "SELECT * FROM Toner";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    writer.WriteLine("\"ID\"; \"Модель\"; \"Цвет\"; \"КоличествоЗаправок\"; \"Комментарий\"; \"Катридж№\"");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine("\"" + reader[0].ToString() + "\";\"" + reader[1].ToString() + "\";\"" + reader[2].ToString() + "\";\"" + reader[3].ToString() + "\";\"" + reader[4].ToString() + "\";\"" + reader[5].ToString(), Encoding.ASCII);
                        }
                    }
                    else
                    {
                        writer.WriteLine("No one row in DabaBase!!!");
                    }
                    writer.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SaveLocale(string locale, string vladel, string comment, string prnterID)
        {
            string cmdText = string.Format("INSERT INTO PLocale ( [Расположение], [Владелец], [Комментарий], [Принтер№] )VALUES (@Locale, @Vladel, @Comment, @PrinterID)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Locale",
                    Value = locale,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Vladel",
                    Value = vladel,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "PrinterID",
                    Value = prnterID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SavePrinter(string Model, string Status, string data, string ot_str, string comment)
        {
            string cmdText = string.Format("INSERT INTO Printer ( [Модель], [Статус], [Дата], [ОтпечатаноCтраниц], [Комментарий] )VALUES (@Model, @Status, @Date, @OS, @Comment)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Status",
                    Value = Status,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Date",
                    Value = data,
                    SqlDbType = SqlDbType.Date
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_str,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveShop(string name, string price, string date, string site, string comment, string tonerID)
        {
            string cmdText = string.Format("INSERT INTO Shop ( [Название], [Цена], [ДатаПокупки], [АдресСайта], [Комментарий], [Тонер№] )VALUES (@Name, @Price, @Date, @Site, @Comment, @TonerID)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Name",
                    Value = name,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Price",
                    Value = price,
                    SqlDbType = SqlDbType.Money
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Date",
                    Value = date,
                    SqlDbType = SqlDbType.Date
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Site",
                    Value = site,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "TonerID",
                    Value = tonerID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool SaveToner(string Model, string color, string ot_zap, string comment, string catrijID)
        {
            string cmdText = string.Format("INSERT INTO Toner ( [Модель], [Цвет], [КоличествоЗаправок], [Комментарий], [Катридж№] )VALUES (@Model, @Color, @OS, @Comment, @CatrijID)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Model",
                    Value = Model,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Color",
                    Value = color,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "OS",
                    Value = ot_zap,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = comment,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "CatrijID",
                    Value = catrijID,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public ArrayList SearchPrinter(string find)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SearchPrinter", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Find",
                    Value = find,
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public bool zapravka(string id, int ot_zap)
        {
            if (ot_zap > 0)
            {
                string cmdText = string.Format("UPDATE Toner SET [КоличествоЗаправок] = @OS  WHERE [ID] = @id", new object[0]);
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand command = new SqlCommand(cmdText, connection);
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "OS",
                        Value = ot_zap - 1,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "id",
                        Value = id,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    try
                    {
                        connection.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return false;
        }
    }
}
