using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML_Experience
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            Clear();
        }
        private void Clear()
        {
            User_text.Text="Ivan Ivanov";
            Sex_comb.SelectedIndex = 0;
            Age_num.Value = 0;

        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            User pers = new User(User_text.Text,Sex_comb.SelectedIndex,(int)Age_num.Value);
            Add(pers);  
            Clear();
        }    
        private void lv_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_users.Items.Count==1)
            {
                User pers = (User)lv_users.SelectedItems[0].Tag;
                if(pers != null)
                {
                    User_text.Text = pers.user_name;
                    Sex_comb.SelectedIndex = pers.user_sex;
                    Age_num.Value = pers.user_age;

                }
            }
            else if(lv_users.Items.Count==0)
            {
                Clear();

            }
        }
        private void SerializeXml(Users users)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Users));

            using (FileStream fs = new FileStream("Users.xml",FileMode.OpenOrCreate))
            {
                xml.Serialize(fs,users);

            }

        }
        private void Ser_but_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            foreach(ListViewItem item in lv_users.Items )
            {
                if(item.Tag != null)
                {
                    users.UsersList.Add((User)item.Tag);
                }
            }
            SerializeXml(users);
        }
        private Users DeserializeXml() 
        {
            XmlSerializer xml = new XmlSerializer(typeof(Users));

            using (FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate))
            {
              return  (Users)xml.Deserialize(fs);
            }

        }
        private void Deser_but_Click(object sender, EventArgs e)
        {
            Clear();
            Users users = DeserializeXml();
            foreach(User user in users.UsersList)
            {
                Add(user);
            }       
        }
        private void Add(User user)
        {
           
            ListViewItem LVI = new ListViewItem(user.user_name);
            LVI.Tag = user;
            lv_users.Items.Add(LVI);
        }
    }
}
