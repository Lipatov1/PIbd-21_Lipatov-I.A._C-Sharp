using System.Collections.Generic;

namespace WindowsFormsTechnic {
    public class MilitaryEquipmentComparer : IComparer<Vehicle> {
        public int Compare(Vehicle x, Vehicle y) {
            if (x.GetType().Name != y.GetType().Name) {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            if (x is ArmoredCar && y is ArmoredCar) {
                return ComparerArmoredCar(x as ArmoredCar, y as ArmoredCar);
            }
            if (x is SelfPropArtilleryInstal && y is SelfPropArtilleryInstal) {
                return ComparerSelfPropArtilleryInstal(x as SelfPropArtilleryInstal, y as SelfPropArtilleryInstal);
            }
            return 0;
        }

        private int ComparerArmoredCar(ArmoredCar x, ArmoredCar y) {
            if (x.MaxSpeed != y.MaxSpeed) {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight) {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor) {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSelfPropArtilleryInstal(SelfPropArtilleryInstal x, SelfPropArtilleryInstal y) {
            var res = ComparerArmoredCar(x, y);

            if (res != 0) {
                return res;
            }
            if (x.DopColor != y.DopColor) {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Camouflage != y.Camouflage) {
                return x.Camouflage.CompareTo(y.Camouflage);
            }
            if (x.Star != y.Star) {
                return x.Star.CompareTo(y.Star);
            }
            if (x.Сaterpillar != y.Сaterpillar) {
                return x.Сaterpillar.CompareTo(y.Сaterpillar);
            }
            return 0;
        }
    }
}