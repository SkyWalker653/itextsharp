using System;
using System.Collections.Generic;
using System.Text;

namespace iTextSharp.text.pdf
{
    public class Glyph
    {
        /**
        * The <i>code</i> or <i>id</i> by which this is represented in the Font File
        */
        public readonly int code;

        /**
         * The normalized width of this Glyph.
         */
        public readonly int width;

        /**
         * The Unicode text represented by this Glyph
         */
        public readonly String chars;
    
        public Glyph(int code, int width, String chars)
        {
            this.code = code;
            this.width = width;
            this.chars = chars;
        }
        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            result = prime * result + ((chars == null) ? 0 : chars.GetHashCode());
            result = prime * result + code;
            result = prime * result + width;
            return result;
        }

        public override bool Equals(Object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Glyph other = (Glyph)obj;
            if (chars == null)
            {
                if (other.chars != null)
                    return false;
            }
            else if (!chars.Equals(other.chars))
                return false;
            if (code != other.code)
                return false;
            if (width != other.width)
                return false;
            return true;
        }

        public override String ToString()
        {
            return typeof(Glyph).Name + " [id=" + code + ", width=" + width + ", chars=" + chars + "]";
        }
    }
}
