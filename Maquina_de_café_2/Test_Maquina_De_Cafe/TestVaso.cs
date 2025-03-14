using Maquina_de_caf�_2;
using NUnit.Framework;

namespace Test_Maquina_De_Cafe
{
    public class Tests
    {
        [Test]
        public void deberiaDevolverTrueSiHayVasos()
        {
            Vaso vasoPeque�o = new Vaso(10,2);
            bool result = vasoPeque�o.hayVasosDisponibles(2);
            Assert.IsTrue(result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHayVasos()
        {
            
            Vaso vasoMediano = new Vaso(0,2);
            bool result = vasoMediano.hayVasosDisponibles(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void deberiaRestarCantidadDeVasos()
        {
           
            Vaso vasoGrande = new Vaso(10,3);
            int result = vasoGrande.restarVasos(3);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoExisteEseVaso()
        {
           
            Vaso vaso = new Vaso(20,1);
            bool result = vaso.hayVasosDisponibles(5);
            Assert.IsFalse(result);
        }
    }
}