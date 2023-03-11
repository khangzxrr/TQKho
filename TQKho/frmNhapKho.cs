using Microsoft.EntityFrameworkCore;
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
using TQKho.Enums;
using TQKho.Exceptions;
using TQKho.Models;

namespace TQKho
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public partial class frmNhapKho : Form
    {
        private DataContext? context;

        private formInputProductConstraint.InputState? inputState;
        private List<Control> inputControls;
        public frmNhapKho(DataContext productContext)
        {
            this.context = productContext;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            this.productBindingSource.DataSource = context.Products.Local.ToBindingList();

            this.inputState = formInputProductConstraint.InputState.DISABLE;

            inputControls = new List<Control>
            {
                poTextBox,
                productCodeTextBox,
                productNameTextBox,
                productQuantityTextBox,
                productShelfTextBox
            };
            setInputStateBaseOnState();
        }

        private void setInputStateBaseOnState()
        {


            switch (inputState)
            {
                case formInputProductConstraint.InputState.ON_CREATE:

                    inputControls.ForEach(control =>
                    {
                        control.Enabled = true;
                        control.Text = "";
                        control.BackColor = Color.White;
                    });

                    break;

                case formInputProductConstraint.InputState.ON_EDIT:

                    inputControls.ForEach(control =>
                    {
                        control.Enabled = true;
                        control.Text = "";
                        control.BackColor = Color.White;
                    });

                    break;

                case formInputProductConstraint.InputState.DISABLE:
                    inputControls.ForEach(control =>
                    {
                        control.Enabled = false;
                        control.BackColor = Color.GhostWhite;
                    });

                    break;
            }
        }

        private void productGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.context != null)
            {
                //var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;
            }
        }

        private void saveAndRefresh()
        {
            this.context!.SaveChanges();
            this.dataGridViewProducts.Refresh();
        }

        private void validate(string shelfCode)
        {
            var shelfCodeValidator = Regex.Match(shelfCode, @"^[a-zA-Z]\d+$");
            if (!shelfCodeValidator.Success)
            {
                throw new ShelfCodeInvalidException();
            }
        }

        private void saveButton_clicked(object sender, EventArgs e)
        {
            if (inputState == formInputProductConstraint.InputState.ON_CREATE ||
                inputState == formInputProductConstraint.InputState.ON_EDIT)
            {
                try
                {
                    var shelfCode = productShelfTextBox.Text.ToUpper();
                    var intQuantity = int.Parse(productQuantityTextBox.Text);
                    validate(shelfCode);

                    var newProduct = new Product
                    {
                        poCode = poTextBox.Text,
                        productCode = productCodeTextBox.Text,
                        productName = productNameTextBox.Text,
                        quantity = intQuantity
                    };

                    if (inputState == formInputProductConstraint.InputState.ON_CREATE)
                    {
                        var shelf = this.context!.Shelfs.Where(s => s.shelfCode == shelfCode).FirstOrDefault();
                        if (shelf == null)
                        {
                            //create new shelf
                            shelf = new Shelf()
                            {
                                shelfCode = shelfCode,
                            };

                            this.context.Add(shelf);
                        }

                        shelf.products.Add(newProduct);
                    }
                    else
                    {
                        var product = this.context!.Products.Where(p => p.productId == int.Parse(productIdTextbox.Text)).FirstOrDefault();
                        product.poCode = poTextBox.Text;
                        product.quantity = intQuantity;
                        product.productCode = productCodeTextBox.Text;
                        product.productName = productNameTextBox.Text;

                        var shelf = context!.Shelfs.Where(s => s.shelfCode == shelfCode).FirstOrDefault();
                        if (shelf == null)
                        {
                            shelf = new Shelf()
                            {
                                shelfCode = shelfCode
                            };
                            shelf.products.Add(product);

                            product.shelf.products.Remove(product);

                            context!.Shelfs.Add(shelf);

                        }
                    }

                    saveAndRefresh();
                    inputControls.ForEach(control => control.Text = "");

                    inputState = formInputProductConstraint.InputState.DISABLE;
                    setInputStateBaseOnState();
                }
                catch (ShelfCodeInvalidException)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại\nSai định dạng mã kệ\nVD:K1, B2, K9, C1,...");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập...\nVD: số lượng phải là số nguyên, không được để trống ô");
                }

            }


        }

        private void dataGridViewProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Vui lòng kiểm tra lại thông tin...\nVD: số lượng phải là một con số");
        }

        private void deleteButton_onClick(object sender, EventArgs e)
        {
            var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

            if (product == null)
            {
                return;
            }

            this.context!.Remove(product);
            saveAndRefresh();

        }

        private void createButton_onClick(object sender, EventArgs e)
        {
            inputState = formInputProductConstraint.InputState.ON_CREATE;
            setInputStateBaseOnState();
        }

        private void editButton_onClick(object sender, EventArgs e)
        {
            var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

            if (product == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn chỉnh sửa");
                return;
            }


            inputState = formInputProductConstraint.InputState.ON_EDIT;
            setInputStateBaseOnState();

            productIdTextbox.Text = product.productId.ToString();
            poTextBox.Text = product.poCode;
            productCodeTextBox.Text = product.productCode;
            productNameTextBox.Text = product.productName;
            productQuantityTextBox.Text = product.quantity.ToString();
            productShelfTextBox.Text = context!.Shelfs.Where(s => s.shelfId == product.shelfId).FirstOrDefault().shelfCode;

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProducts.CurrentRow == null)
            {
                return;
            }
            var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

            if (product == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xuất kho");
                return;
            }

            if (inputState != formInputProductConstraint.InputState.DISABLE)
            {
                MessageBox.Show("Vui lòng chọn save dữ liệu trước khi sử dụng xuất kho");
                return;
            }

            XuatKhoConfirmForm xuatKhoConfirmForm = new XuatKhoConfirmForm(context!, product.productId);
            xuatKhoConfirmForm.ShowDialog();

            xuatKhoConfirmForm.Dispose();

            saveAndRefresh();

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

            poTextBox.Text = product.poCode;
            productCodeTextBox.Text = product.productCode;
            productNameTextBox.Text = product.productName;
            productQuantityTextBox.Text = product.quantity.ToString();
            productShelfTextBox.Text = context!.Shelfs.Where(s => s.shelfId == product.shelfId).FirstOrDefault().shelfCode;
        }
    }
}
