using Core.DataAccesss.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join d in context.Colors
                             on c.ColorId equals d.ColorId
                             select new CarDetailDto {
                                 CarId=c.CarId,
                                 BrandName=b.BrandName,
                                 ModelYear=c.ModelYear,
                                 Description=c.Description,
                                 CarName=c.CarName,
                                 ColorName=d.ColorName,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
