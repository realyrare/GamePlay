using FengTe.GamePlay.Code;
using FengTe.GamePlay.Entity;
using FengTe.GamePlay.Entity.Enum;
using FengTe.GamePlay.IService;
using FengTe.GamePlay.Utility;
using FengTe.GamePlay.Web.App_Start.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FengTe.GamePlay.Web.Areas.UserManage.Controllers
{
    [CustomerAttribute]
    public class UserController : Controller
    {
        // GET: UserManage/User
        public ActionResult Index()
        {
            var  user = new OperatorProvider<FrontCurrentUser>().GetCurrent();
            ViewData.Model = user as FrontCurrentUser;
           ViewBag. FreezeMoney= IocUtils.Resolve<IMoneyService>().UserMoney(user.UserId, false);
           ViewBag.UsableMoney = IocUtils.Resolve<IMoneyService>().UserMoney(user.UserId, true);
           ViewBag.FocusCount = IocUtils.Resolve<IFocusService>().GetFocusList(user.UserId, true).Count;
           ViewBag.FansCount = IocUtils.Resolve<IFocusService>().GetFocusList(user.UserId, false).Count;
            return View();
        }
        public object GetGamesList()
        {
           return  IocUtils.Resolve<IGamesService>().GetList().ToJson();
        }
     
        public JsonResult GetGameRatingList(int gameId)
        {
            var ratingList= IocUtils.Resolve<IGameRatingService>().GetList(gameId).ToJson();
            var areaList= IocUtils.Resolve<IGameAreaService > ().GetList(gameId).ToJson();         
            return Json(new { Rating = ratingList, Area = areaList }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 大神申请-游戏初步认证
        /// </summary>
        /// <returns></returns>
        public ActionResult MainToGameApply(int gameId,int ratingId,int areaId,string ratingImg)
        {
            R_Game_User_Play game = new R_Game_User_Play()
            {
                    GameRating_CutImg=ratingImg,
                    Type=(int)ProjectType.Manito,
                    User_UserId= new OperatorProvider<FrontCurrentUser>().GetCurrent().UserId,
                    Games_GameId=gameId,
                    GameAreaId=areaId,
                    GameRatingId=ratingId
            };
            if (IocUtils.Resolve<IR_Game_User_PlayService>().Insert(game) > 0)
            {
                return Content("ok");
            }
            else {
                return Content("no");
            }
        }
        public ActionResult MainToUploadImg()
        {           
           HttpPostedFileBase file = Request.Files["file"];         
           string msg = string.Empty,filePath="/Content/GameImg/";     
            msg = ImgUploadHelper.CommonUploadImg(file, out msg, filePath);
            return Content(msg);
        }      
        /// <summary>
        /// 默认页
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {
            return View();
        }
        /// <summary>
        /// 大神申请
        /// </summary>
        /// <returns></returns>
        public ActionResult ManitoApply(int userId)
        {
            ViewData.Model = IocUtils.Resolve<IR_Game_User_PlayService>().GetModel(userId);

            return View();
        }
        /// <summary>
        /// 大神上分
        /// </summary>
        /// <returns></returns>
        public ActionResult ManitoTop()
        {
               
            return View();
        }
        /// <summary>
        /// 陪玩-娱乐
        /// </summary>
        /// <returns></returns>
        public ActionResult ManitoRecreation()
        {
            return View();
        }
        public ActionResult ManitoFunPlay()
        {
            User user = new User() {
                UserId=new OperatorProvider<FrontCurrentUser>().GetCurrent().UserId,
                HomePage_Img=Request["homeImg"],
                Sex= int.Parse( Request["sex"]),
                CurrentCity=Request["city"] ,
                PersonalPhoto=Request["photo"],
                PersonalAudio=Request["audio"],
            };
            R_Game_User_Play game = new R_Game_User_Play() {
                Games_GameId=int.Parse( Request["gameId"]),
                GameAreaId=int.Parse(Request["areaId"]),
                GameRatingId=int.Parse(Request["ratingId"]),
                GameRating_CutImg=Request["ratingImg"],
                OnlinePrice=int.Parse(Request["onPrice"]),
                OfflinePrice=int.Parse(Request["offPrice"]),
                TagName=Request["tagName"],
                ServiceNote=Request["serviceNote"],
                GameScore_CutImg=Request["scoreImg"],
                Type=(int)ProjectType.FunPlay
            };          
                if (IocUtils.Resolve<IR_Game_User_PlayService>().InsertFunPlay(game,user))
                {
                    
                    return Content("ok,恭喜：信息提交成功！");
                }
                else {
                    return Content("no,提示：游戏信息认证失败了！");
                }         
        }
        /// <summary>
        /// 接单记录
        /// </summary>
        /// <returns></returns>
        public ActionResult OrderReceivRecord()
        {
            return View();
        }
        /// <summary>
        /// 下单记录
        /// </summary>
        /// <returns></returns> 
        public ActionResult OrderPlaceRecord()
        {
            return View();
        }
        /// <summary>
        /// 大神主页
        /// </summary>
        /// <returns></returns>
        public ActionResult ManitoHomepage()
        {
            var user = new OperatorProvider<FrontCurrentUser>().GetCurrent();
            ViewData.Model = user as FrontCurrentUser;          
            ViewBag.FocusCount = IocUtils.Resolve<IFocusService>().GetFocusList(user.UserId, true).Count;
            ViewBag.FansCount = IocUtils.Resolve<IFocusService>().GetFocusList(user.UserId, false).Count;
            return View();
        }
    }
}