using System.Drawing;
using System.Windows.Forms;

namespace University
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public static class DarkModeManager
    {
        private static Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        public static bool IsDarkMode { get; set; }

        public static void StoreOriginalColors(Control control)
        {
            originalColors.Clear();
            StoreOriginalColorsRecursive(control);
        }

        private static void StoreOriginalColorsRecursive(Control control)
        {
            originalColors.Add(control, control.ForeColor);

            foreach (Control childControl in control.Controls)
            {
                StoreOriginalColorsRecursive(childControl);
            }
        }

        public static void RestoreOriginalColors(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                RestoreOriginalColorsRecursive(childControl);
            }
        }

        private static void RestoreOriginalColorsRecursive(Control control)
        {
            if (originalColors.ContainsKey(control))
            {
                control.ForeColor = originalColors[control];
            }

            foreach (Control childControl in control.Controls)
            {
                RestoreOriginalColorsRecursive(childControl);
            }
        }

        public static void ApplyDarkMode(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                ApplyDarkModeRecursive(childControl);
            }
        }

        private static void ApplyDarkModeRecursive(Control control)
        {
            if (control is Button || control is CheckBox || control is RadioButton)
            {
                control.ForeColor = Color.White;
                control.BackColor = Color.DarkSlateGray;
            }
            else if (control is TextBox || control is ComboBox || control is ListBox)
            {
                control.ForeColor = Color.White;
                control.BackColor = Color.DarkSlateGray;
            }
            else if (control is Label)
            {
                control.ForeColor = Color.White;
            }
            else if (control is DataGridView)
            {
                control.ForeColor = Color.White;
                control.BackColor = Color.DarkSlateGray;
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyDarkModeRecursive(childControl);
            }
        }
    }


}
