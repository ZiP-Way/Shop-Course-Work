using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shop
{
    public partial class ProductControllerForm : Form
    {
        private Product product;

        private bool isImageSelected = false;
        private bool isEditing = false;

        private int indexOfEditingProduct;

        public ProductControllerForm()
        {
            InitializeComponent();

            product = new Product();
            this.Text = "Додавання нового продукту";
            isEditing = false;
        }

        public ProductControllerForm(Product product, int index)
        {
            InitializeComponent();

            this.product = product;
            indexOfEditingProduct = index;

            Text = "Редагування інформації";
            isEditing = true;
        }

        private void ProductControllerForm_Load(object sender, EventArgs e)
        {
            FillingComboBox(brandComBox, ProductInformation.Brands);
            FillingComboBox(typeComBox, ProductInformation.TypeOfProducts);

            if (isEditing)
            {
                FillingFields();
            }
        }

        private void FillingFields()
        {
            nameTxt.Text = product.Name;
            priceTxt.Text = product.Price.ToString();
            pictureBox1.Image = product.Image;
            brandComBox.Text = product.Brand;
            typeComBox.Text = product.Type;
        }

        private void FillingComboBox(ComboBox cBox, string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                cBox.Items.Add(items[i]);
            }

            cBox.SelectedItem = cBox.Items[0];
        }

        private void selectImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Jpg, Jpeg, Images|*.jpg;*.jpeg|PNG Images|*.png|BMP Images|*.bmp|" + "All files (*.*)|*.*";
            ofd.Title = "Choose an image... ";
            ofd.AddExtension = true;
            ofd.FilterIndex = 0;
            ofd.Multiselect = false;
            ofd.ValidateNames = true;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imgLocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

                isImageSelected = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilled())
            {
                product.Name = nameTxt.Text;
                product.Price = Convert.ToInt32(priceTxt.Text);
                product.Image = pictureBox1.Image;
                product.Brand = brandComBox.Text;
                product.Type = typeComBox.Text;

                if (!isEditing)
                {
                    DBController.InsertToDb(product);
                    product.ID = DBController.GetProductId(product);
                    FormProvider.MainPageForm.AddToArrays(product);
                }
                else if (isEditing)
                {
                    ProductInformation.Products[indexOfEditingProduct] = product;
                    FormProvider.MainPageForm.UpdatePanel(indexOfEditingProduct);
                    DBController.UpdateFieldDb(product);
                }

                Close();
            }
        }

        private void ProductControllerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.MainPageForm.ShowForm();
        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool AreFieldsFilled()
        {
            if (String.IsNullOrEmpty(nameTxt.Text) || String.IsNullOrEmpty(priceTxt.Text))
            {
                MessageBox.Show("Поля не можуть бути пустими!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!isImageSelected && !isEditing)
            {
                MessageBox.Show("Оберіть картинку!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}