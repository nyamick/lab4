using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Drink
    {
        public int Vol = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъём: {0}", this.Vol);
            return str;

        }
    }
    public enum FruitType { Apple, Orange };
    public class Juice : Drink

    {

        public FruitType type = FruitType.Apple;
        public bool Pulp = false;

        public override string GetInfo()
        {
            var str = "Cок";
            str += base.GetInfo();
            str += String.Format("\n Наличие мякоти: {0}", this.Pulp);
            str += String.Format("\n Тип фркута: {0}", this.type);

            return str;

        }
    }

    public enum SodaType { Cola, Sprite };
    public class Soda : Drink
    {

        public SodaType type = SodaType.Sprite;
        public int Bubbles = 0;

        public override string GetInfo()
        {
            var str = "Газировка";
            str += base.GetInfo();
            str += String.Format("\n Количетсво пузырьков: {0}", this.Bubbles);
            str += String.Format("\n Тип газировки: {0}", this.type);

            return str;

        }

    }

    public enum AlcType { Beer, Vodka }
    public class Alcohol : Drink
    {

        public int Strength = 0;
        public AlcType type = AlcType.Beer;

        public override string GetInfo()
        {
            var str = "Алкоголь";
            str += base.GetInfo();
            str += String.Format("\n Крепость: {0}", this.Strength);
            str += String.Format("\n Тип алкоголя: {0}", this.type);

            return str;
        }

    }
}
}
