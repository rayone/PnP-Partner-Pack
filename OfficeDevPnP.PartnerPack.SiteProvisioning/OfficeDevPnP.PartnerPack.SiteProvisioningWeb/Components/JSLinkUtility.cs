﻿//using Microsoft.SharePoint.Client;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Web;

//namespace OfficeDevPnP.PartnerPack.SiteProvisioningWeb.Components
//{
//    public static class JSLinkUtility
//    {
//        public static void AddJsLink(String scriptName, String scriptUrl, HttpRequestBase request, ClientContext ctx, Web web)
//        {

//            web.AddJsLink(scriptName, jsLink);

//            //StringBuilder scripts = new StringBuilder(@"
//            //    var headID = document.getElementsByTagName('head')[0]; 
//            //    var");

//            //scripts.AppendFormat(@"
//            //    newScript = document.createElement('script');
//            //    newScript.id = '{0}';
//            //    newScript.type = 'text/javascript';
//            //    newScript.src = '{1}';
//            //    headID.appendChild(newScript);", scriptName, jsLink);
//            //string scriptBlock = scripts.ToString();

//            //web.AddJsBlock(scriptName, scriptBlock);

//            //var existingActions = web.UserCustomActions;
//            //ctx.Load(existingActions);
//            //ctx.ExecuteQueryRetry();
//            //var actions = existingActions.ToArray();
//            //foreach (var action in actions)
//            //{
//            //    if (action.Description == scriptName &&
//            //        action.Location == "ScriptLink")
//            //    {
//            //        action.DeleteObject();
//            //        ctx.ExecuteQueryRetry();
//            //    }
//            //}

//            //var newAction = existingActions.Add();
//            //newAction.Description = scriptName;
//            //newAction.Location = "ScriptLink";

//            //newAction.ScriptBlock = scriptBlock;
//            //newAction.Update();
//            //ctx.Load(web, s => s.UserCustomActions);
//            //ctx.ExecuteQueryRetry();
//        }

//        public static void DeleteJsLink(String scriptName, ClientContext ctx, Web web)
//        {
//            web.DeleteJsLink(scriptName);

//            //var existingActions = web.UserCustomActions;
//            //ctx.Load(existingActions);
//            //ctx.ExecuteQueryRetry();
//            //var actions = existingActions.ToArray();
//            //foreach (var action in actions)
//            //{
//            //    if (action.Description == scriptName &&
//            //        action.Location == "ScriptLink")
//            //    {
//            //        action.DeleteObject();
//            //        ctx.ExecuteQueryRetry();
//            //    }
//            //}
//        }

//        public static Boolean ExistsJsLink(String scriptName, ClientContext ctx, Web web)
//        {
//            var existingActions = web.UserCustomActions;
//            ctx.Load(existingActions);
//            ctx.ExecuteQueryRetry();
//            var actions = existingActions.ToArray();
//            foreach (var action in actions)
//            {
//                if (action.Description == scriptName &&
//                    action.Location == "ScriptLink")
//                {
//                    return (true);
//                }
//            }

//            return (false);
//        }
//    }
//}