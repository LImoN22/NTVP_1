using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms.Control.ControlCollection;
namespace WindowsFormsApplication1
{
    public partial class AddElementForm : Form
    {
        public AddElementForm()
        {
            InitializeComponent();
        }
        private BindingList<System.Windows.Controls.TextBox> TextBoxList = new BindingList<System.Windows.Controls.TextBox>(); 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ControlCollection> listControl = new List<ControlCollection>();
            listControl.Add(Controls);
            switch (comboBox1.SelectedIndex)
            {
                case 0 :
                    {
                        CreateInnerForms createInnerForms = new CreateInnerForms(2);
                        TextBoxList = createInnerForms.ReturnParametr;
                      //  CapacityResCalc capasityResCalc = new CapacityResCalc(Convert.ToDouble(TextBoxList[1].Text),Convert.ToDouble(TextBoxList[2].Text));

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
