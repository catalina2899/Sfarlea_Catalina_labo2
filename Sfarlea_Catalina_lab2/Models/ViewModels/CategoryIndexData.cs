using System.Collections.Generic;
using Sfarlea_Catalina_lab2.Models;

namespace Sfarlea_Catalina_lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
            public IEnumerable<Category> Categories { get; set; }
            public IEnumerable<Book> Books { get; set; }
    }
}
