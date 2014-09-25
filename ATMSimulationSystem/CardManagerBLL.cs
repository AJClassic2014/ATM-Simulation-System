using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ATMManager
{
    /// <summary>
    /// user information BLL class
    /// </summary>
  public  class CardManagerBLL
    {
        CardManagerDAL userDal = new CardManagerDAL();


        /// <summary>
        /// card number confirmation
        /// </summary>
        public Card Login(string cardNum, string pwd)
        {
            DataTable dt = userDal.login(cardNum, pwd);
            if (dt == null || dt.Rows.Count <= 0) return null;
            Card card = returnCard(dt);
            return card;
        }
        /// <summary>
        /// card number confirmation
        /// </summary>
        public Card searchCardByCardNum(string cardNum)
        {
            DataTable dt = userDal.queryCardByNum(cardNum);
            if (dt == null || dt.Rows.Count <= 0) return null;
            Card card = returnCard(dt);
            return card;
        }
        /// <summary>
        /// search card number
        /// </summary>
      public List<string> searchCardNum()
      {
          DataTable dt = userDal.queryCardNum();
          if (dt == null || dt.Rows.Count <= 0) return null;

          List<string> card = new List<string>();
          for (int i = 0; i < dt.Rows.Count; i++)
          {
              card.Add(dt.Rows[i]["cardNum"].ToString());
          }
          return card;
      }

      public List<string> getCardOperation(string cardNum)
      {

          DataTable dtDetails = userDal.queryCardOperation(cardNum);
          List<string> accountDetails = new List<string>();
          for (int i = 0; i < dtDetails.Rows.Count; i++)
          {
              string detailsList=dtDetails.Rows[i]["cardNum"].ToString() + "  " + dtDetails.Rows[i]["time"].ToString() + "  " + dtDetails.Rows[i]["description"].ToString() + "  " + dtDetails.Rows[i]["amount"].ToString();
              accountDetails.Add(detailsList);
          }
          return accountDetails;

      }
        /// <summary>
        /// withdraw operation
        /// </summary>
      public bool updateAccountByID(int id, float value)
      {
          return userDal.updateAccountByID(id, value);
      }
      public bool updateAccountOperationByCardNum(string CardNum, float value,string operation)
      {
          Console.Write("track1");
          return userDal.updateAccountOperationByCardNum(CardNum, value,operation);
      }
      /// <summary>
      /// check balance
      /// </summary>
      public string searchAccountByID(int id)
      {
      return userDal.queryAccountByID(id);
      }
      /// <summary>
      ///update password/pin number
      /// </summary>
      public bool updatePassword(int id, string value)
      {
      return userDal.updatePasswordByID(id,value);
      }
        ///// <summary>
        ///// search user name according to user ID
        ///// </summary>
        //public string searchById(int id)
        //{
        //    string name = userDal.queryById(id);
        //    if ("0".Equals(name) || name.Equals(DBNull.Value))
        //        name = "";This user has been removed
        //    return name;
        //}

        ///// <summary>
        ///// check the information of all the department
        ///// </summary>
        //public List<string> searchDeption()
        //{
        //    List<string> deptionList = new List<string>();
        //    DataTable dt = userDal.queryDeption();
        //    if (dt == null || dt.Rows.Count <= 0) return null;
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        deptionList.Add(dt.Rows[i]["part"].ToString());
        //    }
        //    return deptionList;
        //}

       

        ///// <summary>
        ///// check authorities according to user ID
        ///// </summary>
        //public void setPowerByGid(int gid)
        //{
        //    PowerGroupDAL groupDal = new PowerGroupDAL();
        //    DataTable dt = groupDal.queryItemByGid(gid);
        //    if (dt == null || dt.Rows.Count <= 0)
        //    {
        //        UserPower.DataInit();
        //        return;
        //    }
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        int mid = int.Parse(dt.Rows[i]["moduleId"].ToString());
        //        returnPowerData(mid, dt.Rows[i]["powerStr"].ToString());
        //    }
        //}


        ///// <summary>
        ///// check user name according to telephone number 
        ///// </summary>
        //public string searchNameByPhone(string phone)
        //{
        //    string value = userDal.queryNameByPhone(phone);
        //    if (value.Equals("0"))
        //        return "";
        //    else
        //        return value;
        //}

        ///// <summary>
        ///// check the user name is active or not
        ///// </summary>
        //public bool Exist(string userName)
        //{
        //    if (userDal.queryCountByUserName(userName) > 0)
        //        return true;
        //    return false;
        //}

        /////// <summary>
        /////// check all the users information
        /////// </summary>
        ////public List<User> search()
        ////{
        ////    DataTable dt = userDal.query();
        ////    return returnUserList(dt);
        ////}

        /////// <summary>
        /////// check user inforation according to user ID
        /////// </summary>
        ////public User searchById(int id)
        ////{
        ////    DataTable dt = userDal.queryById(id);
        ////    if (dt == null || dt.Rows.Count <= 0) return null;
        ////    User user = returnCard(dt);
        ////    PowerGroupBLL groupBll = new PowerGroupBLL();
        ////    PowerGroup group = new PowerGroup();
        ////    group.Id = int.Parse(dt.Rows[0]["powerId"].ToString());
        ////    group.Name = groupBll.powerGroupDAL.queryNameByID(group.Id);
        ////    user.Power = group;
        ////    return user;
        ////}

        /////// <summary>
        /////// check user inforation according to department
        /////// </summary>
        ////public List<User> searchByDeption(string value)
        ////{
        ////    DataTable dt = userDal.queryByDeption(value);
        ////    return returnUserList(dt);
        ////}

        /////// <summary>
        ///////check user according to user name and department
        /////// </summary>
        ////public List<User> searchByName(string name, string part)
        ////{
        ////    DataTable dt = userDal.queryByName(name, part);
        ////    return returnUserList(dt);
        ////}

         ////<summary>
         ////Return Card
         ////</summary>
         ////<param name="dt"></param>
         ////<returns></returns>
        private Card returnCard(DataTable dt)
        {
            if (dt == null || dt.Rows.Count <= 0) return null;

            Card card = new Card();
            card.Id = int.Parse(dt.Rows[0]["id"].ToString());
            card.CardNum = dt.Rows[0]["cardNum"].ToString();
            card.Password = dt.Rows[0]["password"].ToString();
            card.Acount = float.Parse(dt.Rows[0]["acount"].ToString());
            return card;
        }

    }
}