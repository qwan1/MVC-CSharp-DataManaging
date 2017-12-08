using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IView
    {
        void setController(Controller controller);
        void populate_t_mining_area();
        void populate_levels(string mining_area_name);
        void populate_t_cut_info(string mining_area_name, string cut_level, string cut_id);
        void populate_t_cut_geom(string cut_id, double x1);
    }
}
