using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//using Yechtech.Utility;

namespace Yechtch.IMS
{
    public class IMSDBHelper<T> where T : class
    {
        IMSEntities context = new IMSEntities();
        /// <summary>
        /// 新增一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Add(T entity)
        {
           
            using (IMSEntities context = new IMSEntities())
            {
                context.Entry<T>(entity).State = System.Data.Entity.EntityState.Added;
                return context.SaveChanges();
            }
            
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="entity"></param>K
        /// <returns></returns>
        public int Remove(T entity)
        {
            using (IMSEntities context = new IMSEntities())
            {
                context.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            
        }

      


        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(T entity)
        {
            using (IMSEntities context = new IMSEntities())
            {
                context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
           
        }
        /// <summary>
        /// 批量新增实体
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        public int AddList(params T[] entities)
        {
            using (IMSEntities context = new IMSEntities())
            {
                int result = 0;
                for (int i = 0; i < entities.Count(); i++)
                {
                    if (entities[i] == null)
                        continue;
                    context.Entry<T>(entities[i]).State = System.Data.Entity.EntityState.Added;
                    if (i != 0 && i % 20 == 0)
                    {
                        result += context.SaveChanges();
                    }
                }
                if (entities.Count() > 0)
                    result += context.SaveChanges();
                return result;
            }

            
        }
        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int RemoveList(Expression<Func<T, bool>> where)
        {
            using (IMSEntities context = new IMSEntities())
            {
                var temp = context.Set<T>().Where(where);
                foreach (var item in temp)
                {
                    context.Entry<T>(item).State = System.Data.Entity.EntityState.Deleted;
                }
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<T> FindList(Expression<Func<T, bool>> where)
        {
            IList<T> list = new List<T>();
            using (IMSEntities context = new IMSEntities())
            {
                var temp = context.Set<T>().Where(where);

                foreach (var item in temp)
                {
                    list.Add(item);
                }

            }
               
            return list;
        }
        /// <summary>
        /// 按条件查询，排序
        /// </summary>
        /// <typeparam name="S"><peparam>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IList<T> FindList<S>(Expression<Func<T, bool>> where, Expression<Func<T, S>> orderBy, bool isAsc)
        {
            IList<T> list = new List<T>();
            using (IMSEntities context = new IMSEntities())
            {
                var temp = context.Set<T>().Where(where);
                if (isAsc)
                    temp = temp.OrderBy<T, S>(orderBy);
                else
                    temp = temp.OrderByDescending<T, S>(orderBy);

                foreach (var item in temp)
                {
                    list.Add(item);
                }
            }
            return list;

        }



        /// <summary>
        /// 按条件查询，分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="rowCount"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<T> FindPagedList(int pageIndex, int pageSize, out int rowCount, Expression<Func<T, bool>> where)
        {
            IList<T> list = new List<T>();
            using (IMSEntities context = new IMSEntities())
            {
                var temp = context.Set<T>().Where(where);
                rowCount = temp.Count();
                temp = temp.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                foreach (var item in temp)
                {
                    list.Add(item);
                }
            }
            return list;

        }
        /// <summary>
        /// 按条件查询，分页，排序 dbhelper.FindPagedList(2, 10, out rowcount,x=>x.Name=="1",s=>s.Id,true);
        /// </summary>
        /// <typeparam name="S"><peparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="rowCount"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IList<T> FindPagedList<S>(int pageIndex, int pageSize, out int rowCount, Expression<Func<T, bool>> where, Expression<Func<T, S>> orderBy, bool isAsc)
        {
            IList<T> list = new List<T>();
            using (IMSEntities context = new IMSEntities())
            {
                var temp = context.Set<T>().Where(where);
                rowCount = temp.Count();
                if (isAsc)
                    temp = temp.OrderBy<T, S>(orderBy).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                else
                    temp = temp.OrderByDescending<T, S>(orderBy).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                    foreach (var item in temp)
                    {
                        list.Add(item);
                }
            }
            return list;

        }
    }
}
