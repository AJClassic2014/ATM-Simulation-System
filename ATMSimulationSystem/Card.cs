using System;
using System.Collections.Generic;
using System.Text;

namespace ATMManager
{
  public  class Card
    {

        /// <summary>
        /// id
        /// </summary>
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value.Equals(DBNull.Value)) id = 0;
                else id = value;
            }
        }

        /// <summary>
        ///card number
        /// </summary>
        private string cardNum;
        public string CardNum
        {
            get { return cardNum; }
            set
            {
                if (value.Equals(DBNull.Value)) cardNum = "";
                else cardNum = value;
            }
        }

        /// <summary>
        /// password
        /// </summary>
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Equals(DBNull.Value)) password = "";
                else password = value;
            }
        }
        /// <summary>
        /// password
        /// </summary>
        private float acount;
        public float Acount
        {
            get { return acount; }
            set
            {
                if (value.Equals(DBNull.Value)) acount = 0.0f;
                else acount = value;
            }
        }

    }
}
