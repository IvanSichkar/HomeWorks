using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Motorcycle  //public - для того, что бы класс был доступен в любом месте и в других сборках
    {
        int odometrDefault = 100;
        public int odometrPublic = 100;
        protected int odometrProtected = 100;
        private int odometrPrivate = 100;
        protected private int odometrProtectedPrivate = 100;
        internal int odometrInternal = 100;
        protected internal int odometrProtectedInternal = 100;

        void StartEngineDefault() { }
        public void StartEnginePublic() { }
        protected void StartEngineProtected() { }
        private void StartEnginePrivate() { }
        protected private void PrivateStartNgineProtected() { }
        internal void StartEngineInternal() { }
        protected internal void StartEngineProtectedInternal() { }
    }
    public class SportBike : Motorcycle
    {
        public void SomeMtehod()
        {
            base.odometrInternal = 50;
            base.odometrProtectedInternal = 50;
            base.odometrProtectedPrivate = 50;
            base.odometrPublic = 50;
            base.odometrProtected = 50;

            //base.odometrDefault=50; private - доступен только Motocycle
            //base.odometrPrivate = 50; private - доступен только Motocycle
        }
    }
}
