using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExhibitionApp
{
    class MyAppSetting
    {
        public  DateTime ShutDownTime;
        

        public void Load()
        {

        }


        private static MyAppSetting instance;

        private MyAppSetting()
        {

        }

        public static MyAppSetting GetInstance()
        {
            if (instance == null)
            {
                instance = new MyAppSetting();
            }
            return instance;
        }
    }
}
