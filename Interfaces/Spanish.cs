using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Spanish : LanguageMessages {

        protected override void InitDictionary() {
            this.messages.Add(0, "Hola");
            this.messages.Add(1, "Adios");
            this.messages[9999] = "Error";
        }

        public Spanish() : base() {

        }

    }
}
