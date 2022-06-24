using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_WF_Vasilchenko
{
    internal class Messages
    {
        public static DialogResult CloseConfirmationDialog()
        {
            string _message = "Already leaving?";
            string _caption = "Exit";
            DialogResult result;
            result = MessageBox.Show(_message, _caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();

            return result;
        }
    }
}
