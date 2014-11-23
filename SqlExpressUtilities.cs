using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Compact_Agenda
{

    public class TextFilter
    {
        static public string PrepareForSql(string text)
        {
            if (text != null)
                return text.Replace("'", "apostrophe");
            else
                return "";
        }

        static public string FromSql(string text)
        {
            if (text != null)
                return text.Replace("apostrophe", "'");
            else
                return "";
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    // Cette classe offre une interface conviviale au programmeur utilisateur pour des transactions SQL
    // avec une table d'un base de données SQL Express
    //
    // Auteur: Nicolas Chourot
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public class SqlExpressUtilities
    {
        // objet de connection
        SqlConnection connection;
        // chaine de connection
        string connexionString;
        

        // Liste des valeur des champs lors de la lecture de la requête
        public List<string> fieldsValues = new List<string>();
        // Liste des noms des champs de la table en cours de lecture
        public List<string> FieldsNames = new List<string>();
        // Objet de lecture de la dernière requête
        public SqlDataReader reader;

        // contructeur obligatoire auquel il faut fournir la chaine de connection
        // et l'objet Application de l'application ASP.net
        public SqlExpressUtilities(string connexionString)
        {
            this.connexionString = connexionString;
        }

        static string TwoDigit(int n)
        {
            string s = n.ToString();
            if (n < 10)
                s = "0" + s;
            return s;

        }
        
        public static string DateSQLFormat(DateTime date)
        {
            return  date.Year + "-" + 
                    TwoDigit(date.Month) + "-" + 
                    TwoDigit(date.Day) + " " + 
                    TwoDigit(date.Hour) + ":" +
                    TwoDigit(date.Minute) + ":" + 
                    TwoDigit(date.Second) + ".000";
        }


        // Extraire les valeur des champs de l'enregistrement suivant du lecteur 
        bool GetfieldsValues()
        {
            bool endOfReader = false;
            // Effacer la liste des valeurs
            fieldsValues.Clear();
            // si il reste des enregistrements à lire
            if (endOfReader = reader.Read())
            {
                // Extraire les valeurs des champs
                for (int f = 0; f < reader.FieldCount; f++)
                {
                    // la fonction Trim permet l'effacement des espaces en trop 
                    // avant et après la valeur proprement dite
                    fieldsValues.Add(reader[f].ToString().Trim());
                }
            }
            return endOfReader;
        }

        // Extraire les noms des champs 
        void GetFieldsName()
        {
            if (reader != null)
            {
                FieldsNames.Clear();
                for (int f = 0; f < reader.FieldCount; f++)
                {
                    FieldsNames.Add(reader.GetName(f));
                }
            }
        }

        // Passer à l'enregistrement suivant du lecteur de requête
        public bool NextRecord()
        {
            return GetfieldsValues();
        }

        // Exécuter une commande SQL
        public int QuerySQL(string sqlCommand)
        {
            // instancier l'objet de collection
            try
            {
                connection = new SqlConnection(connexionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            // bâtir l'objet de requête
            SqlCommand sqlcmd = new SqlCommand(sqlCommand);

            // affecter l'objet de connection à l'objet de requête
            sqlcmd.Connection = connection;

            // ouvrir la connection avec la bd
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            // éxécuter la requête SQL et récupérer les enregistrements qui en découlent
            reader = sqlcmd.ExecuteReader();

            // Saisir les noms des champs de la table impliquée dans la requête
            GetFieldsName();
            // retourner le nombre d'enregistrements générés
           
            return reader.FieldCount;

        }

        // Conclure la dernière requête
        public void EndQuerySQL()
        {
            // Fermer la connection
            connection.Close();
        }

        // Éxécuter une requête SQL qui ne génère pas d'enregistrement
        public int NonQuerySQL(string sqlCommand)
        {
            int recordsAffected = QuerySQL(sqlCommand);
            EndQuerySQL();
            return recordsAffected;
        }

        // retourne l'indexe du champs de nom fieldName
        public int IndexOf(string fieldName)
        {
            int i = FieldsNames.IndexOf(fieldName);
            return FieldsNames.IndexOf(fieldName);
        }

        // Surchage de l'opérateur [] pour pouvoir atteindre un champ par son nom
        // par exemple : tableUsers["nom_du_champ"]
        public string this[string fieldName]
        {
            get { return fieldsValues[IndexOf(fieldName)]; }
            set { fieldsValues[IndexOf(fieldName)] = value; }
        }

        public int UpdateRecord(string TableName)
        {
            String SQL = "UPDATE " + TableName + " ";

            SQL += "SET ";
            int nb_fields = FieldsNames.Count();
            // sauter fieldNum = 0 qui correspond au Id de l'enregistrement
            for (int fieldNum = 1; fieldNum < nb_fields; fieldNum++)
            {
                SQL += "[" + FieldsNames[fieldNum] + "] = ";
                SQL += "'" + fieldsValues[fieldNum] + "'";
                if (fieldNum < (nb_fields - 1)) SQL += ", ";
            }
            SQL += " WHERE [" + FieldsNames[0] + "] = " + "'" + fieldsValues[0] + "'";

            return NonQuerySQL(SQL);
        }
    }


    // Classe spécialisée à la table EVENTS
    public class TableEvents : SqlExpressUtilities
    {
        public Event currentEventRecord { get; set; }

        // Constructeur obligatoire
        public TableEvents(string connexionString)
            : base(connexionString)
        {
        }

        public void AddEvent(Event Event)
        {
            NonQuerySQL("INSERT INTO Events (Title, Description, Starting, Ending, Category) VALUES ('" + TextFilter.PrepareForSql(Event.Title) + "','" +
                                                                                                TextFilter.PrepareForSql(Event.Description) + "','" +
                                                                                                DateSQLFormat(Event.Starting) + "','" +
                                                                                                DateSQLFormat(Event.Ending) + "','" +
                                                                                                Event.Category.ToString() + "');");
        }

        public Event GetEventByID(string Id)
        {
            string sql = "SELECT * FROM Events WHERE Id = '" + Id + "'";

            int fieldCount = QuerySQL(sql);

            if (fieldCount > 0)
            {
                NextRecord();
                return new Event(   this["Id"], 
                                    this["Title"], 
                                    this["Description"],
                                    this["Starting"],  
                                    this["Ending"],
                                    this["Category"]);
            }
            else
                return null;
        }

        public bool NextEventRecord()
        {
            bool more = NextRecord();
            if (more)
            {
                currentEventRecord = new Event( this["Id"],
                                                this["Title"],
                                                this["Description"],
                                                this["Starting"],
                                                this["Ending"],
                                                this["Category"]);
            }
            return more;
        }

        public void GetDateEvents(DateTime date)
        {
            DateTime DateStart = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            DateTime DateEnd = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            string sql = "SELECT * FROM Events WHERE Starting >= '" + DateSQLFormat(DateStart) + "' AND Starting <= '" + DateSQLFormat(DateEnd) + "' ORDER BY Starting ";

            QuerySQL(sql);
        }

        public void GetAllEvents()
        {
            string sql = "SELECT * FROM Events ORDER BY Starting";

            QuerySQL(sql);
        }

        public void UpdateEventRecord(Event Event)
        {
            GetEventByID(Event.Id);
            //fieldsValues[0] = Event.Id;
            fieldsValues[1] = TextFilter.PrepareForSql(Event.Title);
            fieldsValues[2] = TextFilter.PrepareForSql(Event.Description);
            fieldsValues[3] = DateSQLFormat(Event.Starting);
            fieldsValues[4] = DateSQLFormat(Event.Ending);
            fieldsValues[5] = Event.Category.ToString();

            UpdateRecord("Events");
        }

        public int DeleteEvent(Event Event)
        {
            return NonQuerySQL("DELETE FROM Events WHERE Id ='" + Event.Id + "'");
        }
        public int DeleteEvent(string id)
        {
            return NonQuerySQL("DELETE FROM Events WHERE Id ='" + id + "'");
        }
    }
}