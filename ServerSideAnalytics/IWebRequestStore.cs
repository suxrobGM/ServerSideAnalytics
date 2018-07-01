﻿using Maddalena;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ServerSideAnalytics
{
    public interface IWebRequestStore<T> where T : IWebRequest
    {
        T GetNew();

        Task AddAsync(T request);
    }
}