using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
  
  public  class CreateInnerForms
    {
        private BindingList<Control.ControlCollection> _textBoxAmount;
        public CreateInnerForms(BindingList<Control.ControlCollection> textBoxAmount)
        {
            _textBoxAmount = textBoxAmount;
        }

            /// <summary>
      /// Текст бокс возвращает Controls 
      /// </summary>
      /// <param name="name"></param>
      /// <param name="locationX"></param>
      /// <param name="locationY"></param>
      /// <param name="control"></param>
      /// <param name="enabledTextBox"></param>
      /// <returns></returns>
      public BindingList<TextBox> CreatingTextBox(List<string> listName, Point position)
      {
          var listTextBox = new BindingList<TextBox>();
          foreach(var name in listName)
          {

              listTextBox.Add(CreateTextBox(name, position));
              //pothition.X += 20;
              position.Y += 40;

             /* Name = name,
              Location = new System.Drawing.Point(locationX, locationY),
              Size = new System.Drawing.Size(100, 20),
              Visible = true,
              Enabled = enabledTextBox
          */
               };

          //не обязательно передавать в обычнх контрол можно сразу передедать через groupBox
          //control[0].Add(textBox);
         // TextBoxList.Add(textBox);
          return (listTextBox);

      }
      /// <summary>
      /// Конструктор для текстбоксов
      /// </summary>

      private TextBox CreateTextBox(string name, Point position)
      {
          TextBox createTextBox = new TextBox();
          createTextBox.Name = name;
          createTextBox.Location = position;
          _textBoxAmount[0].Add(createTextBox);
          _textBoxAmount[1].Add(createTextBox);
          return createTextBox;
      }

     
     /// <summary>
     /// Циклический метод создания текст боксов 
     /// </summary>
    /*  private void CycleCreationOfTextBox( ) 
      {
          
          for (int i = 0; _textBoxAmount == i; i++)
          {
              TextBoxList.Add(CreatingTextBox(i.ToString(), 20, (20 + 40 * i),true));
          }
 
      }
      public BindingList<TextBox> ReturnParametr
      {
          get 
          {
              CycleCreationOfTextBox ();
              return TextBoxList;   
          }
         
      }
      private BindingList<Control> _bindingListControls;
      public BindingList<Control> ReciveParametr
      {

          set
          {
              _bindingListControls = value; 

              
          }

      }*/


   /*   internal void CreatingTextBox(List<string> name, Point p)
      {
          throw new NotImplementedException();
      }*/
    }
}
