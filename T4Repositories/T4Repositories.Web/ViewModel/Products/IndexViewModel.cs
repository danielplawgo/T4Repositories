using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T4Repositories.Web.ViewModel.Products
{
    public class IndexViewModel : BaseViewModel
    {
        public IndexViewModel()
        {
            PageTitle = "Lista produktów";
        }

        public IList<IndexItemViewModel> Items { get; set; }
    }

    public class IndexItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}