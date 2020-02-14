using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    abstract class LanguageMessages : ISpeakable {

        protected Dictionary<int, string> messages = new Dictionary<int, string> {
            [9999] = "Message not found"
        };

        protected abstract void InitDictionary();

        public string GetMessage(int MessageNumber) {
            if (!messages.ContainsKey(MessageNumber)) {
                return messages[9999];
            }
            return messages[MessageNumber];
        }
            public LanguageMessages() {
                InitDictionary();
            }

    }
}
