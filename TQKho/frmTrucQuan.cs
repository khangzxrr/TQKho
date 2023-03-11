using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TQKho.Contexts;
using TQKho.CustomControls;
using TQKho.Models;

namespace TQKho
{
    public partial class frmTrucQuan : Form
    {
        private DataContext context;

        public frmTrucQuan(DataContext productContext)
        {
            this.context = productContext;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var distinctShelfCodes = context.Shelfs.ToList();

            distinctShelfCodes.ForEach(code =>
            {
                shelfComboBox.Items.Add(code);
            });

        }

        private void shelfCodeComboboxValueChanged(object sender, EventArgs e)
        {
            var shelf = (Shelf)shelfComboBox.SelectedItem;

            if (shelf == null)
            {
                MessageBox.Show("Vui lòng chọn kệ");
            }



            flowLayoutPanel.Controls.Clear();

            foreach(var product in shelf.products)
            {
                ShelfControl shelfControl = new ShelfControl(product);
                flowLayoutPanel.Controls.Add(shelfControl);
            }


            

        }
    }
}
