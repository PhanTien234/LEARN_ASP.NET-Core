using Microsoft.AspNetCore.Mvc;

namespace XTLAB{

    // [ViewComponent]
    public class ProductBox : ViewComponent
    {
        //(1)
        //string(IViewComponentResult) Invoke(object m)
        // InvokeAsync

        /*
           - [ViewComponent]
           - Dat ten lop co hau to laf ViewComponent
           * Ke thua ViewComponent (Chúng ta nên sử dụng cách này)
        */

        ProductListService productServices;
        public ProductBox(ProductListService _products){
            productServices = _products;
        }
        public IViewComponentResult Invoke(bool sapxeptang = true){

            List<Product> _products = null;
            if(sapxeptang){
                _products = productServices.products.OrderBy(p => p.Price).ToList();
            }else{
                _products = productServices.products.OrderByDescending(p => p.Price).ToList();
            }
            return View<List<Product>>(_products); //Default.cshtml
        }
    }
}