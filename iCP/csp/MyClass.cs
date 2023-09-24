using System;
using System.Runtime.InteropServices;

namespace csp
{
    /*
     * Project Info:
     * Type: API
     * Languaje: C#
     * API Name: C#+ / C Sharp Plus / C# Plus
     * Codename: csp
     * Version: 0.7
     * Channel: Beta
     * Subdivisions:
     * |  CSPv
     * |  CSPv Subdivision:
     * |  |  Text (struct)
     * |  |  FText (struct)
     * |  |  MText (struct | empty)
     * |  |  Num (struct)
     * |  |  MindX (struct)
     * |  |  VFText (struct | empty)
     * |  |  DNum (struct | empty)
     */
    public class CSPv
    {
        public CSPv()
        {
        }
        /*
         * CSPV:
         * | Text:
         * | | StringValue : String
         * | | Text : Constructor (String : in)
         * | | Assign : Void (Text:in)
         * | | Assign : Void (String:in)
         * | | Assign : Void (Num : in)
         * | | Assign : Void (Int : in)
         * | | ToString : String{}
         * | | CompareTo : Int{} (Object : in)
         * | | Equals : Bool{} (String : in)
         * | | ToString : String{} (String : in, IFormatProvider : in)
         * ----------------------------------------
         * | FText:
         * | | StringValue : String
         * | | FText : Constructor (String : in)
         * | | CompareTo : Int{} (Object : in)
         * | | Equals : Bool{} (String : in)
         * | | ToString : String{} (String : in, IFormatProvider : in)
         * | | ToString : String{} (Text : in)
         * ----------------------------------------
         * | MText : Empty
         * ----------------------------------------
         * | Num:
         * | | numb : Int
         * | | Num : Constructor(Int : in)
         * | | CompareTo : Int{} (Object : in)
         * | | Equals : Bool{} (String : in)
         * | | ToString : String{} (String : in, IFormatProvider : in)
         * | | ToInt : Int{}
         * ----------------------------------------
         * | MindX
         * | | mindx : Text
         * | | MindX : Constructor (Text : in)
         * ----------------------------------------
         * | VFText : Empty
         * ----------------------------------------
         * | DNum : Empty
         */
        public struct Text : IComparable, IEquatable<string>, IFormattable
        {

            public string StringValue { get; set; }

            public Text(string stringValue)
            {
                StringValue = stringValue;
            }
            public void Assign(Text text)
            {
                StringValue = text.ToString();
            }
            public void Assign(string text)
            {
                StringValue = text;
            }
            public void Assign(Num num)
            {
                StringValue = num.ToString();
            }
            public void Assign(int @int)
            {
                StringValue = @int.ToString();
            }
            public override string ToString()
            {
                return $"{StringValue}";
            }

            public int CompareTo(object obj)
            {

                return this.Equals(obj) ? 1 : 0;
            }

            public bool Equals(string other)
            {
                return (other == StringValue) ? true : false;

            }


            public string ToString(string format, IFormatProvider formatProvider)
            {
                return StringValue;
            }

        }
        public struct FText : IComparable, IEquatable<string>, IFormattable
        {
            public string StringValue { get; set; }
            public FText(string sv)
            {
                StringValue = @sv;
            }
            public int CompareTo(object obj)
            {
                return obj.ToString() == StringValue ? 1 : 0;
            }

            public bool Equals(string other)
            {
                return other == StringValue ? true : false;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return $@"{StringValue}";
            }
            public string ToString(Text instance)
            {
                return $"{StringValue}";
            }

        }
        public struct MText
        {

        }

        public struct Num : IFormattable, IComparable, IEquatable<string>
        {
            int numb;
            public Num(int numu)
            {
                numb = numu;
            }
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
            public bool Equals(string other)
            {
                throw new NotImplementedException();
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return numb.ToString();
            }
            public int ToInt()
            {
                return numb;
            }
        }
        public struct MIndX
        {
            public Text mindx;
            public MIndX(Text mdx)
            {
                mindx = mdx;
            }

        }
        public struct VFText
        {

        }
        public struct DNum
        {

        }
    }
}