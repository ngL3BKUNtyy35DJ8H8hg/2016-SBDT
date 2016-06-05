using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
    internal class CBombard : CAct
    {
        protected CSpriteObj SpriteObj;
        protected float speed;
        private float dAngle = -45f;
        protected Vector3 topos;
        protected Vector3 frompos;
        protected CActObj fromObj;
        protected List<CTarget> targets;
        protected int itarget;
        protected int targetsCount;
        protected int interval;
        protected int itime;
        protected int lasttime;
        private float rAngle;
        public CBombard(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, float pdAngle, Vector3 pFromPos, Vector3 pTo, int pisound, bool loop)
            : base(pThucHanh)
        {
            this.Name = pName;
            this.frompos = pFromPos;
            this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 0, this.frompos, 0f);
            this.topos = pTo;
            if (this.topos.Z == 0f)
            {
                this.topos.Z = this.myThucHanh.myTerrain.getZ(this.topos.X, this.topos.Y);
            }
            this.StartTickCount = start;
            this.duration = pduration;
            this.speed = pspeed;
            this.interval = (int)(this.speed * 1000f);
            this.dAngle = pdAngle;
            this.rAngle = Geometry.DegreeToRadian(this.dAngle);
            this.StopTickCount = this.StartTickCount + this.duration;
            this.Calc1();
            this.isound = pisound;
            this.soundloop = loop;
        }
        public CBombard(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, float pdAngle, CActObj pFromObj, Vector3 pTo, int pisound, bool loop)
            : base(pThucHanh)
        {
            try
            {
                this.Name = pName;
                this.fromObj = pFromObj;
                this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 0, this.fromObj.Position, 0f);
                this.topos = pTo;
                if (this.topos.Z == 0f)
                {
                    this.topos.Z = this.myThucHanh.myTerrain.getZ(this.topos.X, this.topos.Y);
                }
                this.StartTickCount = start;
                this.duration = pduration;
                this.speed = pspeed;
                this.interval = (int)(this.speed * 1000f);
                this.dAngle = pdAngle;
                this.rAngle = Geometry.DegreeToRadian(this.dAngle);
                this.StopTickCount = this.StartTickCount + this.duration;
                this.isound = pisound;
                this.soundloop = loop;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override object Clone()
        {
            return base.MemberwiseClone();
        }
        public override void Reset()
        {
            this.done = false;
            this.SpriteObj.visible = false;
            this.started = false;
        }
        public override void Stop()
        {
            this.SpriteObj.visible = false;
            base.endaction();
        }
        protected virtual void setfrompos()
        {
            if (this.fromObj != null)
            {
                this.frompos = this.fromObj.Position;
                if (this.fromObj.ObjType == "Model" && this.frompos.Z > -5f)
                {
                    this.frompos.Z = this.frompos.Z - 1f;
                }
            }
            if (this.frompos.Z == 0f)
            {
                this.frompos.Z = this.myThucHanh.myTerrain.getZ(this.frompos.X, this.frompos.Y);
            }
        }
        protected virtual void Calc1()
        {
            this.setfrompos();
            this.GetOrbit(this.frompos, this.topos);
            this.itarget = 0;
        }
        private void GetOrbit(Vector3 pFrom, Vector3 pTo)
        {
            Vector3 right = new Vector3(this.frompos.X, this.frompos.Y, this.topos.Z);
            Vector3 vector = this.topos - right;
            float num = vector.Length();
            float angleZ = CAct.GetAngleZ(vector);
            vector.Z = (float)Math.Tan((double)this.rAngle) * num;
            int num2 = (int)(this.topos - this.frompos).Length();
            this.targets = new List<CTarget>();
            double num3 = (double)(vector.Z - (pTo.Z - pFrom.Z));
            float valueZ = 0f;
            if (num2 > 0)
            {
                valueZ = -(float)(num3 * 2.0 / (double)(num2 * (num2 + 1)));
            }
            Vector3 vector2 = vector * (1f / (float)num2);
            Vector3 right2 = new Vector3(0f, 0f, valueZ);
            Vector3 vector3 = pFrom;
            CTarget cTarget = new CTarget();
            cTarget.Position = vector3;
            cTarget.TickCount = 0;
            cTarget.angleZ = angleZ;
            cTarget.angleX = CAct.GetAngleX(vector2);
            this.targets.Add(cTarget);
            if (num2 > 1)
            {
                float num4 = 0f;
                for (int i = 1; i < num2; i++)
                {
                    vector2 += right2;
                    vector3 += vector2;
                    cTarget = new CTarget();
                    cTarget.Position = vector3;
                    cTarget.angleZ = angleZ;
                    cTarget.angleX = CAct.GetAngleX(vector2);
                    this.targets.Add(cTarget);
                    this.targets[i].len = (this.targets[i].Position - this.targets[i - 1].Position).Length();
                    num4 += this.targets[i].len;
                }
                this.targetsCount = num2;
                float num5 = 0f;
                for (int j = 1; j < this.targetsCount; j++)
                {
                    num5 += this.targets[j].len;
                    if (num4 > 0f)
                    {
                        this.targets[j].TickCount = (int)(num5 * (float)this.interval / num4);
                    }
                    else
                    {
                        this.targets[j].TickCount = this.interval;
                    }
                }
                return;
            }
            cTarget = new CTarget();
            cTarget.Position = this.topos;
            cTarget.TickCount = 0;
            cTarget.angleZ = angleZ;
            cTarget.angleX = CAct.GetAngleX(vector2);
            this.targets.Add(cTarget);
        }
        protected int GetNextTargetIndex(int pTickCount)
        {
            int result = 0;
            for (int i = 0; i < this.targetsCount; i++)
            {
                if (this.targets[i].TickCount > pTickCount)
                {
                    result = i - 1;
                    break;
                }
            }
            return result;
        }
        protected virtual void UpdateStatus(Vector3 pPos, float pangleZ, float pangleX)
        {
            this.SpriteObj.Position = pPos;
            this.SpriteObj.angleZ = pangleZ;
            this.SpriteObj.angleX = pangleX;
        }
        public override void UpdateAct(int pTickCount)
        {
            if (this.started)
            {
                int num = pTickCount - this.StartTickCount;
                this.itime = this.GetNextTime(num);
                if (this.itime > this.lasttime)
                {
                    this.lasttime = this.itime;
                }
                int num2 = num % this.interval;
                this.SpriteObj.visible = true;
                this.itarget = this.GetNextTargetIndex(num2);
                double num3 = (double)(num2 - this.targets[this.itarget].TickCount) / (double)(this.targets[this.itarget + 1].TickCount - this.targets[this.itarget].TickCount);
                Vector3 left = this.targets[this.itarget + 1].Position - this.targets[this.itarget].Position;
                this.UpdateStatus(this.targets[this.itarget].Position + left * (float)num3, this.targets[this.itarget + 1].angleZ, this.targets[this.itarget + 1].angleX);
                return;
            }
            this.lasttime = 0;
            this.itarget = 0;
            this.started = true;
            this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
            this.SpriteObj.visible = true;
        }
        protected int GetNextTime(int currTickCount0)
        {
            int num = this.lasttime;
            while (!(currTickCount0 > num * this.interval & currTickCount0 <= (num + 1) * this.interval))
            {
                num++;
            }
            return num;
        }
    }
}
