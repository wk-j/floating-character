using System;
using System.Linq;

namespace FloatingCharacter {
    public class Glyph {

        public static char[] FloatingCharacters = "  ั  ็  ิ ำ ี  ึ  ื  ุ  ู  ่  ้   ๊  ๋   ์  "
            .Where(x => x != ' ').ToArray();
        
        public static char[] IgnoreCharacters = "  ั  ็  ิ  ี  ึ  ื  ุ  ู ่  ้   ๊  ๋  ์  "
            .Where(x => x != ' ').ToArray();
    }
}
