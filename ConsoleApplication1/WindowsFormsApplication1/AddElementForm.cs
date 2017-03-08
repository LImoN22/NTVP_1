using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibrary1;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public partial class AddElementForm : Form
    {
        public AddElementForm()
        {
            InitializeComponent();
            listControl.Add(Controls);
            listControl.Add(groupBox1.Controls);
        }
       private BindingList<Control.ControlCollection> listControl = new BindingList<Control.ControlCollection>();
        private BindingList<System.Windows.Controls.TextBox> _textBoxList = new BindingList<System.Windows.Controls.TextBox>(); 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (comboBox1.SelectedIndex)
            {
                case 0 :
                    {
                        CreateInnerForms cr = new CreateInnerForms(listControl);
                        List<string> name = new List<string>();
                        name.Add("one");
                        name.Add("two");
                        name.Add("three");
                        Point p = new Point(10, 20);
                        cr.CreatingTextBox(name, p);
                        /*CreateInnerForms createInnerForms = new CreateInnerForms(2);
                        _textBoxList = createInnerForms.ReturnParametr;
                      // CapacityResCalc capasityResCalc = new CapacityResCalc(Convert.ToDouble(_textBoxList[1].Text),Convert.ToDouble(_textBoxList[2].Text));
                        */
                        break; 
                    }
                case 1:
                    {
                        CreateInnerForms cr = new CreateInnerForms(listControl);
                        List<string> name = new List<string>();
                        name.Add("one1");
                        name.Add("two1");
                        name.Add("three1");
                        Point p = new Point(10, 5);
                        cr.CreatingTextBox(name, p);
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
