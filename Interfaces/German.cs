using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class German : LanguageMessages {

        protected override void InitDictionary() {
            this.messages.Add(0, "Hallo");
            this.messages.Add(1, "Auf Weidersehen");
            this.messages[9999] = "Error";
        }

        public German() : base() {

        }
    }
}
