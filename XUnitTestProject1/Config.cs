using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
   public class Config
    {

        public int MyProperty { get; set; }

        public Config()
        {
            SauceOptionsToBind = new SauceOptions();
        }





     public   SauceOptions SauceOptionsToBind { get; set; }
      



    }


    public class SauceOptions
    {


        public SauceOptions()
        {
            MyDic = new Dictionary<string, object>();
        }


        public Dictionary<string,object> MyDic { get;  }


        private object GetValue(string key)
        {
            if (!MyDic.ContainsKey(key))
            {
                MyDic.Add(key, null);


            }



            return MyDic[key];

           
        }


        private void SetValue(string key, object value)
        {

            if (!MyDic.ContainsKey(key))
            {
                MyDic.Add(key, null);


            }

             MyDic[key] = value;

        }






        public object Prop1
        {

            get => GetValue("Prop1");
            set => SetValue("Prop1", value);
        }

        public object Prop2
        {

            get => GetValue("Prop2");
            set => SetValue("Prop2", value);
        }



        public object Prop3
        {

            get => GetValue("Prop3");
            set => SetValue("Prop3", value);
        }
        public object Prop4
        {

            get => GetValue("Prop4");
            set => SetValue("Prop4", value);
        }



    }



}




