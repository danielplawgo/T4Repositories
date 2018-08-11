namespace T4Repositories.Web.ViewModel.Products
{
    public class ProductViewModel : BaseViewModel
    {
        public ProductViewModel()
        {
            PageTitle = Id == 0 ? "Dodanie produktu" : string.Format("Edycja produktu: {0}", Name);
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}