﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();

        void Update(Car car);

        void Delete(Car car);

        void Add(Car car);

        Car GetById(int id);
    }
}