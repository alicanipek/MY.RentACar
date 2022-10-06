﻿using Core.DataAccess;
using Entities.Concreate;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<Car> GetCarByColorId(int id);
        List<Car> GetCarByBrandId(int id);
    }
}
