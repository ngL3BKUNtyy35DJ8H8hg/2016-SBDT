using DBiGraphicObjs.DBiGraphicObjects;
using System;

namespace SaBan
{
    public class CFOUNDNODE
    {
        private GraphicObject m_FoundObject;

        private int m_NodeIndex;

        public GraphicObject FoundObject
        {
            get
            {
                return this.m_FoundObject;
            }
            set
            {
                this.m_FoundObject = value;
            }
        }

        public int NodeIndex
        {
            get
            {
                return this.m_NodeIndex;
            }
            set
            {
                this.m_NodeIndex = value;
            }
        }
    }
}
