using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", description = "Современный вид транспорта"},
                    new Category { categoryName = "Класические автомобили", description = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
