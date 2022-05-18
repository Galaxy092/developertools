using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Developer_Tools
{
    public partial class DT : Form
    {
        public DT()
        {
            InitializeComponent();
        }

        private void btnvscode_Click(object sender, EventArgs e)
        {
            var vscode = new ProcessStartInfo("Firefox.exe");
            vscode.Arguments = "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user";
            Process.Start(vscode);
        }

        private void btngit_Click(object sender, EventArgs e)
        {
            var git = new ProcessStartInfo("Chrome.exe");
            git.Arguments = "https://github.com/git-for-windows/git/releases/download/v2.36.1.windows.1/Git-2.36.1-64-bit.exe";
            Process.Start(git);
        }

        private void btnsqlserver_Click(object sender, EventArgs e)
        {
            var sqlServerDeveloperEdition = new ProcessStartInfo("Chrome.exe");
            sqlServerDeveloperEdition.Arguments = "https://go.microsoft.com/fwlink/p/?linkid=866662";
            Process.Start(sqlServerDeveloperEdition);
        }

        private void btnintellij_Click(object sender, EventArgs e)
        {
            var intellijIDE = new ProcessStartInfo("Chrome.exe");
            intellijIDE.Arguments = "https://download.jetbrains.com/idea/ideaIC-2022.1.1.exe";
            Process.Start(intellijIDE);
        }

        private void btnpycharm_Click(object sender, EventArgs e)
        {
            var pycharmIDE = new ProcessStartInfo("Chrome.exe");
            pycharmIDE.Arguments = "https://download.jetbrains.com/python/pycharm-community-2022.1.1.exe";
            Process.Start(pycharmIDE);
        }

        private void btneclipse_Click(object sender, EventArgs e)
        {
            var eclipseIDE = new ProcessStartInfo("Chrome.exe");
            eclipseIDE.Arguments = "https://www.eclipse.org/downloads/download.php?file=/oomph/epp/2022-03/R/eclipse-inst-jre-win64.exe&mirror_id=1273";
            Process.Start(eclipseIDE);
        }

        private void btnvs2022community_Click(object sender, EventArgs e)
        {
            var vs2022community = new ProcessStartInfo("Chrome.exe");
            vs2022community.Arguments = "https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030";
            Process.Start(vs2022community);
        }

        private void btnsublimetext_Click(object sender, EventArgs e)
        {
            var sublimeText = new ProcessStartInfo("Chrome.exe");
            sublimeText.Arguments = "https://download.sublimetext.com/sublime_text_build_4126_x64_setup.exe";
            Process.Start(sublimeText);
        }

        private void btnapachenetbeans13_Click(object sender, EventArgs e)
        {
            var NetBeans13 = new ProcessStartInfo("Chrome.exe");
            NetBeans13.Arguments = "https://dlcdn.apache.org/netbeans/netbeans-installers/13/Apache-NetBeans-13-bin-windows-x64.exe";
            Process.Start(NetBeans13);
        }

        private void btnatom_Click(object sender, EventArgs e)
        {
            var atom = new ProcessStartInfo("Chrome.exe");
            atom.Arguments = "https://atom.io/download/windows_x64";
            Process.Start(atom);
        }

        private void btnpostgresql_Click(object sender, EventArgs e)
        {
            var postgreSQL = new ProcessStartInfo("Chrome.exe");
            postgreSQL.Arguments = "https://www.enterprisedb.com/postgresql-tutorial-resources-training?uuid=db55e32d-e9f0-4d7c-9aef-b17d01210704&campaignId=7012J000001NhszQAC";
            Process.Start(postgreSQL);
        }

        private void btnmysql_Click(object sender, EventArgs e)
        {
            var mySQL = new ProcessStartInfo("Chrome.exe");
            mySQL.Arguments = "https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-community-8.0.29.0.msi";
            Process.Start(mySQL);
        }

        private void btnmongodb_Click(object sender, EventArgs e)
        {
            var mongoDB = new ProcessStartInfo("Chrome.exe");
            mongoDB.Arguments = "https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-5.0.8-signed.msi";
            Process.Start(mongoDB);
        }

        private void btnredis_Click(object sender, EventArgs e)
        {
            var redis = new ProcessStartInfo("Chrome.exe");
            redis.Arguments = "https://github.com/redis/redis/archive/7.0.0.tar.gz";
            Process.Start(redis);
        }

        public void btnoracle_Click(object sender, EventArgs e)
        {
            var oracle = new ProcessStartInfo("Chrome.exe");
            oracle.Arguments = "https://www.oracle.com/webapps/redirect/signon?nexturl=https://download.oracle.com/otn/nt/oracle21c/213000/WINDOWS.X64_213000_db_home.zip";
            Process.Start(oracle);
        }
    }
}
