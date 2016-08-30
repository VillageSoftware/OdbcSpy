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
        private const string PRODUCT_NAME = "ODBC Spy";

        public MainForm()
        {
            InitializeComponent();
            ConnectionStringBox.Text = _defaultConnectionString;

            //Set window title
            string architectureText = System.Environment.Is64BitProcess
                ? " (64 bit)"
                : " (32 bit)";

            Text = PRODUCT_NAME + architectureText;

        }

        private void Connect()
        {
            odbc = new OdbcClient();
            odbc.Finished += odbc_Finished;
            odbc.Connect(ConnectionStringBox.Text);
        }

        private void Execute()
        {
            Connect();
            EnableCancelButton(true);
            odbc.Execute(QueryBox.Text);
        }

        void odbc_Finished(object sender, EventArgs e)
        {
            EnableCancelButton(false);
            SetResultsText(odbc.Results);
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

        delegate void TextDelegate(string text);
        void SetResultsText(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new TextDelegate(SetResultsText), new object[] { text });
                return;
            }

            Results.Text = text;
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
