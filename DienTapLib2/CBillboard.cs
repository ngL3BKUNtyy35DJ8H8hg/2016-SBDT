using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
namespace DienTapLib
{
    public class CBillboard : CActObj
    {
        private int m_frame;
        private int m_frameMax;
        private bool bAnimated;
        private CBillboardMesh m_BillboardMesh;
        protected CTerrainMesh myTerrain;
        private int m_currrow;
        public Mesh mesh
        {
            get
            {
                return this.m_BillboardMesh.mesh;
            }
        }
        public CBillboardMesh BillboardMesh
        {
            get
            {
                return this.m_BillboardMesh;
            }
        }
        public float Z
        {
            get
            {
                return this.Position.Z;
            }
            set
            {
                this.Position.Z = value;
            }
        }
        public CBillboard(CTerrainMesh pTerrain, string pName, Device device, CBillboardMesh pBillboardMesh, Vector3 position, float pAngleZ)
        {
            this.visible = true;
            this.m_frame = 0;
            this.Name = pName;
            this.m_BillboardMesh = pBillboardMesh;
            this.m_frameMax = this.m_BillboardMesh.GetFrameMax();
            this.myTerrain = pTerrain;
            this.Position = position;
            this.angleZ = pAngleZ;
            this.m_currrow = 0;
        }
        public void SetAnimation(bool pAnimated)
        {
            this.bAnimated = pAnimated;
        }
        public void Render(CThucHanh pThucHanh, Matrix pTerrainMatrix, float pAngleZ)
        {
            this.UpdateDirection(pThucHanh);
            this.m_frame++;
            if (this.m_frame > this.m_frameMax)
            {
                this.m_frame = 0;
            }
            int texIndex = this.GetTexIndex(this.m_frame);
            float angle = -pAngleZ;
            this.myTerrain.device.Transform.World = Matrix.RotationZ(angle) * Matrix.Translation(this.Position.X, this.Position.Y, this.Position.Z - this.m_BillboardMesh.ShiftZ) * pTerrainMatrix;
            this.m_BillboardMesh.Render(texIndex);
        }
        public void Render(CTerrain pTerrain, Matrix pTerrainMatrix, float pAngleZ)
        {
            this.UpdateDirection(pTerrain);
            this.m_frame++;
            if (this.m_frame > this.m_frameMax)
            {
                this.m_frame = 0;
            }
            int texIndex = this.GetTexIndex(this.m_frame);
            float angle = -pAngleZ;
            this.myTerrain.device.Transform.World = Matrix.RotationZ(angle) * Matrix.Translation(this.Position.X, this.Position.Y, this.Position.Z - this.m_BillboardMesh.ShiftZ) * pTerrainMatrix;
            this.m_BillboardMesh.Render(texIndex);
        }
        public void Render(Matrix pTerrainMatrix, float pAngleZ)
        {
            this.m_frame++;
            if (this.m_frame > this.m_frameMax)
            {
                this.m_frame = 0;
            }
            int texIndex = this.GetTexIndex(this.m_frame);
            float angle = -pAngleZ;
            this.myTerrain.device.Transform.World = Matrix.RotationZ(angle) * Matrix.Translation(this.Position.X, this.Position.Y, this.Position.Z - this.m_BillboardMesh.ShiftZ) * pTerrainMatrix;
            this.m_BillboardMesh.Render(texIndex);
        }
        private int GetTexIndex(int pFrame)
        {
            int num = 0;
            if (this.bAnimated && this.m_BillboardMesh.cols > 1)
            {
                int num2 = pFrame % (this.m_BillboardMesh.delay * this.m_BillboardMesh.cols);
                num = (int)Math.Floor((double)num2 / (double)this.m_BillboardMesh.delay);
            }
            return this.m_currrow * this.m_BillboardMesh.cols + num;
        }
        private void SetCurrRow(int prow)
        {
            if (prow >= 0 && prow < this.m_BillboardMesh.rows)
            {
                this.m_currrow = prow;
            }
        }
        private void UpdateDirection(float mAngleZ)
        {
            if (mAngleZ > 3.14159274f)
            {
                mAngleZ -= 6.28318548f;
            }
            if (mAngleZ < -3.14159274f)
            {
                mAngleZ += 6.28318548f;
            }
            if (mAngleZ >= -0.3926991f && mAngleZ < 0.3926991f)
            {
                int rows = this.m_BillboardMesh.rows;
                switch (rows)
                {
                    case 2:
                        this.SetCurrRow(0);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(0);
                        return;
                    default:
                        if (rows != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(0);
                        return;
                }
            }
            else if (mAngleZ >= 0.3926991f && mAngleZ < 1.17809725f)
            {
                int rows2 = this.m_BillboardMesh.rows;
                switch (rows2)
                {
                    case 2:
                        this.SetCurrRow(0);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(0);
                        return;
                    default:
                        if (rows2 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(1);
                        return;
                }
            }
            else if (mAngleZ >= 1.17809725f && mAngleZ < 1.96349549f)
            {
                int rows3 = this.m_BillboardMesh.rows;
                switch (rows3)
                {
                    case 2:
                        this.SetCurrRow(0);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(1);
                        return;
                    default:
                        if (rows3 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(2);
                        return;
                }
            }
            else if (mAngleZ >= 1.96349549f && mAngleZ < 2.74889374f)
            {
                int rows4 = this.m_BillboardMesh.rows;
                switch (rows4)
                {
                    case 2:
                        this.SetCurrRow(0);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(1);
                        return;
                    default:
                        if (rows4 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(3);
                        return;
                }
            }
            else if (mAngleZ >= 2.74889374f && mAngleZ < 3.53429174f)
            {
                int rows5 = this.m_BillboardMesh.rows;
                switch (rows5)
                {
                    case 2:
                        this.SetCurrRow(1);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(2);
                        return;
                    default:
                        if (rows5 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(4);
                        return;
                }
            }
            else if (mAngleZ >= -2.74889374f && mAngleZ < -1.96349549f)
            {
                int rows6 = this.m_BillboardMesh.rows;
                switch (rows6)
                {
                    case 2:
                        this.SetCurrRow(1);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(2);
                        return;
                    default:
                        if (rows6 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(5);
                        return;
                }
            }
            else if (mAngleZ >= -1.96349549f && mAngleZ < -1.17809725f)
            {
                int rows7 = this.m_BillboardMesh.rows;
                switch (rows7)
                {
                    case 2:
                        this.SetCurrRow(1);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(3);
                        return;
                    default:
                        if (rows7 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(6);
                        return;
                }
            }
            else if (mAngleZ >= -1.17809725f && mAngleZ < -0.3926991f)
            {
                int rows8 = this.m_BillboardMesh.rows;
                switch (rows8)
                {
                    case 2:
                        this.SetCurrRow(1);
                        return;
                    case 3:
                        break;
                    case 4:
                        this.SetCurrRow(3);
                        return;
                    default:
                        if (rows8 != 8)
                        {
                            return;
                        }
                        this.SetCurrRow(7);
                        break;
                }
            }
        }
        private void UpdateDirection(CThucHanh pThucHanh)
        {
            float num = this.angleZ + 1.57079637f;
            num += pThucHanh.getAngleZ();
            CAct.NormAngle(ref num);
            this.UpdateDirection(num);
        }
        private void UpdateDirection(CTerrain pTerrain)
        {
            float num = this.angleZ + 1.57079637f;
            num += pTerrain.GetAngleZ();
            this.UpdateDirection(num);
        }
        public void UpdateDirection(CThucHanh pThucHanh, float pAngleZ)
        {
            float num = pAngleZ + 1.57079637f;
            num += pThucHanh.getAngleZ();
            CAct.NormAngle(ref num);
            this.UpdateDirection(num);
        }
    }
}
