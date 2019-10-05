using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AutoTester
{
    [Serializable]
    public class MacroNode : ICloneable
    {
        public MacroNode()
        {
            state = NodeStates.마우스_이동;
            tag = "";
            x=0;
            y=0;
            interval=0;
        }
        public NodeStates state { get; set; }
        public string tag { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int interval { get; set; }
        public string inputString { get; set; }
        
        public object Clone()
        {
            MacroNode macroNode = new MacroNode();
            macroNode.state = state;
            macroNode.tag = tag;
            macroNode.x = x;
            macroNode.y = y;
            macroNode.interval = interval;
            macroNode.inputString = inputString;
            return macroNode;
        }
    }

    public enum NodeStates
    {
        마우스_이동,
        마우스_왼쪽클릭,
        마우스_오른쪽클릭,
        마우스_더블클릭,
        마우스_휠클릭,
        마우스_이동_후_왼쪽클릭,
        마우스_휠_내리기,
        마우스_휠_올리기,
        마우스_누르기_왼쪽,
        마우스_떼기_왼쪽,
        마우스_누르기_오른쪽,
        마우스_떼기_오른쪽,
        마우스_누르기_휠,
        마우스_떼기_휠,
        시스템_대기,
        시스템_스크린샷찍기,
        키보드_키입력,
    }
    public static class NodeSetter
    {
        public static Color NodeColor(NodeStates s)
        {
            string[] colorTable = {   
                 "FF82E2FF"//" 마우스:이동"
                ,"FF64F5B8"//" 마우스:클릭(왼쪽)"
                ,"FF64F5B8"//" 마우스:클릭(오른쪽)"
                ,"FF6BE8DE"//" 마우스:더블클릭"
                ,"FF64F5B8"//" 마우스:휠클릭"
                ,"FF6BE8DE"//" 마우스:이동 후 왼쪽클릭"
                ,"FF5DD4A0"//" 마우스:휠 내리기"
                ,"FF5DD4A0"//" 마우스:휠 올리기"
                ,"FF5DB1D4"//" 마우스:누르기(왼쪽)"
                ,"FF5DB1D4"//" 마우스:떼기(왼쪽)"
                ,"FF5DB1D4"//" 마우스:누르기(오른쪽)"
                ,"FF5DB1D4"//" 마우스:떼기(오른쪽)"
                ,"FF5DB1D4"//" 마우스:누르기(휠)"
                ,"FF5DB1D4"//" 마우스:떼기(휠)"
                ,"FFFFC061"//" 시스템:대기"
                ,"FFFFC061"//" 시스템:스크린샷 찍기"
                ,"FFEB5060"//" 키보드:키 입력"
            };
            return Color.FromArgb(Int32.Parse(colorTable[(int)s], System.Globalization.NumberStyles.HexNumber));
        }

        public static string NodeName(NodeStates s,bool eventName)
        {
            if (eventName)
            {
                string[] nameTable = { 
                 "이동"
                ,"클릭(왼쪽)"
                ,"클릭(오른쪽)"
                ,"더블클릭"
                ,"휠클릭"
                ,"이동 후 왼쪽클릭"
                ,"휠 내리기"
                ,"휠 올리기"
                ,"누르기(왼쪽)"
                ,"떼기(왼쪽)"
                ,"누르기(오른쪽)"
                ,"떼기(오른쪽)"
                ,"누르기(휠)"
                ,"떼기(휠)"
                ,"대기"
                ,"스크린샷 찍기"
                ,"키 입력" 
                };
                return nameTable[(int)s];
            }
            else
            {
                string[] nameTable = { 
                 " 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 마우스"
                ," 시스템"
                ," 시스템"
                ," 키보드"        
                };
                return nameTable[(int)s];
            }
        }
    }
}
