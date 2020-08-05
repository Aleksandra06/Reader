using System;
using Reader.ReaderDb.Model;

namespace Reader.Web.PageModel
{
    public class AuthorItemViewModel : ICloneable
    {
        private AuthorModel mItem;
        public AuthorModel Item => mItem;
        public AuthorItemViewModel()
        {
            mItem = new AuthorModel();
        }
        public AuthorItemViewModel(AuthorModel item)
        {
            mItem = item;
        }

        public int AuthorId
        {
            get
            {
                return mItem.AuthorId;
            }
            set
            {
                mItem.AuthorId = value;
            }
        }
        public string Name
        {
            get
            {
                return mItem.Name;
            }
            set
            {
                mItem.Name = value;
            }
        }
        public DateTime InsertDate
        {
            get
            {
                return mItem.InsertDate;
            }
            set
            {
                mItem.InsertDate = value;
            }
        }
        public string Nickname
        {
            get
            {
                return mItem.Nickname;
            }
            set
            {
                mItem.Nickname = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return mItem.BirthDay;
            }
            set
            {
                mItem.BirthDay = value;
            }
        }
        public DateTime DeathDay
        {
            get
            {
                return mItem.DeathDay;
            }
            set
            {
                mItem.DeathDay = value;
            }
        }
        public int Time
        {
            get
            {
                return mItem.Time;
            }
            set
            {
                mItem.Time = value;
            }
        }

        public object Clone()
        {
            AuthorItemViewModel tempObject = (AuthorItemViewModel)this.MemberwiseClone();
            tempObject.mItem = (AuthorModel)mItem.Clone();
            return tempObject;
        }
    }
}
