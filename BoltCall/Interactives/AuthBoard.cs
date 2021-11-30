using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltCall.Interactives
{
    public partial class AuthBoard : Form
    {
        public AuthBoard()
        {
            InitializeComponent();
        }

        private enum Type
        {
            LPWD,
            RPWD,
            RName,
            LEmail,
            LToken,
            REmail,
            RAccess,
        }

        #region Textbox-Events

        private void TBLEmail_TextChanged(object _, EventArgs E)
        {

        }

        private void TBLPwd_TextChanged(object _, EventArgs E)
        {

        }

        private void TBLToken_TextChanged(object _, EventArgs E)
        {

        }

        private void TBRName_TextChanged(object _, EventArgs E)
        {

        }

        private void TBREmail_TextChanged(object _, EventArgs E)
        {

        }

        private void TBRPwd_TextChanged(object _, EventArgs E)
        {

        }

        #endregion Textbox-Events
    }
}
