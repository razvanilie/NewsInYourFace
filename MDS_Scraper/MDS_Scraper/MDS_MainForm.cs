using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDS_Scraper
{
    public partial class MDS_MainForm : Form
    {
        public MDS_MainForm()
        {
            InitializeComponent();
        }

        // Close the program when clicked
        private void btnExitProject_Click(object sender, EventArgs e)
        {

            Application.Exit(); // end the app
        }

        //if the txtDays text is not a number don't start the robot, else start the robot and write info in txt
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDays.Text.Trim(), out _))
            {
                lblDays.ForeColor = Color.Black;
                btnStart.Visible = false;
                labelUiPath.Visible = true;

                // delete the content of file
                StreamWriter _ = new StreamWriter("mds_robot_other_info.csv"); // delete the content
                _.Close();// delete the content of file
                _ = new StreamWriter("mds_robot_sites.csv"); // delete the content
                _.Close();
                StreamWriter siteWriter = new StreamWriter("mds_robot_sites.csv", true);
                siteWriter.AutoFlush = true;
                if (btnFirstSite.BackColor == Color.LimeGreen)
                    siteWriter.WriteLine("techcrunch.com");
                if (btnSecondSite.BackColor == Color.LimeGreen)
                    siteWriter.WriteLine("cultivatedculture.com");
                if (btnThirdSite.BackColor == Color.LimeGreen)
                    siteWriter.WriteLine("uipath.com");
                siteWriter.Close();
                StreamWriter otherinfoWriter = new StreamWriter("mds_robot_other_info.csv", true);
                otherinfoWriter.AutoFlush = true;
                otherinfoWriter.WriteLine("days," + txtDays.Text.Trim());
                otherinfoWriter.Close();

                timerEndApp.Enabled = true;
            }
            else
                lblDays.ForeColor = Color.Red;
        }

        private void btnFirstSite_Click(object sender, EventArgs e)
        {
            if (btnFirstSite.BackColor == Color.RoyalBlue)
            {
                btnFirstSite.BackColor = Color.LimeGreen;
            }
            else
            {
                btnFirstSite.BackColor = Color.RoyalBlue;
            }
        }

        private void btnSecondSite_Click(object sender, EventArgs e)
        {
            if (btnSecondSite.BackColor == Color.RoyalBlue)
            {
                btnSecondSite.BackColor = Color.LimeGreen;
            }
            else
            {
                btnSecondSite.BackColor = Color.RoyalBlue;
            }
        }

        private void btnThirdSite_Click(object sender, EventArgs e)
        {
            if (btnThirdSite.BackColor == Color.RoyalBlue)
            {
                btnThirdSite.BackColor = Color.LimeGreen;
            }
            else
            {
                btnThirdSite.BackColor = Color.RoyalBlue;
            }
        }

        private void timerEndApp_Tick(object sender, EventArgs e)
        {
            Application.Exit(); //after 10 sec end the app
        }
    }
}
