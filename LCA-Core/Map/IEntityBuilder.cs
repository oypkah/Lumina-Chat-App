using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Core.Map
{
    public interface IEntityBuilder
    {
        void Builder(ModelBuilder builder);
    }
}
