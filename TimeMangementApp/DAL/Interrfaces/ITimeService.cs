﻿using TimeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementApp.DAL.Interrfaces
{
    public interface ITimeService
    {
        List<Time> GetAllTimes();
        Task<Time> CreateTime(Time expense);
        Task<Time> GetTimeById(long id);
        Task<bool> DeleteTimeById(long id);
        Task<Time> UpdateTime(Time model);
    }
}
