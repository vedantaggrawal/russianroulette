using System;
using RussianRoulette;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RussianRouletteTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Gun obj = new Gun();

        [TestMethod]
        public void testFireAway() //testing whether chances decrease when bullet is 
                                   //  not fired while gun is pointing away
        {
            bool flag = true;
            while (flag) {
                obj.emptyChamber();
                obj.loadBullet();
                obj.spinChambers();
                int res = obj.FireAway();
                if (res == -1)
                {
                    flag = false;
                    Assert.AreEqual(1, obj.get_chances(), "chances still same even when no bullet was fired pointing away");
                }
            }
            
        }

     
    }
}
