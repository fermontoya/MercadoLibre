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
            string[] mutantefila ={ "aaaabc", "defghi", "jklmnñ", "123456", "opqrst", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteColumna()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "daaabc", "defghi", "dklmnñ", "d23456", "opqrst", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteOblicuaIzquierda()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "daaabc", "eefghi", "dkzmnñ", "d23z56", "opqrzt", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
        [Fact]
        public void MutanteOblicuaDerecha()
        {
            ADN mutanteohumano = new ADN();
            string[] mutantefila = { "dfaabc", "eefghi", "dkzfnñ", "d235f6", "opqrzt", "uvwxyz" };
            bool Result = mutanteohumano.isMutant(mutantefila);
            Assert.True(Result);
        }
    }
}
