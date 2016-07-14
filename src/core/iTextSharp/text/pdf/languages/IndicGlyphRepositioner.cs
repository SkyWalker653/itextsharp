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
                Glyph nextGlyph = getNextGlyph(glyphList, i);

                if ((nextGlyph != null)
                        && getCharactersToBeShiftedLeftByOnePosition().Contains(nextGlyph.chars))
                {
                    glyphList.Insert(i, nextGlyph);
                    glyphList.Insert(i + 1, glyph);
                    i++;
                    continue;
                }
            }

        }

        public abstract List<string> getCharactersToBeShiftedLeftByOnePosition();

        private Glyph getNextGlyph(List<Glyph> glyphs, int currentIndex)
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
