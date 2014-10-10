using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    class hnf_type
    {
        private int _type_id;

        public int Type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }
        private string _type_name;

        public string Type_name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }
        private string _type_image;

        public string Type_image
        {
            get { return _type_image; }
            set { _type_image = value; }
        }
        private string _type_isimage;

        public string Type_isimage
        {
            get { return _type_isimage; }
            set { _type_isimage = value; }
        }
        private string _type_isshow;

        public string Type_isshow
        {
            get { return _type_isshow; }
            set { _type_isshow = value; }
        }
        private string _type_recommand;

        public string Type_recommand
        {
            get { return _type_recommand; }
            set { _type_recommand = value; }
        }
    }
}
