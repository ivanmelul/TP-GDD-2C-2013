using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entities
{
    public interface IMapable
    {
        IMapable Map(SqlDataReader reader);
        List<SPParameter> UnMap(IMapable entity);
    }
}
