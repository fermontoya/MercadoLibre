using MercadoLibre;
using System;
using Xunit;

namespace MercadoLibreTest
{
    public class UnitTest1
    {
        [Fact]
        public void MutanteFila()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila ={ "aaaabc", "defghi", "jklmn�", "123456", "opqrst", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteColumna()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "daaabc", "defghi", "dklmn�", "d23456", "opqrst", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteOblicuaIzquierda()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "daaabc", "eefghi", "dkzmn�", "d23z56", "opqrzt", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteOblicuaDerecha()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "dfaabc", "eefghi", "dkzfn�", "d235f6", "opqrzt", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
    }
}
