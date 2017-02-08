using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsAddress
            clsAddress AnAdress = new clsAddress();
            //check to see class is not null
            Assert.IsNotNull(AnAdress);
        }




    }



}
