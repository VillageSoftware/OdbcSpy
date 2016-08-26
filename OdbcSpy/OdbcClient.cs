using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OdbcSpy
{
    public delegate void FinishedHandler(object sender, EventArgs e);

    public class OdbcClient
    {
        private OdbcConnection c;
        private string _connectionString;
        private Thread _queryThread;
        private string _query;

        public string Results { get; set; }

        public event FinishedHandler Finished;

        private void RaiseFinished()
        {
            Finished(this, new EventArgs());
        }

        public void Connect(string connectionString)
        {
            _connectionString = connectionString;
            c = new OdbcConnection(_connectionString);
        }

        public void CancelQuery()
        {
            _queryThread.Abort();
            c.Close();
            RaiseFinished();
        }

        private void ExecutionThread()
        {
            try
            {
                c.Open();
            }
            catch (Exception ex)
            {
                Results = ex.ToString();
            }

            var command = new OdbcCommand(_query);
            command.Connection = c;

            try
            {
                string textOutput = RunQuery(command);
                Results = textOutput;
            }
            catch (Exception ex)
            {
                Results = ex.ToString();
            }
            finally
            {
                c.Close();
                RaiseFinished();
            }
        }

        public void Execute(string query)
        {
            _query = query;
            _queryThread = new Thread(new ThreadStart(ExecutionThread));
            _queryThread.Start();
        }

        private string RunQuery(OdbcCommand command)
        {
            var reader = command.ExecuteReader();

            var Columns = new List<String>();
            var Rows = new List<List<String>>();
            string textOutput = "";

            if (reader.HasRows)
            {

                for (int column = 0; column < reader.FieldCount; column++)
                {
                    string colName = reader.GetName(column);
                    Columns.Add(colName);
                    textOutput += colName + ",";
                }

                textOutput += "\r\n";

                while (reader.Read())
                {
                    var Row = new List<String>();
                    for (int column = 0; column < reader.FieldCount; column++)
                    {
                        string value;

                        try
                        {
                            value = reader.GetString(column);
                        }
                        catch
                        {
                            value = "";
                        }

                        textOutput += value + ",";
                        Row.Add(value);
                    }

                    textOutput += "\r\n";
                    Rows.Add(Row);
                }
            }
            else
            {
                return "No results";
            }
            return textOutput;
        }

    }
}
