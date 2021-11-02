using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            moto.odometrPublic = 150;

            //  moto.odometrPrivate = 10; // Доступен только Motorcycle
            //  moto.odometrDefault = 10;// private - Доступен только Motorcycle
            //  moto.odometrInternal = 10;// Доступен только в AssemblyOne
            //  moto.odometrProtected = 10; // Доступен Motorcycle и его наследникам (и в других сборках) 
            //  moto.odometrProtectedInternal=10; //Доступен в любом месте AssemblyOne и в наследниках Motorcycle 
            //  moto.odometrProtectedPrivate=10; //Доступен Motorcycle и его наследникам в сборке AssemblyOnew

            //у экземпляров sport и enduro - действуют такие же огрничения как и у экземпляра moto (см. выше)

            SportBike sport = new SportBike();
            sport.odometrPublic = 150;
           
            EnduroBike enduro = new EnduroBike();
            enduro.odometrPublic = 150;
        }
        public class EnduroBike:Motorcycle
        {
            public void SomeMethod()
            {
                base.odometrProtected = 10; 
                base.odometrProtectedInternal = 10;
                base.odometrPublic = 10;

                //base.odometrProtectedPrivate = 50;  Доступен Motorcycle и его наследникам в сборке AssemblyOne
                //base.odometrInternal = 50; Доступен только в AssemblyOne
                //base.odometrDefault=50; private - Доступен только Motorcycle
                //base.odometrPrivate = 50; private - Доступен только Motorcycle
            }
        }
    }
}
