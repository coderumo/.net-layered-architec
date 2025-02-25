﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext()) { // gönderilen userın claimlerinin join vasıtası ile çekilmesi
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationsClaims
                                on operationClaim.Id equals userOperationClaim.OperationClaimId
                                    where userOperationClaim.UserId == user.Id
                                        select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                return result.ToList();
            }
        }
    }
}
