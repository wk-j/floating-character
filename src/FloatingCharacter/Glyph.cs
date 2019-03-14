using System;
using System.Linq;

namespace FloatingCharacter {
    public class Glyph {
        static char[] floatingChars = "  ั  ็  ิ  ี  ึ  ื  ุ  ู  ่  ้   ๊  ๋   ์  "
            .Where(x => x != ' ').ToArray();

        public static char[] FloatingCharacters() => floatingChars;
    }
}
