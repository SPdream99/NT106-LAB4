using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai07
{
    public class FoodListResponse
    {
        public List<FoodModel> data { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        public int current { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }
}
