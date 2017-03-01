using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibrary1;
using Control = System.Windows.Forms.Control;


namespace WindowsFormsApplication1
{
    public partial class AddElementForm : Form
    {
        public AddElementForm()
        {
            InitializeComponent();
        }
        private BindingList<System.Windows.Controls.TextBox> _textBoxList = new BindingList<System.Windows.Controls.TextBox>(); 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Control.ControlCollection> listControl = new List<Control.ControlCollection> {Controls};
            switch (comboBox1.SelectedIndex)
            {
                case 0 :
                    {
                        CreateInnerForms createInnerForms = new CreateInnerForms(2);
                        _textBoxList = createInnerForms.ReturnParametr;
                      // CapacityResCalc capasityResCalc = new CapacityResCalc(Convert.ToDouble(_textBoxList[1].Text),Convert.ToDouble(_textBoxList[2].Text));

                        break; 
                    }
                case 1:
                    {

                        break; 

                    }
                case 2:
                    {
                        break; 
                    }
                
                default: break; 
            }

        }
    

    }


}
