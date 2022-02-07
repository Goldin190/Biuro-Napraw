using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BiuroNaprawProjekt
{
    public class NpgsqlHandler
    {
        private Npgsql.NpgsqlConnection conn;        
        private string host;
        private string passwd;
        private string port;
        private string username;
        private string db;
        private string schema;
        public string SQL;
        public string eMessage; // exepction message
        

        // funkcja tylko do testów
        public string TestConnectionString()
        {
            return "Host = " + this.host + 
                "\nPasswd = " + this.passwd + 
                "\nUsername = " + this.username + 
                "\nSchema = " + this.schema + 
                "\nPort = " + this.port+
                "\nDataBase = "+this.db;
        }

        public void OpenConnection()
        {
            this.conn.Open();
        }
        public void CloseConnection()
        {
            this.conn.Close();
        }

        private bool ReadParametersFromConfig(int BranchId)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            XmlNode connectionXml = config.LastChild.ChildNodes[BranchId];
            XmlNode propertyNode = connectionXml.FirstChild;
            this.host = connectionXml.ChildNodes[0].InnerText;
            this.username = connectionXml.ChildNodes[1].InnerText;
            this.passwd = connectionXml.ChildNodes[2].InnerText;
            this.schema = connectionXml.ChildNodes[3].InnerText;
            this.port = connectionXml.ChildNodes[4].InnerText;
            this.db = connectionXml.ChildNodes[5].InnerText;
            return true;
        }
        
        public bool Initialize_connection()
        {
            if (ReadParametersFromConfig(0))
            {
                conn = new Npgsql.NpgsqlConnection("Host=" + this.host+
                                                        ";Port=" + this.port+
                                                        ";Username="+this.username+
                                                        ";Password="+this.passwd+
                                                        ";Database="+this.db + ";");

                return true;
            }
            return false;
        }
        public List<string> SelectNumbersToString()
        {
            List<string> rows = new List<string>();
            SQL = "Select * " +
                "From \"Production\".\"Numery\" ";

            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                using (Npgsql.NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string row = "";
                        row += " " + reader.GetDecimal(0);
                        row += " " + reader.GetDecimal(1);
                        row += " " + reader.GetDecimal(2);
                        row += " " + reader.GetDecimal(3);
                        row += " " + reader.GetDecimal(4);
                        row += " " + reader.GetDecimal(5);
                        row += " " + reader.GetDecimal(6);
                        row += " " + reader.GetDecimal(7);
                        row += " " + reader.GetString(8);
                        row += " " + reader.GetString(9);
                        row += " " + reader.GetDecimal(10);
                        row += " " + reader.GetString(11);
                        row += " " + reader.GetString(12);
                        rows.Add(row);
                    }
                }
            }
            return rows;
        }
        public bool CheckConnection()
        {
            SQL = "Select * " +
                "From \"Production\".\"Numery\" " +
                "ORDER BY \"Number\" ASC" +
                " limit 1";
            try
            {
                this.OpenConnection();
                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn);
            }
            catch(Npgsql.NpgsqlException e)
            {
                this.eMessage = e.Message;
                this.CloseConnection();
                return false;
            }
            this.CloseConnection();
            return true;
            
        }
        public List<NumberClass> SelectNumbers()
        {
            List<NumberClass> numbers = new List<NumberClass>();
            
            SQL = "Select * " +
                "From \"Production\".\"Numery\" "+
                "ORDER BY \"Number\" ASC";
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                using (Npgsql.NpgsqlDataReader reader = command.ExecuteReader()) 
                { 
                    while (reader.Read())
                    {
                        NumberClass number = new NumberClass();
                        List<string> row = new List<string>();

                        row.Add(reader.GetDecimal(0).ToString());
                        row.Add(reader.GetDecimal(1).ToString() + "-" + 
                            reader.GetDecimal(2).ToString() + "-" +
                            reader.GetDecimal(3).ToString());
                        row.Add(reader.GetDecimal(4).ToString());
                        row.Add(reader.GetDecimal(5).ToString() + "-" +
                            reader.GetDecimal(6).ToString());
                        row.Add(reader.GetDecimal(7).ToString());
                        row.Add(reader.GetString(8));
                        row.Add(reader.GetString(9));
                        row.Add(reader.GetDecimal(10).ToString());
                        row.Add(reader.GetString(11));
                        row.Add(reader.GetString(12));
                        number.PopulateFromList(row);
                        number.numer = reader.GetDecimal(0);
                        number.stacyjna[0] = reader.GetDecimal(1);
                        numbers.Add(number);
                    }
                }
            }
            
            this.CloseConnection();
            return numbers;
        }
        public bool AddNumber(NumberClass number)
        {
            SQL = "INSERT INTO \"Production\".\"Numery\"(" +
                    "\"Number\", \"Stacyjna1\", \"Stacyjna2\"," +
                    " \"Stacyjna3\", \"Koncentrator\", \"Liniowa1\"," +
                    " \"Liniowa2\", \"LokalizacjaID\", \"Nazwa\", " +
                    "\"Adres\", \"Ograniczenia\", \"Trasa\", " +
                    "\"Uwagi\", \"IsEdited\")" +
                   "VALUES("+number.numer+"," +number.stacyjna[0]+"," +number.stacyjna[1] + ","
                   +number.stacyjna[2] + "," +number.koncetntrator+"," +number.liniowa[0] + ","
                   +number.liniowa[1] + "," +number.jwID+", \'" +number.nazwa+"\',\'"
                   +number.adres+"\'," +number.ograniczenia+",\'" +number.trasa+"\',\'"
                   +number.uwagi+"\'," +false+");";
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    this.CloseConnection();
                    return true;
                }
            }
            this.CloseConnection();
            return false;
        }
        public bool UpdateNumer(NumberClass number)
        {
            SQL = "UPDATE \"Production\".\"Numery\""+
                "SET \"Stacyjna1\" ="+number.stacyjna[0]+","+
                " \"Stacyjna2\" ="+number.stacyjna[1]+ ","+
                " \"Stacyjna3\" ="+number.stacyjna[2] + ","+
                " \"Koncentrator\" ="+number.koncetntrator+"," +
                " \"Liniowa1\" ="+number.liniowa[0]+"," +
                " \"Liniowa2\" ="+number.liniowa[1] + ","+
                " \"LokalizacjaID\" ="+number.jwID+"," +
                " \"Nazwa\" =\'"+number.nazwa+"\'," +
                " \"Adres\" =\'"+number.adres+"\'," +
                " \"Ograniczenia\" ="+number.ograniczenia+", " +
                "\"Trasa\" =\'"+number.trasa+"\', " +
                "\"Uwagi\" =\'"+number.uwagi+"\' " +
                "WHERE \"Number\" = "+number.numer;
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    this.CloseConnection();
                    return true;
                }
            }
            this.CloseConnection();
            return false;
        }

        public List<Lokalizacja> SelectLokacje()
        {
            List<Lokalizacja> lokacje = new List<Lokalizacja>();

            SQL = "Select * " +
                "From \"Production\".\"Lokalizacje\" "+
                "ORDER BY \"ID\" ASC";
            
            this.OpenConnection();
            using(Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn)){
                using (Npgsql.NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lokalizacja lokacja = new Lokalizacja();
                        lokacja.id = reader.GetInt32(0);
                        lokacja.nazwa = reader.GetString(1);
                        lokacje.Add(lokacja);
                    }
                }                
            }
            this.CloseConnection();
            return lokacje;
        }
        public bool InsertLokacje(string name)
        {
            SQL = "INSERT INTO \"Production\".\"Lokalizacje\"(" +
                    "\"Nazwa\")" +
                   "VALUES(\'" + name + "\');";
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    this.CloseConnection();
                    return true;
                }
            }
            this.CloseConnection();
            return false;
        }

        public bool UpdateLokacje(int id,string name)
        {
            SQL = "UPDATE \"Production\".\"Lokalizacje\"" +
               "SET \"Nazwa\" =\'" + name +"\'"+
               "WHERE \"ID\" = " + id;
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    this.CloseConnection();
                    return true;
                }
            }
            this.CloseConnection();
            return false;
        }
        public bool DeleteLokacje(int id)
        {
            SQL = "DELETE FROM \"Production\".\"Lokalizacje\""+
               "WHERE \"ID\" = " + id;
            this.OpenConnection();
            using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(SQL, conn))
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    this.CloseConnection();
                    return true;
                }
            }
            this.CloseConnection();
            return false;
        }

    }
}
/*                        if (reader.GetDecimal(2) == null)
                        {
                            number.stacyjna[1] = 0;
                        }
                        else
                        {
                            number.stacyjna[1] = reader.GetDecimal(2);
                        }
                        if (reader.GetDecimal(3) == null)
                        {
                            number.stacyjna[2] = 0;
                        }
                        else
                        {
                            number.stacyjna[2] = reader.GetDecimal(3);
                        }
                        number.koncetntrator = reader.GetDecimal(4);
                        if (reader.GetDecimal(5) == null)
                        {
                            number.liniowa[0] = 0;
                        }
                        else
                        {
                            number.liniowa[0] = reader.GetDecimal(5);
                        }
                        if (reader.GetDecimal(5) == null)
                        {
                            number.liniowa[0] = 0;
                        }
                        else
                        {
                            number.liniowa[1] = reader.GetDecimal(6);
                        }
                        if (reader.GetString(8) == null || reader.GetString(8) == "")
                        {
                            number.nazwa = "";
                        }
                        else
                        {
                            number.nazwa = reader.GetString(8);
                        }
                        if (reader.GetString(9) == null || reader.GetString(9) == "")
                        {
                            number.adres = "";
                        }
                        else
                        {
                            number.adres = reader.GetString(9);
                        }
                        if (reader.GetString(11) == null || reader.GetString(11) == "")
                        {
                            number.trasa = "";
                        }
                        else
                        {
                            number.trasa = reader.GetString(11);
                        }
                        if (reader.GetString(12) == null || reader.GetString(12) == "")
                        {
                            number.uwagi = "";
                        }
                        else
                        {
                            number.uwagi = reader.GetString(12);
                        }
                        number.ograniczenia = reader.GetDecimal(10);
*/