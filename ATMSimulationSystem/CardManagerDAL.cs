using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Globalization;

namespace ATMManager
{
    /// <summary>
    /// User DAL class
    /// </summary>
   public  class CardManagerDAL
    {
        /// <summary>
        /// log in confirmation
        /// </summary>
        public DataTable login(string cardNum, string password)
        {
            string sql = "select * from BankCard where cardNum='" + cardNum + "' and password='" + password + "'";
            return DBConn.SqlExecSqlReturnDataTable(sql);
        }
        
        /// <summary>
        /// check all the information according to card number
        /// </summary>
        public DataTable queryCardByNum(string num)
        {
            string sql = "select * from BankCard where cardNum=" + num;
            return DBConn.SqlExecSqlReturnDataTable(sql);
        }
        /// <summary>
        /// check card number
        /// </summary>
        public DataTable queryCardNum()
        {
            string sql = "select cardNum from BankCard ";
            return DBConn.SqlExecSqlReturnDataTable(sql);
        }

        public DataTable queryCardOperation(string cardNum)
        {
            string sql = "select cardNum,time,description,amount from AccountDetails where cardNum=" + "'" + cardNum + "'";
            return DBConn.SqlExecSqlReturnDataTable(sql);
        }

        /// <summary>
        /// check card number information according to ID
        /// </summary>
        public DataTable queryCardByID(int id)
        {
            string sql = "select id,cardNum,password,acount from BankCard where id=" + id;
            return DBConn.SqlExecSqlReturnDataTable(sql);
        }
        
        /// <summary>
        /// withdraw
        /// </summary>
        public string queryNameById(int id)
        {
            string sql = "select name from users where id=" + id;
            return DBConn.SqlExecSqlScalar(sql);
        }
     
        /// <summary>
        /// check balance
        /// </summary>
        public string queryAccountByID(int id)
        {
            string sql = "select acount from BankCard where id=" + id;
            return DBConn.SqlExecSqlScalar(sql);
        }
        /// <summary>
        ///change balance
        /// </summary>
        public bool updateAccountOperationByCardNum(string CardNum, float value,string operation)
        {
            System.DateTime Time=new System.DateTime(); 
 
            string time = DateTime.Now.ToString();
            Console.Write("track2");
            string sql = "INSERT INTO AccountDetails VALUES (" + "'" + CardNum + "'" + " ," + "'" + time + "'" + " ," + "'" + operation + "'" + " ," + "'" + value + "'" + ")";
            
            return DBConn.SqlExecSqlReturn(sql);
        }
       
       public bool updateAccountByID(int id,float value )
        {
            string sql = "update BankCard  set  acount=" + value + " where id=" + id;
            return DBConn.SqlExecSqlReturn(sql);
        }
        /// <summary>
        ///change balance
        /// </summary>
        public bool updatePasswordByID(int id, string value)
        {
            string sql = "update BankCard  set  password=" + value + " where id=" + id;
            return DBConn.SqlExecSqlReturn(sql);
        }
        /// <summary>
        /// check tansfer card number
        /// </summary>
        public string queryNameByPhone(string phone)
        {
            string sql = "select name from users where phone= '" + phone + "'";
            return DBConn.SqlExecSqlScalar(sql);
        }
        /// <summary>
        /// check if card number is available
        /// </summary>
        public string exitCardNum(string cardNum)
        {
            string sql = "select cardNum from BankCard where cardNum=" + cardNum;
            return DBConn.SqlExecSqlScalar(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="powerId"></param>
        /// <returns></returns>
        public int queryIdByPowerId(int powerId)
        {
            string sql = "select count(*) as count from users where powerId=" + powerId;
            return DataFormat.StringToInt(DBConn.SqlExecSqlScalar(sql));
        }
  
        ///// <summary>
        ///// change customer information
        ///// </summary>
        //public bool update(User user)
        //{
        //    string sql = "update users set name='" + user.Name + "',sex='" + user.Sex + "',part='" + user.Part + "',birthDate='" + user.BirthDate + "',phone='" + user.Phone + "',userName='" + user.UserName + "',password='" + user.Password + "',email='" + user.Email + "',info='" + user.Info + "',post='"+user.Post+"' where id='" + user.Id + "'";
        //    return DBConn.SqlExecSqlReturn(sql);
        //}

        ///// <summary>
        ///// change customer authorities
        ///// </summary>
        //public bool updatePower(int pId,int uid)
        //{
        //    string sql = "update users set powerId='" + pId + "' where id='" + uid + "'";
        //    return DBConn.SqlExecSqlReturn(sql);
        //}

        ///// <summary>
        ///// change personal information
        ///// </summary>
        //public bool updatePerson(User user)
        //{
        //    string sql = "update users set name='" + user.Name + "',sex='" + user.Sex + "',birthDate='" + user.BirthDate + "',phone='" + user.Phone + "',email='" + user.Email + "' where id='" + user.Id + "'";
        //    return DBConn.SqlExecSqlReturn(sql);
        //}
        ///// <summary>
        ///// check all the users information
        ///// </summary>
        //public DataTable query()
        //{
        //    string sql = "select id,name,sex,part,birthDate,phone,userName,password,email,info,post,powerId from users";
        //    return DBConn.SqlExecSqlReturnDataTable(sql);
        //}

        ///// <summary>
        ///// insert customer inforation
        ///// </summary>
        //public bool insert(User user)
        //{
        //    string sql = "insert into users(name,sex,part,birthDate,phone,userName,password,email,info,powerId,post) values('" +
        //        user.Name + "','" + user.Sex + "','" + user.Part + "','" + user.BirthDate + "','" + user.Phone + "','" + user.UserName + "','" + user.Password + "','" + user.Email + "','" + user.Info + "','" + user.Power.Id + "','"+user.Post+"')";
        //    return DBConn.SqlExecSqlReturn(sql);
        //}

        ///// <summary>
        ///// check user name is existing or not
        ///// </summary>
        //public int queryCountByUserName(string userName)
        //{
        //    string sql = "select count(id) from users where userName='" + userName + "'";
        //    return DataFormat.StringToInt(DBConn.SqlExecSqlScalar(sql).ToString());
        //}
     
        ///// <summary>
        ///// delete customer information
        ///// </summary>
        //public bool deleteById(int id)
        //{
        //    string sql = "delete from users where id=" + id;
        //    return DBConn.SqlExecSqlReturn(sql);
        //}

        ///// <summary>
        ///// delete customer information(powerId)
        ///// </summary>
        //public bool deleteByPowerId(int id)
        //{
        //    string sql = "delete from users where powerId=" + id;
        //    return DBConn.SqlExecSqlReturn(sql);
        //}

        ///// <summary>
        ///// check all the occupation information
        ///// </summary>
        //public DataTable queryPost()
        //{
        //    string sql = "select distinct post from users";
        //    return DBConn.SqlExecSqlReturnDataTable(sql);
        //}

        ///// <summary>
        ///// senior inquiry
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public DataTable queryByDefiend(string str)
        //{
        //    string sql = "select id,name,sex,part,birthDate,phone,userName,password,email,info,post,powerId from users";
        //    if (!"".Equals(str))
        //        sql += " where " + str;
        //    return DBConn.SqlExecSqlReturnDataTable(sql);
        //}
    }
}
