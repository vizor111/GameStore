using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState2
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cmdSave_Click(object sender, EventArgs e)
        {
            // Поместить текст в словарь        
            var textToSave = new Dictionary<string, string>();
            SaveAllText(Page.Controls, textToSave, true);

            // Сохранить всю коллекцию в состоянии представления        
            ViewState["ControlText"] = textToSave;
        }

        private void SaveAllText(ControlCollection controls,
            Dictionary<string, string> textToSave, bool saveNested)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    // Добавить текст в словарь                
                    textToSave.Add(control.ID, ((TextBox)control).Text);
                }

                if ((control.Controls != null) && saveNested)
                {
                    SaveAllText(control.Controls, textToSave, true);
                }
            }
        }

        protected void cmdRestore_Click(object sender, EventArgs e)
        {
            if (ViewState["ControlText"] != null)
            {
                // Извлечь словарь            
                var savedText = (Dictionary<string, string>)ViewState["ControlText"];

                // Отобразить весь текст за счет прохода по словарю            
                lblResults.Text = "";
                foreach (KeyValuePair<string, string> item in savedText)
                {
                    lblResults.Text += "<b>" + item.Key + "</b> = " + item.Value + "<br />";
                }
            }
        }
    }
}