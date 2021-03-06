﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yintai.Architecture.Common.Models;
using Yintai.Architecture.Common.Web.Mvc.ActionResults;
using Yintai.Architecture.Common.Web.Mvc.Controllers;

namespace Yintai.Hangzhou.WebApiCore
{
    public static class ControllerExtension
    {
        public static ActionResult RenderError(this RestfulController controller, Action<ExecuteResult> callback)
        {
            var result = new RestfulResult
                {
                    Data = new ExecuteResult { StatusCode = StatusCode.InternalServerError, Message = "操作失败！" }

                };
            if (callback != null)
                callback(result.Data as ExecuteResult);
            return result;
        }
    }
}
