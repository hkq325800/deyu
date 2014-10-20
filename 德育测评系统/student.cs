using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoralEvaluated
{
    class student
    {
        private int us_id;                  //学号
        public int Us_id
        {
            get
            {
                return this.us_id;
            }
            set
            {
                this.us_id = value;
            }
        }
        private int cl_id;                  //班级
        public int Cl_id
        {
            get
            {
                return this.cl_id;
            }
            set
            {
                this.cl_id = value;
            }
        }
        private int st_job;                 //职务
        public int St_job
        {
            get
            {
                return this.st_job;
            }
            set
            {
                this.st_job = value;
            }
        }
        private int st_part;                //政治面貌
        public int St_part
        {
            get
            {
                return this.st_part;
            }
            set
            {
                this.st_part = value;
            }
        }
        private int st_dormitory;               //寝室
        public int St_dormitory
        {
            get
            {
                return this.st_dormitory;
            }
            set
            {
                this.st_dormitory = value;
            }
        }
    }
}
