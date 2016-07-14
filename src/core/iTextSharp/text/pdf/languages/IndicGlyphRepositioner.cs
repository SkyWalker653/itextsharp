using System;
using System.Collections.Generic;
using System.Text;

namespace iTextSharp.text.pdf.languages
{
    abstract class IndicGlyphRepositioner : GlyphRepositioner
    {
        public void RepositionGlyphs(List<Glyph> glyphList)
        {

            for (int i = 0; i < glyphList.Count; i++)
            {
                Glyph glyph = glyphList[i];
                Glyph nextGlyph = GetNextGlyph(glyphList, i);

                if ((nextGlyph != null)
                        && CharactersToBeShiftedLeftByOnePosition().Contains(nextGlyph.chars))
                {
                    glyphList[i] = nextGlyph;
                    glyphList[i + 1] = glyph;
                    i++;
                    continue;
                }
            }

        }

        internal abstract List<string> CharactersToBeShiftedLeftByOnePosition();

        private Glyph GetNextGlyph(List<Glyph> glyphs, int currentIndex)
        {
            if (currentIndex + 1 < glyphs.Count)
            {
                return glyphs[currentIndex + 1];
            }
            else
            {
                return null;
            }
        }
    }
}
