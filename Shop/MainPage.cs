using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shop
{
    public struct PanelElements
    {
        public Label NameLabel;
        public PictureBox EditImg;
        public PictureBox DelImg;
        public PictureBox ProductImg;
        public Label PriceLabel;
        public Panel BackPanel;
    }


    public partial class MainPage : Form
    {
        private const string defaultSearchFieldText = "Я шукаю..."; // used when the search field is empty

        private PanelElements[] panelElements;

        private string searchByTypeValue = "";
        private string searchByBrandValue = "";

        public MainPage()
        {
            InitializeComponent();

            DBController.DBConnection();
            ProductInformation.Products = DBController.GetProductsFromDb();

            panelElements = new PanelElements[ProductInformation.Products.Length];
        }
        public void ShowForm()
        {
            Show();
            ShowPanels();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormComponentsSetings();
        }

        public void UpdatePanel(int index)
        {
            panelElements[index].PriceLabel.Text = ProductInformation.Products[index].Price.ToString() + "₴";
            panelElements[index].NameLabel.Text = ProductInformation.Products[index].Name;
            panelElements[index].ProductImg.Image = ProductInformation.Products[index].Image;
        }

        public void AddToArrays(Product product)
        {
            List<Product> tempProduct = ProductInformation.Products.OfType<Product>().ToList();
            tempProduct.Add(product);
            ProductInformation.Products = tempProduct.ToArray();

            List<PanelElements> temp = panelElements.OfType<PanelElements>().ToList();
            temp.Add(CreatePanel(product));
            panelElements = temp.ToArray();
        }
        private void RemoveFromArrays(int index)
        {
            List<PanelElements> temp = panelElements.OfType<PanelElements>().ToList();
            temp.RemoveAt(index);
            panelElements = temp.ToArray();

            List<Product> tempProduct = ProductInformation.Products.OfType<Product>().ToList();
            tempProduct.RemoveAt(index);
            ProductInformation.Products = tempProduct.ToArray();
        }

        private void SetFormComponentsSetings()
        {
            // Create check boxes with product filters
            CreateCheckBoxes(ProductInformation.TypeOfProducts.Length, typeOfSweetsGB);
            CreateCheckBoxes(ProductInformation.Brands.Length, brandGB);

            SetSearchFieldDefaultDesign();

            //Create panels with information about product and add this panel to FlowLayoutPanel  
            for (int i = 0; i < ProductInformation.Products.Length; i++)
            {
                panelElements[i] = CreatePanel(ProductInformation.Products[i]);
            }

            priceFromTxt.Text = "0";
            priceToTxt.Text = GetMaxPrice().ToString();
        }

        private void CreateCheckBoxes(int howMuch, GroupBox groupBox)
        {
            for (int i = 1; i <= howMuch; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Width = 200;
                checkBox.Height = 30;
                checkBox.Location = new Point(25, 25 * i);
                if (groupBox == typeOfSweetsGB)
                {
                    checkBox.Text = ProductInformation.TypeOfProducts[i - 1];
                    checkBox.CheckedChanged += new EventHandler(TypeCheckBox_CheckedChanged);
                }
                else if(groupBox == brandGB)
                {
                    checkBox.Text = ProductInformation.Brands[i - 1];
                    checkBox.CheckedChanged += new EventHandler(BrandCheckBox_CheckedChanged);
                }
                groupBox.Controls.Add(checkBox);
            }
        }

        private PanelElements CreatePanel(Product product)
        {
            PanelElements panelElements = new PanelElements();

            Label productPriceLabel = new Label();
            productPriceLabel.BackColor = SystemColors.Control;
            productPriceLabel.Dock = DockStyle.Fill;
            productPriceLabel.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productPriceLabel.ForeColor = SystemColors.MenuHighlight;
            productPriceLabel.Location = new Point(0, 273);
            productPriceLabel.Size = new Size(100, 53);
            productPriceLabel.Text = product.Price.ToString() + "₴";
            productPriceLabel.BackColor = Color.Transparent;
            productPriceLabel.TextAlign = ContentAlignment.MiddleRight;

            Label productNameLabel = new Label();
            productNameLabel.Dock = DockStyle.Top;
            productNameLabel.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productNameLabel.Location = new Point(0, 213);
            productNameLabel.Size = new Size(235, 40);
            productNameLabel.Text = product.Name;
            productNameLabel.BackColor = Color.Transparent;
            productNameLabel.TextAlign = ContentAlignment.MiddleLeft;

            PictureBox deleteImg = new PictureBox();
            deleteImg.ImageLocation = "Icons/delete.png";
            deleteImg.BackColor = Color.White;
            deleteImg.Size = new Size(30, 30);
            deleteImg.Location = new Point(135, 10);
            deleteImg.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteImg.Click += new EventHandler(delImg_Click);


            PictureBox editImg = new PictureBox();
            editImg.ImageLocation = "Icons/edit.png";
            editImg.BackColor = Color.White;
            editImg.Size = new Size(30, 30);
            editImg.Location = new Point(135, 50);
            editImg.SizeMode = PictureBoxSizeMode.StretchImage;
            editImg.Click += new EventHandler(editImg_Click);

            PictureBox productImg = new PictureBox();
            productImg.Controls.Add(deleteImg);
            productImg.Dock = DockStyle.Top;
            productImg.Image = product.Image;
            productImg.Location = new Point(0, 0);
            productImg.Size = new Size(235, 200);
            productImg.SizeMode = PictureBoxSizeMode.Zoom;
            productImg.TabStop = false;

            Panel panel = new Panel();
            panel.Controls.Add(productPriceLabel);
            panel.Controls.Add(productNameLabel);
            panel.Controls.Add(deleteImg);
            panel.Controls.Add(editImg);
            panel.Controls.Add(productImg);

            panel.Location = new Point(3, 3);
            panel.Size = new Size(174, 290);
            panel.BackColor = Color.White;

            flowLayoutPanel1.Controls.Add(panel);

            panelElements.DelImg = deleteImg;
            panelElements.EditImg = editImg;
            panelElements.ProductImg = productImg;
            panelElements.NameLabel = productNameLabel;
            panelElements.PriceLabel = productPriceLabel;
            panelElements.BackPanel = panel;

            return panelElements;
        }

        #region "Component methods"
        private void editImg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panelElements.Length; i++)
            {
                if ((PictureBox)sender == panelElements[i].EditImg)
                {
                    FormProvider.MainPageForm.Hide();
                    ProductControllerForm pc_Form = new ProductControllerForm(ProductInformation.Products[i], i);
                    pc_Form.Show();
                }
            }
        }

        private void delImg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panelElements.Length; i++)
            {
                if ((PictureBox)sender == panelElements[i].DelImg)
                {
                    DBController.DeleteFromDb((int)ProductInformation.Products[i].ID);

                    panelElements[i].BackPanel.Dispose();

                    RemoveFromArrays(i);
                }
            }
        }

        private void searchTxt_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text == defaultSearchFieldText)
            {
                searchTxt.Text = "";
                searchTxt.ForeColor = Color.Black;
            }
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTxt.Text))
            {
                searchTxt.Text = defaultSearchFieldText;
                searchTxt.ForeColor = ColorTranslator.FromHtml("#BFCDDB");
            }
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            FormProvider.MainPageForm.Hide();

            ProductControllerForm pc_Form = new ProductControllerForm();
            pc_Form.Show();
        }

        private void selectedPriceBtn_Click(object sender, EventArgs e)
        {
            ShowPanels();
        }

        private void WriteOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PriceFieldsValidation_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(priceFromTxt.Text) && !String.IsNullOrEmpty(priceToTxt.Text))
            {
                int minPrice = Convert.ToInt32(priceFromTxt.Text);
                int maxPrice = Convert.ToInt32(priceToTxt.Text);

                if (minPrice > maxPrice)
                {
                    priceFromTxt.BackColor = Color.OrangeRed;
                    priceToTxt.BackColor = Color.OrangeRed;
                    selectedPriceBtn.Enabled = false;
                }
                else
                {
                    priceFromTxt.BackColor = Color.White;
                    priceToTxt.BackColor = Color.White;
                    selectedPriceBtn.Enabled = true;
                }
            }
        }

        private void seatchBtn_Click(object sender, EventArgs e)
        {
            bool isShowedPanel = false;
            if (!String.IsNullOrEmpty(searchTxt.Text))
            {
                ResetFilters();

                string searchText = searchTxt.Text.ToLower();
                for (int i = 0; i < ProductInformation.Products.Length; i++)
                {
                    string productName = ProductInformation.Products[i].Name.ToLower();
                    int indexOfSubstring = productName.IndexOf(searchText);

                    if (indexOfSubstring >= 0 || searchTxt.Text == defaultSearchFieldText)
                    {
                        panelElements[i].BackPanel.Visible = true;
                        isShowedPanel = true;
                    }
                    else
                    {
                        panelElements[i].BackPanel.Visible = false;
                    }
                }
            }
            if (!isShowedPanel)
            {
                nothingFoundedLabel.Visible = true;
            }
            else
            {
                nothingFoundedLabel.Visible = false;
            }
        }

        private void TypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSearchFieldDefaultDesign();

            CheckBox checkBox = (CheckBox)sender;
            string checkBoxTxt = checkBox.Text;
            int indexOfSubstring = searchByTypeValue.IndexOf(checkBoxTxt);

            if (checkBox.Checked)
            {
                if (indexOfSubstring < 0)
                {
                    searchByTypeValue += checkBoxTxt;
                }
            }
            else
            {
                if (indexOfSubstring >= 0)
                {
                    searchByTypeValue = searchByTypeValue.Remove(indexOfSubstring, checkBoxTxt.Length);
                }
            }

            ShowPanels();
        }

        private void BrandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSearchFieldDefaultDesign();

            CheckBox checkBox = (CheckBox)sender;
            string checkBoxTxt = checkBox.Text;
            int indexOfSubstring = searchByBrandValue.IndexOf(checkBoxTxt);

            if (checkBox.Checked)
            {
                if (indexOfSubstring < 0)
                {
                    searchByBrandValue += checkBoxTxt;
                }
            }
            else
            {
                if (indexOfSubstring >= 0)
                {
                    searchByBrandValue = searchByBrandValue.Remove(indexOfSubstring, checkBoxTxt.Length);
                }
            }

            ShowPanels();
        }
        #endregion "Component methods"

        private bool IsPriceBetweenNeededValues(int price)
        {
            int minPrice = Convert.ToInt32(priceFromTxt.Text);
            int maxPrice = Convert.ToInt32(priceToTxt.Text);

            if (price >= minPrice && price <= maxPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowPanels()
        {
            bool isShowedPanel = false;

            for (int i = 0; i < ProductInformation.Products.Length; i++)
            {
                string type = ProductInformation.Products[i].Type;
                string brand = ProductInformation.Products[i].Brand;
                int price = ProductInformation.Products[i].Price;

                int indexOfSubstringType = searchByTypeValue.IndexOf(type);
                int indexOfSubstringBrand = searchByBrandValue.IndexOf(brand);

                if (!String.IsNullOrEmpty(searchByTypeValue) && !String.IsNullOrEmpty(searchByBrandValue))
                {
                    if (indexOfSubstringType >= 0 && indexOfSubstringBrand >= 0 && IsPriceBetweenNeededValues(price))
                    {
                        panelElements[i].BackPanel.Visible = true;
                        isShowedPanel = true;
                    }
                    else
                    {
                        panelElements[i].BackPanel.Visible = false;
                    }
                }
                else if (!String.IsNullOrEmpty(searchByTypeValue) || !String.IsNullOrEmpty(searchByBrandValue))
                {
                    if ((indexOfSubstringType >= 0 || indexOfSubstringBrand >= 0) && IsPriceBetweenNeededValues(price))
                    {
                        panelElements[i].BackPanel.Visible = true;
                        isShowedPanel = true;
                    }
                    else
                    {
                        panelElements[i].BackPanel.Visible = false;
                    }
                }
                else
                {
                    if (IsPriceBetweenNeededValues(price))
                    {
                        panelElements[i].BackPanel.Visible = true;
                        isShowedPanel = true;
                    }
                    else
                    {
                        panelElements[i].BackPanel.Visible = false;
                    }
                }
            }

            if (!isShowedPanel)
            {
                nothingFoundedLabel.Visible = true;
            }
            else
            {
                nothingFoundedLabel.Visible = false;
            }
        }

        private void ResetFilters()
        {
            DeselectCheckBoxesInGroup(typeOfSweetsGB);
            DeselectCheckBoxesInGroup(brandGB);
        }

        private void DeselectCheckBoxesInGroup(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = false;
                }
            }
        }

        private void SetSearchFieldDefaultDesign()
        {
            searchTxt.Text = defaultSearchFieldText;
            searchTxt.ForeColor = ColorTranslator.FromHtml("#BFCDDB");
        }

        private int GetMaxPrice()
        {
            int maxPrice = 0;
            for (int i = 0; i < ProductInformation.Products.Length; i++)
            {
                int price = ProductInformation.Products[i].Price;
                if (maxPrice < price)
                {
                    maxPrice = price;
                }
            }
            return maxPrice;
        }
    }
}
