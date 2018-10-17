using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VirtualityBusCard.Repositories
{
    interface IRepositories<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordeyBy = null,
                string includeProperties = "");
        /* IEnumerable和IEnumerable<T> 接口在.NET中是非常重要的接口, 
        它允许开发人员定义foreach语句功能的实现并支持非泛型方法的简单的迭代，
        IEnumerable和IEnumerable<T> 接口是.NET Framework中最基本的集合访问器。
        它定义了一组扩展方法，用来对数据集合中的元素进行遍历、过滤、排序、搜索等操作。*/
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
        void Save();
    }
}
