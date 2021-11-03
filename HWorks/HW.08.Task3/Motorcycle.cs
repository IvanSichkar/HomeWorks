using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._08.Task3
{
    class Motorcycle
    {
        int odometrDefault = 100;
        public int odometrPublic=100;
        
        protected int protectedOdometr=100;
        private int privateOdometr=100;
        protected private int protectedPrivateOdometr=100;

        internal int internalOdometr=100;
        protected internal int protectedInternalOdometr=100;

        void DefaultStartEngine() { }
        public void PublicStartEngine() { }
        protected void ProtectedStartEngine() { }
        private void PrivateStartEngine() { }
        protected private void ProtectedPrivateStartNgine() { }
        internal void InternalStartEngine() { }
        protected internal void ProtectedInternalStartEngine() { }

        
    }
}
