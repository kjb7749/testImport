using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;
using CodeBase;
using System.Linq;
using System.Threading.Tasks;

namespace GrushOpenDentalPlugin
{
    public partial class Form1 : Form
    {
        public long PatNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GrushDentalDashboard_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test code

            string server = ProgramProperties.GetPropVal(Programs.GetProgramNum(ProgramName.eClinicalWorks), "eCWServer");//this property will not exist if using Oracle, eCW will never use Oracle
            string port = ProgramProperties.GetPropVal(Programs.GetProgramNum(ProgramName.eClinicalWorks), "eCWPort");//this property will not exist if using Oracle, eCW will never use Oracle

            string username = "root";//"ecwUser";
            string password = "";//"l69Rr4Rmj4CjiCTLxrIblg==";//encrypted

            CentralConnections.GetConnections();

        string connString =
                "Server=" + server + ";"
                + "Port=" + port + ";"//although this does seem to cause a bug in Mono.  We will revisit this bug if needed to exclude the port option only for Mono.
                + "Database=mobiledoc;"//ecwMaster;"
                                       //+"Connect Timeout=20;"
                + "User ID=" + username + ";"
                + "Password=" + CodeBase.MiscUtils.Decrypt(password) + ";"
                + "CharSet=utf8;"
                + "Treat Tiny As Boolean=false;"
                + "Allow User Variables=true;"
                + "Default Command Timeout=300;"//default is 30seconds
                + "Pooling=false"
                ;

            string command = "select Description from account;";

            string result = MySql.Data.MySqlClient.MySqlHelper.ExecuteDataRow(connString, command)["Description"].ToString();
            MessageBox.Show(result);
        }
    }
}
