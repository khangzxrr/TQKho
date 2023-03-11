using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TQKho.Models;

namespace TQKho.CustomControls
{
    public partial class ShelfControl : UserControl
    {
        private Product product;
        public ShelfControl(Product product)
        {
            InitializeComponent();

            this.product = product;

            poTextBox.Text = this.product.poCode;
            shelfCode.Text = this.product.shelf.shelfCode;
            productNameTextBox.Text = this.product.productName;

            float percent = (float)(product.quantity / 1000f * 100f);
            progressBar.Value = (int)percent;

            percentTextBox.Text = $@"{product.quantity}/1000  {percent}%";
        }

    }
}
