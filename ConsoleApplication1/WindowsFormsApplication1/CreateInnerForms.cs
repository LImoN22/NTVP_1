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

     
          return (listTextBox);

      }

      public BindingList<Label> CreatingLabel(List<string> listName, Point position)
      {
          var listLabel = new BindingList<Label>();
          foreach (var name in listName)
          {
              listLabel.Add(CreatingLabel(name, position));
              position.Y += 40;

          };
          return (listLabel);

      }
   /// <summary>
   /// очистка текст боксов 
   /// </summary>
   /// <param name="_textBoxList"></param>
   /// <param name="listControl"></param>
   /// <returns></returns>
      public BindingList<TextBox> ClearBindingListTextBox(BindingList<TextBox> _textBoxList, BindingList<Control.ControlCollection> listControl)
      {
          if (_textBoxList != null)
          {
              foreach (var t in _textBoxList)
              {
                  listControl[0].Remove(t);
                  t.Dispose();
              }
              _textBoxList.Clear();
          }
          return _textBoxList;

      }
      /// <summary>
      /// Очистка лейблов 
      /// </summary>
      /// <param name="labelList"></param>
      /// <param name="listControl"></param>
      /// <returns></returns>
     public BindingList<Label> ClearBindingListLabel(BindingList<Label> labelList, BindingList<Control.ControlCollection> listControl)
      {
          if (labelList != null)
          {
              foreach (var lable in labelList)
              {
                  listControl[0].Remove(lable);
                  lable.Dispose();
              }
              labelList.Clear();
          }
          return labelList;
      }

      private TextBox CreateTextBox(string name, Point position)
      {
          TextBox createTextBox = new TextBox();
          createTextBox.Name = name;
          createTextBox.Location = position;
          _textBoxAmount[0].Add(createTextBox);
          _textBoxAmount[1].Add(createTextBox);
          return createTextBox;
      }

      private Label CreatingLabel(string name, Point position)
      {
          Label creatingLabel = new Label();
          creatingLabel.Name = "Label" + name;
          creatingLabel.Location = position;
          creatingLabel.Text = name;
          creatingLabel.Height = 13; 
          _textBoxAmount[0].Add(creatingLabel);
          _textBoxAmount[1].Add(creatingLabel);
          return creatingLabel;
      }

     

    }
}
