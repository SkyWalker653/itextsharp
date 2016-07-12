using System;
using System.Collections.Generic;
using System.Text;

namespace iTextSharp.text.pdf.languages
{
    public interface GlyphRepositioner
    {
        void repositionGlyphs(List<Glyph> glyphList);
    }
}
