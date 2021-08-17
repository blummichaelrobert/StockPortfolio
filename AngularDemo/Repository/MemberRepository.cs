using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularDemo.Models;

namespace AngularDemo.Repository
{
    public class MemberRepository : DbContext
    {
        private readonly AppDBContext context;

        public MemberRepository(AppDBContext context)
        {
            this.context = context;
        }
    }
}
