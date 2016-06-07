using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    class MyAppSetting
    {
        public Dictionary<string, string> config = new Dictionary<string, string>();

        public DateTime ShutDownTime;

        public static string TIME_OF_SHUTDOWN = "TimeOfShutdown";
        public static string PATH_OF_SLIDE = "PathOfSlide";
        public static string PATH_OF_VIDEO = "PahtOfVideo";
        public static string PWD_OF_LOGOUT = "PasswordOfLogout";

        public void Load()
        {
            config.Clear();

            DataSet source_ds = SQLiteDBHelper.Query("SELECT * FROM t_config WHERE 1=1 ");

            if (source_ds.Tables.Count > 0)
            {
                for (int i = 0; i < source_ds.Tables[0].Rows.Count; i++)
                {
                    string key = source_ds.Tables[0].Rows[i]["key"].ToString();
                    string value = source_ds.Tables[0].Rows[i]["value"].ToString();
                    config.Add(key, value);
                }
            }

           
            string[] arr  = GetTimeOfShutDown().Split(':');
            if (arr != null && arr.Length == 2) 
            {
                DateTime mid1 = DateTime.Now;
                mid1 = new DateTime(mid1.Year, mid1.Month, mid1.Day, Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), 0, 0);
                ShutDownTime = mid1;
            }
        }

        public void SavePwd(string new_pwd)
        {
            update(PWD_OF_LOGOUT, new_pwd);
        }

        public void update(string key ,string value)
        {
            int affected = 0;
            string err = "";
            try
            {
                affected = SQLiteDBHelper.ExecuteSql("INSERT OR REPLACE INTO t_config ( key,value) VALUES ( '" + key + "', '" + value + "')");
            }
            catch (Exception ex)
            {
               err =  ex.ToString();
            }

            if (affected <= 0)
            {
                MessageBox.Show("更新失败!\n" + err);
            }else
            {
                if (this.config.ContainsKey(key))
                {
                    config[key] = value;
                }
                else
                {
                    config.Add(key, value);
                }
            }
          
        }

        public string GetValue(string key)
        {
            return config[key];
        }

        public void SaveShutDownTime(int min,int sec)
        {
            DateTime mid1 = DateTime.Now;
            mid1 = new DateTime(mid1.Year, mid1.Month, mid1.Day, mid1.Hour, min, sec, 0);
            ShutDownTime = mid1;

            string t = Convert.ToString(min) + ":" + Convert.ToString(sec);
      
            update(TIME_OF_SHUTDOWN, t);
        }
        public void SavePathOfSlide(string path)
        {

            update(PATH_OF_SLIDE, path);
        }

        public void SavePathOfVideo(string path)
        {
    
            update(PATH_OF_VIDEO, path);
        }
        

        public string GetPathOfSlide()
        {
            return config[PATH_OF_SLIDE];
        }
        
        public string GetPathOfVideo()
        {
            return config[PATH_OF_VIDEO];
        }

        public string GetPassWordOfLogout()
        {
            return config[PWD_OF_LOGOUT];
        }

        public string GetTimeOfShutDown()
        {
            return config[TIME_OF_SHUTDOWN];
        }

        public int DeleteLink(string name)
        {
          return SQLiteDBHelper.ExecuteSql("DELETE FROM t_company_link WHERE name='" + name +"' ");
           
           
        }

        public List<MyLink> GetCompanyLinks()
        {
            List<MyLink> lst = new List<MyLink>();

            DataSet source_ds = SQLiteDBHelper.Query("SELECT * FROM t_company_link WHERE 1=1 ");

            if (source_ds.Tables.Count > 0)
            {
                for (int i = 0; i < source_ds.Tables[0].Rows.Count; i++)
                {
                    MyLink link = new MyLink();
                    link.websiteName = source_ds.Tables[0].Rows[i]["name"].ToString();
                    link.url = source_ds.Tables[0].Rows[i]["link"].ToString();
                    lst.Add(link);
                }
            }

            return lst;
        }

        public DataTable GetCompanyLinks2()
        {
            DataTable dt = null;

            DataSet source_ds = SQLiteDBHelper.Query("SELECT * FROM t_company_link WHERE 1=1 ");

            if (source_ds.Tables.Count > 0)
            {
                dt = source_ds.Tables[0];
            }

            return dt;
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
