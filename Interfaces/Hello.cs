using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Hello {

        ISpeakable Language;

        public void Speak() {
            Console.WriteLine($"Hello : { Language.GetMessage(0) }");
            Console.WriteLine($"Goodbye : { Language.GetMessage(1) }");
            Console.WriteLine($"Error : { Language.GetMessage(9999) }");

        }

        public Hello(ISpeakable language) {
            Language = language;
        }

    }
}
