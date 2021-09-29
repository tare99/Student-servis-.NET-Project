using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DLWMS.WinForms.DLWMS.Klase
{
    public class Validator
    {
        public static bool Validiraj(Control control, ErrorProvider err, string poruka)
        {
            bool validno = true;
            if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                validno = false;
            else if (control is ComboBox && ((control as ComboBox).SelectedIndex < 0 || string.IsNullOrEmpty((control as ComboBox).Text)))
                validno = false;
            else if(control is PictureBox && (control as PictureBox).Image==null)
                validno = false;
           
            if(!validno)
            {
                err.SetError(control, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
