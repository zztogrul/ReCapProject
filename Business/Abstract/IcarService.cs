using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IcarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId();
        List<Car> GetCarsByColorId();
        List<Car> GetByDailyPrice(decimal min);
    }
}
