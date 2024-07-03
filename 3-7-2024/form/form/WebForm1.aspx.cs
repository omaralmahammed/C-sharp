using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Email = exampleInputEmail1.Text;
            string Id = id.Text;

            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
            }


            string selectedLanguages = "";
            foreach (ListItem item in CheckBoxList.Items)
            {
                if (item.Selected)
                {
                    selectedLanguages += item.Text + ", ";
                }
            }




            inputName.Text = Name;
            InputEmail.Text = Email;
            inputId.Text = Id;
            inputGender.Text = gender;
            inoutLanguage.Text = selectedLanguages;

        }
    }
}