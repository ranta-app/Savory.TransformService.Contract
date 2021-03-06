﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TransformService.Contract.Response
{
    /// <summary>
    /// 预览返回状态码
    /// </summary>
    public enum PreviewStatus
    {
        /// <summary>
        /// 未定义
        /// </summary>
        None = 0,

        /// <summary>
        /// 操作成功
        /// </summary>
        Success = 1,

        /// <summary>
        /// 模版必传
        /// </summary>
        TemplateBodyRequired = 101,

        /// <summary>
        /// 引擎处理失败
        /// </summary>
        EngineSaysNo = 201
    }
}
