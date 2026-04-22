using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        void Update(Booking entity);
    }
}
