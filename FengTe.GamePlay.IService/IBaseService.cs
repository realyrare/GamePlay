using FengTe.GamePlay.Entity.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengTe.GamePlay.IService
{
  public  interface IBaseService<T> where T:class,new()
    {
        /// <summary>
        /// 返回列表
        /// </summary>       
        IEnumerable<T> GetList();

        /// <summary>
        /// 返回单个对象
        /// </summary>
        T GetModel(int id);
        /// <summary>
        /// 查询多个结果集
        /// </summary>
        IList<T> GetQueryMultiple();

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="isAsc">是否升序</param>
        /// <param name="param">模糊查询参数</param>
        /// <returns></returns>
        Tuple<IEnumerable<T>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null);
        /// <summary>
        /// 删除单条记录
        /// </summary>        
        bool Delete(T entity);
        /// <summary>
        /// 批量删除
        /// </summary>    
        bool DeleteList(IList<T> list);
        /// <summary>
        /// 新增单条记录
        /// </summary>

        int Insert(T entity);
        /// <summary>
        /// 批量新增
        /// </summary>

        int InsertList(IList<T> list);
        /// <summary>
        /// 更新单条记录
        /// </summary>
        bool Update(T entity);
        /// <summary>
        /// 批量更新
        /// </summary>
        bool UpdateList(IList<T> list);

    }
}
