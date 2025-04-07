using BLL;
using Dto.Input;

namespace UI.Win;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonCreateProduct_Click(object sender, EventArgs e)
    {
        var model = new ProductCreateInput {
            Name = "Test", 
            Description = "xyz", 
            Price = 1_000 
        };

        var service = new ProductService();
        service.Create(model);
    }
}
