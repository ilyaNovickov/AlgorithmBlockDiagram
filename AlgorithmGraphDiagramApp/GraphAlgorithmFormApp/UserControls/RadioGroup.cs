using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithmFormApp
{
    [ProvideProperty("GroupName", typeof(RadioButton))]
    public partial class RadioGroup : Component, IExtenderProvider
    {
        #region Данные
        readonly Dictionary<RadioButton, string> groups = new Dictionary<RadioButton, string>();
        #endregion
        #region Конструкторы
        public RadioGroup()
        {
            InitializeComponent();
        }
        //public RadioGroup(IContainer container)
        //{
        //    container.Add(this);
        //}
        #endregion
        #region Методы
        public string GetGroupName(RadioButton radioButton)
        {
            if (groups.TryGetValue(radioButton, out string group))
                return group;
            else
                return "";
        }
        public void SetGroupName(RadioButton radioButton, string group)
        {
            if (radioButton == null)
                return;
            if (group != null)
            {
                RadioButton currentChecked = GetCheckedRadioButton(group);

                radioButton.AutoCheck = false;
                if (currentChecked != null)
                    radioButton.Checked = false;
                groups.Add(radioButton, group);
                radioButton.Click += OnRadioClicked;
            }
            else
            {
                groups.Remove(radioButton);
                radioButton.Click -= OnRadioClicked;
            }

        }
        public bool CanExtend(object extendee)
        {
            return extendee is RadioButton;
        }
        private void OnRadioClicked(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
                return;

            var currentChecked = GetCheckedRadioButton(GetGroupName(radioButton));
            if (currentChecked != null)
                currentChecked.Checked = false;
            radioButton.Checked = true;
        }
        private RadioButton GetCheckedRadioButton(string groupName)
        {
            //var radios = from pair in groups
            //             where pair.Value == groupName && pair.Key.Checked
            //             select pair.Key;
            //return radioButton.FirstOrDefault();

            foreach (var pair in groups)
            {
                if (pair.Value == groupName && pair.Key.Checked == true)
                    return pair.Key;
            }
            return null;
        }
        #endregion
    }
}
