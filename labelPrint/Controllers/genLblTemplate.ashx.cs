﻿using labelPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labelPrint.Controllers
{
    /// <summary>
    /// Summary description for genLblTemplate
    /// </summary>
    public class genLblTemplate : IHttpHandler
    {
        siixsem_sys_lblPrint_dbEntities m_db = new siixsem_sys_lblPrint_dbEntities();
        siixsem_main_dbEntities m_dbM = new siixsem_main_dbEntities();
        public void ProcessRequest(HttpContext context)
        {
            String json = "{";
            try
            {
                generate_lblCode_template2_Result template_code;
                int id_model = Convert.ToInt32(context.Request.Form["idModel"]);
                int id_side = Convert.ToInt32(context.Request.Form["idSide"]);
                int id_flx = Convert.ToInt32(context.Request.Form["idflx"]);
                int id_vol = Convert.ToInt32(context.Request.Form["idVol"]);
                int id_rev; //= Convert.ToInt32(context.Request.Form["idRev"]);
                if (m_dbM.isDFCIFC(id_model).First().se_dfc_ifc == 1)
                    id_rev = 0;
                else
                    id_rev = Convert.ToInt32(context.Request.Form["idRev"]);

                int id_color = Convert.ToInt32(context.Request.Form["idColor"]);

                String dateDJ = context.Request.Form["dateDj"].ToString().Trim();


                DateTime fechaDJ = DateTime.Parse(dateDJ);
                template_code = m_db.generate_lblCode_template2(id_model, id_side, id_flx, id_vol, id_rev,id_color, fechaDJ).First();

                //lblCodeTemplate = m_db.generate_lblCode_template(id_model, id_side, id_flx, id_vol, id_rev).First().template;
                json += "\"result\":\"true\",";
                json += "\"line1\":\"" + template_code.line1.Replace("\n","") + "\",";
                json += "\"line2\":\"" + template_code.line2 + "\",";
                json += "\"lblTemp\":\"" + template_code.template + "\"";
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