namespace ShopManagement
{
    public partial class frmTaxCollector : Form
    {
        public frmTaxCollector()
        {
            InitializeComponent();
        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            // var - to allocate generic type automatically, implicit
            // take user input such  amount and percentage
            var salary = Convert.ToDouble(txtIncome.Text.Trim());
            var percentage = Convert.ToDouble(cmbTaxSlab.SelectedValue);

            // find tax and print the result to user
            lblFinalTax.Text = GetTax(salary, percentage).ToString();
        }

        private double GetTax(double salary, double percentage)
        {
            return (salary * percentage / 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // var - to allocate generic type automatically, implicit
            // take user input such  amount and percentage
            var salary = Convert.ToDouble(txtIncome.Text.Trim());
            var percentage = Convert.ToDouble(cmbTaxSlab.Text);

            // find tax and print the result to user
            lblTaxResult.Text = GetTax(salary, percentage).ToString();
        }
    }
}