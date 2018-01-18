using EmitMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.Utility
{
  public  class ConvertHelper<TSource,TDestination> where TSource:class where TDestination:class

    {
        public static TDestination Convert(TSource source)
        {
            ObjectsMapper<TSource, TDestination> mapper = ObjectMapperManager.DefaultInstance.GetMapper<TSource, TDestination>();
            TDestination destination = mapper.Map(source);
            return destination;
        }
    }
}
