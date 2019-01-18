using System;
using System.Collections.Generic;
using Models;
using Repository.UnitOfWork;

namespace Services
{
    public class BenchmarkService
    {
        private IUnitOfWork _unitOfWork;

        public BenchmarkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public HeavilyRequestedObjectDTO GetHeavilyRequestedObjectById(int id)
        {
            return _unitOfWork.HeavilyRequestedObjects.GetHeavilyRequestedObjectById(id);
        }
    }
}
