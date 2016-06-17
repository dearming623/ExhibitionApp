using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MoveableListLib
{
    public partial class MoveableList : UserControl
    {
        //存储菜单项
        public ArrayList arrList = new ArrayList();

        //最大数目
        // private int max =10;
        //单元数目
        // private int unit = 10;

        public static int ITEM_LOCATION_X = 0;

        public MoveableList()
        {
            InitializeComponent();       
            //初始化
            //initListContent(); 
        }
        
        /// <summary>
        /// 加载新数据
        /// </summary>
        /// <param name="lastPosition">最后一条记录的位置</param>
        public void loadNewData(int lastPosition)
        {
            int currentSize =this.Controls.Count;
            for (int i = 0; i < arrList.Count; i++)
            {
                MListItem item = (MListItem)arrList[i];
                item.Location = new Point(ITEM_LOCATION_X, item.Height *i + lastPosition);
                this.Controls.Add(item);
            }
        }
        /// <summary>
        /// 是否还存在其他数据
        /// </summary>
        /// <returns></returns>
        public bool existOtherData()
        {
            //if (this.Controls.Count <= arrList.Count)
            //    return true;
            return false;
        }



        public void loadItemList(ArrayList lst)
        {
            arrList = lst;

            this.Controls.Clear();

            int i = 0;
            foreach (MListItem item in lst)
            {
                item.Location = new Point(ITEM_LOCATION_X, item.Height * i);
               
                this.Controls.Add(item);
                i++;
            }

           
        }

        public void setAllSelection(bool v)
        {
            foreach (var item in this.Controls)
            {
                MListItem render = (MListItem) item;
                render.setSelection(v);
            }
        }
    }

}
