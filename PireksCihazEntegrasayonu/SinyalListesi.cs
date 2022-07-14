using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Baglanti
{
    public class SinyalListesi
    {
        private Byte currentValue = 0x00;
        public const Byte
               NULL = 0,
               SOH = 1,
               STX = 2,
               ETX = 3,
               EOT = 4,
               ENQ = 5,
               ACK = 6,
               BEL = 7,
               BS = 8,
               TAB = 9,
               LF = 10,
               VT = 11,
               FF = 12,
               CR = 13,
               SO = 14,
               SI = 15,
               DLE = 16,
               DC1 = 17,
               DC2 = 18,
               DC3 = 19,
               DC4 = 20,
               NAK = 21,
               SYN = 22,
               ETB = 23,
               CAN = 24,
               EM = 25,
               SUB = 26,
               ESC = 27,
               FS = 28,
               GS = 29,
               RS = 30,
               US = 31,
               SPACE = 32;
        public SinyalListesi(byte kodu)
        {
            currentValue = kodu;
        }
        public static char getChar(byte data)
        {
           
            return (char)data;
        }
        public static char getChar(SinyalListesiEnum data)
        {
            return (char)(byte)data;
            
        }
        public  static string getString(SinyalListesiEnum data)
        {
            return (getChar(data)).ToString();
            //decimal

        }
         public  static string getString(byte data)
        {
            return (getChar(data)).ToString();
            //decimal

        }

        public static explicit operator string(SinyalListesi value)
        {
            return getString(value.currentValue);
                
        }
        

        public static implicit operator SinyalListesi(byte value)
        {
            SinyalListesi deger = new SinyalListesi(value);
            deger.currentValue = value;
            return deger;
        }

        public class StringSinyalListesi
        {
            public const string NULL = "\u0000",
                               SOH = "\u0001",
                               STX = "\u0002",
                               ETX = "\u0003",
                               EOT = "\u0004",
                               ENQ = "\u0005",
                               ACK = "\u0006",
                               BEL = "\u0007",
                               BS = "\u0008",
                               TAB = "\u0009",
                               LF = "\u000A",
                               VT = "\u000B",
                               FF = "\u000C",
                               CR = "\u000D",
                               SO = "\u000E",
                               SI = "\u000F",
                               DLE = "\u0010",
                               DC1 = "\u0011",
                               DC2 = "\u0012",
                               DC3 = "\u0013",
                               DC4 = "\u0014",
                               NAK = "\u0015",
                               SYN = "\u0016",
                               ETB = "\u0017",
                               CAN = "\u0018",
                               EM = "\u0019",
                               SUB = "\u001A",
                               ESC = "\u001B",
                               FS = "\u001C",
                               GS = "\u001D",
                               RS = "\u001E",
                               US = "\u001F",
                               SPACE = "\u0020";
        }
        public class CharSinyalListesi
        {
            public const char NULL = (char)SinyalListesi.NULL;
            public const char SOH = (char)SinyalListesi.SOH;
            public const char STX = (char)SinyalListesi.STX;
            public const char ETX = (char)SinyalListesi.ETX;
            public const char EOT = (char)SinyalListesi.EOT;
            public const char ACK = (char)SinyalListesi.ACK;
            public const char BEL = (char)SinyalListesi.BEL;
            public const char BS = (char)SinyalListesi.BS;
            public const char TAB = (char)SinyalListesi.TAB;
            public const char LF = (char)SinyalListesi.LF;
            public const char VT = (char)SinyalListesi.VT;
            public const char FF = (char)SinyalListesi.FF;
            public const char CR = (char)SinyalListesi.CR;
            public const char SO = (char)SinyalListesi.SO;
            public const char SI = (char)SinyalListesi.SI;
            public const char DLE = (char)SinyalListesi.DLE;
            public const char DC1 = (char)SinyalListesi.DC1;
            public const char DC2 = (char)SinyalListesi.DC2;
            public const char DC3 = (char)SinyalListesi.DC3;
            public const char DC4 = (char)SinyalListesi.DC4;
            public const char NAK = (char)SinyalListesi.NAK;
            public const char SYN = (char)SinyalListesi.SYN;
            public const char ETB = (char)SinyalListesi.ETB;
            public const char CAN = (char)SinyalListesi.CAN;
            public const char EM = (char)SinyalListesi.EM;
            public const char SUB = (char)SinyalListesi.SUB;
            public const char ESC = (char)SinyalListesi.ESC;
            public const char FS = (char)SinyalListesi.FS;
            public const char GS = (char)SinyalListesi.GS;
            public const char RS = (char)SinyalListesi.RS;
            public const char US = (char)SinyalListesi.US;
            public const char ENQ = (char)SinyalListesi.ENQ;
            public const char SPACE = (char)SinyalListesi.SPACE;
        }
        //public string getString(SinyalListesi data)
        //{
        //    switch (data)
        //    {
        //        case SinyalListesi.NULL:
        //            return "\u0000";                    
        //        case SinyalListesi.SOH:
        //            return "\u0001";                    
        //        case SinyalListesi.STX:
        //            return "\u0002";                    
        //        case SinyalListesi.ETX:
        //            return "\u0003";                    
        //        case SinyalListesi.EOT:
        //            return "\u0004";                    
        //        case SinyalListesi.ENQ:
        //            return "\u0005";                    
        //        case SinyalListesi.ACK:
        //            return "\u0006";                    
        //        case SinyalListesi.BEL:
        //            return "\u0007";                    
        //        case SinyalListesi.BS:
        //            return "\u0008";                    
        //        case SinyalListesi.TAB:
        //            return "\u0009";                    
        //        case SinyalListesi.LF:
        //            return "\u000A";                    
        //        case SinyalListesi.VT:
        //            return "\u000B";                    
        //        case SinyalListesi.FF:
        //            return "\u000C";                    
        //        case SinyalListesi.CR:
        //            return "\u000D";                    
        //        case SinyalListesi.SO:
        //            return "\u000E";                    
        //        case SinyalListesi.SI:
        //            return "\u000F";                    
        //        case SinyalListesi.DLE:
        //            return "\u0010";                    
        //        case SinyalListesi.DC1:
        //            return "\u0011";                    
        //        case SinyalListesi.DC2:
        //            return "\u0012";                    
        //        case SinyalListesi.DC3:
        //            return "\u0013";                    
        //        case SinyalListesi.DC4:
        //            return "\u0014";                    
        //        case SinyalListesi.NAK:
        //            return "\u0015";                    
        //        case SinyalListesi.SYN:
        //            return "\u0016";                    
        //        case SinyalListesi.ETB:
        //            return "\u0017";                    
        //        case SinyalListesi.CAN:
        //            return "\u0018";                    
        //        case SinyalListesi.EM:
        //            return "\u0019";                    
        //        case SinyalListesi.SUB:
        //            return "\u001A";                    
        //        case SinyalListesi.ESC:
        //            return "\u001B";                    
        //        case SinyalListesi.FS:
        //            return "\u001C";                    
        //        case SinyalListesi.GS:
        //            return "\u001D";                    
        //        case SinyalListesi.RS:
        //            return "\u001E";                    
        //        case SinyalListesi.US:
        //            return "\u001F";                    
        //        case SinyalListesi.SPACE:
        //            return "\u0020";                    
        //        default:
        //            return "\u0000";   
        //    }
          

        //}
    }

}
