using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class English : LanguageMessages {

        protected override void InitDictionary() {
            this.messages.Add(0, "Hello");
            this.messages.Add(1, "Goodbye");
            this.messages[9999] = "Error";
        }

        public English() : base() {

        }
    }
}
