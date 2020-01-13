using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    class DAOcombo
    {
        
        public static ArrayList combosFromMenu(string menuName)
        {
            OrderSystemEntities db = new OrderSystemEntities();
            ArrayList comboArrayList = new ArrayList();
            menu menu = db.menus.FirstOrDefault(x => x.menu_name == menuName);
            if (menu == null)
            {
                return comboArrayList;}
            var menuDetails = db.menu_detail.Where(r => r.menuId == menu.id);
            foreach (var i in menuDetails)
            {
                combo comboes = db.comboes.FirstOrDefault(x => x.id == i.productID && x.disable ==false );
                if (comboes != null)
                {
                    comboArrayList.Add(comboes);
                }
                
            }

            return comboArrayList;
        }

        public static ArrayList foodsFromMenu(string menuName)
        {
            OrderSystemEntities db = new OrderSystemEntities();
            ArrayList foodArrayList = new ArrayList();
            menu menu = db.menus.FirstOrDefault(x => x.menu_name == menuName);
            if (menu == null)
            {
                return foodArrayList;
            }
            var menuDetails = db.menu_detail.Where(r => r.menuId == menu.id);
            foreach (var i in menuDetails)
            {
                food food = db.foods.FirstOrDefault(x => x.id == i.productID && x.disable == false);
                if (food != null)
                {
                    foodArrayList.Add(food);
                }
            }


            return foodArrayList;
        }
    }
}
