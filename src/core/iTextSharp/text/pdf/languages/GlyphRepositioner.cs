using System;
using System.Collections.Generic;
using System.Text;

namespace iTextSharp.text.pdf.languages
{
    public interface GlyphRepositioner
    {
        void RepositionGlyphs(List<Glyph> glyphList);
    }
}
