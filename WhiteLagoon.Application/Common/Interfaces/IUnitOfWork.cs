using System;
using System.Collections.Generic;
using System.Text;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IVillaRepository Villa { get; }
        IVillaNumberRepository VillaNumber { get; }
        IBookingRepository Booking { get; }
        IApplicationUserRepository User { get; }
        IAmenityRepository Amenity { get; }

        void Save();
    }
}
