﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        List<Rental> GetAll();
        Rental GetById(int customerId);
        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
    }
}
