﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EW.Utility.Logging
{ /// <summary>
    /// 定义日志输出适配器的方法
    /// </summary>
    public interface ILoggerAdapter
    {
        /// <summary>
        /// 由指定类型获取<see cref="ILog"/>日志实例
        /// </summary>
        /// <param name="type">指定类型</param>
        /// <returns></returns>
        ILog GetLogger(Type type);

        /// <summary>
        /// 由指定名称获取<see cref="ILog"/>日志实例
        /// </summary>
        /// <param name="name">指定名称</param>
        /// <returns></returns>
        ILog GetLogger(string name);
    }
}