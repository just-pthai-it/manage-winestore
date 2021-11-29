using ManageWineStore.app.Controllers.ModelControllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Controllers
{
    class RevenueController
    {
        private WineController wineController = new WineController();
        private SaleReceiptController saleReceiptController = new SaleReceiptController();

        public DataTable getWines()
        {
            return wineController.findAll();
        }

        public DataTable getRevenue1(string wine, string time, string year)
        {
            string commandText = "";
            object[] obj = new object[2];

            if (time == "Tháng")
            {
                if (wine == "0")
                {
                    commandText = "EXEC revenue_all_year @year ;";
                    obj[0] = year;
                }
                else
                {
                    commandText = "EXEC revenue_all_year_by_wine @year , @wine_id ;";
                    obj[0] = year;
                    obj[1] = wine;
                }
            }
            else
            {
                if (wine == "0")
                {
                    commandText = "EXEC revenue_quarter @year ;";
                    obj[0] = year;
                }
                else
                {
                    commandText = "EXEC revenue_quarter_by_wine @year , @wine_id ;";
                    obj[0] = year;
                    obj[1] = wine;
                }
            }

            return this.saleReceiptController.getRevenue(commandText, obj);
        }

        public DataTable getRevenue2(string wine, string year)
        {
            string commandText = "";
            object[] obj = new object[2];
            if (wine == "0")
            {
                commandText = "EXEC revenue_by_year @year ;";
                obj[0] = year;
            }
            else
            {
                commandText = "EXEC revenue_by_year_by_wine @year , @wine_id ;";
                obj[0] = year;
                obj[1] = wine;
            }

            return this.saleReceiptController.getRevenue(commandText, obj);
        }
    }
}
