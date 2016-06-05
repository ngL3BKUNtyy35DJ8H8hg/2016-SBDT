using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
    public class CMnu
    {
        protected CThucHanh myThucHanh;
        public List<CMnuItem> mnuItems;
        public List<CScript> scripts;
        public CMnu(CThucHanh pThucHanh)
        {
            this.myThucHanh = pThucHanh;
            this.mnuItems = new List<CMnuItem>();
            this.scripts = new List<CScript>();
        }
        public void LoadScripts(string pFileName)
        {
            try
            {
                this.mnuItems = CMnuDef.GetMnuItems(pFileName);
                this.scripts = new List<CScript>();
                foreach (CMnuItem current in this.mnuItems)
                {
                    foreach (CScriptDef current2 in current.ScriptDefs)
                    {
                        if (current2.scrptfile.Length > 0)
                        {
                            bool flag = false;
                            int count = this.scripts.Count;
                            for (int i = 0; i < count; i++)
                            {
                                if (current2.scrptfile == this.scripts[i].ScrptFile)
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                CScript cScript = new CScript(this.myThucHanh, current2.scrptfile);
                                cScript.StopTickCount = cScript.LoadActions();
                                this.scripts.Add(cScript);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Draw(Font pText, int pCurr)
        {
            int num = -1;
            foreach (CMnuItem current in this.mnuItems)
            {
                num++;
                if (num == pCurr)
                {
                    current.Draw(pText, this.myThucHanh.ActColor);
                }
                else
                {
                    current.Draw(pText, this.myThucHanh.NoActColor);
                }
            }
        }
        public int GetItemIndex(int pPosX, int pPosY, float tyleMH)
        {
            int result = -1;
            int num = -1;
            foreach (CMnuItem current in this.mnuItems)
            {
                num++;
                if (current.Hit(pPosX, pPosY, tyleMH))
                {
                    result = num;
                    break;
                }
            }
            return result;
        }
        public int GetTongHopItemIndex(string TongHopID)
        {
            int result = -1;
            int num = -1;
            foreach (CMnuItem current in this.mnuItems)
            {
                num++;
                if (current.id.Length > 0 && current.id == TongHopID)
                {
                    result = num;
                    break;
                }
            }
            return result;
        }
        private CMnuItem GetMnuItem(string pItemId)
        {
            CMnuItem result = null;
            foreach (CMnuItem current in this.mnuItems)
            {
                if (current.id.Length > 0 && current.id == pItemId)
                {
                    result = current;
                    break;
                }
            }
            return result;
        }
        private CScript GetScript(string pScrptfile)
        {
            CScript cScript = null;
            foreach (CScript current in this.scripts)
            {
                if (current.ScrptFile == pScrptfile)
                {
                    cScript = new CScript(current.myThucHanh, current.ScrptFile, current.StartTickCount, current.StopTickCount);
                    using (List<CAct>.Enumerator enumerator2 = current.acts.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            CAct current2 = enumerator2.Current;
                            CAct item = (CAct)current2.Clone();
                            cScript.acts.Add(item);
                        }
                        break;
                    }
                }
            }
            return cScript;
        }
        private void LoadActs(CMnuItem pMnuItem, ref CRunActs pRunActs)
        {
            int num = 0;
            int num2 = 0;
            List<CScriptDef> list = new List<CScriptDef>();
            foreach (CScriptDef current in pMnuItem.ScriptDefs)
            {
                if (current.scrptfile.Length > 0)
                {
                    CScript script = this.GetScript(current.scrptfile);
                    int start = this.GetStart(current.start, list);
                    script.UpdateStart(start);
                    foreach (CAct current2 in script.acts)
                    {
                        pRunActs.actions.Add(current2);
                    }
                    current.StartTickCount = script.StartTickCount;
                    current.StopTickCount = script.StopTickCount;
                    if (current.StartTickCount < num)
                    {
                        num = current.StartTickCount;
                    }
                    if (current.StopTickCount > num2)
                    {
                        num2 = current.StopTickCount;
                    }
                    if (num < pRunActs.StartTickCount)
                    {
                        pRunActs.StartTickCount = num;
                    }
                    if (num2 > pRunActs.StopTickCount)
                    {
                        pRunActs.StopTickCount = num2;
                    }
                    list.Add(current);
                }
                else if (current.mnuItemRef.Length > 0)
                {
                    CRunActs cRunActs = new CRunActs();
                    CMnuItem mnuItem = this.GetMnuItem(current.mnuItemRef);
                    if (mnuItem != null)
                    {
                        this.LoadActs(mnuItem, ref cRunActs);
                    }
                    int start2 = this.GetStart(current.start, list);
                    cRunActs.UpdateStart(start2);
                    foreach (CAct current3 in cRunActs.actions)
                    {
                        pRunActs.actions.Add(current3);
                    }
                    current.StartTickCount = cRunActs.StartTickCount;
                    current.StopTickCount = cRunActs.StopTickCount;
                    if (current.StartTickCount < num)
                    {
                        num = current.StartTickCount;
                    }
                    if (current.StopTickCount > num2)
                    {
                        num2 = current.StopTickCount;
                    }
                    if (num < pRunActs.StartTickCount)
                    {
                        pRunActs.StartTickCount = num;
                    }
                    if (num2 > pRunActs.StopTickCount)
                    {
                        pRunActs.StopTickCount = num2;
                    }
                    list.Add(current);
                }
            }
        }
        public CRunActs GetActs(int iItem)
        {
            CMnuItem pMnuItem = this.mnuItems[iItem];
            CRunActs result = new CRunActs();
            this.LoadActs(pMnuItem, ref result);
            return result;
        }
        private int GetStart(string startstr, List<CScriptDef> pScriptDefs)
        {
            int num = 0;
            if (startstr.ToLower().StartsWith("stop"))
            {
                int num2;
                int num3;
                if ((num2 = startstr.IndexOf("(")) > 0 && (num3 = startstr.IndexOf(")")) > 0 && num3 > num2 + 1)
                {
                    string text = startstr.Substring(num2 + 1, num3 - num2 - 1);
                    if (text.Length > 0)
                    {
                        num = this.GetScriptDefstop(text, pScriptDefs);
                    }
                }
                else if (pScriptDefs.Count > 0)
                {
                    num = pScriptDefs[pScriptDefs.Count - 1].StopTickCount;
                }
                else
                {
                    num = 0;
                }
                if ((num2 = startstr.IndexOf("+")) > 0)
                {
                    string strSingle = startstr.Substring(num2 + 1);
                    int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
                    num += num4;
                }
                if ((num2 = startstr.IndexOf("-")) > 0)
                {
                    string strSingle = startstr.Substring(num2 + 1);
                    int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
                    num -= num4;
                }
            }
            else if (startstr.ToLower().StartsWith("start"))
            {
                int num2;
                int num3;
                if ((num2 = startstr.IndexOf("(")) > 0 && (num3 = startstr.IndexOf(")")) > 0 && num3 > num2 + 1)
                {
                    string text = startstr.Substring(num2 + 1, num3 - num2 - 1);
                    if (text.Length > 0)
                    {
                        num = this.GetScriptDefstart(text, pScriptDefs);
                    }
                }
                else if (pScriptDefs.Count > 0)
                {
                    num = pScriptDefs[pScriptDefs.Count - 1].StartTickCount;
                }
                else
                {
                    num = 0;
                }
                if ((num2 = startstr.IndexOf("+")) > 0)
                {
                    string strSingle = startstr.Substring(num2 + 1);
                    int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
                    num += num4;
                }
                if ((num2 = startstr.IndexOf("-")) > 0)
                {
                    string strSingle = startstr.Substring(num2 + 1);
                    int num4 = (int)(CHelper.myToSingle(strSingle) * 1000f);
                    num -= num4;
                }
            }
            else
            {
                num = (int)(CHelper.myToSingle(startstr) * 1000f);
            }
            return num;
        }
        private int GetScriptDefstart(string name, List<CScriptDef> pScriptDefs)
        {
            int result = -1;
            bool flag = false;
            for (int i = pScriptDefs.Count - 1; i >= 0; i--)
            {
                CScriptDef cScriptDef = pScriptDefs[i];
                if (cScriptDef.id.Length == name.Length && cScriptDef.id == name)
                {
                    result = cScriptDef.StartTickCount;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                if (pScriptDefs.Count > 0)
                {
                    result = pScriptDefs[pScriptDefs.Count - 1].StartTickCount;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }
        private int GetScriptDefstop(string name, List<CScriptDef> pScriptDefs)
        {
            int result = -1;
            bool flag = false;
            for (int i = pScriptDefs.Count - 1; i >= 0; i--)
            {
                CScriptDef cScriptDef = pScriptDefs[i];
                if (cScriptDef.id.Length == name.Length && cScriptDef.id == name)
                {
                    result = cScriptDef.StopTickCount;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                if (pScriptDefs.Count > 0)
                {
                    result = pScriptDefs[pScriptDefs.Count - 1].StopTickCount;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }
    }
}