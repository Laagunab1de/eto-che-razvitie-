using Kids1135PluginBase;
using System;
using System.Windows.Controls;

namespace WpfLibrary1
{
    public class Test : IPlugin
    {
        public string Name => "Симулятор плагина";

        public string Description => "Это пример плагина";

        public string Author => "Дядя Пушкин";

        public Page GetPage()
        {
            return new Page1();
        }
    }


}
