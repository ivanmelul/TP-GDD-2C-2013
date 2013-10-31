using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Utils
{
    public class UIHelper
    {

        public static bool AskFor(String question)
        {
            return AskFor(question, String.Empty);
        }

        public static bool AskFor(String question, String title)
        {
            DialogResult dialogResult = MessageBox.Show(question, title,MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                return true;
            else
                return false;
        }

    }
}
