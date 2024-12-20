﻿using labelPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labelPrint.Controllers
{
    /// <summary>
    /// Summary description for getNumSidesByIdModel
    /// </summary>
    public class getNumSidesByIdModel : IHttpHandler
    {
        siixsem_main_dbEntities m_db = new siixsem_main_dbEntities();
        public void ProcessRequest(HttpContext context)
        {
            String json = "{";
            try
            {
                int idM = Convert.ToInt32(context.Request.Form["idM"]);
                int numSides = Convert.ToInt32(m_db.getNumSidesByIdModel(idM).First().numSides);
                json += "\"result\":\"true\",";
                json += "\"numSides\":\"" + numSides.ToString() + "\"";
            }
            catch (Exception ex)
            {
                json += "\"result\":\"false\",";
                json += "\"MessageError\":\"" + ex.Message + "\"";
            }
            json += "}";
            context.Response.ContentType = "text/plain";
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}