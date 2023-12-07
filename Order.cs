using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llc_decorations
{
    public class Order
    {
        public string photoPath { get; set; }
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCostWithoutDiscount { get; set; }
        public string ProductCostWithDiscount { get; set; }
        public string ProductDiscountAmount { get; set; }

        public string ProductNameInListBox
        {
            get
            {
                return $"Товар: {ProductName}, Цена без скидки: {ProductCostWithoutDiscount}, Цена со скидкой {ProductCostWithDiscount}, Скидка: {ProductDiscountAmount}";
            }
        }
    }
}
