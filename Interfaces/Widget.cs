using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    public class Widget : IPrintable {

       public void Print() {
            Console.WriteLine("Widget");
        }
    }
}
