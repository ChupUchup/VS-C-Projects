using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SergeUtils;

namespace WildCardComboBox
{
    public partial class Form1 : Form
    {
        public class MethodItem
        {
            public string Name { get; set; }
            public StringMatchingMethod Value { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            m_combo.Items.Add("EBSAntiJitterConfig");
            m_combo.Items.Add("BridgeFilterConfig2");
            m_combo.Items.Add("PCMActiveUserList");
            m_combo.Items.Add("SpotFXPriceConfigIDList");
            //m_combo.Items.AddRange(s_NOBELS_LITTERATURE);

            //m_methodCB.DisplayMember = "Name";
            //m_methodCB.Items.Add(new MethodItem { Name = "No wildcards", Value = StringMatchingMethod.NoWildcards });
            //m_methodCB.Items.Add(new MethodItem { Name = "Use wildcards", Value = StringMatchingMethod.UseWildcards });
            //m_methodCB.Items.Add(new MethodItem { Name = "Use regexs", Value = StringMatchingMethod.UseRegexs });
            //m_methodCB.SelectedIndex = 0;

            m_combo.MatchingMethod = StringMatchingMethod.NoWildcards;
        }
    }
}
