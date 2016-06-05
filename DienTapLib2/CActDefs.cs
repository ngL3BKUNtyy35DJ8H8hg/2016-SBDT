using Microsoft.DirectX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
namespace DienTapLib
{
    public class CActDefs
    {
        public static List<CActDef> ReadActionDef(string pFileName)
        {
            List<CActDef> result;
            if (pFileName.Length > 0)
            {
                XmlTextReader xmlTextReader = new XmlTextReader(pFileName);
                try
                {
                    result = CActDefs.XML2ActionDefs(xmlTextReader);
                }
                catch
                {
                    result = new List<CActDef>();
                }
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
            }
            else
            {
                result = new List<CActDef>();
            }
            return result;
        }
        private static List<CActDef> XML2ActionDefs(XmlTextReader rr)
        {
            List<CActDef> list = new List<CActDef>();
            List<Vector3> list2 = new List<Vector3>();
            Vector3 vector = new Vector3(0f, 0f, 0f);
            Vector3 pFromPos = new Vector3(0f, 0f, 0f);
            string text = "";
            string text2 = "Blink";
            string texfile = "";
            string text3 = "";
            string psoundname = "";
            string pstart = "0";
            int prepeat = 0;
            int psteps = 10;
            float ppartial = 1f;
            float pCenterX = 0.5f;
            float pCenterY = 0.5f;
            Vector3 pcameraPos = new Vector3(0f, 0f, 0f);
            float pangleZ = 0f;
            float pangleX = 0f;
            string pCornerText = "";
            string pDescText = "";
            DescPos pPos = DescPos.Duoi;
            bool pSaBanHide = false;
            float num = -45f;
            float pspeed = 0f;
            float valueX = 0f;
            float valueY = 0f;
            float valueZ = 0f;
            int num2 = 0;
            string text4 = "";
            string pduration = "0";
            float num3 = 0f;
            float num4 = 0f;
            float pshiftZ = 0f;
            bool pstophide = false;
            float pstopangleZ = 0f;
            while (rr.Read())
            {
                XmlNodeType nodeType = rr.NodeType;
                XmlNodeType xmlNodeType = nodeType;
                string name2;
                if (xmlNodeType != XmlNodeType.Element)
                {
                    if (xmlNodeType == XmlNodeType.EndElement)
                    {
                        string name;
                        if ((name = rr.Name) != null)
                        {
                            if (!(name == "Target"))
                            {
                                if (!(name == "From"))
                                {
                                    if (!(name == "Targets"))
                                    {
                                        if (name == "Action")
                                        {
                                            bool loop = false;
                                            string key;
                                            switch (key = text2)
                                            {
                                                case "Blink":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CBlinkDef(text2, text, text3, pstart, pduration, pspeed, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Explode":
                                                    {
                                                        if (num3 == 0f)
                                                        {
                                                            num3 = 3f;
                                                        }
                                                        if (num4 == 0f)
                                                        {
                                                            num4 = 3f;
                                                        }
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item;
                                                        if (text3.Length == 0)
                                                        {
                                                            item = new CExplodeObjDef(text2, text, texfile, num3, num4, pshiftZ, pstart, pduration, pspeed, vector, psoundname, loop);
                                                        }
                                                        else
                                                        {
                                                            item = new CExplodeObjDef(text2, text, texfile, num3, num4, pshiftZ, pstart, pduration, pspeed, text3, psoundname, loop);
                                                        }
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "ExplodeDcl":
                                                    {
                                                        if (num3 == 0f)
                                                        {
                                                            num3 = 3f;
                                                        }
                                                        if (num4 == 0f)
                                                        {
                                                            num4 = 3f;
                                                        }
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CExplodeDclDef(text2, text, texfile, num3, num4, pshiftZ, pduration, pspeed, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Bombard":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        if (num3 == 0f)
                                                        {
                                                            num3 = 0.5f;
                                                        }
                                                        if (num4 == 0f)
                                                        {
                                                            num4 = 1.5f;
                                                        }
                                                        CActDef item;
                                                        if (text3.Length == 0)
                                                        {
                                                            item = new CBombardFromDef(text2, text, texfile, num3, num4, pstart, pduration, pspeed, num, pFromPos, vector, psoundname, loop, text4, prepeat);
                                                        }
                                                        else
                                                        {
                                                            item = new CBombardFromDef(text2, text, texfile, num3, num4, pstart, pduration, pspeed, num, text3, vector, psoundname, loop, text4, prepeat);
                                                        }
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Shoot":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        if (num3 == 0f)
                                                        {
                                                            num3 = 0.5f;
                                                        }
                                                        if (num4 == 0f)
                                                        {
                                                            num4 = 1.5f;
                                                        }
                                                        CActDef item;
                                                        if (text3.Length == 0)
                                                        {
                                                            item = new CShootFromDef(text2, text, texfile, num3, num4, pstart, pduration, pspeed, pFromPos, vector, psoundname, loop, text4, prepeat);
                                                        }
                                                        else
                                                        {
                                                            item = new CShootFromDef(text2, text, texfile, num3, num4, pstart, pduration, pspeed, text3, vector, psoundname, loop, text4, prepeat);
                                                        }
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Hide":
                                                case "Unhide":
                                                case "DisappearA":
                                                case "DisappearUp":
                                                case "DisappearDown":
                                                case "DisappearLeft":
                                                case "Disappear":
                                                case "AppearA":
                                                case "AppearUp":
                                                case "AppearDown":
                                                case "AppearLeft":
                                                case "Appear":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CAppearDef(text2, text, text3, pstart, pduration, psteps, ppartial, pstophide, psoundname, loop, prepeat);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Spin":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CSpinDef(text2, text, text3, pstart, pduration, num, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "SpinTo":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CSpinToDef(text2, text, text3, pstart, pduration, vector, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Fly":
                                                case "Move":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CMoveObjDef(text2, text, text3, pstart, pduration, pstophide, pstopangleZ, list2, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "FocusAt":
                                                    {
                                                        CActDef item = new CFocusAtDef(text2, text, pstart, pduration, pCenterX, pCenterY, pcameraPos, pangleZ, pangleX);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "CornerTitle":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                        }
                                                        CActDef item = new CCornerTitleDef(text2, text, pstart, pduration, pCornerText);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Description":
                                                    {
                                                        if (num2 == 1)
                                                        {
                                                            loop = true;
                                                        }
                                                        CActDef item = new CDescriptionDef(text2, text, pstart, pduration, pDescText, pPos, pSaBanHide, psoundname, loop);
                                                        list.Add(item);
                                                        break;
                                                    }
                                                case "Comment":
                                                    {
                                                        CActDef item = new CCommentDef(text);
                                                        list.Add(item);
                                                        break;
                                                    }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    pFromPos = new Vector3(valueX, valueY, valueZ);
                                }
                            }
                            else
                            {
                                vector = new Vector3(valueX, valueY, valueZ);
                                list2.Add(vector);
                            }
                        }
                    }
                }
                else if ((name2 = rr.Name) != null && !(name2 == "Actions"))
                {
                    if (!(name2 == "Action"))
                    {
                        if (!(name2 == "Targets"))
                        {
                            if (!(name2 == "Target"))
                            {
                                if (name2 == "From")
                                {
                                    if (rr.AttributeCount > 0)
                                    {
                                        while (rr.MoveToNextAttribute())
                                        {
                                            string name3;
                                            if ((name3 = rr.Name) != null)
                                            {
                                                if (!(name3 == "X"))
                                                {
                                                    if (!(name3 == "Y"))
                                                    {
                                                        if (name3 == "Z")
                                                        {
                                                            valueZ = CHelper.myToSingle(rr.Value);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        valueY = CHelper.myToSingle(rr.Value);
                                                    }
                                                }
                                                else
                                                {
                                                    valueX = CHelper.myToSingle(rr.Value);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (rr.AttributeCount > 0)
                            {
                                while (rr.MoveToNextAttribute())
                                {
                                    string name4;
                                    if ((name4 = rr.Name) != null)
                                    {
                                        if (!(name4 == "X"))
                                        {
                                            if (!(name4 == "Y"))
                                            {
                                                if (name4 == "Z")
                                                {
                                                    valueZ = CHelper.myToSingle(rr.Value);
                                                }
                                            }
                                            else
                                            {
                                                valueY = CHelper.myToSingle(rr.Value);
                                            }
                                        }
                                        else
                                        {
                                            valueX = CHelper.myToSingle(rr.Value);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            list2.Clear();
                        }
                    }
                    else
                    {
                        text = "";
                        num2 = 0;
                        text3 = "";
                        num3 = 0f;
                        num4 = 0f;
                        pduration = "0";
                        psoundname = "";
                        psteps = 10;
                        ppartial = 1f;
                        prepeat = 1;
                        num = -45f;
                        pCenterX = 0.5f;
                        pCenterY = 0.5f;
                        pcameraPos = new Vector3(0f, 0f, 0f);
                        pangleZ = 0f;
                        pangleX = 0f;
                        pCornerText = "";
                        pDescText = "";
                        pPos = DescPos.Duoi;
                        pSaBanHide = false;
                        pshiftZ = 0f;
                        pstophide = false;
                        pstopangleZ = 0f;
                        text4 = "";
                        if (rr.AttributeCount > 0)
                        {
                            while (rr.MoveToNextAttribute())
                            {
                                string name5;
                                switch (name5 = rr.Name)
                                {
                                    case "ID":
                                        text = rr.Value;
                                        break;
                                    case "Type":
                                        text2 = rr.Value;
                                        break;
                                    case "ImageFile":
                                        texfile = rr.Value;
                                        break;
                                    case "Obj":
                                        Convert.ToInt32(rr.Value);
                                        break;
                                    case "ObjName":
                                        text3 = rr.Value;
                                        break;
                                    case "Start":
                                        pstart = rr.Value;
                                        break;
                                    case "Repeat":
                                        prepeat = Convert.ToInt32(rr.Value);
                                        break;
                                    case "Duration":
                                        pduration = rr.Value;
                                        break;
                                    case "Delay":
                                        CHelper.myToSingle(rr.Value);
                                        break;
                                    case "Steps":
                                        psteps = Convert.ToInt32(rr.Value);
                                        break;
                                    case "Speed":
                                        pspeed = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "Partial":
                                        ppartial = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "CanAjust":
                                        Convert.ToBoolean(rr.Value);
                                        break;
                                    case "dAngle":
                                        num = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "CenterX":
                                        pCenterX = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "CenterY":
                                        pCenterY = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "cameraPosX":
                                        pcameraPos.X = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "cameraPosY":
                                        pcameraPos.Y = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "cameraPosZ":
                                        pcameraPos.Z = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "angleZ":
                                        pangleZ = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "angleX":
                                        pangleX = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "CornerText":
                                        pCornerText = rr.Value;
                                        break;
                                    case "DescText":
                                        pDescText = rr.Value;
                                        break;
                                    case "Pos":
                                        pPos = ((rr.Value == "Tren") ? DescPos.Tren : ((rr.Value == "Giua") ? DescPos.Giua : DescPos.Duoi));
                                        break;
                                    case "SaBanHide":
                                        pSaBanHide = Convert.ToBoolean(rr.Value);
                                        break;
                                    case "GravityZ":
                                        CHelper.myToSingle(rr.Value);
                                        break;
                                    case "Degree":
                                        CHelper.myToSingle(rr.Value);
                                        break;
                                    case "SoundName":
                                        psoundname = rr.Value;
                                        break;
                                    case "iSound":
                                        Convert.ToInt32(rr.Value);
                                        break;
                                    case "SoundLoop":
                                        num2 = Convert.ToInt32(rr.Value);
                                        break;
                                    case "Width":
                                        num3 = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "Height":
                                        num4 = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "ShiftZ":
                                        pshiftZ = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "Hide":
                                        pstophide = Convert.ToBoolean(rr.Value);
                                        break;
                                    case "StopAngleZ":
                                        pstopangleZ = CHelper.myToSingle(rr.Value);
                                        break;
                                    case "ExplID":
                                        text4 = rr.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return list;
        }
        public static void WriteActionDef(List<CActDef> actiondefs, string pFileName)
        {
            string text = "<Actions>\r\n";
            foreach (CActDef current in actiondefs)
            {
                text += current.GetActionStr();
            }
            text += "</Actions>";
            using (StreamWriter streamWriter = new StreamWriter(pFileName))
            {
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }
        public static List<Vector3> ReadTargets(string pTargetStr)
        {
            List<Vector3> result = new List<Vector3>();
            NameTable nameTable = new NameTable();
            XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(nameTable);
            xmlNamespaceManager.AddNamespace("bk", "urn:sample");
            XmlParserContext context = new XmlParserContext(null, xmlNamespaceManager, null, XmlSpace.None);
            XmlTextReader xmlTextReader = new XmlTextReader(pTargetStr, XmlNodeType.Element, context);
            try
            {
                result = CActDefs.XML2Targets(xmlTextReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (xmlTextReader != null)
            {
                xmlTextReader.Close();
            }
            return result;
        }
        private static List<Vector3> XML2Targets(XmlTextReader rr)
        {
            List<Vector3> list = new List<Vector3>();
            Vector3 item = new Vector3(0f, 0f, 0f);
            float valueX = 0f;
            float valueY = 0f;
            float valueZ = 0f;
            while (rr.Read())
            {
                XmlNodeType nodeType = rr.NodeType;
                XmlNodeType xmlNodeType = nodeType;
                string name2;
                if (xmlNodeType != XmlNodeType.Element)
                {
                    if (xmlNodeType == XmlNodeType.EndElement)
                    {
                        string name;
                        if ((name = rr.Name) != null)
                        {
                            if (!(name == "Target"))
                            {
                                if (!(name == "Targets"))
                                {
                                }
                            }
                            else
                            {
                                item = new Vector3(valueX, valueY, valueZ);
                                list.Add(item);
                            }
                        }
                    }
                }
                else if ((name2 = rr.Name) != null)
                {
                    if (!(name2 == "Targets"))
                    {
                        if (name2 == "Target")
                        {
                            if (rr.AttributeCount > 0)
                            {
                                while (rr.MoveToNextAttribute())
                                {
                                    string name3;
                                    if ((name3 = rr.Name) != null)
                                    {
                                        if (!(name3 == "X"))
                                        {
                                            if (!(name3 == "Y"))
                                            {
                                                if (name3 == "Z")
                                                {
                                                    valueZ = CHelper.myToSingle(rr.Value);
                                                }
                                            }
                                            else
                                            {
                                                valueY = CHelper.myToSingle(rr.Value);
                                            }
                                        }
                                        else
                                        {
                                            valueX = CHelper.myToSingle(rr.Value);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        list.Clear();
                    }
                }
            }
            return list;
        }
    }
}
