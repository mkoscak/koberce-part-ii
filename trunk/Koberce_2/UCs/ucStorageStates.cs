using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koberce_2.Entities;

namespace Koberce_2.UCs
{
    public partial class ucStorageStates : UserControl
    {
        public ucStorageStates()
        {
            InitializeComponent();

            /*var uc = new ucStorages();
            panelStorages.Controls.Add(uc);
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            uc.Size = uc.Parent.ClientSize;

            var uc2 = new ucProducts();
            panelProducts.Controls.Add(uc2);
            uc2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            uc2.Size = uc2.Parent.ClientSize;*/

            try
            {
                ReloadAllData();
            }
            catch (Exception)
            {
            }
        }

        private void ReloadAllData()
        {
        }
    }
}
