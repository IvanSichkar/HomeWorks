using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            moto.odometrPublic = 70;
            moto.odometrInternal = 70;            
            moto.odometrProtectedInternal  = 70;  
   
            //moto.privateOdometr   Доступен только Motorcycle
            //moto.protectedOdometr Доступен только Motorcycle и его наследникам
            //moto.defaultOdometr   private Доступен только Motorcycle
            //moto.protectedPrivateOdometr  Доступен Motorcycle и его наследникам в AssemblyOne

            SportBike sport = new SportBike();
            sport.odometrPublic = 80;
            sport.odometrInternal = 80;
            sport.odometrProtectedInternal = 80;

            //sport.privateOdometr   Доступен только Motorcycle
            //sport.protectedOdometr Доступен только Motorcycle и его наследникам
            //sport.defaultOdometr   private Доступен только Motorcycle
            //sport.protectedPrivateOdometr  Доступен Motorcycle и его наследникам в AssemblyOne
        }
    }
}
