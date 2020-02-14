using System;
using System.Collections.Generic;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {

            var hello = new Hello(new English());
            var hello2 = new Hello(new Spanish());
            var hellofr = new Hello(new French());
            (new Hello(new German())).Speak();

            hello.Speak();
            hello2.Speak();
            hellofr.Speak();

        }

        static void TestInterfaceWidgets() { 

            var w1 = new Widget();
            var aw = new AdvWidget();
            var sw = new SuperWidget();

            var widgets = new List<IPrintable>();
            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);

            foreach(var widget in widgets) {
                widget.Print();
            }



        }
    }
}
