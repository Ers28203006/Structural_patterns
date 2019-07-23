using System;

namespace Brige
{
    //существует два независимых имплементатора
    interface IStyleimplementator
    {
        void StyleOperation();
    }

    interface IFontsize
    {
        void FontsizeOperation();
    }

    // реализация каждого из имплементаторов
    class Fontsize : IFontsize
    {
        public void FontsizeOperation()
        {
            Console.WriteLine("Назначен 14 шрифт");
        }
    }
    class BlackStyle : IStyleimplementator
    {
        string _style = string.Empty;
        public BlackStyle(string style)
        {
            _style = style;
        }
        public void StyleOperation()
        {
            Console.WriteLine($"Стиль страницы {_style}");
        }
    }

    //абстракция типа лист web-страницы
    abstract class AbstractionPage
    {
        IStyleimplementator _styleimplementator = null;
        IFontsize _fontsize = null;
        public AbstractionPage(IStyleimplementator styleimplementator, IFontsize fontsize)
        {
            _styleimplementator = styleimplementator;
            _fontsize = fontsize;
        }

        public virtual void Operation()
        {
            _styleimplementator.StyleOperation();
            _fontsize.FontsizeOperation();
        }
    }

    //конкретная реализация абстракции
    class Page : AbstractionPage
    {
        public Page(IStyleimplementator styleimplementator, IFontsize fontsize) : base(styleimplementator, fontsize)
        {
        }
        public override void Operation()
        {
            Console.WriteLine("Выбраны следующие настройки для страницы сайта: ");
            base.Operation();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IStyleimplementator styleimplementator = new BlackStyle("темный");
            IFontsize fontsize = new Fontsize();
            AbstractionPage page = new Page(styleimplementator, fontsize);
            page.Operation();
        }
    }
}
