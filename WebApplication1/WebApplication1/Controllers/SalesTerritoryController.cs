using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Controllers
{
    public class SalesTerritoryController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SalesTerritory salesterritory)
        {
            if (ModelState.IsValid)
            {
                AddEmployee(salesterritory);
                return View();
            }

            return View();
        }


        public void AddEmployee(SalesTerritory st)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SalesTerritoryContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddSalesTerritory", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter();
                p1.ParameterName = "@SalesTerritoryAlternateKey";
                p1.Value = st.SalesTerritoryAlternateKey;
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter();
                p2.ParameterName = "@SalesTerritoryRegion";
                p2.Value = st.SalesTerritoryRegion;
                cmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter();
                p3.ParameterName = "@SalesTerritoryCountry";
                p3.Value = st.SalesTerritoryCountry;
                cmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter();
                p4.ParameterName = "@SalesTerritoryGroup";
                p4.Value = st.SalesTerritoryGroup;
                cmd.Parameters.Add(p4);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

    }
}