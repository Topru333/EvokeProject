using EvokeProjectWithApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvokeProjectWithApi.Controllers {

    public interface ManSortStrategy {
        List<DecaratedMan> filter (List<DecaratedMan> list);
    }

    public class SortByName : ManSortStrategy {
        public List<DecaratedMan> filter (List<DecaratedMan> list) {
            return list.OrderBy(o => o.Name).ToList();
        }
    }

    public class SortByAge : ManSortStrategy {
        public List<DecaratedMan> filter (List<DecaratedMan> list) {
            return list.OrderBy(o => o.Age).ToList();
        }
    }
}