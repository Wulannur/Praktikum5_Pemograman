using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_1204007
{
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        //Exposing & Overriding Text Property
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                try
                {
                    int.Parse(value);
                    base.Text = value;
                    return;
                }
                catch { }
                if (value == null)
                {
                    base.Text = value;
                    return;
                }
            }
        }

        //Raising & Overriding OnKeyPress event
        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            int asciiInteger = Convert.ToInt32(e.KeyChar);
            if (asciiInteger >= 47 && asciiInteger <= 57)
            {
                //If the value of the ASCII converted char type (e.KeyChar) represents 0-9
                //pass the event to Windows for deafult processing
                e.Handled = false;
                return;
            }
            //if the value of the ASCII converted char type (e.KeyChar) represents BACKSPACE
            //pass the event to Windows for deafult processing
            if (asciiInteger == 8)
            {
                e.Handled = false;
                return;
            }
            //if the value of the ASCII converted char type (e.KeyChar) is anything else
            //handle the event here by setting Handled=true whic prevents the event from being
            //passed Windows for deafult processing
            e.Handled = true;
            if (InvalidUserEntry != null)
                InvalidUserEntry(this, e);
        }
    }
}
