using FengTe.GamePlay.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Params;
using Dapper;
using System.Data;

namespace FengTe.GamePlay.Repository.MSSQLDB
{
    public class R_Game_User_PlayRepository : IR_Game_User_PlayRepository
    {
        public bool Delete(R_Game_User_Play entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<R_Game_User_Play> GetList()
        {
            throw new NotImplementedException();
        }

        public R_Game_User_Play GetModel(int id = 1, string name = null)
        {
            string sql = "select top 1 State,type,Games_GameId,InTime from R_Game_User_Play where User_UserId=@UserId order by intime asc  ";
            using (var conn=ConnectionFactory.Connection())
            {
               return  conn.Query<R_Game_User_Play>(sql,new { UserId = id}).SingleOrDefault();
            }
        }

        /// <summary>
        /// 大神申请>大神上分
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(R_Game_User_Play entity)
        {
            string sql = "insert  into  R_Game_User_Play(GameRating_CutImg,Type,User_UserId,Games_GameId,GameRatingId,GameAreaId) values(@GameRating_CutImg,@Type,@User_UserId,@Games_GameId,@GameRatingId,@GameAreaId) ";
            using (var conn=ConnectionFactory.Connection())
            {
               return  conn.Execute(sql,entity);
            }
        }

        public int InsertFunPlay(R_Game_User_Play entity, User user)
        {          
            using (var conn = ConnectionFactory.Connection())
            {
               const string sql = " insert  into  R_Game_User_Play(GameRating_CutImg,Type,User_UserId,Games_GameId,GameRatingId,GameAreaId,OnlinePrice,OfflinePrice,TagName,ServiceNote,GameScore_CutImg)  values(@GameRating_CutImg, @Type, @User_UserId, @Games_GameId, @GameRatingId, @GameAreaId, @OnlinePrice, @OfflinePrice, @TagName, @ServiceNote, @GameScore_CutImg) ";

                const string sql2 = " update [dbo].[User]  set  HomePage_Img=@HomePage_Img,Sex=@Sex,CurrentCity=@CurrentCity,PersonalPhoto=@PersonalPhoto,PersonalAudio=@PersonalAudio   where  UserId=@UserId";
                IDbTransaction tran = conn.BeginTransaction();
                try
                {
                 int i=   conn.Execute(sql, entity,tran);
                   i += conn.Execute(sql2, new { UserId = user.UserId, HomePage_Img = user.HomePage_Img, Sex = user.Sex, CurrentCity = user.CurrentCity, PersonalPhoto = user.PersonalPhoto, PersonalAudio = user.PersonalAudio }, tran);
                    tran.Commit();
                    return i;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
               
            }
        }

        public Tuple<IEnumerable<R_Game_User_Play>, int> LoadPageEntities(int pageIndex, int PageSize, bool isAsc, QueryParam param = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(R_Game_User_Play entity)
        {
            throw new NotImplementedException();
        }
    }
}
