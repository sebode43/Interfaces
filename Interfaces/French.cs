using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class French : LanguageMessages {

        protected override void InitDictionary() {
            this.messages.Add(0, "Bonjour");
            this.messages.Add(1, "Au Revoir");
            this.messages[9999] = "Error";
        }

        public French() : base() {

        }

    }
}
