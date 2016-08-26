using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Threading;
using System.Windows.Forms;

namespace OdbcSpy
{
    public partial class MainForm : Form
    {
        private string _defaultConnectionString = "DSN=DriverName;UID=username;pwd=password";
        private OdbcClient odbc;

        public MainForm()
        {
            InitializeComponent();
            ConnectionStringBox.Text = _defaultConnectionString;

            Connect();
        }

        private void Connect()
        {
            odbc = new OdbcClient();
            odbc.Finished += odbc_Finished;
            odbc.Connect(ConnectionStringBox.Text);
        }

        void odbc_Finished(object sender, EventArgs e)
        {
            EnableCancelButton(false);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void QueryBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Execute();
            }
        }

        private void Execute()
        {
            EnableCancelButton(true);
            odbc.Execute(QueryBox.Text);
        }

        delegate void BooleanDelegate(bool on);
        void EnableCancelButton(bool enable)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new BooleanDelegate(EnableCancelButton), new object[] { enable });
                return;
            }

            cancelButton.Enabled = enable;
        }

        private void renderText(List<String> Columns, List<List<String>> Rows, String textOutput)
        {
            foreach (string cn in Columns)
            {
                textOutput += cn + ",";
            }

            textOutput += "\r\n";

            foreach (List<String> r in Rows)
            {
                foreach (string v in r)
                {
                    textOutput += v + ",";
                }
                textOutput += "\r\n";
            }

            Results.Text = textOutput;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Results.Text);
            MessageBox.Show("Results copied to clipboard");
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            odbc.CancelQuery();
        }

    }


}
