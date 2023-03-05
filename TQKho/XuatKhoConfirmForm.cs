using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TQKho.Contexts;
using TQKho.Models;

namespace TQKho
{
    public partial class XuatKhoConfirmForm : Form
    {
        private ProductContext productContext = null;
        private int productId = -1;
        public XuatKhoConfirmForm(ProductContext productContext, int productId)
        {
            InitializeComponent();
            this.productContext = productContext;
            this.productId = productId;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            var product = productContext.Products.Where(p => p.productId == productId).FirstOrDefault();

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm, vui lòng tắt/mở lại app");
                return;
            }


            try
            {
                int exportQuantity = int.Parse(quantityTextbox.Text);

                if (product.quantity - exportQuantity < 0)
                {
                    MessageBox.Show("Số lượng không còn đủ, chỉ còn: " + product.quantity);
                    return;
                }

                product.quantity -= exportQuantity;

                productContext.SaveChanges();

            }
            catch(FormatException format)
            {
                MessageBox.Show("Vui lòng đảm bảo số lượng xuất là số");
                return;
            }
            catch (Exception ex) { 
                MessageBox.Show("Có lỗi xảy ra\n" + ex.Message + "\nVui lòng liên hệ developer!");
                return;
            }


            
        }
    }
}
