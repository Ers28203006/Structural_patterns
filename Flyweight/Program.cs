using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    interface ICityFlyweight
    {
        void HouseTypes(string houseModel);
    }

    class ModelHouse : ICityFlyweight
    {
        public void HouseTypes(string houseModel)
        {
            Console.WriteLine(houseModel); 
        }
    }

    class Skyscraper : ICityFlyweight
    {
        ICityFlyweight _cityFlyweight;
        public Skyscraper(ICityFlyweight cityFlyweight)
        {
            _cityFlyweight = cityFlyweight;
        }
        public void HouseTypes(string houseModel)
        {
            _cityFlyweight.HouseTypes(houseModel);
        }
    }

    class PanelSkyscraper : ICityFlyweight
    {
        ICityFlyweight _cityFlyweight;
        public PanelSkyscraper(ICityFlyweight cityFlyweight)
        {
            _cityFlyweight = cityFlyweight;
        }
        public void HouseTypes(string houseModel)
        {
            _cityFlyweight.HouseTypes(houseModel);
        }
    }
    class BrickHouse : ICityFlyweight
    {
        ICityFlyweight _cityFlyweight;
        public BrickHouse(ICityFlyweight cityFlyweight)
        {
            _cityFlyweight = cityFlyweight;
        }
        public void HouseTypes(string houseModel)
        {
            _cityFlyweight.HouseTypes(houseModel);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICityFlyweight cityModel = new ModelHouse();
            cityModel.HouseTypes("В модели города нет ни одного дома");
            ICityFlyweight skyscraperModel = new Skyscraper(cityModel);
            skyscraperModel.HouseTypes("Добавлена модель небоскреба");
            ICityFlyweight panelSkyscraperModel = new PanelSkyscraper(cityModel);
            panelSkyscraperModel.HouseTypes("Добавлена модель кирпичной высотки");
            ICityFlyweight brickHouseModel = new BrickHouse(cityModel);
            brickHouseModel.HouseTypes("Добавлена модель кирпичного дома");
        }
    }
}
