﻿using Microsoft.EntityFrameworkCore;
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
using TQKho.Enums;
using TQKho.Models;

namespace TQKho
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public partial class frmNhapKho : Form
    {
        private ProductContext? context;

        private formInputProductConstraint.InputState? inputState;
        private List<Control> inputControls;
        public frmNhapKho()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.context = new ProductContext();

            this.context.Database.EnsureCreated();
            this.context.Products.Load();

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
                        control.BackColor = Color.Gray;
                    });

                    break;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            this.context?.Dispose();
            this.context = null;
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
        private void saveButton_clicked(object sender, EventArgs e)
        {
            if (inputState == formInputProductConstraint.InputState.ON_CREATE)
            {
                try
                {
                    this.context!.Products.Add(new Product
                    {
                        poCode = poTextBox.Text,
                        productCode = productCodeTextBox.Text,
                        productName = productNameTextBox.Text,
                        quantity = int.Parse(productQuantityTextBox.Text),
                        shelfCode = productShelfTextBox.Text
                    });

                    saveAndRefresh();
                    inputControls.ForEach(control => control.Text = "");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập...\nVD: số lượng phải là số nguyên, không được để trống ô");
                }

            }
            else if (inputState == formInputProductConstraint.InputState.ON_EDIT)
            {
                try
                {
                    var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

                    product.poCode = poTextBox.Text;
                    product.productCode = productCodeTextBox.Text;
                    product.productName = productNameTextBox.Text;
                    product.quantity = int.Parse(productQuantityTextBox.Text);
                    product.shelfCode = productShelfTextBox.Text;

                    saveAndRefresh();
                    inputControls.ForEach(control => control.Text = "");
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

            poTextBox.Text = product.poCode;
            productCodeTextBox.Text = product.productCode;
            productNameTextBox.Text = product.productName;
            productQuantityTextBox.Text = product.quantity.ToString();
            productShelfTextBox.Text = product.shelfCode;


        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
