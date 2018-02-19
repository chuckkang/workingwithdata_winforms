using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            //ArrayList arrList = new ArrayList();
            //DataCollections dtaCollection = new DataCollections();
            //arrList = dtaCollection.ArrLists();
            //arrList.Sort();
            //foreach (object i in arrList)
            //{
            //    // when goin through an arraylist, you need to specify the type somehow.
            //    // 
            //    if (i is DataCollections)
            //    { lblResults.Text += "This is Data\n"; }
            //    else if (i is Person)
            //       { lblResults.Text += "This is Person\n"; }
            //    else
            //    { lblResults.Text += "This is nothin\n"; }
            //*********************************************************************

            //Hashtable HTable = new Hashtable();
            //DataCollections dc = new DataCollections();
            //HTable = dc.Htable();

            //lblResults.Text = HTable[5].ToString();
            //**********************************************************************

            // load list box

            List<Names> NameList = new List<Names>();
            Names names = new WorkingWithData.Form1.Names();
            //NameList = GetNames();
            NameList = GetNames();
            
            foreach (Names N in NameList)
            {
                listBox1.Items.Add(N.First);
            }
            }

        private List<Names> GetNames()
        {
            List<Names> lstNames = new List<Names>();

            lstNames.Add(new Names() { First = "Chuck", Last = "Kang" });
            lstNames.Add(new Names() { First = "2", Last = "Kang2" });
            lstNames.Add(new Names() { First = "3", Last = "Kang3" });
            lstNames.Add(new Names() { First = "4", Last = "Kang4" });


            return lstNames;
        }

        public class Names
        {
            public string First { get; set; }
            public string Last { get; set; }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResults.Text = listBox1.SelectedIndex.ToString();
        }
    }
}
