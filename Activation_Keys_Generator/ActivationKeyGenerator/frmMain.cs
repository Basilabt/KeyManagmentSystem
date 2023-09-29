using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessAccessLayer;

namespace ActivationKeyGenerator
{
    public partial class frmMain : Form
    {

        private clsUser _loggedUser;

        public frmMain(clsUser loggedUser)
        {
            InitializeComponent();

            _loggedUser = loggedUser;
        }

        private void _FillListViewWithData(DataTable codes)
        {
            string type = "-";
            string code = "-";
            string isValid = "-1";

            ListViewItem item;

            if (radioBoth.Checked)
            {
                foreach (DataRow row in codes.Rows)
                {
                    type = row[5].ToString();
                    code = row[2].ToString();
                    isValid = row[3].ToString();

                    item = new ListViewItem(type);

                    item.SubItems.Add(code);
                    item.SubItems.Add(isValid);

                    listCodes.Items.Add(item);
                }
            } 
            else if(radioValid.Checked)
            {

                foreach (DataRow row in codes.Rows)
                {
                    type = row[5].ToString();
                    code = row[2].ToString();
                    isValid = row[3].ToString();

              
              

                    if(isValid == "True")
                    {
                        item = new ListViewItem(type);

                        item.SubItems.Add(code);
                        item.SubItems.Add(isValid);

                        listCodes.Items.Add(item);
                    }

                  
                }

            }
            else
            {
                foreach (DataRow row in codes.Rows)
                {
                    type = row[5].ToString();
                    code = row[2].ToString();
                    isValid = row[3].ToString();

                  

                    if (isValid == "False")
                    {
                        item = new ListViewItem(type);

                        item.SubItems.Add(code);
                        item.SubItems.Add(isValid);

                        listCodes.Items.Add(item);
                    }


                }
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           


        }

        private void btnGetCodes_Click(object sender, EventArgs e)
        {

            if(radioGooglePlay.Checked)
            {
                _FillListViewWithData(clsCode.getCodes(clsCode.Type.Itunes));
            } 
            else if(radioItunes.Checked)
            {
                _FillListViewWithData(clsCode.getCodes(clsCode.Type.Itunes));
            } 
            else if(radioSteam.Checked)
            {
                _FillListViewWithData(clsCode.getCodes(clsCode.Type.Steam));
            }
            else if(radioWindowsActivation.Checked)
            {
                _FillListViewWithData(clsCode.getCodes(clsCode.Type.WindowsActivation));
            } 
            else if(radioAll.Checked)
            {
                _FillListViewWithData(clsCode.getCodes(clsCode.Type.All));
            } 
            else
            {
                MessageBox.Show("Please Select Code Type !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
           // clear list.
        }
    }
}
